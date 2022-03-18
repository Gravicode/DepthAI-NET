/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<FollowCameraInputsManager>))]
    public class FollowCameraInputsManager : CameraInputsManager<FollowCamera>
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public FollowCameraInputsManager() : base() { }

        public FollowCameraInputsManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FollowCameraInputsManager(
            FollowCamera camera
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FollowCameraInputsManager" },
                camera
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public FollowCameraInputsManager addKeyboard()
        {
            return EventHorizonBlazorInterop.FuncClass<FollowCameraInputsManager>(
                entity => new FollowCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addKeyboard" }
                }
            );
        }

        public FollowCameraInputsManager addMouseWheel()
        {
            return EventHorizonBlazorInterop.FuncClass<FollowCameraInputsManager>(
                entity => new FollowCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addMouseWheel" }
                }
            );
        }

        public FollowCameraInputsManager addPointers()
        {
            return EventHorizonBlazorInterop.FuncClass<FollowCameraInputsManager>(
                entity => new FollowCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addPointers" }
                }
            );
        }

        public FollowCameraInputsManager addVRDeviceOrientation()
        {
            return EventHorizonBlazorInterop.FuncClass<FollowCameraInputsManager>(
                entity => new FollowCameraInputsManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "addVRDeviceOrientation" }
                }
            );
        }
        #endregion
    }
}