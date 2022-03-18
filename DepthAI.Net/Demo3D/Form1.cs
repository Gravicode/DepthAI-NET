using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Simulation;
using WebviewAppTest;
using WebviewAppTest.Data;
using DepthAI.Core;

namespace Demo3D
{
    public partial class Form1 : Form
    {
        private readonly AppState _appState = new();

        public Form1()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            serviceCollection.AddSingleton<AppState>(_appState);

            serviceCollection.AddSingleton<WeatherForecastService>();

            InitializeComponent();

            blazorWebView1.HostPage = @"wwwroot\index.html";
            blazorWebView1.Services = serviceCollection.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");
            button1.Click+=button1_Click;
            head = new HeadPose();
            BtnStart.Click += (a, b) => {
                head.StartDevice();
            };
            BtnStop.Click += (a, b) => {
                head.StopDevice();
            };
            

            head.HeadPoseChanged += (_, o) => {

                _appState.MoveHead(o.newHeadPoseRoll, o.newHeadPoseYaw, o.newHeadPosePitch, o.oldHeadPoseRoll, o.oldHeadPoseYaw, o.oldHeadPosePitch);
                if (InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        PicBox1.Image = o.NewImage;
                        //TxtInfo.Clear();
                        //TxtInfo.Text = $"pitch: {o.newHeadPosePitch}, roll: {o.newHeadPoseRoll}, yaw:{o.newHeadPoseYaw}";
                    });
                }
                else
                {
                    PicBox1.Image = o.NewImage;
                    //TxtInfo.Clear();
                    //TxtInfo.Text = $"pitch: {o.newHeadPosePitch}, roll: {o.newHeadPoseRoll}, yaw:{o.newHeadPoseYaw}";
                }
            };
        }
        HeadPose head;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                owner: this,
                text: $"Current counter value is: {_appState.Counter}",
                caption: "Counter");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}