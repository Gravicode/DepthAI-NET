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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebXRManagedOutputCanvasOptions>))]
    public class WebXRManagedOutputCanvasOptions : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static WebXRManagedOutputCanvasOptions GetDefaults(ThinEngine engine = null)
        {
            return EventHorizonBlazorInterop.FuncClass<WebXRManagedOutputCanvasOptions>(
                entity => new WebXRManagedOutputCanvasOptions() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "WebXRManagedOutputCanvasOptions", "GetDefaults" }, engine
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties
        private HTMLCanvasElementCachedEntity __canvasElement;
        public HTMLCanvasElementCachedEntity canvasElement
        {
            get
            {
            if(__canvasElement == null)
            {
                __canvasElement = EventHorizonBlazorInterop.GetClass<HTMLCanvasElementCachedEntity>(
                    this.___guid,
                    "canvasElement",
                    (entity) =>
                    {
                        return new HTMLCanvasElementCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvasElement;
            }
            set
            {
__canvasElement = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canvasElement",
                    value
                );
            }
        }

        private XRWebGLLayerInitCachedEntity __canvasOptions;
        public XRWebGLLayerInitCachedEntity canvasOptions
        {
            get
            {
            if(__canvasOptions == null)
            {
                __canvasOptions = EventHorizonBlazorInterop.GetClass<XRWebGLLayerInitCachedEntity>(
                    this.___guid,
                    "canvasOptions",
                    (entity) =>
                    {
                        return new XRWebGLLayerInitCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __canvasOptions;
            }
            set
            {
__canvasOptions = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "canvasOptions",
                    value
                );
            }
        }

        
        public string newCanvasCssStyle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "newCanvasCssStyle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "newCanvasCssStyle",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public WebXRManagedOutputCanvasOptions() : base() { }

        public WebXRManagedOutputCanvasOptions(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}