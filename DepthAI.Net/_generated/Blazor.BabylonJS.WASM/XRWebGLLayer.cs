/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<XRWebGLLayer>))]
public class XRWebGLLayer : CachedEntityObject
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
        public static decimal getNativeFramebufferScaleFactor(XRSession session)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "XRWebGLLayer", "getNativeFramebufferScaleFactor" }, session
                }
            );
        }
    #endregion

    #region Accessors

    #endregion

    #region Properties
        
        public bool antialias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "antialias"
                );
            }
        }

        private WebGLFramebuffer __framebuffer;
        public WebGLFramebuffer framebuffer
        {
            get
            {
            if(__framebuffer == null)
            {
                __framebuffer = EventHorizonBlazorInterop.GetClass<WebGLFramebuffer>(
                    this.___guid,
                    "framebuffer",
                    (entity) =>
                    {
                        return new WebGLFramebuffer() { ___guid = entity.___guid };
                    }
                );
            }
            return __framebuffer;
            }
        }

        
        public decimal framebufferWidth
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "framebufferWidth"
                );
            }
        }

        
        public decimal framebufferHeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "framebufferHeight"
                );
            }
        }

        
        public bool ignoreDepthValues
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "ignoreDepthValues"
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRWebGLLayer() : base() { }

        public XRWebGLLayer(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public XRWebGLLayer(
            XRSession session, WebGLRenderingContext context, XRWebGLLayerInit layerInit = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "XRWebGLLayer" },
                session, context, layerInit
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods
        #region getViewport TODO: Get Comments as metadata identification
        private bool _isGetViewportEnabled = false;
        private readonly IDictionary<string, Func<Task>> _getViewportActionMap = new Dictionary<string, Func<Task>>();

        public string getViewport(
            Func<Task> callback
        )
        {
            SetupGetViewportLoop();

            var handle = Guid.NewGuid().ToString();
            _getViewportActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool getViewport_Remove(
            string handle
        )
        {
            return _getViewportActionMap.Remove(
                handle
            );
        }

        private void SetupGetViewportLoop()
        {
            if (_isGetViewportEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "getViewport",
                "CallGetViewportActions",
                _invokableReference
            );
            _isGetViewportEnabled = true;
        }

        [JSInvokable]
        public async Task CallGetViewportActions()
        {
            foreach (var action in _getViewportActionMap.Values)
            {
                await action();
            }
        }
        #endregion
    #endregion
}
