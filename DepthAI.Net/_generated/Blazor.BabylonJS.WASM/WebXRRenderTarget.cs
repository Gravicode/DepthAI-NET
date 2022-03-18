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

    public interface WebXRRenderTarget : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<WebXRRenderTargetCachedEntity>))]
    public class WebXRRenderTargetCachedEntity : CachedEntityObject, WebXRRenderTarget
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
        private WebGLRenderingContextCachedEntity __canvasContext;
        public WebGLRenderingContextCachedEntity canvasContext
        {
            get
            {
            if(__canvasContext == null)
            {
                __canvasContext = EventHorizonBlazorInterop.GetClass<WebGLRenderingContextCachedEntity>(
                    this.___guid,
                    "canvasContext",
                    (entity) =>
                    {
                        return new WebGLRenderingContextCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvasContext;
            }
            set
            {
__canvasContext = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canvasContext",
                    value
                );
            }
        }

        private XRWebGLLayer __xrLayer;
        public XRWebGLLayer xrLayer
        {
            get
            {
            if(__xrLayer == null)
            {
                __xrLayer = EventHorizonBlazorInterop.GetClass<XRWebGLLayer>(
                    this.___guid,
                    "xrLayer",
                    (entity) =>
                    {
                        return new XRWebGLLayer() { ___guid = entity.___guid };
                    }
                );
            }
            return __xrLayer;
            }
            set
            {
__xrLayer = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xrLayer",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebXRRenderTargetCachedEntity() : base() { }

        public WebXRRenderTargetCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public ValueTask<XRWebGLLayer> initializeXRLayerAsync(XRSession xrSession)
        {
            return EventHorizonBlazorInterop.TaskClass<XRWebGLLayer>(
                entity => new XRWebGLLayer() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "initializeXRLayerAsync" }, xrSession
                }
            );
        }
        #endregion
    }
}