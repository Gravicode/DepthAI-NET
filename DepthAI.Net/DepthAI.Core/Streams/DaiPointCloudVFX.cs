/*
 * This file contains cloud point VFX pipeline and interface for Unity scenes called "PointCloudVFX","MatrixVFX","Matrix2VFX"
 * Main goal is to display depth as point cloud using Visual Effect Graph
 * This work is based on Keijiro Takahashi https://github.com/keijiro/DepthAITestbed
 */

using System;
using System.Runtime.InteropServices;
//using UnityEngine;
using System.Collections.Generic;
using SimpleJSON;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace DepthAI.Core
{
    public class DaiPointCloudVFX : PredefinedBase
    {
        //Lets make our calls from the Plugin
        [DllImport("depthai-unity", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitPointCloudVFX(in PipelineConfig config);

        [DllImport("depthai-unity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr PointCloudVFXResults(out FrameInfo frameInfo, bool getPreview, bool useDepth,
            bool retrieveInformation, bool useIMU, int deviceNum);


        // public attributes
        
        //[Header("RGB Camera")]
        public float cameraFPS = 30;
        public RGBResolution rgbResolution;
        private const bool Interleaved = false;
        private const ColorOrder ColorOrderV = ColorOrder.BGR;

        //[Header("Mono Cameras")] 
        public MonoResolution monoResolution;

        //[Header("Point Cloud VFX Configuration")]
        //[Tooltip("by default Kernel 7x7")]
        public MedianFilter medianFilter;

        public bool useIMU = false;
        public bool retrieveSystemInformation = false;
        private const bool GETPreview = true;
        private const bool UseDepth = true;

        public bool useAlignment = false;
        public bool useSubpixel = true;

        //[Header("Point Cloud VFX Results")] 
        public Image colorTexture;
        public Image monoRTexture;
        public Image depthTexture;
        public string pointCloudVFXResults;
        public string systemInfo;

        // private attributes

        private byte[] _monoRPixel32;
        private GCHandle _monoRPixelHandle;
        private IntPtr _monoRPixelPtr;

        private byte[] _depthPixel32;
        private GCHandle _depthPixelHandle;
        private IntPtr _depthPixelPtr;

        private byte[] _colorPixel32;
        private GCHandle _colorPixelHandle;
        private IntPtr _colorPixelPtr;

        public ushort[] depthU;
        public GCHandle depthGC;
        public IntPtr depthPtr;

        PixelFormat MonoPxFormat;
        Size Monosize;
        int MonoStride;
        Size Colorsize;
        int ColorStride;
        PixelFormat ColorPxFormat;
        PixelFormat DepthPxFormat;

        /*
         * Init textures. In this case we allocate them but copy data in unity side with loadrawdata
         */
        void InitTexture()
        {
            int previewResW = 300;
            int previewResH = 300;
            int monoW = 640;
            int monoH = 400;


            if (useAlignment)
            {
                previewResW = 640;
                previewResH = 360;
                monoW = 640;
                monoH = 360;
            }
                
            colorTexture = new Bitmap(previewResW, previewResH);
            //_colorPixel32 = colorTexture.GetPixels32();
            Colorsize = new Size(previewResW, previewResH);
            ColorPxFormat = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
            ColorStride = ImageHelper.GetStride(Colorsize.Width, ColorPxFormat);
            _colorPixel32 = new byte[ColorStride * Colorsize.Height];
            //Pin pixel32 array
            _colorPixelHandle = GCHandle.Alloc(_colorPixel32, GCHandleType.Pinned);
            //Get the pinned address
            _colorPixelPtr = _colorPixelHandle.AddrOfPinnedObject();


            MonoPxFormat = System.Drawing.Imaging.PixelFormat.Format32bppArgb;
            monoRTexture = new Bitmap(monoW, monoH); //new Texture2D(monoW, monoH, TextureFormat.ARGB32, false);
            Monosize = new Size(monoW, monoH);
            MonoStride = ImageHelper.GetStride(Monosize.Width, MonoPxFormat);
            _monoRPixel32 = new byte[MonoStride * Monosize.Height];
            //_monoRPixel32 = monoRTexture.GetPixels32();
            //Pin pixel32 array
            _monoRPixelHandle = GCHandle.Alloc(_monoRPixel32, GCHandleType.Pinned);
            //Get the pinned address
            _monoRPixelPtr = _monoRPixelHandle.AddrOfPinnedObject();

            DepthPxFormat = System.Drawing.Imaging.PixelFormat.Format16bppArgb1555;
            depthTexture = new Bitmap(monoW, monoH, DepthPxFormat); //new Texture2D(monoW, monoH, TextureFormat.R16, false);
            
        }
        public DaiPointCloudVFX()
        {
            Start();
        }
        // Init textures. In this case we don't assign pointers previous copy
        void Start()
        {
            InitTexture();
            
            frameInfo.colorPreviewData = _colorPixelPtr;
            frameInfo.rectifiedRData = _monoRPixelPtr;

            if (useAlignment) depthU = new ushort[640 * 360];
            else depthU = new ushort[640 * 400];
            depthGC = GCHandle.Alloc(depthU, GCHandleType.Pinned);
            depthPtr = depthGC.AddrOfPinnedObject();
            frameInfo.depthData = depthPtr;
        }

        // Prepare Pipeline Configuration and call pipeline init implementation
        protected override bool InitDevice()
        {
            // Color camera
            config.colorCameraFPS = cameraFPS;
            config.colorCameraResolution = (int) rgbResolution;
            config.colorCameraInterleaved = Interleaved;
            config.colorCameraColorOrder = (int) ColorOrderV;

            // Not really impact if using alignment
            config.previewSizeHeight = 300;
            config.previewSizeWidth = 300;

            // Mono camera
            config.monoLCameraResolution = (int) monoResolution;
            config.monoRCameraResolution = (int) monoResolution;

            // Depth
            config.confidenceThreshold = 245;

            if (useAlignment)
            {
                config.ispScaleF1 = 1; 
                config.ispScaleF2 = 3; 
                config.manualFocus = 130;
                config.depthAlign = 1; // RGB align
            }
            else
            {
                config.ispScaleF1 = 0;
                config.ispScaleF2 = 0;
                config.manualFocus = 0;
            }

            config.leftRightCheck = true;
            config.subpixel = useSubpixel;
            config.deviceId = device.deviceId;
            config.deviceNum = (int) device.deviceNum;
            config.medianFilter = (int) medianFilter;

            // Plugin lib init pipeline implementation
            deviceRunning = InitPointCloudVFX(config);
            
            // Check if was possible to init device with pipeline. Base class handles replay data if possible.
            if (!deviceRunning)
                Debug.WriteLine(
                    "Was not possible to initialize Point Cloud VFX. Check you have available devices on OAK For Unity -> Device Manager and check you setup correct deviceId if you setup one.");

            return deviceRunning;
        }

        // Get results from pipeline
        protected override void GetResults()
        {
            // if not doing replay
            if (!device.replayResults)
            {
                // Plugin lib pipeline results implementation
                pointCloudVFXResults = Marshal.PtrToStringAnsi(PointCloudVFXResults(out frameInfo, GETPreview, UseDepth,
                    retrieveSystemInformation, useIMU,
                    (int) device.deviceNum));
            }
            else
            {
                pointCloudVFXResults = device.results;
            }
        }
        Image GetImageMono()
        {
            Bitmap bmp = new Bitmap(Monosize.Width, Monosize.Height, MonoStride,
                        MonoPxFormat, _monoRPixelHandle.AddrOfPinnedObject());

            //After doing your stuff, free the Bitmap and unpin the array.
            return bmp;
            //bmp.Dispose();
            //handle.Free();
        } 
        
        Image GetImageColor()
        {
            Bitmap bmp = new Bitmap(Colorsize.Width, Colorsize.Height, ColorStride,
                        ColorPxFormat, _colorPixelHandle.AddrOfPinnedObject());

            //After doing your stuff, free the Bitmap and unpin the array.
            return bmp;
            //bmp.Dispose();
            //handle.Free();
        }
        
        Image GetImageDepth(int Width,int Height, int Stride, IntPtr Ptr)
        {
            Bitmap bmp = new Bitmap(Width,Height, Stride,
                        DepthPxFormat, Ptr);

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
                if (colorTexture != null)
                    colorTexture.Dispose();
                colorTexture = GetImageColor();
                //colorTexture.SetPixels32(_colorPixel32);
                //colorTexture.Apply();

                if (monoRTexture != null)
                    monoRTexture.Dispose();
                monoRTexture = GetImageMono();
                //monoRTexture.SetPixels32(_monoRPixel32);
                //monoRTexture.Apply();

                if (!useAlignment) depthTexture = GetImageDepth( 640, 400, 2, depthPtr);
                else depthTexture = GetImageDepth(640, 360, 2, depthPtr);
                //depthTexture.Apply();

                // If recording data
                if (!device.recordResults) return;
                
                List<Image> textures = new List<Image>() {monoRTexture, depthTexture};
                List<string> nameTextures = new List<string>() {"monor", "depth"};

                device.Record("", textures, nameTextures);
            }
            // replay data
            else
            {
                for (int i = 0; i < device.textureNames.Count; i++)
                {
                    if (device.textureNames[i] == "monor")
                    {
                        if (monoRTexture != null)
                            monoRTexture.Dispose();
                        monoRTexture = device.textures[i];
                        //monoRTexture.SetPixels32(device.textures[i].GetPixels32());
                        //monoRTexture.Apply();
                    }

                    if (device.textureNames[i] == "depth")
                    {
                        depthTexture = device.textures[i];
                        //depthTexture.SetPixels32(device.textures[i].GetPixels32());
                        //depthTexture.Apply();
                    }

                }
            }

            if (string.IsNullOrEmpty(pointCloudVFXResults)) return;

            // EXAMPLE HOW TO PARSE INFO
            var obj = JSON.Parse(pointCloudVFXResults);
            if (!retrieveSystemInformation || obj == null) return;
            
            float ddrUsed = obj["sysinfo"]["ddr_used"];
            float ddrTotal = obj["sysinfo"]["ddr_total"];
            float cmxUsed = obj["sysinfo"]["cmx_used"];
            float cmxTotal = obj["sysinfo"]["ddr_total"];
            float chipTempAvg = obj["sysinfo"]["chip_temp_avg"];
            float cpuUsage = obj["sysinfo"]["cpu_usage"];
            systemInfo = "Device System Information\nddr used: "+ddrUsed+"MiB ddr total: "+ddrTotal+" MiB\n"+"cmx used: "+cmxUsed+" MiB cmx total: "+cmxTotal+" MiB\n"+"chip temp avg: "+chipTempAvg+"\n"+"cpu usage: "+cpuUsage+" %";
       }
    }
}