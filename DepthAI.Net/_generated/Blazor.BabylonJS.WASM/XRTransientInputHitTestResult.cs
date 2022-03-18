/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRTransientInputHitTestResult : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRTransientInputHitTestResultCachedEntity>))]
public class XRTransientInputHitTestResultCachedEntity : CachedEntityObject, XRTransientInputHitTestResult
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
        private XRInputSourceCachedEntity __inputSource;
        public XRInputSourceCachedEntity inputSource
        {
            get
            {
            if(__inputSource == null)
            {
                __inputSource = EventHorizonBlazorInterop.GetClass<XRInputSourceCachedEntity>(
                    this.___guid,
                    "inputSource",
                    (entity) =>
                    {
                        return new XRInputSourceCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __inputSource;
            }
        }

        
        public XRHitTestResultCachedEntity[] results
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<XRHitTestResultCachedEntity>(
                    this.___guid,
                    "results",
                    (entity) =>
                    {
                        return new XRHitTestResultCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRTransientInputHitTestResultCachedEntity() : base() { }

        public XRTransientInputHitTestResultCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
