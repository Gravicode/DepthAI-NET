/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRRenderState : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRRenderStateCachedEntity>))]
public class XRRenderStateCachedEntity : CachedEntityObject, XRRenderState
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
        private XRWebGLLayer __baseLayer;
        public XRWebGLLayer baseLayer
        {
            get
            {
            if(__baseLayer == null)
            {
                __baseLayer = EventHorizonBlazorInterop.GetClass<XRWebGLLayer>(
                    this.___guid,
                    "baseLayer",
                    (entity) =>
                    {
                        return new XRWebGLLayer() { ___guid = entity.___guid };
                    }
                );
            }
            return __baseLayer;
            }
        }

        
        public decimal depthFar
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depthFar"
                );
            }
        }

        
        public decimal depthNear
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "depthNear"
                );
            }
        }

        
        public decimal inlineVerticalFieldOfView
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "inlineVerticalFieldOfView"
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRRenderStateCachedEntity() : base() { }

        public XRRenderStateCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
