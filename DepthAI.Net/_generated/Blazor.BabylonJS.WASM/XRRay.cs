/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<XRRay>))]
public class XRRay : CachedEntityObject
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
        private DOMPointReadOnly __origin;
        public DOMPointReadOnly origin
        {
            get
            {
            if(__origin == null)
            {
                __origin = EventHorizonBlazorInterop.GetClass<DOMPointReadOnly>(
                    this.___guid,
                    "origin",
                    (entity) =>
                    {
                        return new DOMPointReadOnly() { ___guid = entity.___guid };
                    }
                );
            }
            return __origin;
            }
            set
            {
__origin = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "origin",
                    value
                );
            }
        }

        private DOMPointReadOnly __direction;
        public DOMPointReadOnly direction
        {
            get
            {
            if(__direction == null)
            {
                __direction = EventHorizonBlazorInterop.GetClass<DOMPointReadOnly>(
                    this.___guid,
                    "direction",
                    (entity) =>
                    {
                        return new DOMPointReadOnly() { ___guid = entity.___guid };
                    }
                );
            }
            return __direction;
            }
            set
            {
__direction = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "direction",
                    value
                );
            }
        }

        
        public decimal[] matrix
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<decimal>(
                    this.___guid,
                    "matrix"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "matrix",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRRay() : base() { }

        public XRRay(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public XRRay(
            XRRigidTransform transformOrOrigin, DOMPointInit direction = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "XRRay" },
                transformOrOrigin, direction
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
