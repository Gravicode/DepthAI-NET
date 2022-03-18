/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRHitTestOptionsInit : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRHitTestOptionsInitCachedEntity>))]
public class XRHitTestOptionsInitCachedEntity : CachedEntityObject, XRHitTestOptionsInit
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
        private XRSpaceCachedEntity __space;
        public XRSpaceCachedEntity space
        {
            get
            {
            if(__space == null)
            {
                __space = EventHorizonBlazorInterop.GetClass<XRSpaceCachedEntity>(
                    this.___guid,
                    "space",
                    (entity) =>
                    {
                        return new XRSpaceCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __space;
            }
            set
            {
__space = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "space",
                    value
                );
            }
        }

        
        public int[] entityTypes
        {
            get
            {
            return EventHorizonBlazorInterop.Get<int[]>(
                    this.___guid,
                    "entityTypes"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "entityTypes",
                    value
                );
            }
        }

        private XRRay __offsetRay;
        public XRRay offsetRay
        {
            get
            {
            if(__offsetRay == null)
            {
                __offsetRay = EventHorizonBlazorInterop.GetClass<XRRay>(
                    this.___guid,
                    "offsetRay",
                    (entity) =>
                    {
                        return new XRRay() { ___guid = entity.___guid };
                    }
                );
            }
            return __offsetRay;
            }
            set
            {
__offsetRay = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "offsetRay",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRHitTestOptionsInitCachedEntity() : base() { }

        public XRHitTestOptionsInitCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
