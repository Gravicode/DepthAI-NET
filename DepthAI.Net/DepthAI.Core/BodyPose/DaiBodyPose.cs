/*
* This file contains body pose detector pipeline and interface for Unity scene called "Body Pose"
* Main goal is to show how to use basic NN model like body pose inside Unity. It's using MoveNet body pose model.
*/

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Numerics;
using System.Runtime.InteropServices;
using SimpleJSON;

namespace DepthAI.Core
{
    public class DaiBodyPose : PredefinedBase
    {
        //Lets make our calls from the Plugin
        [DllImport("depthai-unity", CallingConvention = CallingConvention.Cdecl)]
        /*
        * Pipeline creation based on streams template
        *
        * @param config pipeline configuration 
        * @returns pipeline 
        */
        private static extern bool InitBodyPose(in PipelineConfig config);

        [DllImport("depthai-unity", CallingConvention = CallingConvention.Cdecl)]
        /*
        * Pipeline results
        *
        * @param frameInfo camera images pointers
        * @param getPreview True if color preview image is requested, False otherwise. Requires previewSize in pipeline creation.
        * @param width Unity preview image canvas width
        * @param height Unity preview image canvas height
        * @param useDepth True if depth information is requested, False otherwise. Requires confidenceThreshold in pipeline creation.
        * @param drawBodyPoseInPreview True to draw body landmakrs in the preview image
        * @param bodyLandmarkScoreThreshold Normalized score to filter body pose keypoints detections
        * @param retrieveInformation True if system information is requested, False otherwise. Requires rate in pipeline creation.
        * @param useIMU True if IMU information is requested, False otherwise. Requires freq in pipeline creation.
        * @param deviceNum Device selection on unity dropdown
        * @returns Json with results or information about device availability. 
        */    
        private static extern IntPtr BodyPoseResults(out FrameInfo frameInfo, bool getPreview, int width, int height,  bool useDepth, bool drawBodyPoseInPreview, float bodyLandmarkScoreThreshold, bool retrieveInformation, bool useIMU, int deviceNum);

        
        // Editor attributes
        //[Header("RGB Camera")] 
        public float cameraFPS = 30;
        public RGBResolution rgbResolution;
        private const bool Interleaved = true;
        private const ColorOrder ColorOrderV = ColorOrder.BGR;

        //[Header("Mono Cameras")] 
        public MonoResolution monoResolution;

        //[Header("Body Pose Configuration")] 
        public MedianFilter medianFilter;
        public bool useIMU = false;
        public bool retrieveSystemInformation = false;
        public bool drawBodyPoseInPreview;
        public float bodyLandmarkThreshold; 
        private const bool GETPreview = true;
        private const bool UseDepth = true;

        //[Header("Body Pose Results")] 
        public Image colorTexture;
        public string bodyPoseResults;
        public string systemInfo;
        public Vector3[] landmarks;
        public GameObject[] skeleton;
        public GameObject[] cylinders;
        public Vector2[] connections;

        // private attributes
        private byte[] _colorPixel32;
        private GCHandle _colorPixelHandle;
        private IntPtr _colorPixelPtr;
        PixelFormat pxFormat = PixelFormat.Format32bppArgb;
        Size size;
        int Stride;
        public event EventHandler<PoseChangedArgs> PoseChanged;
        // Init textures. Each PredefinedBase implementation handles textures. Decoupled from external viz (Canvas, VFX, ...)
        void InitTexture()
        {
            size = new Size(300, 300);
            //Get the stride, in this case it will have the same length of the width.
            //Because the image Pixel format is 1 Byte/pixel.
            //Usually stride = "ByterPerPixel"*Width
            Stride = ImageHelper.GetStride(size.Width, pxFormat);
            _colorPixel32 = new byte[Stride * size.Height];
            colorTexture = new Bitmap(size.Width,size.Height);
          
            //Pin pixel32 array
            _colorPixelHandle = GCHandle.Alloc(_colorPixel32, GCHandleType.Pinned);
            //Get the pinned address
            _colorPixelPtr = _colorPixelHandle.AddrOfPinnedObject();
        }
        public DaiBodyPose()
        {
            
            Start();
        }
        // Start. Init textures and frameInfo
        void Start()
        {
            cylinders = new GameObject[17];
            skeleton = new GameObject[17];
            for(var i = 0; i < skeleton.Length; i++)
            {
                cylinders[i] = new();
                skeleton[i] = new();
            }
            connections = new Vector2[16];
            landmarks = new Vector3[17];
            
            // Init dataPath to load body pose NN model
            _dataPath = PathHelper.AssemblyDirectory;
            
            InitTexture();

            // Init FrameInfo. Only need it in case memcpy data ptr on plugin lib.
            frameInfo.colorPreviewData = _colorPixelPtr;
        }

        // Prepare Pipeline Configuration and call pipeline init implementation
        protected override bool InitDevice()
        {
            // Color camera
            config.colorCameraFPS = cameraFPS;
            config.colorCameraResolution = (int) rgbResolution;
            config.colorCameraInterleaved = Interleaved;
            config.colorCameraColorOrder = (int) ColorOrderV;
            // Need it for color camera preview
            config.previewSizeHeight = 192; // 192 for lightning model, 256 for thunder model
            config.previewSizeWidth = 192;
            
            // Mono camera
            config.monoLCameraResolution = (int) monoResolution;
            config.monoRCameraResolution = (int) monoResolution;

            // Depth
            // Need it for depth
            config.confidenceThreshold = 230;
            config.leftRightCheck = true;
            config.ispScaleF1 = 2;
            config.ispScaleF2 = 3;
            config.manualFocus = 130;
            config.depthAlign = 1; // RGB align
            config.subpixel = true;
            config.deviceId = device.deviceId;
            config.deviceNum = (int) device.deviceNum;
            if (useIMU) config.freq = 400;
            if (retrieveSystemInformation) config.rate = 30.0f;
            config.medianFilter = (int) medianFilter;
            
            // Body Pose NN model
            config.nnPath1 = _dataPath +
                             "/Models/movenet_singlepose_lightning_3.blob";
            
            // Plugin lib init pipeline implementation
            deviceRunning = InitBodyPose(config);

            // Check if was possible to init device with pipeline. Base class handles replay data if possible.
            if (!deviceRunning)
                Debug.WriteLine(
                    "Was not possible to initialize Body Pose. Check you have available devices on OAK For Unity -> Device Manager and check you setup correct deviceId if you setup one.");

            return deviceRunning;
        }

        // Get results from pipeline
        protected override void GetResults()
        {
            // if not doing replay
            if (!device.replayResults)
            {
                // Plugin lib pipeline results implementation
                bodyPoseResults = Marshal.PtrToStringAnsi(BodyPoseResults(out frameInfo, GETPreview, 300, 300, UseDepth, drawBodyPoseInPreview, bodyLandmarkThreshold, retrieveSystemInformation,
                    useIMU,
                    (int) device.deviceNum));
            }
            // if replay read results from file
            else
            {
                bodyPoseResults = device.results;
            }
        }
        /// <summary>
        /// AngleBetween - the angle between 2 vectors
        /// </summary>
        /// <returns>
        /// Returns the the angle in degrees between vector1 and vector2
        /// </returns>
        /// <param name="vector1"> The first Vector </param>
        /// <param name="vector2"> The second Vector </param>
        public static float AngleBetween(Vector3 vector1, Vector3 vector2)
        {
            double sin = vector1.X * vector2.Y - vector2.X * vector1.Y;
            double cos = vector1.X * vector2.X + vector1.Y * vector2.Y;

            return (float)(Math.Atan2(sin, cos) * (180 / Math.PI));
        }
        
        void PlaceConnection(GameObject sp1, GameObject sp2, GameObject cyl)
        {
            Vector3 v3Start = sp1.Position;
            Vector3 v3End = sp2.Position;
     
            cyl.Position = (v3End - v3Start)/2.0f + v3Start;
     
            //Vector3 v3T = cyl.transform.localScale; 
            //v3T.y = (v3End - v3Start).magnitude/2; 
        
            //cyl.transform.localScale = v3T;
     
            //cyl.transform.rotation = Quaternion.CreateFromAxisAngle(Vector3.UnitY, v3End - v3Start);
        }
        Image GetImage()
        {
            Bitmap bmp = new Bitmap(size.Width, size.Height, Stride,
                        pxFormat, _colorPixelHandle.AddrOfPinnedObject());

            //After doing your stuff, free the Bitmap and unpin the array.
            return bmp;
            //bmp.Dispose();
            //handle.Free();
        }
        // Process results from pipeline
        protected override void ProcessResults()
        {
            // If not replaying data
            if (!device.replayResults)
            {
                // Apply textures
                if (colorTexture != null)
                    colorTexture.Dispose();
                colorTexture = GetImage();
                //colorTexture.SetPixels32(_colorPixel32);
                //colorTexture.Apply();
            }
            // if replaying data
            else
            {
                // Apply textures but get them from unity device implementation
                for (int i = 0; i < device.textureNames.Count; i++)
                {
                    if (device.textureNames[i] == "color")
                    {
                        colorTexture = device.textures[i];
                        //colorTexture.SetPixels32(device.textures[i].GetPixels32());
                        //colorTexture.Apply();
                    }
                }
            }

            if (string.IsNullOrEmpty(bodyPoseResults)) return;

            // EXAMPLE HOW TO PARSE INFO
            var json = JSON.Parse(bodyPoseResults);
            var arr = json["landmarks"];

            for (int i = 0; i<17; i++) landmarks[i] = Vector3.Zero;
            
            foreach(JSONNode obj in arr)
            {
                int index = -1;
                float x = 0.0f,y = 0.0f,z = 0.0f;
                float kx = 0.0f, ky = 0.0f;

                index = obj["index"];
                x = obj["location.x"];
                y = obj["location.y"];
                z = obj["location.z"];

                kx = obj["xpos"];
                ky = obj["ypos"];

                if (index != -1) 
                {
                    landmarks[index] = new Vector3(x/1000,y/1000,z/1000);
                    if (x!=0 && y!=0 && z!=0) 
                    {
                        skeleton[index].SetActive(true);
                        skeleton[index].Position = landmarks[index];
                    }
                }
            }

            bool allZero = true;
            for (int i=0; i<17; i++)
            {
                if (landmarks[i]!=Vector3.Zero) 
                {
                    allZero = false;
                    break;
                }
            }

            // Update skeleton and movement
            if (!allZero)
            {
                for (int i = 0; i<17; i++) if (landmarks[i] == Vector3.Zero) skeleton[i].SetActive(false);

                // place dots connections
                for (int i=0; i<16; i++)
                {
                    int s = (int)connections[i].X;
                    int e = (int)connections[i].Y;
                    
                    if (landmarks[s] != Vector3.Zero && landmarks[e]!=Vector3.Zero)
                    {
                        cylinders[i].SetActive(true);
                        PlaceConnection(skeleton[s],skeleton[e],cylinders[i]);
                    }
                    else cylinders[i].SetActive(false);
                }
            }
            PoseChanged?.Invoke(this, new PoseChangedArgs() { Heads = cylinders, Skeletons = skeleton, NewImage = colorTexture });
            if (!retrieveSystemInformation || json == null) return;
            
            float ddrUsed = json["sysinfo"]["ddr_used"];
            float ddrTotal = json["sysinfo"]["ddr_total"];
            float cmxUsed = json["sysinfo"]["cmx_used"];
            float cmxTotal = json["sysinfo"]["ddr_total"];
            float chipTempAvg = json["sysinfo"]["chip_temp_avg"];
            float cpuUsage = json["sysinfo"]["cpu_usage"];
            systemInfo = "Device System Information\nddr used: "+ddrUsed+"MiB ddr total: "+ddrTotal+" MiB\n"+"cmx used: "+cmxUsed+" MiB cmx total: "+cmxTotal+" MiB\n"+"chip temp avg: "+chipTempAvg+"\n"+"cpu usage: "+cpuUsage+" %";
        }
    }
    public class PoseChangedArgs : EventArgs
    {

        public GameObject[] Skeletons { get; set; }
        public GameObject[] Heads { get; set; }

        public Image? NewImage { get; set; }
    }
    public class GameObject 
    {
        public float LocalScale { get; set; } = 1;
        public float Magnitude { get; set; } = 1;
        public Vector3 Position { get; set; }
        public void SetActive(bool State)
        {
            this.IsActive = State;
        }
        public bool IsActive { get; set; }
    }
}