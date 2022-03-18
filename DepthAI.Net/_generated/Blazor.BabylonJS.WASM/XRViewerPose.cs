/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRViewerPose : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRViewerPoseCachedEntity>))]
public class XRViewerPoseCachedEntity : CachedEntityObject, XRViewerPose
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
        
        public XRViewCachedEntity[] views
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<XRViewCachedEntity>(
                    this.___guid,
                    "views",
                    (entity) =>
                    {
                        return new XRViewCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRViewerPoseCachedEntity() : base() { }

        public XRViewerPoseCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
