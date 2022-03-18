/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRView : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRViewCachedEntity>))]
public class XRViewCachedEntity : CachedEntityObject, XRView
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
        
        public object eye
        {
            get
            {
            return EventHorizonBlazorInterop.Get<object>(
                    this.___guid,
                    "eye"
                );
            }
        }

        
        public decimal[] projectionMatrix
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "projectionMatrix"
                );
            }
        }

        private XRRigidTransform __transform;
        public XRRigidTransform transform
        {
            get
            {
            if(__transform == null)
            {
                __transform = EventHorizonBlazorInterop.GetClass<XRRigidTransform>(
                    this.___guid,
                    "transform",
                    (entity) =>
                    {
                        return new XRRigidTransform() { ___guid = entity.___guid };
                    }
                );
            }
            return __transform;
            }
        }

        
        public decimal recommendedViewportScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "recommendedViewportScale"
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRViewCachedEntity() : base() { }

        public XRViewCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public void requestViewportScale(decimal scale)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "requestViewportScale" }, scale
                }
            );
        }
    #endregion
}
