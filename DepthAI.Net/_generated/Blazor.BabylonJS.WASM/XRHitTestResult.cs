/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRHitTestResult : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRHitTestResultCachedEntity>))]
public class XRHitTestResultCachedEntity : CachedEntityObject, XRHitTestResult
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

    #endregion
    
    #region Constructor
        public XRHitTestResultCachedEntity() : base() { }

        public XRHitTestResultCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public XRPoseCachedEntity getPose(XRSpace baseSpace)
        {
            return EventHorizonBlazorInterop.FuncClass<XRPoseCachedEntity>(
                entity => new XRPoseCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPose" }, baseSpace
                }
            );
        }

        public ValueTask<XRAnchorCachedEntity> createAnchor(XRRigidTransform pose)
        {
            return EventHorizonBlazorInterop.TaskClass<XRAnchorCachedEntity>(
                entity => new XRAnchorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createAnchor" }, pose
                }
            );
        }
    #endregion
}
