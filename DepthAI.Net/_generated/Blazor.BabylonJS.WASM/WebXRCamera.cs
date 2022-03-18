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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebXRCamera>))]
    public class WebXRCamera : FreeCamera
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public int trackingState
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "trackingState"
                );
            }
        }

        
        public decimal realWorldHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "realWorldHeight"
                );
            }
        }
        #endregion

        #region Properties
        private Observable<Vector3> __onBeforeCameraTeleport;
        public Observable<Vector3> onBeforeCameraTeleport
        {
            get
            {
            if(__onBeforeCameraTeleport == null)
            {
                __onBeforeCameraTeleport = EventHorizonBlazorInterop.GetClass<Observable<Vector3>>(
                    this.___guid,
                    "onBeforeCameraTeleport",
                    (entity) =>
                    {
                        return new Observable<Vector3>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onBeforeCameraTeleport;
            }
            set
            {
__onBeforeCameraTeleport = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onBeforeCameraTeleport",
                    value
                );
            }
        }

        private Observable<Vector3> __onAfterCameraTeleport;
        public Observable<Vector3> onAfterCameraTeleport
        {
            get
            {
            if(__onAfterCameraTeleport == null)
            {
                __onAfterCameraTeleport = EventHorizonBlazorInterop.GetClass<Observable<Vector3>>(
                    this.___guid,
                    "onAfterCameraTeleport",
                    (entity) =>
                    {
                        return new Observable<Vector3>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onAfterCameraTeleport;
            }
            set
            {
__onAfterCameraTeleport = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onAfterCameraTeleport",
                    value
                );
            }
        }

        
        public IObservable<int> onTrackingStateChanged
        {
            get
            {
            return EventHorizonBlazorInterop.Get<IObservable<int>>(
                    this.___guid,
                    "onTrackingStateChanged"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onTrackingStateChanged",
                    value
                );
            }
        }

        
        public bool compensateOnFirstFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "compensateOnFirstFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "compensateOnFirstFrame",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebXRCamera() : base() { }

        public WebXRCamera(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebXRCamera(
            string name, Scene scene, WebXRSessionManager _xrSessionManager
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "WebXRCamera" },
                name, scene, _xrSessionManager
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void setTransformationFromNonVRCamera(Camera otherCamera = null, System.Nullable<bool> resetToBaseReferenceSpace = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setTransformationFromNonVRCamera" }, otherCamera, resetToBaseReferenceSpace
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