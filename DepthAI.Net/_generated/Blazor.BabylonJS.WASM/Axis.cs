/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<Axis>))]
    public class Axis : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        private static Vector3 __X;
        public static Vector3 X
        {
            get
            {
            if(__X == null)
            {
                __X = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Axis.X",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __X;
            }
            set
            {
__X = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Axis.X",
                    value
                );
            }
        }

        private static Vector3 __Y;
        public static Vector3 Y
        {
            get
            {
            if(__Y == null)
            {
                __Y = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Axis.Y",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __Y;
            }
            set
            {
__Y = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Axis.Y",
                    value
                );
            }
        }

        private static Vector3 __Z;
        public static Vector3 Z
        {
            get
            {
            if(__Z == null)
            {
                __Z = EventHorizonBlazorInterop.GetClass<Vector3>(
                    "BABYLON",
                    "Axis.Z",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __Z;
            }
            set
            {
__Z = null;
                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Axis.Z",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public Axis() : base() { }

        public Axis(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}