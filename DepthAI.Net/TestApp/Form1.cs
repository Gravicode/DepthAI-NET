using DepthAI.Core;

namespace TestApp
{
    public partial class Form1 : Form
    {
        DaiFaceDetector face;
        DaiStreams stream;
        DaiObjectDetector objdet;
        DaiBodyPose pose;
        DaiFaceEmotions emotion;
        DaiHeadPose head;
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        record analysistype (string name, string value);

        void Clear()
        {
            PicBox1.Image = null;
            PicBox2.Image = null;
            PicBox3.Image = null;
            PicBox4.Image = null;
            PicBox5.Image = null;
            PicBox6.Image = null;
            TxtInfo.Clear();
        }
        void Setup()
        {
            var listAnalysis = new List<analysistype>() { 
             new analysistype ("face","face"),
             new analysistype ("emotion","emotion"),
             new analysistype ("body pose","body-pose"),
             new analysistype ("object detector","object-detector"),
             new analysistype ("streams","streams"),
             new analysistype ("head pose","head-pose"),
            };
            CmbType.DataSource = listAnalysis;
            CmbType.DisplayMember = "name";
            CmbType.ValueMember = "value";
            
            var manager = new OAKDeviceManager();
            var list = manager.GetAvailableDevices();

           
           
            //stream = new();
            BtnStart.Click += (a,b) => {
                Clear();
                var selItem = CmbType.SelectedItem as analysistype;
                var device = list.First();
                switch (selItem.value)
                {
                    case "face":
                        face = new DaiFaceDetector();

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

                        face.device = new();
                        face.device.deviceId = device.deviceId;
                        face.ConnectDevice();
                       
                        face.StartAnalysis();
                        break;
                    case "emotion":
                        emotion = new  DaiFaceEmotions();

                        emotion.FaceEmotionDetected += (_, o) => {
                            if (InvokeRequired)
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    PicBox1.Image = o.NewImage;
                                    TxtInfo.Clear();
                                    TxtInfo.Text = $"center X: {o.valueCenterX}\ncenter Y: {o.valueCenterY}\nanger: {o.angerProb}\nneutral: {o.neutralProb}\nsurprise: {o.surpriseProb}\nsad: {o.sadProb}\nhappy: {o.happyProb}";
                                });
                            }
                            else
                            {
                                PicBox1.Image = o.NewImage;
                                TxtInfo.Clear();
                                TxtInfo.Text = $"center X: {o.valueCenterX}\ncenter Y: {o.valueCenterY}\nanger: {o.angerProb}\nneutral: {o.neutralProb}\nsurprise: {o.surpriseProb}\nsad: {o.sadProb}\nhappy: {o.happyProb}";
                            }
                        };

                        emotion.device = new();
                        emotion.device.deviceId = device.deviceId;
                        emotion.ConnectDevice();

                        emotion.StartAnalysis();
                        break;
                    case "streams":
                        stream = new();

                        stream.FrameReceived += (_, o) => {
                            if (InvokeRequired)
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    PicBox1.Image = o.ColorImage;
                                    PicBox2.Image = o.MonoLImage;
                                    PicBox3.Image = o.MonoRImage;
                                    PicBox4.Image = o.DepthImage;
                                    PicBox5.Image = o.DisparityImage;
                                    TxtInfo.Clear();
                                });
                            }
                            else
                            {
                                PicBox1.Image = o.ColorImage;
                                PicBox2.Image = o.MonoLImage;
                                PicBox3.Image = o.MonoRImage;
                                PicBox4.Image = o.DepthImage;
                                PicBox5.Image = o.DisparityImage;
                                TxtInfo.Clear();
                            }
                        };

                        stream.device = new();
                        stream.device.deviceId = device.deviceId;
                        stream.ConnectDevice();
                        stream.StartAnalysis();
                        break;
                    case "object-detector":
                        objdet = new ();

                        objdet.ObjectDetected += (_, o) => {
                            if (InvokeRequired)
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    PicBox1.Image = o.NewImage;
                                    TxtInfo.Clear();
                                    foreach(var obj in o.DetectedObjects)
                                    {
                                        TxtInfo.Text += $"label: {obj.Label}, score: {obj.Score}, pos: ({obj.Position.X},{obj.Position.Y},{obj.Position.Z})\n";
                                    }
                                    
                                });
                            }
                            else
                            {
                                PicBox1.Image = o.NewImage;
                                TxtInfo.Clear();
                                foreach (var obj in o.DetectedObjects)
                                {
                                    TxtInfo.Text += $"label: {obj.Label}, score: {obj.Score}, pos: ({obj.P1.X},{obj.Position.Y})-({obj.P2.X},{obj.P2.Y})\n";
                                }
                            }
                        };

                        objdet.device = new();
                        objdet.device.deviceId = device.deviceId;
                        objdet.ConnectDevice();

                        objdet.StartAnalysis();
                        break;
                    case "body-pose":
                        pose = new();

                        pose.PoseChanged += (_, o) => {
                            if (InvokeRequired)
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    PicBox1.Image = o.NewImage;
                                    TxtInfo.Clear();
                                    var counter = 0;
                                    TxtInfo.Text = "skeletons:\n";
                                    foreach (var obj in o.Skeletons)
                                    {
                                        if(obj.IsActive)
                                            TxtInfo.Text += $"ID: {counter++}, pos: {obj.Position} \n";
                                    }
                                    TxtInfo.Text += "heads:\n";
                                    foreach (var obj in o.Heads)
                                    {
                                        if (obj.IsActive)
                                            TxtInfo.Text += $"ID: {counter++}, pos: {obj.Position} \n";
                                    }
                                });
                            }
                            else
                            {
                                PicBox1.Image = o.NewImage;
                                TxtInfo.Clear();
                                var counter = 0;
                                TxtInfo.Text = "skeletons:\n";
                                foreach (var obj in o.Skeletons)
                                {
                                    if (obj.IsActive)
                                        TxtInfo.Text += $"ID: {counter++}, pos: {obj.Position} \n";
                                }
                                TxtInfo.Text += "heads:\n";
                                foreach (var obj in o.Heads)
                                {
                                    if (obj.IsActive)
                                        TxtInfo.Text += $"ID: {counter++}, pos: {obj.Position} \n";
                                }
                            }
                        };

                        pose.device = new();
                        pose.device.deviceId = device.deviceId;
                        pose.ConnectDevice();

                        pose.StartAnalysis();
                        break;
                    case "head-pose":
                        head = new DaiHeadPose();

                        head.HeadPoseChanged += (_, o) => {
                            if (InvokeRequired)
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    PicBox1.Image = o.NewImage;
                                    TxtInfo.Clear();
                                    TxtInfo.Text = $"yaw: {o.HeadYaw}\nroll: {o.HeadRoll}\npitch: {o.HeadPitch}";
                                });
                            }
                            else
                            {
                                PicBox1.Image = o.NewImage;
                                TxtInfo.Clear();
                                TxtInfo.Text = $"yaw: {o.HeadYaw}\nroll: {o.HeadRoll}\npitch: {o.HeadPitch}";
                            }
                        };

                        head.device = new();
                        head.device.deviceId = device.deviceId;
                        head.ConnectDevice();

                        head.StartAnalysis();
                        break;
                    default:
                        break;
                }
                CmbType.Enabled = false;
            };
            BtnStop.Click += (a,b) => {
                var selItem = CmbType.SelectedItem as analysistype;
                switch (selItem.value)
                {
                    case "face":
                        face.FinishDevice();
                        face.Dispose();
                        break;
                    case "emotion":
                        emotion.FinishDevice();
                        emotion.Dispose();
                        break;
                    case "streams":
                        stream.FinishDevice();
                        stream.Dispose();
                        break;
                    case "object-detector":
                        objdet.FinishDevice();
                        objdet.Dispose();
                        break;
                    case "body-pose":
                        pose.FinishDevice();
                        pose.Dispose();
                        break;
                    case "head-pose":
                        head.FinishDevice();
                        head.Dispose();
                        break;
                    default:
                        break;
                }
                CmbType.Enabled = true;

            };
            
           
        }
    }
}
