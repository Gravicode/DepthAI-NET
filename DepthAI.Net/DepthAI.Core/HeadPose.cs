using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace DepthAI.Core
{
    public class HeadPose:IDisposable
    {
        //Lets make our calls from the Plugin

#if WIN
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitHeadPose(string nnPath, string nnPath2);
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool HeadPosePreview(IntPtr data, int width, int height);
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern float HeadPoseYaw();
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern float HeadPoseRoll();
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern float HeadPosePitch();
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool FinishHeadPose();
#else
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitHeadPose(string nnPath,string nnPath2);
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool HeadPosePreview(IntPtr data, int width, int height);
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern float HeadPoseYaw();
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern float HeadPoseRoll();
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern float HeadPosePitch();
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool FinishHeadPose();        
#endif


        public Image cameraImage;
        //private Texture2D cameraTexture;

        //private Texture2D tex;
        private byte[] pixel32;
        PixelFormat pxFormat = PixelFormat.Format32bppArgb;
        private GCHandle pixelHandle;
        private IntPtr pixelPtr;

        int Stride;
        public int Width { get; set; } = 300;
        public int Height { get; set; } = 300;

        private bool deviceRunning;

        public float headPoseYaw;
        public float headPoseRoll;
        public float headPosePitch;

        private float oldHeadPoseYaw;
        private float oldHeadPoseRoll;
        private float oldHeadPosePitch;

        //public string valueCenterYaw;
        //public string valueCenterRoll;
        //public string valueCenterPitch;

        public HeadPose()
        {
            Setup();
        }

        public event EventHandler<HeadPoseChangedArgs> HeadPoseChanged;
        void Setup()
        {
            //cameraTexture = new Texture2D(300, 300);    
            InitTexture();
            //cameraImage.material.mainTexture = tex;
            deviceRunning = false;

            oldHeadPoseYaw = 0.0f;
            oldHeadPoseRoll = 0.0f;
            oldHeadPosePitch = 0.0f;

        }

        public void StartDevice()
        {
            if (!deviceRunning)
            {
                InitHeadPose(PathHelper.AssemblyDirectory + "/Models/face-detection-retail-0004_openvino_2021.2_4shave.blob", PathHelper.AssemblyDirectory + "/Models/head-pose-estimation-adas-0001_openvino_2021.2_4shave.blob");
                deviceRunning = true;
                tokenSource = new CancellationTokenSource();
                DoLooping(tokenSource.Token);
            }
        }

        public void StopDevice()
        {
            if (deviceRunning)
            {
                tokenSource.Cancel();
                deviceRunning = false;
                FinishHeadPose();
            }
        }

        void InitTexture()
        {
            Size size = new Size(Width, Height);
            
            //Get the stride, in this case it will have the same length of the width.
            //Because the image Pixel format is 1 Byte/pixel.
            //Usually stride = "ByterPerPixel"*Width
            Stride = ImageHelper.GetStride(size.Width, pxFormat);
            pixel32 = new byte[Stride * size.Height];
            pixelHandle = GCHandle.Alloc(pixel32, GCHandleType.Pinned);
           
            //tex = new Texture2D(300, 300, TextureFormat.ARGB32, false);
            //pixel32 = tex.GetPixels32();
            //Pin pixel32 array
            
            //Get the pinned address
            pixelPtr = pixelHandle.AddrOfPinnedObject();
        }
        

        Image GetImage()
        {
            Bitmap bmp = new Bitmap(Width, Height, Stride,
                        pxFormat, pixelHandle.AddrOfPinnedObject());

            //After doing your stuff, free the Bitmap and unpin the array.
            return bmp;
            //bmp.Dispose();
            //handle.Free();
        }

        CancellationTokenSource tokenSource;
        void DoLooping(CancellationToken token)
        {
            var thread1 = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    if (deviceRunning)
                    {
                        HeadPosePreview(pixelPtr, Width, Height);
                        headPoseYaw = HeadPoseYaw();
                        headPoseRoll = HeadPoseRoll();
                        headPosePitch = HeadPosePitch();

                        //valueCenterYaw = headPoseYaw.ToString();
                        //valueCenterRoll = headPoseRoll.ToString();
                        //valueCenterPitch = headPosePitch.ToString();

                        if (System.Math.Abs(headPoseRoll - oldHeadPoseRoll) > 2.0f && System.Math.Abs(headPosePitch - oldHeadPosePitch) > 2.0f && System.Math.Abs(headPoseYaw - oldHeadPoseYaw) > 2.0f)
                        {

                            // roll

                            //cube.transform.Rotate(0f, (headPoseRoll - oldHeadPoseRoll), 0f, Space.Self);

                            // // pitch

                            //cube.transform.Rotate(0f, 0f, -(headPosePitch - oldHeadPosePitch), Space.Self);
                            // // yaw
                            //cube.transform.Rotate((headPoseYaw - oldHeadPoseYaw), 0f, 0f, Space.Self);

                            oldHeadPoseRoll = headPoseRoll;
                            oldHeadPoseYaw = headPoseYaw;
                            oldHeadPosePitch = headPosePitch;
                        }

                        cameraImage = GetImage();
                        HeadPoseChanged?.Invoke(this,new HeadPoseChangedArgs() { newHeadPosePitch = headPosePitch, newHeadPoseRoll = headPoseRoll, newHeadPoseYaw  = headPoseYaw,
                         oldHeadPosePitch = oldHeadPosePitch, oldHeadPoseRoll = oldHeadPoseRoll, oldHeadPoseYaw = oldHeadPoseYaw, NewImage = cameraImage});
                        //tex.SetPixels32(pixel32);
                        //tex.Apply();
                    }
                    Thread.Sleep(100);
                    if (token.IsCancellationRequested) break;
                }
            }));
            thread1.Start();
            
        }

        public void Dispose()
        {
            StopDevice();
            //Free handle
            pixelHandle.Free();
        }
    }

    public class HeadPoseChangedArgs:EventArgs
    {
      
        public float newHeadPoseRoll { get; set; }
        public float newHeadPoseYaw { get; set; }
        public float newHeadPosePitch { get; set; }
        public float oldHeadPoseRoll { get; set; }
        public float oldHeadPoseYaw { get; set; }
        public float oldHeadPosePitch { get; set; }
        public Image? NewImage { get; set; }
    }
}
