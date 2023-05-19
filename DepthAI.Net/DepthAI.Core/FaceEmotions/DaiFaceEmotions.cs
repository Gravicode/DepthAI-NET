/*
* This file contains face emotion pipeline and interface for Unity scene called "Face Emotion"
* Main goal is to show how to use 2-stage NN model like face emotion inside Unity
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
    public class DaiFaceEmotions : PredefinedBase, IDisposable
    {
        //Lets make our calls from the Plugin
        [DllImport("depthai-unity", CallingConvention = CallingConvention.Cdecl)]
        /*
        * Pipeline creation based on streams template
        *
        * @param config pipeline configuration 
        * @returns pipeline 
        */
        private static extern bool InitFaceEmotion(in PipelineConfig config);
    
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
       
        private static extern IntPtr FaceEmotionResults(out FrameInfo frameInfo, bool getPreview, int width, int height, bool drawBestFaceInPreview, bool drawAllFacesInPreview, float faceScoreThreshold, bool useDepth, bool retrieveInformation, bool useIMU, int deviceNum);
        public event EventHandler<FaceEmotionArgs> FaceEmotionDetected;
        public int Width { get; set; } = 300;
        public int Height { get; set; } = 300;
        int Stride;
        public Image? cameraImage;
        // Editor attributes
        //[Header("RGB Camera")]
        public float cameraFPS = 30;
        public RGBResolution rgbResolution;
        private const bool Interleaved = false;
        private const ColorOrder ColorOrderV = ColorOrder.BGR;

        //[Header("Mono Cameras")]
        public MonoResolution monoResolution;

        //[Header("Face Emotion Configuration")]
        public MedianFilter medianFilter;
        public bool useIMU = false;
        public bool retrieveSystemInformation = false;
        public bool drawBestFaceInPreview;
        public bool drawAllFacesInPreview;
        public float faceScoreThreshold;
        private const bool GETPreview = true;
        private const bool UseDepth = true;

        //[Header("Face Emotion Results")]
        //public Texture2D colorTexture;
        public string faceEmotionResults;
        public string systemInfo;

        // private attributes
        //private Color32[] _colorPixel32;
        private byte[] _colorPixel32;
        PixelFormat pxFormat = PixelFormat.Format32bppArgb;
        
        private GCHandle _colorPixelHandle;
        private IntPtr _colorPixelPtr;

        // Init textures. Each PredefinedBase implementation handles textures. Decoupled from external viz (Canvas, VFX, ...)
        void InitTexture()
        {
            Size size = new Size(Width, Height);
            //Get the stride, in this case it will have the same length of the width.
            //Because the image Pixel format is 1 Byte/pixel.
            //Usually stride = "ByterPerPixel"*Width
            Stride = ImageHelper.GetStride(size.Width, pxFormat);
            _colorPixel32 = new byte[Stride * size.Height];
            _colorPixelHandle = GCHandle.Alloc(_colorPixel32, GCHandleType.Pinned);

            //Get the pinned address
            _colorPixelPtr = _colorPixelHandle.AddrOfPinnedObject();

            //colorTexture = new Texture2D(300, 300, TextureFormat.ARGB32, false);
            //_colorPixel32 = colorTexture.GetPixels32();
            //Pin pixel32 array
            //_colorPixelHandle = GCHandle.Alloc(_colorPixel32, GCHandleType.Pinned);
            //Get the pinned address
            //_colorPixelPtr = _colorPixelHandle.AddrOfPinnedObject();
        }
        public DaiFaceEmotions()
        {
            Start();
        }

        // Start. Init textures and frameInfo
        void Start()
        {
            /*
            // Init dataPath to load face detector NN model
            _dataPath = Application.dataPath;

            InitTexture();

            // Init FrameInfo. Only need it in case memcpy data ptr on plugin lib.
            frameInfo.colorPreviewData = _colorPixelPtr;
            */
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
            config.colorCameraResolution = (int)rgbResolution;
            config.colorCameraInterleaved = Interleaved;
            config.colorCameraColorOrder = (int)ColorOrderV;
            // Need it for color camera preview
            config.previewSizeHeight = 300;
            config.previewSizeWidth = 300;

            // Mono camera
            config.monoLCameraResolution = (int)monoResolution;
            config.monoRCameraResolution = (int)monoResolution;

            // Depth
            // Need it for depth
            config.confidenceThreshold = 230;
            config.leftRightCheck = true;
            if (rgbResolution == RGBResolution.THE_800_P)
            {
                config.ispScaleF1 = 1;
                config.ispScaleF2 = 2;
            }
            else
            {
                config.ispScaleF1 = 2;
                config.ispScaleF2 = 3;
            }
            config.manualFocus = 130;
            config.depthAlign = 1; // RGB align
            config.subpixel = false;
            config.deviceId = device.deviceId;
            config.deviceNum = (int)device.deviceNum;
            if (useIMU) config.freq = 400;
            if (retrieveSystemInformation) config.rate = 30.0f;
            config.medianFilter = (int)medianFilter;

            // 2-stage NN model
            config.nnPath1 = _dataPath +
                             "\\Models\\emotion_2021_stage_1.blob";

            config.nnPath2 = _dataPath +
                             "\\Models\\emotion_2021_stage_2.blob";

            // Plugin lib init pipeline implementation
            deviceRunning = InitFaceEmotion(config);

            // Check if was possible to init device with pipeline. Base class handles replay data if possible.
            if (!deviceRunning)
                Debug.WriteLine(
                    "Was not possible to initialize Face Emotion. Check you have available devices on OAK For Unity -> Device Manager and check you setup correct deviceId if you setup one.");

            return deviceRunning;
        }

        // Get results from pipeline
        protected override void GetResults()
        {
            // if not doing replay
            if (!device.replayResults)
            {
                // Plugin lib pipeline results implementation
                faceEmotionResults = Marshal.PtrToStringAnsi(FaceEmotionResults(out frameInfo, GETPreview, 300, 300, drawBestFaceInPreview, drawAllFacesInPreview, faceScoreThreshold, UseDepth, retrieveSystemInformation,
                    useIMU,
                    (int)device.deviceNum));
            }
            // if replay read results from file
            else
            {
                faceEmotionResults = device.results;
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

            if (string.IsNullOrEmpty(faceEmotionResults)) return;

            // EXAMPLE HOW TO PARSE INFO
            // Example JSON results from Face emotion returned by the plugin
            // {"best":{"X":125,"Y":-123,"Z":559,"label":1,"score":1.0,"xcenter":231,"xmax":0.9609375,"xmin":0.5849609375,"ycenter":229,"ymax":0.98046875,"ymin":0.55078125},
            // "faceEmotion":{"anger":0.62646484375,"happy":0.002521514892578125,"neutral":0.154052734375,"sad":0.2095947265625,"surprise":0.00675201416015625}}

            var obj = JSON.Parse(faceEmotionResults);
            int centerx = 0;
            int centery = 0;
            if (obj != null)
            {
                centerx = obj["best"]["xcenter"];
                centery = obj["best"]["ycenter"];
            }
            if (centerx == 0 && centery == 0) { }
            else
            {
                // record results
                if (device.recordResults)
                {
                    //List<Texture2D> textures = new List<Texture2D>()
                    //    {colorTexture};
                    //List<string> nameTextures = new List<string>() { "color" };
                    List<Image> textures = new List<Image>() { cameraImage };
                    List<string> nameTextures = new List<string>() { "color" };

                    device.Record(faceEmotionResults, textures, nameTextures);
                }

                if (UseDepth)
                {
                    int depthx = obj["best"]["X"];
                    int depthy = obj["best"]["Y"];
                    int depthz = obj["best"]["Z"];
                    if (depthx == 0 && depthy == 0 && depthz == 0) { }
                    else
                    {
                    }
                }

                // PROCESS FACE EMOTION RESULTS
                /*float neutralProb = 0.0f;
                float happyProb = 0.0f;
                float sadProb = 0.0f;
                float surpriseProb = 0.0f;
                float angerProb = 0.0f;

                if (obj != null)
                {
                    neutralProb = obj["faceEmotion"]["neutral"];
                    happyProb = obj["faceEmotion"]["happy"];
                    sadProb = obj["faceEmotion"]["sad"];
                    surpriseProb = obj["faceEmotion"]["surprise"];
                    angerProb = obj["faceEmotion"]["anger"];
                }*/
            }
            if (obj != null)
            {
                FaceEmotionDetected?.Invoke(this, new FaceEmotionArgs()
                {
                    neutralProb = obj["bestFaceEmotion"]["neutral"],
                    happyProb = obj["bestFaceEmotion"]["happy"],
                    sadProb = obj["bestFaceEmotion"]["sad"],
                    surpriseProb = obj["bestFaceEmotion"]["surprise"],
                    angerProb = obj["bestFaceEmotion"]["anger"],
                    valueCenterX = centerx,
                    valueCenterY = centery,
                    NewImage = cameraImage
                });

            }
           
            if (!retrieveSystemInformation || obj == null) return;

            float ddrUsed = obj["sysinfo"]["ddr_used"];
            float ddrTotal = obj["sysinfo"]["ddr_total"];
            float cmxUsed = obj["sysinfo"]["cmx_used"];
            float cmxTotal = obj["sysinfo"]["ddr_total"];
            float chipTempAvg = obj["sysinfo"]["chip_temp_avg"];
            float cpuUsage = obj["sysinfo"]["cpu_usage"];
            systemInfo = "Device System Information\nddr used: " + ddrUsed + "MiB ddr total: " + ddrTotal + " MiB\n" + "cmx used: " + cmxUsed + " MiB cmx total: " + cmxTotal + " MiB\n" + "chip temp avg: " + chipTempAvg + "\n" + "cpu usage: " + cpuUsage + " %";
        }
        public void Dispose()
        {

            FinishDevice();
            //Free handle
            _colorPixelHandle.Free();

        }
    }
    public class FaceEmotionArgs : EventArgs
    {
        public float neutralProb { get; set; }
        public float happyProb { get; set; }
        public float sadProb { get; set; }
        public float surpriseProb { get; set; }
        public float angerProb { get; set; }
        public float valueCenterX { get; set; }
        public float valueCenterY { get; set; }

        public Image? NewImage { get; set; }
    }
}