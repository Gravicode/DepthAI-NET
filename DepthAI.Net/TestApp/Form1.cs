using DepthAI.Core;

namespace TestApp
{
    public partial class Form1 : Form
    {
        DaiFaceDetector face;
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        void Setup()
        {
            var manager = new OAKDeviceManager();
            var list = manager.GetAvailableDevices();
            face = new DaiFaceDetector();
            BtnStart.Click += (a,b) => {
                //face.StartDevice();
                face.device = new();
                var device = list.First();
                face.device.deviceId = device.deviceId;
                
                face.ConnectDevice();
            };
            BtnStop.Click += (a,b) => {
                //face.StopDevice();
                face.FinishDevice();
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
            /*
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