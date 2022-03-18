/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRSessionInit : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRSessionInitCachedEntity>))]
public class XRSessionInitCachedEntity : CachedEntityObject, XRSessionInit
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
        
        public string[] optionalFeatures
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "optionalFeatures"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "optionalFeatures",
                    value
                );
            }
        }

        
        public string[] requiredFeatures
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "requiredFeatures"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "requiredFeatures",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRSessionInitCachedEntity() : base() { }

        public XRSessionInitCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
