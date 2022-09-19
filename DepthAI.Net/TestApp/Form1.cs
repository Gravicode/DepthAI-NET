using DepthAI.Core;

namespace TestApp
{
    public partial class Form1 : Form
    {
        DaiFaceDetector face;
        DaiStreams stream;
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        void Setup()
        {
            var manager = new OAKDeviceManager();
            var list = manager.GetAvailableDevices();
            //face = new DaiFaceDetector();
            stream = new();
            BtnStart.Click += (a,b) => {
                //face.StartDevice();
                //face.device = new();
                stream.device = new();
                var device = list.First();
                //face.device.deviceId = device.deviceId;
                stream.device.deviceId = device.deviceId;
                
                stream.ConnectDevice();
                //face.ConnectDevice();
            };
            BtnStop.Click += (a,b) => {
                //face.StopDevice();
                //face.FinishDevice();
                stream.FinishDevice();
            };
            stream.FrameReceived+=(_,o) => {
                if (InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        PicBox1.Image = o.ColorImage;
                        TxtInfo.Clear();
                    });
                }
                else
                {
                    PicBox1.Image = o.ColorImage;
                    TxtInfo.Clear();
                }
            };
            /*
            face.FaceDetected += (_, o) => 
                if (InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        PicBox1.Image = o.NewImage;
                        TxtInfo.Clear();
                        TxtInfo.Text = $"center X: {o.valueCenterX}\ncenter Y: {o.valueCenterY}";
                    });
                }
                else
                {
                    PicBox1.Image = o.NewImage;
                    TxtInfo.Clear();
                    TxtInfo.Text = $"center X: {o.valueCenterX}\ncenter Y: {o.valueCenterY}";
                }
            };
            
            head.HeadPoseChanged += (_, o) => {
                

                if (InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        PicBox1.Image = o.NewImage;
                        TxtInfo.Clear();
                        TxtInfo.Text = $"pitch: {o.newHeadPosePitch}\nroll: {o.newHeadPoseRoll}\nyaw:{o.newHeadPoseYaw}";
                    });
                }
                else
                {
                    PicBox1.Image = o.NewImage;
                    TxtInfo.Clear();
                    TxtInfo.Text = $"pitch: {o.newHeadPosePitch}\nroll: {o.newHeadPoseRoll}\nyaw:{o.newHeadPoseYaw}";
                }
            };*/
        }
    }
}

/*
 //old
 HeadPose head;
        FaceDetector face;
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        void Setup()
        {
            face = new FaceDetector();
            head = new HeadPose();
            BtnStart.Click += (a,b) => {
                //face.StartDevice();
                head.StartDevice();
            };
            BtnStop.Click += (a,b) => {
                //face.StopDevice();
                head.StopDevice();
            };
            face.FaceDetected += (_, o) => {
                if (InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        PicBox1.Image = o.NewImage;
                        TxtInfo.Clear();
                        TxtInfo.Text = $"center X: {o.valueCenterX}\ncenter Y: {o.valueCenterY}";
                    });
                }
                else
                {
                    PicBox1.Image = o.NewImage;
                    TxtInfo.Clear();
                    TxtInfo.Text = $"center X: {o.valueCenterX}\ncenter Y: {o.valueCenterY}";
                }
            };
            
            head.HeadPoseChanged += (_, o) => {
                

                if (InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        PicBox1.Image = o.NewImage;
                        TxtInfo.Clear();
                        TxtInfo.Text = $"pitch: {o.newHeadPosePitch}\nroll: {o.newHeadPoseRoll}\nyaw:{o.newHeadPoseYaw}";
                    });
                }
                else
                {
                    PicBox1.Image = o.NewImage;
                    TxtInfo.Clear();
                    TxtInfo.Text = $"pitch: {o.newHeadPosePitch}\nroll: {o.newHeadPoseRoll}\nyaw:{o.newHeadPoseYaw}";
                }
            };
        }
 */