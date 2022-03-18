/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRTransientInputHitTestSource : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRTransientInputHitTestSourceCachedEntity>))]
public class XRTransientInputHitTestSourceCachedEntity : CachedEntityObject, XRTransientInputHitTestSource
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
        public XRTransientInputHitTestSourceCachedEntity() : base() { }

        public XRTransientInputHitTestSourceCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public void cancel()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "cancel" }
                }
            );
        }
    #endregion
}
