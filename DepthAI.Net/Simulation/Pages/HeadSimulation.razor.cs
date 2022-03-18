using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using WebviewAppTest;
//using babylon_wasm.Client;
using BABYLON;
using EventHorizon.Blazor.Server.BabylonJS.Model;
using EventHorizon.Blazor.Server.Interop.Callbacks;
//using EventHorizon.Blazor.Interop.Callbacks;

namespace Simulation.Pages
{
    public partial class HeadSimulation
    {
        private Engine _engine;
        Scene _scene;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await CreateSceneAsync();
                AppState.HeadMoved += AppState_HeadMoved;
            }
        }
        float oldHeadPoseRoll = 0f;
        float oldHeadPosePitch = 0f;
        float oldHeadPoseYaw = 0f;

        private async void AppState_HeadMoved(object? sender, HeadMoveArgs e)
        {
            if (System.Math.Abs(e.newHeadPoseRoll - oldHeadPoseRoll) > 2.0f && System.Math.Abs(e.newHeadPosePitch - oldHeadPosePitch) > 2.0f && System.Math.Abs(e.newHeadPoseYaw - oldHeadPoseYaw) > 2.0f)
            {

                if (SkullHead != null)
                {
                    /*
                    // roll
                    var vec = await Vector3.NewVector3();
                    await vec.set_x(0);
                    await vec.set_y(0);
                    await vec.set_z((decimal)(e.newHeadPoseRoll - oldHeadPoseRoll));

                    await SkullHead.set_rotation(vec);
                  

                    // // pitch
                    vec = await Vector3.NewVector3();
                    await vec.set_x(-(decimal)(e.newHeadPosePitch - oldHeadPosePitch));
                    await vec.set_y(0);
                    await vec.set_z(0);

                    await SkullHead.set_rotation(vec);

                    // // yaw
                    vec = await Vector3.NewVector3();
                    await vec.set_x(0);
                    await vec.set_y((decimal)(e.newHeadPoseYaw - oldHeadPoseYaw));
                    await vec.set_z(0);

                    await SkullHead.set_rotation(vec);
                    */
                    var vec = await Vector3.NewVector3();
                    await vec.set_x(-(decimal)(e.newHeadPosePitch - oldHeadPosePitch));
                    await vec.set_y((decimal)(e.newHeadPoseYaw - oldHeadPoseYaw));
                    await vec.set_z((decimal)(e.newHeadPoseRoll - oldHeadPoseRoll));

                    await SkullHead.set_rotation(vec);
                    oldHeadPoseRoll = e.newHeadPoseRoll;
                    oldHeadPoseYaw = e.newHeadPoseYaw;
                    oldHeadPosePitch = e.newHeadPosePitch;
                }

            }
        }

        public void Dispose()
        {
            _engine?.dispose();
        }

        //Game game;
        public async Task CreateSceneAsync()
        {
            var canvas = await Canvas.GetElementById(
                   "game-window"
               );
            var engine = await Engine.NewEngine(
                canvas,
                true
            );
            _scene = await Scene.NewScene(
                engine
            );

            //kasih light ke scene
            var light = await HemisphericLight.NewHemisphericLight(
                "HemisphericLight",
                await Vector3.NewVector3(
                    0,
                    100,
                    8
                ),
                _scene
            );
            await light.set_intensity (1);
            
            await BABYLON.SceneLoader.ImportMesh(null, "scenes/", "skull.babylon", _scene,
                new ActionCallback<AbstractMesh[], IParticleSystem[], Skeleton[], AnimationGroup[], TransformNode[], Geometry[], Light[]>(async (meshes, arg2, arg3, arg4, arg5, arg6, arg7) =>
                {
                    foreach(var mesh in meshes)
                    {
                        SkullHead = mesh;
                    }
                    //_scene.createDefaultCameraOrLight(true, true, true);
                    //_scene.createDefaultEnvironment();
                    
                })
                );
            var camera = await ArcRotateCamera.NewArcRotateCamera(
                 "ArcRotateCamera",
                 0,//(decimal)(System.Math.PI / 2),
                 0,//(decimal)(System.Math.PI / 4),
                 0,
                 await Vector3.NewVector3(0, 0, 0),
                 _scene
             );

            //await camera.set_lowerRadiusLimit(2);
            //await camera.set_upperRadiusLimit(10);
            //await camera.set_wheelDeltaPercentage(0.01m);


            await _scene.set_activeCamera(camera);

            await camera.attachControl(
                false
            );
            //init game kita
            //game = new Game(_scene);

            await engine.runRenderLoop(new ActionCallback(
                             () => Task.Run(() => _scene.render(true, false))
                         ));

            _engine = engine;
        }
        AbstractMesh SkullHead;
        //kalau kamu mijit keyboard
        protected void HandleKeyDown(KeyboardEventArgs args)
        {
            Console.WriteLine(args.Key);
            switch (args.Key.ToLower())
            {
                //teken w tuk geser pad ke atas
                case "w":
                    //game?.MovePadUp();
                    break;
                //teken s untuk geser pad ke bawah
                case "s":
                    //game?.MovePadDown();
                    break;

                default:
                    //do nothing
                    break;
            }
            if (args.ShiftKey && args.CtrlKey && args.AltKey && args.Key.ToLower() == "i")
            {
                
            }
        }
    }
    /*
    public class Game
    {
        public enum Players
        {
            Human, Com
        }
        Scene scene;
        const decimal GameWidth = 20;
        const decimal GameHeight = 10;
        const decimal BallDiameter = 1;
        const decimal PadWidth = 3;
        const decimal PadDepth = 0.25m;
        const decimal PadToBorderDist = 1.5m;
        const decimal MovePadDist = 0.5m;
        const decimal BorderDepth = 0.25m;
        const decimal GapSize = 0.75m;

        //vars
        Mesh Ball;
        Mesh MyPad;
        Mesh ComPad;

        //score labels
        BABYLON.GUI.TextBlock PlayerScoreTxt;
        BABYLON.GUI.TextBlock ComScoreTxt;
        BABYLON.GUI.TextBlock StatusTxt;
        //posisi awal game
        public decimal StartX { set; get; } = 0;
        public decimal StartY { set; get; } = 0;
        public Game(Scene scene, decimal X = 0, decimal Y = 0)
        {
            this.scene = scene;
            this.StartX = X;
            this.StartY = Y;
            InitScene();
        }
        //geser pad ke atas
        public void MovePadUp(Players player = Players.Human)
        {
            if (player == Players.Human)
            {
                if (MyPad.position.z < GameHeight - (PadWidth / 2))
                    MyPad.position.z += MovePadDist;
            }
            else
            {
                if (ComPad.position.z < GameHeight - (PadWidth / 2))
                    ComPad.position.z += MovePadDist;
            }
        }
        //geser pad ke bawah
        public void MovePadDown(Players player = Players.Human)
        {
            if (player == Players.Human)
            {
                if (MyPad.position.z - (PadWidth / 2) > 0)
                    MyPad.position.z -= MovePadDist;
            }
            else
            {
                if (ComPad.position.z - (PadWidth / 2) > 0)
                    ComPad.position.z -= MovePadDist;
            }
        }

        void InitScene()
        {
            //border game
            var border_up = BABYLON.MeshBuilder.CreateBox("border-up", new { height = 1, width = GameWidth, depth = BorderDepth }, scene);
            var border_right = BABYLON.MeshBuilder.CreateBox("border-right", new { height = 1, width = GameHeight, depth = BorderDepth }, scene);
            var border_left = BABYLON.MeshBuilder.CreateBox("border-left", new { height = 1, width = GameHeight, depth = BorderDepth }, scene);
            var border_down = BABYLON.MeshBuilder.CreateBox("border-down", new { height = 1, width = GameWidth, depth = BorderDepth }, scene);
            border_up.position.x = StartX + (0.5m * GameWidth);
            border_up.position.z = StartY;

            border_down.position.x = StartX + (0.5m * GameWidth);
            border_down.position.z = StartY + GameHeight;

            border_left.position.x = StartX;
            border_left.position.z = StartY + (0.5m * GameHeight);
            border_left.rotate(BABYLON.Axis.Y, BABYLON.Tools.ToRadians(90));

            border_right.position.x = StartX + (GameWidth);
            border_right.position.z = StartY + (0.5m * GameHeight);
            border_right.rotate(BABYLON.Axis.Y, BABYLON.Tools.ToRadians(90));
            //ball
            Ball = BABYLON.MeshBuilder.CreateSphere("ball", new { diameter = BallDiameter }, scene);
            Ball.position = new Vector3(GameWidth / 2, 0, GameHeight / 2);
            var ballMat = new BABYLON.StandardMaterial("ballmat", scene);
            ballMat.diffuseColor = new BABYLON.Color3(0, 0.5m, 0.7m);
            Ball.material = ballMat;

            //pads
            MyPad = BABYLON.MeshBuilder.CreateBox("player-pad", new { height = 1, width = PadWidth, depth = PadDepth }, scene);
            ComPad = BABYLON.MeshBuilder.CreateBox("com-pad", new { height = 1, width = PadWidth, depth = PadDepth }, scene);

            MyPad.position.x = StartX + PadToBorderDist;
            MyPad.position.z = StartY + (0.5m * GameHeight);
            MyPad.rotate(BABYLON.Axis.Y, BABYLON.Tools.ToRadians(90));
            var playerpadmat = new BABYLON.StandardMaterial("playerpadmat", scene);
            playerpadmat.diffuseColor = new BABYLON.Color3(0.85m, 0, 0);
            MyPad.material = playerpadmat;

            ComPad.position.x = StartX + (GameWidth) - PadToBorderDist;
            ComPad.position.z = StartY + (0.5m * GameHeight);
            ComPad.rotate(BABYLON.Axis.Y, BABYLON.Tools.ToRadians(90));
            var compadmat = new BABYLON.StandardMaterial("compadmat", scene);
            compadmat.diffuseColor = new BABYLON.Color3(0, 0.85m, 0);
            ComPad.material = compadmat;

            //cam
            #region arc rotate cam
            var camera = new BABYLON.ArcRotateCamera("camera", (decimal)(-System.Math.PI / 2), (decimal)(System.Math.PI / 2.5), 30, new BABYLON.Vector3(StartX + (0.5m * GameWidth), 0, (0.5m * GameHeight)), scene);
            camera.upperBetaLimit = (decimal)(System.Math.PI / 2.2);
            camera.attachControl(true);
            #endregion

            //score
            var adt = BABYLON.GUI.AdvancedDynamicTexture.CreateFullscreenUI("UI", true, scene: scene);

            var panel = new BABYLON.GUI.StackPanel("stack1");
            panel.width = "220px";
            panel.top = "-25px";
            panel.horizontalAlignment = BABYLON.GUI.Control.HORIZONTAL_ALIGNMENT_RIGHT;
            panel.verticalAlignment = BABYLON.GUI.Control.VERTICAL_ALIGNMENT_BOTTOM;
            adt.addControl(panel);

            PlayerScoreTxt = new BABYLON.GUI.TextBlock("score1");
            PlayerScoreTxt.text = "Player: ";
            PlayerScoreTxt.height = "30px";
            PlayerScoreTxt.color = "white";
            panel.addControl(PlayerScoreTxt);

            ComScoreTxt = new BABYLON.GUI.TextBlock("score2");
            ComScoreTxt.text = "Com: ";
            ComScoreTxt.height = "30px";
            ComScoreTxt.color = "white";
            panel.addControl(ComScoreTxt);

            StatusTxt = new BABYLON.GUI.TextBlock("status");
            StatusTxt.text = "-";
            StatusTxt.height = "50px";
            StatusTxt.color = "red";
            panel.addControl(StatusTxt);

            //button tuk mulai game
            var btn = BABYLON.GUI.Button.CreateSimpleButton("btnStart", "Start Game");
            btn.horizontalAlignment = BABYLON.GUI.Control.HORIZONTAL_ALIGNMENT_LEFT;
            btn.verticalAlignment = BABYLON.GUI.Control.VERTICAL_ALIGNMENT_BOTTOM;
            btn.textBlock.color = "white";
            btn.width = "200px";
            btn.height = "50px";
            btn.paddingLeft = "10px";
            btn.paddingBottom = "10px";
            btn.onPointerClickObservable.add((i, e) =>
            {
                StartGame();
                return Task.CompletedTask;
            });
            adt.addControl(btn);

        }
        void StartGame()
        {
            //klu mulai game, cek dulu sebelumnya uda mulai atau belum
            if (IsRunning && cts != null)
            {
                cts.Cancel();
                Thread.Sleep(200);
            }
            cts = new CancellationTokenSource();
            //reset posisi bola
            Ball.position = new Vector3(GameWidth / 2, 0, GameHeight / 2);
            gameThread = Task.Run(async () => Loop(cts.Token));
            gameThread.Start();
        }
        Task gameThread;
        public bool IsRunning { get; set; } = false;
        CancellationTokenSource cts;
        //game looping
        async Task Loop(CancellationToken GameToken)
        {

            decimal BallX = Ball.position.x, BallY = Ball.position.z, BallDX = 0.2m, BallDY = 0.4m;
            int ScoreHuman = 0, ScoreCom = 0;
            IsRunning = true;

            while (true)
            {
                //kluar kalau token d cancel
                if (GameToken.IsCancellationRequested)
                {

                    break;
                }

                BallX += BallDX;
                BallY += BallDY;
                //cek kalau bola nubruk tembok kiri
                if (BallX <= GapSize && BallDX < 0)
                {
                    //win
                    //play sound
                    ScoreCom++;
                    BallDX *= -1;
                }
                //cek klu bola nubruk pad player
                else if (BallX >= MyPad.position.x && BallX <= MyPad.position.x + GapSize && BallDX < 0 && BallY >= MyPad.position.z - (PadWidth / 2) && BallY <= MyPad.position.z + (PadWidth / 2))
                {
                    //pantul
                    BallDX *= -1;
                }
                //cek kalau bola nubruk tembok kanan
                if (BallX >= GameWidth - GapSize && BallDX > 0)
                {
                    //win
                    //play sound
                    ScoreHuman++;
                    BallDX *= -1;
                }
                //cek kalau bola nubruk pad com
                else if (BallX + GapSize >= ComPad.position.x && BallX <= ComPad.position.x + PadDepth && BallDX > 0 && BallY >= ComPad.position.z - (PadWidth / 2) && BallY <= ComPad.position.z + (PadWidth / 2))
                {
                    //pantul
                    BallDX *= -1;
                }

                //cek klu bola nubruk langit2 dan bawah
                if (BallY <= GapSize || BallY >= GameHeight - GapSize)
                {
                    BallDY *= -1;

                }

                //move ball
                Ball.position.x = BallX;
                Ball.position.z = BallY;

                // Computer
                if (BallY > ComPad.position.z)
                    MovePadUp(Players.Com);
                else
                if (BallY < ComPad.position.z)
                    MovePadDown(Players.Com);

                // Score
                PlayerScoreTxt.text = $"Player: {ScoreHuman}";
                ComScoreTxt.text = $"Com: {ScoreCom}";

                if (ScoreHuman >= 5)
                {
                    StatusTxt.text = "You Win!";
                    break;
                }

                if (ScoreCom >= 5)
                {
                    StatusTxt.text = "You Lose!";
                    break;
                }
                //delay - kasih kesempatan tuk render UI blazor
                await Task.Delay(50);
            }
            IsRunning = false;
        }
        
    }*/
}