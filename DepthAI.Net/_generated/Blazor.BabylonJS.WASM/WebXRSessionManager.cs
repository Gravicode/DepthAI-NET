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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebXRSessionManager>))]
    public class WebXRSessionManager : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static ValueTask<bool> IsSessionSupportedAsync(string  sessionMode)
        {
            return EventHorizonBlazorInterop.Task<bool>(
                new object[]
                {
                    new string[] { "BABYLON", "WebXRSessionManager", "IsSessionSupportedAsync" }, sessionMode
                }
            );
        }
        #endregion

        #region Accessors
        private XRReferenceSpaceCachedEntity __referenceSpace;
        public XRReferenceSpaceCachedEntity referenceSpace
        {
            get
            {
            if(__referenceSpace == null)
            {
                __referenceSpace = EventHorizonBlazorInterop.GetClass<XRReferenceSpaceCachedEntity>(
                    this.___guid,
                    "referenceSpace",
                    (entity) =>
                    {
                        return new XRReferenceSpaceCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __referenceSpace;
            }
            set
            {
__referenceSpace = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "referenceSpace",
                    value
                );
            }
        }
        #endregion

        #region Properties
        private Scene __scene;
        public Scene scene
        {
            get
            {
            if(__scene == null)
            {
                __scene = EventHorizonBlazorInterop.GetClass<Scene>(
                    this.___guid,
                    "scene",
                    (entity) =>
                    {
                        return new Scene() { ___guid = entity.___guid };
                    }
                );
            }
            return __scene;
            }
            set
            {
__scene = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "scene",
                    value
                );
            }
        }

        private XRReferenceSpaceCachedEntity __baseReferenceSpace;
        public XRReferenceSpaceCachedEntity baseReferenceSpace
        {
            get
            {
            if(__baseReferenceSpace == null)
            {
                __baseReferenceSpace = EventHorizonBlazorInterop.GetClass<XRReferenceSpaceCachedEntity>(
                    this.___guid,
                    "baseReferenceSpace",
                    (entity) =>
                    {
                        return new XRReferenceSpaceCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __baseReferenceSpace;
            }
            set
            {
__baseReferenceSpace = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "baseReferenceSpace",
                    value
                );
            }
        }

        private XRFrameCachedEntity __currentFrame;
        public XRFrameCachedEntity currentFrame
        {
            get
            {
            if(__currentFrame == null)
            {
                __currentFrame = EventHorizonBlazorInterop.GetClass<XRFrameCachedEntity>(
                    this.___guid,
                    "currentFrame",
                    (entity) =>
                    {
                        return new XRFrameCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __currentFrame;
            }
            set
            {
__currentFrame = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentFrame",
                    value
                );
            }
        }

        
        public decimal currentTimestamp
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "currentTimestamp"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "currentTimestamp",
                    value
                );
            }
        }

        
        public decimal defaultHeightCompensation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "defaultHeightCompensation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "defaultHeightCompensation",
                    value
                );
            }
        }

        private Observable<XRFrameCachedEntity> __onXRFrameObservable;
        public Observable<XRFrameCachedEntity> onXRFrameObservable
        {
            get
            {
            if(__onXRFrameObservable == null)
            {
                __onXRFrameObservable = EventHorizonBlazorInterop.GetClass<Observable<XRFrameCachedEntity>>(
                    this.___guid,
                    "onXRFrameObservable",
                    (entity) =>
                    {
                        return new Observable<XRFrameCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onXRFrameObservable;
            }
            set
            {
__onXRFrameObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onXRFrameObservable",
                    value
                );
            }
        }

        private Observable<XRReferenceSpaceCachedEntity> __onXRReferenceSpaceChanged;
        public Observable<XRReferenceSpaceCachedEntity> onXRReferenceSpaceChanged
        {
            get
            {
            if(__onXRReferenceSpaceChanged == null)
            {
                __onXRReferenceSpaceChanged = EventHorizonBlazorInterop.GetClass<Observable<XRReferenceSpaceCachedEntity>>(
                    this.___guid,
                    "onXRReferenceSpaceChanged",
                    (entity) =>
                    {
                        return new Observable<XRReferenceSpaceCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onXRReferenceSpaceChanged;
            }
            set
            {
__onXRReferenceSpaceChanged = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onXRReferenceSpaceChanged",
                    value
                );
            }
        }

        private Observable<CachedEntity> __onXRSessionEnded;
        public Observable<CachedEntity> onXRSessionEnded
        {
            get
            {
            if(__onXRSessionEnded == null)
            {
                __onXRSessionEnded = EventHorizonBlazorInterop.GetClass<Observable<CachedEntity>>(
                    this.___guid,
                    "onXRSessionEnded",
                    (entity) =>
                    {
                        return new Observable<CachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onXRSessionEnded;
            }
            set
            {
__onXRSessionEnded = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onXRSessionEnded",
                    value
                );
            }
        }

        private Observable<XRSessionCachedEntity> __onXRSessionInit;
        public Observable<XRSessionCachedEntity> onXRSessionInit
        {
            get
            {
            if(__onXRSessionInit == null)
            {
                __onXRSessionInit = EventHorizonBlazorInterop.GetClass<Observable<XRSessionCachedEntity>>(
                    this.___guid,
                    "onXRSessionInit",
                    (entity) =>
                    {
                        return new Observable<XRSessionCachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onXRSessionInit;
            }
            set
            {
__onXRSessionInit = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onXRSessionInit",
                    value
                );
            }
        }

        private XRSessionCachedEntity __session;
        public XRSessionCachedEntity session
        {
            get
            {
            if(__session == null)
            {
                __session = EventHorizonBlazorInterop.GetClass<XRSessionCachedEntity>(
                    this.___guid,
                    "session",
                    (entity) =>
                    {
                        return new XRSessionCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __session;
            }
            set
            {
__session = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "session",
                    value
                );
            }
        }

        private XRReferenceSpaceCachedEntity __viewerReferenceSpace;
        public XRReferenceSpaceCachedEntity viewerReferenceSpace
        {
            get
            {
            if(__viewerReferenceSpace == null)
            {
                __viewerReferenceSpace = EventHorizonBlazorInterop.GetClass<XRReferenceSpaceCachedEntity>(
                    this.___guid,
                    "viewerReferenceSpace",
                    (entity) =>
                    {
                        return new XRReferenceSpaceCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __viewerReferenceSpace;
            }
            set
            {
__viewerReferenceSpace = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "viewerReferenceSpace",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebXRSessionManager() : base() { }

        public WebXRSessionManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebXRSessionManager(
            Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "WebXRSessionManager" },
                scene
            );
            ___guid = entity.___guid;
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

        public async ValueTask exitXRAsync()
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "exitXRAsync" }
                }
            );
        }

        public RenderTargetTexture getRenderTargetTextureForEye(object eye)
        {
            return EventHorizonBlazorInterop.FuncClass<RenderTargetTexture>(
                entity => new RenderTargetTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getRenderTargetTextureForEye" }, eye
                }
            );
        }

        public WebXRRenderTargetCachedEntity getWebXRRenderTarget(WebXRManagedOutputCanvasOptions options = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebXRRenderTargetCachedEntity>(
                entity => new WebXRRenderTargetCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getWebXRRenderTarget" }, options
                }
            );
        }

        public async ValueTask initializeAsync()
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "initializeAsync" }
                }
            );
        }

        public ValueTask<XRSessionCachedEntity> initializeSessionAsync(string xrSessionMode = null, XRSessionInit xrSessionInit = null)
        {
            return EventHorizonBlazorInterop.TaskClass<XRSessionCachedEntity>(
                entity => new XRSessionCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "initializeSessionAsync" }, xrSessionMode, xrSessionInit
                }
            );
        }

        public ValueTask<bool> isSessionSupportedAsync(string sessionMode)
        {
            return EventHorizonBlazorInterop.Task<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isSessionSupportedAsync" }, sessionMode
                }
            );
        }

        public void resetReferenceSpace()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "resetReferenceSpace" }
                }
            );
        }

        public void runXRRenderLoop()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "runXRRenderLoop" }
                }
            );
        }

        public ValueTask<XRReferenceSpaceCachedEntity> setReferenceSpaceTypeAsync(string referenceSpaceType = null)
        {
            return EventHorizonBlazorInterop.TaskClass<XRReferenceSpaceCachedEntity>(
                entity => new XRReferenceSpaceCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "setReferenceSpaceTypeAsync" }, referenceSpaceType
                }
            );
        }

        public async ValueTask updateRenderStateAsync(XRRenderState state)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateRenderStateAsync" }, state
                }
            );
        }
        #endregion
    }
}