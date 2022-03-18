/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;



[JsonConverter(typeof(CachedEntityConverter<XRRigidTransform>))]
public class XRRigidTransform : CachedEntityObject
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
        private DOMPointReadOnly __position;
        public DOMPointReadOnly position
        {
            get
            {
            if(__position == null)
            {
                __position = EventHorizonBlazorInterop.GetClass<DOMPointReadOnly>(
                    this.___guid,
                    "position",
                    (entity) =>
                    {
                        return new DOMPointReadOnly() { ___guid = entity.___guid };
                    }
                );
            }
            return __position;
            }
            set
            {
__position = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "position",
                    value
                );
            }
        }

        private DOMPointReadOnly __orientation;
        public DOMPointReadOnly orientation
        {
            get
            {
            if(__orientation == null)
            {
                __orientation = EventHorizonBlazorInterop.GetClass<DOMPointReadOnly>(
                    this.___guid,
                    "orientation",
                    (entity) =>
                    {
                        return new DOMPointReadOnly() { ___guid = entity.___guid };
                    }
                );
            }
            return __orientation;
            }
            set
            {
__orientation = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "orientation",
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

        private XRRigidTransform __inverse;
        public XRRigidTransform inverse
        {
            get
            {
            if(__inverse == null)
            {
                __inverse = EventHorizonBlazorInterop.GetClass<XRRigidTransform>(
                    this.___guid,
                    "inverse",
                    (entity) =>
                    {
                        return new XRRigidTransform() { ___guid = entity.___guid };
                    }
                );
            }
            return __inverse;
            }
            set
            {
__inverse = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "inverse",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRRigidTransform() : base() { }

        public XRRigidTransform(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public XRRigidTransform(
            DOMPointInit position = null, DOMPointInit direction = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "XRRigidTransform" },
                position, direction
            );
            ___guid = entity.___guid;
        }
    #endregion

    #region Methods

    #endregion
}
