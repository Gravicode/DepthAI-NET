/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRAnchor : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRAnchorCachedEntity>))]
public class XRAnchorCachedEntity : CachedEntityObject, XRAnchor
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
        private XRSpaceCachedEntity __anchorSpace;
        public XRSpaceCachedEntity anchorSpace
        {
            get
            {
            if(__anchorSpace == null)
            {
                __anchorSpace = EventHorizonBlazorInterop.GetClass<XRSpaceCachedEntity>(
                    this.___guid,
                    "anchorSpace",
                    (entity) =>
                    {
                        return new XRSpaceCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __anchorSpace;
            }
            set
            {
__anchorSpace = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "anchorSpace",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRAnchorCachedEntity() : base() { }

        public XRAnchorCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public void delete()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "delete" }
                }
            );
        }
    #endregion
}
