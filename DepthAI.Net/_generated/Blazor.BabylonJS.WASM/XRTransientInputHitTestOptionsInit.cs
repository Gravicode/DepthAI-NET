/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRTransientInputHitTestOptionsInit : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRTransientInputHitTestOptionsInitCachedEntity>))]
public class XRTransientInputHitTestOptionsInitCachedEntity : CachedEntityObject, XRTransientInputHitTestOptionsInit
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
        
        public string profile
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "profile"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "profile",
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
        public XRTransientInputHitTestOptionsInitCachedEntity() : base() { }

        public XRTransientInputHitTestOptionsInitCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
