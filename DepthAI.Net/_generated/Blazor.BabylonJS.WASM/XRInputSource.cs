/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BABYLON;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRInputSource : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRInputSourceCachedEntity>))]
public class XRInputSourceCachedEntity : CachedEntityObject, XRInputSource
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
        
        public object handedness
        {
            get
            {
            return EventHorizonBlazorInterop.Get<object>(
                    this.___guid,
                    "handedness"
                );
            }
        }

        
        public object targetRayMode
        {
            get
            {
            return EventHorizonBlazorInterop.Get<object>(
                    this.___guid,
                    "targetRayMode"
                );
            }
        }

        private XRSpaceCachedEntity __targetRaySpace;
        public XRSpaceCachedEntity targetRaySpace
        {
            get
            {
            if(__targetRaySpace == null)
            {
                __targetRaySpace = EventHorizonBlazorInterop.GetClass<XRSpaceCachedEntity>(
                    this.___guid,
                    "targetRaySpace",
                    (entity) =>
                    {
                        return new XRSpaceCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __targetRaySpace;
            }
        }

        private XRSpaceCachedEntity __gripSpace;
        public XRSpaceCachedEntity gripSpace
        {
            get
            {
            if(__gripSpace == null)
            {
                __gripSpace = EventHorizonBlazorInterop.GetClass<XRSpaceCachedEntity>(
                    this.___guid,
                    "gripSpace",
                    (entity) =>
                    {
                        return new XRSpaceCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __gripSpace;
            }
        }

        private Gamepad __gamepad;
        public Gamepad gamepad
        {
            get
            {
            if(__gamepad == null)
            {
                __gamepad = EventHorizonBlazorInterop.GetClass<Gamepad>(
                    this.___guid,
                    "gamepad",
                    (entity) =>
                    {
                        return new Gamepad() { ___guid = entity.___guid };
                    }
                );
            }
            return __gamepad;
            }
        }

        
        public string[] profiles
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "profiles"
                );
            }
        }

        private XRHandCachedEntity __hand;
        public XRHandCachedEntity hand
        {
            get
            {
            if(__hand == null)
            {
                __hand = EventHorizonBlazorInterop.GetClass<XRHandCachedEntity>(
                    this.___guid,
                    "hand",
                    (entity) =>
                    {
                        return new XRHandCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __hand;
            }
        }
    #endregion
    
    #region Constructor
        public XRInputSourceCachedEntity() : base() { }

        public XRInputSourceCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
