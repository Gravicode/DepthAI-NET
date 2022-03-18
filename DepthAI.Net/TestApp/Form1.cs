using DepthAI.Core;

namespace TestApp
{
    public partial class Form1 : Form
    {
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
                face.StartDevice();
                //head.StartDevice();
            };
            BtnStop.Click += (a,b) => {
                face.StopDevice();
                //head.StopDevice();
            };
            face.FaceDetected += (_, o) => {
                if (InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        PicBox1.Image = o.NewImage;
                        TxtInfo.Clear();
                        TxtInfo.Text = $"center X: {o.valueCenterX}, center Y: {o.valueCenterY}";
                    });
                }
                else
                {
                    PicBox1.Image = o.NewImage;
                    TxtInfo.Clear();
                    TxtInfo.Text = $"center X: {o.valueCenterX}, center Y: {o.valueCenterY}";
                }
            };
            
            head.HeadPoseChanged += (_, o) => {
                

                if (InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        PicBox1.Image = o.NewImage;
                        TxtInfo.Clear();
                        TxtInfo.Text = $"pitch: {o.newHeadPosePitch}, roll: {o.newHeadPoseRoll}, yaw:{o.newHeadPoseYaw}";
                    });
                }
                else
                {
                    PicBox1.Image = o.NewImage;
                    TxtInfo.Clear();
                    TxtInfo.Text = $"pitch: {o.newHeadPosePitch}, roll: {o.newHeadPoseRoll}, yaw:{o.newHeadPoseYaw}";
                }
            };
        }
    }
}