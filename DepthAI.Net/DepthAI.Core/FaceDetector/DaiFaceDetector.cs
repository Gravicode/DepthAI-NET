/*
* This file contains face detector pipeline and interface for Unity scene called "Face Detector"
* Main goal is to show how to use basic NN model like face detector inside Unity
*/

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using SimpleJSON;
using System.Drawing.Imaging;
using System.Drawing;
using System.Diagnostics;

namespace DepthAI.Core
{
    public class DaiFaceDetector : PredefinedBase, IDisposable
    {
        //Lets make our calls from the Plugin
        [DllImport("depthai-unity", CallingConvention = CallingConvention.Cdecl)]
        /*
        * Pipeline creation based on streams template
        *
        * @param config pipeline configuration 
        * @returns pipeline 
        */
        private static extern bool InitFaceDetector(in PipelineConfig config);

        [DllImport("depthai-unity", CallingConvention = CallingConvention.Cdecl)]
        /*
        * Pipeline results
        *
        * @param frameInfo camera images pointers
        * @param getPreview True if color preview image is requested, False otherwise. Requires previewSize in pipeline creation.
        * @param drawBestFaceInPreview True to draw face rectangle in the preview image
        * @param drawAllFacesInPreview True to draw all detected faces in the preview image
        * @param faceScoreThreshold Normalized score to filter face detections
        * @param useDepth True if depth information is requested, False otherwise. Requires confidenceThreshold in pipeline creation.
        * @param retrieveInformation True if system information is requested, False otherwise. Requires rate in pipeline creation.
        * @param useIMU True if IMU information is requested, False otherwise. Requires freq in pipeline creation.
        * @param deviceNum Device selection on unity dropdown
        * @returns Json with results or information about device availability. 
        */    
        private static extern IntPtr FaceDetectorResults(out FrameInfo frameInfo, bool getPreview, bool drawBestFaceInPreview, bool drawAllFacesInPreview, float faceScoreThreshold, bool useDepth, bool retrieveInformation, bool useIMU, int deviceNum);
        int Stride;
        public int Width { get; set; } = 300;
        public int Height { get; set; } = 300;
        public Image? cameraImage;
        // Editor attributes
        //[Header("RGB Camera")] 
        public float cameraFPS = 30;
        public RGBResolution rgbResolution;
        private const bool Interleaved = false;
        private const ColorOrder ColorOrderV = ColorOrder.BGR;

        //[Header("Mono Cameras")] 
        public MonoResolution monoResolution;

        //[Header("Face Detector Configuration")] 
        public MedianFilter medianFilter;
        public bool useIMU = false;
        public bool retrieveSystemInformation = false;
        public bool drawBestFaceInPreview=true;
        public bool drawAllFacesInPreview;
        public float faceScoreThreshold; 
        private const bool GETPreview = true;
        private const bool UseDepth = true;

        //[Header("Face Detector Results")] 
        //public Texture2D colorTexture;
        public string faceDetectorResults;
        public string systemInfo;

        //[Header("Cube Character")] public GameObject cubeCharacter;

        // private attributes
        //private Color32[] _colorPixel32;
        private byte[] _colorPixel32;
        PixelFormat pxFormat = PixelFormat.Format32bppArgb;
        private GCHandle _colorPixelHandle;
        private IntPtr _colorPixelPtr;

        public event EventHandler<FaceDetectedArgs> FaceDetected;

        // Init textures. Each PredefinedBase implementation handles textures. Decoupled from external viz (Canvas, VFX, ...)
        void InitTexture()
        {
            /*
            colorTexture = new Texture2D(300, 300, TextureFormat.ARGB32, false);
            _colorPixel32 = colorTexture.GetPixels32();
            //Pin pixel32 array
            _colorPixelHandle = GCHandle.Alloc(_colorPixel32, GCHandleType.Pinned);
            //Get the pinned address
            _colorPixelPtr = _colorPixelHandle.AddrOfPinnedObject();

            */
            Size size = new Size(Width, Height);
            //Get the stride, in this case it will have the same length of the width.
            //Because the image Pixel format is 1 Byte/pixel.
            //Usually stride = "ByterPerPixel"*Width
            Stride = ImageHelper.GetStride(size.Width, pxFormat);
            _colorPixel32 = new byte[Stride * size.Height];
            _colorPixelHandle = GCHandle.Alloc(_colorPixel32, GCHandleType.Pinned);

            //Get the pinned address
            _colorPixelPtr = _colorPixelHandle.AddrOfPinnedObject();
        }
        public DaiFaceDetector()
        {
            Start();
        }

        // Start. Init textures and frameInfo
        void Start()
        {
            // Init dataPath to load face detector NN model
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
            config.previewSizeHeight = 300;
            config.previewSizeWidth = 300;
            
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
            config.subpixel = false;
            config.deviceId = device.deviceId;
            config.deviceNum = (int) device.deviceNum;
            if (useIMU) config.freq = 400;
            if (retrieveSystemInformation) config.rate = 30.0f;
            config.medianFilter = (int) medianFilter;
            
            // Face NN model
            config.nnPath1 = _dataPath + "\\Models\\face-detection-retail-0004_openvino_2021.2_4shave.blob";
            // Plugin lib init pipeline implementation
            deviceRunning = InitFaceDetector(config);
            
            // Check if was possible to init device with pipeline. Base class handles replay data if possible.
            if (!deviceRunning)
                Debug.WriteLine(
                    "Was not possible to initialize Face Detector. Check you have available devices on OAK For Unity -> Device Manager and check you setup correct deviceId if you setup one.");
           
            return deviceRunning;
        }

        // Get results from pipeline
        protected override void GetResults()
        {
            // if not doing replay
            if (!device.replayResults)
            {
                // Plugin lib pipeline results implementation
                var res = FaceDetectorResults(out frameInfo, GETPreview, drawBestFaceInPreview, drawAllFacesInPreview, faceScoreThreshold, UseDepth, retrieveSystemInformation,
                    useIMU,
                    (int)device.deviceNum);
                faceDetectorResults = Marshal.PtrToStringAnsi(res);
            }
            // if replay read results from file
            else
            {
                faceDetectorResults = device.results;
            }
        }
        Image GetImage()
        {
            Bitmap bmp = new Bitmap(Width, Height, Stride,
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
                //colorTexture.SetPixels32(_colorPixel32);
                //colorTexture.Apply();
                if (cameraImage != null)
                    cameraImage.Dispose();
                cameraImage = GetImage();
            }
            // if replaying data
            else
            {
                // Apply textures but get them from unity device implementation
                for (int i = 0; i < device.textureNames.Count; i++)
                {
                    if (device.textureNames[i] == "color")
                    {
                        if (cameraImage != null)
                            cameraImage.Dispose();
                        cameraImage = GetImage();
                        //colorTexture.SetPixels32(device.textures[i].GetPixels32());
                        //colorTexture.Apply();
                    }
                }
            }

            if (string.IsNullOrEmpty(faceDetectorResults)) return;

            // EXAMPLE HOW TO PARSE INFO
            // Example JSON results from Face detection returned by the plugin
            // { "faces": [ {"label":0,"score":0.0,"xmin":0.0,"ymin":0.0,"xmax":0.0,"ymax":0.0,"xcenter":0.0,"ycenter":0.0},{"label":1,"score":1.0,"xmin":0.0,"ymin":0.0,"xmax":0.0,* "ymax":0.0,"xcenter":0.0,"ycenter":0.0}],"best":{"label":1,"score":1.0,"xmin":0.0,"ymin":0.0,"xmax":0.0,"ymax":0.0,"xcenter":0.0,"ycenter":0.0},"fps":0.0}
            
            var obj = JSON.Parse(faceDetectorResults);
            int centerx = 0;
            int centery = 0;
            if (obj != null)
            {
                centerx = obj["best"]["xcenter"];
                centery = obj["best"]["ycenter"];
            }
            if (centerx == 0 && centery == 0) {}
            else
            {
                // record results
                if (device.recordResults)
                {
                    List<Image> textures = new List<Image>() {cameraImage};
                    List<string> nameTextures = new List<string>() {"color"};

                    device.Record(faceDetectorResults, textures, nameTextures);
                }
                
                if (UseDepth)
                {
                    int depthx = obj["best"]["X"];
                    int depthy = obj["best"]["Y"];
                    int depthz = obj["best"]["Z"];
                    if (depthx == 0 && depthy == 0 && depthz == 0) {}
                    else
                    {
                        // move cube character
                        // Normalize 3D position of face regarding the camera to the Unity scene depending your use case / design / needs
                        //cubeCharacter.transform.localPosition = new Vector3((float)depthx/100.0f,(float)depthy/100.0f,(float)depthz/100.0f);
                    }
                }
                //else cubeCharacter.transform.localPosition = new Vector3((float)(150-centerx)/100.0f,(float)-(centery-150)/100.0f,cubeCharacter.transform.localPosition.z);
            }
            FaceDetected?.Invoke(this, new FaceDetectedArgs()
            {
                valueCenterX = centerx,
                valueCenterY = centery,
                NewImage = cameraImage
            });
            if (!retrieveSystemInformation || obj == null) return;
            
            float ddrUsed = obj["sysinfo"]["ddr_used"];
            float ddrTotal = obj["sysinfo"]["ddr_total"];
            float cmxUsed = obj["sysinfo"]["cmx_used"];
            float cmxTotal = obj["sysinfo"]["ddr_total"];
            float chipTempAvg = obj["sysinfo"]["chip_temp_avg"];
            float cpuUsage = obj["sysinfo"]["cpu_usage"];
            systemInfo = "Device System Information\nddr used: "+ddrUsed+"MiB ddr total: "+ddrTotal+" MiB\n"+"cmx used: "+cmxUsed+" MiB cmx total: "+cmxTotal+" MiB\n"+"chip temp avg: "+chipTempAvg+"\n"+"cpu usage: "+cpuUsage+" %";
        }

        public void Dispose()
        {
           
                FinishDevice();
                //Free handle
                _colorPixelHandle.Free();
            
        }
    }
    public class FaceDetectedArgs : EventArgs
    {

        public float valueCenterX { get; set; }
        public float valueCenterY { get; set; }

        public Image? NewImage { get; set; }
    }
}