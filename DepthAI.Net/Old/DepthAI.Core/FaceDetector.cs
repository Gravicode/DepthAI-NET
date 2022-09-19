using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace DepthAI.Core
{
    public class FaceDetector : IDisposable
    {//Lets make our calls from the Plugin

#if WIN
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitFaceDetector(string nnPath);
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool FaceDetectorPreview(IntPtr data, int width, int height);
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern int FaceDetectorResultsMX();
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern int FaceDetectorResultsMY();
        [DllImport("depthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool FinishFaceDetector();
#else
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool InitFaceDetector(string nnPath);
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool FaceDetectorPreview(IntPtr data, int width, int height);
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern int FaceDetectorResultsMX();
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern int FaceDetectorResultsMY();
        [DllImport("libdepthai-core", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool FinishFaceDetector();
#endif


        int Stride;
        public int Width { get; set; } = 300;
        public int Height { get; set; } = 300;

        public Image? cameraImage;

        private byte[] pixel32;
        PixelFormat pxFormat = PixelFormat.Format32bppArgb;
        private GCHandle pixelHandle;
        private IntPtr pixelPtr;

        private bool deviceRunning;

        public int faceDetectorResultsMX;
        public int faceDetectorResultsMY;

        //public Text valueCenterX;
        //public Text valueCenterY;
        public event EventHandler<FaceDetectedArgs> FaceDetected;
        public FaceDetector()
        {
            Setup();
        }
        void Setup()
        {
            InitTexture();
            deviceRunning = false;
        }

        public void StartDevice()
        {
            if (!deviceRunning)
            {
                InitFaceDetector(PathHelper.AssemblyDirectory + "/Models/face-detection-retail-0004_openvino_2021.2_4shave.blob");
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
                FinishFaceDetector();
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

            //Get the pinned address
            pixelPtr = pixelHandle.AddrOfPinnedObject();

        }


        Image GetImage()
        {
            Bitmap bmp = new Bitmap(Width, Height, Stride,
                        pxFormat, pixelPtr);

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
                    if (token.IsCancellationRequested) break;
                    if (deviceRunning)
                    {
                        FaceDetectorPreview(pixelPtr, Width, Height);
                        faceDetectorResultsMX = FaceDetectorResultsMX();
                        faceDetectorResultsMY = FaceDetectorResultsMY();
                        if (cameraImage != null)
                            cameraImage.Dispose();
                        cameraImage = GetImage();
                        FaceDetected?.Invoke(this, new FaceDetectedArgs()
                        {
                            valueCenterX = faceDetectorResultsMX,
                            valueCenterY = faceDetectorResultsMY,
                            NewImage = cameraImage
                        });
                        Thread.Sleep(100);
                    }
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
    public class FaceDetectedArgs : EventArgs
    {

        public float valueCenterX { get; set; }
        public float valueCenterY { get; set; }

        public Image? NewImage { get; set; }
    }
}
