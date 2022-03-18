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

    
    
    [JsonConverter(typeof(CachedEntityConverter<FollowCamera>))]
    public class FollowCamera : TargetCamera
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
        
        public decimal radius
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "radius"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "radius",
                    value
                );
            }
        }

        
        public decimal lowerRadiusLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerRadiusLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerRadiusLimit",
                    value
                );
            }
        }

        
        public decimal upperRadiusLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperRadiusLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperRadiusLimit",
                    value
                );
            }
        }

        
        public decimal rotationOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "rotationOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rotationOffset",
                    value
                );
            }
        }

        
        public decimal lowerRotationOffsetLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerRotationOffsetLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerRotationOffsetLimit",
                    value
                );
            }
        }

        
        public decimal upperRotationOffsetLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperRotationOffsetLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperRotationOffsetLimit",
                    value
                );
            }
        }

        
        public decimal heightOffset
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "heightOffset"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "heightOffset",
                    value
                );
            }
        }

        
        public decimal lowerHeightOffsetLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "lowerHeightOffsetLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lowerHeightOffsetLimit",
                    value
                );
            }
        }

        
        public decimal upperHeightOffsetLimit
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "upperHeightOffsetLimit"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "upperHeightOffsetLimit",
                    value
                );
            }
        }

        
        public decimal cameraAcceleration
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraAcceleration"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraAcceleration",
                    value
                );
            }
        }

        
        public decimal maxCameraSpeed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxCameraSpeed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxCameraSpeed",
                    value
                );
            }
        }

        private AbstractMesh __lockedTarget;
        public AbstractMesh lockedTarget
        {
            get
            {
            if(__lockedTarget == null)
            {
                __lockedTarget = EventHorizonBlazorInterop.GetClass<AbstractMesh>(
                    this.___guid,
                    "lockedTarget",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __lockedTarget;
            }
            set
            {
__lockedTarget = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "lockedTarget",
                    value
                );
            }
        }

        private FollowCameraInputsManager __inputs;
        public FollowCameraInputsManager inputs
        {
            get
            {
            if(__inputs == null)
            {
                __inputs = EventHorizonBlazorInterop.GetClass<FollowCameraInputsManager>(
                    this.___guid,
                    "inputs",
                    (entity) =>
                    {
                        return new FollowCameraInputsManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __inputs;
            }
            set
            {
__inputs = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inputs",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public FollowCamera() : base() { }

        public FollowCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public FollowCamera(
            string name, Vector3 position, Scene scene, AbstractMesh lockedTarget = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "FollowCamera" },
                name, position, scene, lockedTarget
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void attachControl(System.Nullable<bool> noPreventDefault = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachControl" }, noPreventDefault
                }
            );
        }

        public void detachControl()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "detachControl" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}