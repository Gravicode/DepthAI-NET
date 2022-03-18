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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebXRExperienceHelper>))]
    public class WebXRExperienceHelper : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static ValueTask<WebXRExperienceHelper> CreateAsync(Scene scene)
        {
            return EventHorizonBlazorInterop.TaskClass<WebXRExperienceHelper>(
                entity => new WebXRExperienceHelper() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "WebXRExperienceHelper", "CreateAsync" }, scene
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private WebXRCamera __camera;
        public WebXRCamera camera
        {
            get
            {
            if(__camera == null)
            {
                __camera = EventHorizonBlazorInterop.GetClass<WebXRCamera>(
                    this.___guid,
                    "camera",
                    (entity) =>
                    {
                        return new WebXRCamera() { ___guid = entity.___guid };
                    }
                );
            }
            return __camera;
            }
            set
            {
__camera = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "camera",
                    value
                );
            }
        }

        private WebXRFeaturesManager __featuresManager;
        public WebXRFeaturesManager featuresManager
        {
            get
            {
            if(__featuresManager == null)
            {
                __featuresManager = EventHorizonBlazorInterop.GetClass<WebXRFeaturesManager>(
                    this.___guid,
                    "featuresManager",
                    (entity) =>
                    {
                        return new WebXRFeaturesManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __featuresManager;
            }
            set
            {
__featuresManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "featuresManager",
                    value
                );
            }
        }

        private Observable<WebXRCamera> __onInitialXRPoseSetObservable;
        public Observable<WebXRCamera> onInitialXRPoseSetObservable
        {
            get
            {
            if(__onInitialXRPoseSetObservable == null)
            {
                __onInitialXRPoseSetObservable = EventHorizonBlazorInterop.GetClass<Observable<WebXRCamera>>(
                    this.___guid,
                    "onInitialXRPoseSetObservable",
                    (entity) =>
                    {
                        return new Observable<WebXRCamera>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onInitialXRPoseSetObservable;
            }
            set
            {
__onInitialXRPoseSetObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onInitialXRPoseSetObservable",
                    value
                );
            }
        }

        
        public IObservable<int> onStateChangedObservable
        {
            get
            {
            return EventHorizonBlazorInterop.Get<IObservable<int>>(
                    this.___guid,
                    "onStateChangedObservable"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onStateChangedObservable",
                    value
                );
            }
        }

        private WebXRSessionManager __sessionManager;
        public WebXRSessionManager sessionManager
        {
            get
            {
            if(__sessionManager == null)
            {
                __sessionManager = EventHorizonBlazorInterop.GetClass<WebXRSessionManager>(
                    this.___guid,
                    "sessionManager",
                    (entity) =>
                    {
                        return new WebXRSessionManager() { ___guid = entity.___guid };
                    }
                );
            }
            return __sessionManager;
            }
            set
            {
__sessionManager = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sessionManager",
                    value
                );
            }
        }

        
        public int state
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int>(
                    this.___guid,
                    "state"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "state",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebXRExperienceHelper() : base() { }

        public WebXRExperienceHelper(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public ValueTask<WebXRSessionManager> enterXRAsync(string sessionMode, string referenceSpaceType, WebXRRenderTarget renderTarget = null, XRSessionInit sessionCreationOptions = null)
        {
            return EventHorizonBlazorInterop.TaskClass<WebXRSessionManager>(
                entity => new WebXRSessionManager() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enterXRAsync" }, sessionMode, referenceSpaceType, renderTarget, sessionCreationOptions
                }
            );
        }

        public async ValueTask exitXRAsync()
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "exitXRAsync" }
                }
            );
        }
        #endregion
    }
}