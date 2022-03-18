/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRPose : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRPoseCachedEntity>))]
public class XRPoseCachedEntity : CachedEntityObject, XRPose
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

        
        public bool emulatedPosition
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "emulatedPosition"
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRPoseCachedEntity() : base() { }

        public XRPoseCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
