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

    
    
    [JsonConverter(typeof(CachedEntityConverter<SpotLight>))]
    public class SpotLight : ShadowLight
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal angle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "angle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "angle",
                    value
                );
            }
        }

        
        public decimal innerAngle
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "innerAngle"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "innerAngle",
                    value
                );
            }
        }

        
        public decimal shadowAngleScale
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowAngleScale"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowAngleScale",
                    value
                );
            }
        }

        private Matrix __projectionTextureMatrix;
        public Matrix projectionTextureMatrix
        {
            get
            {
            if(__projectionTextureMatrix == null)
            {
                __projectionTextureMatrix = EventHorizonBlazorInterop.GetClass<Matrix>(
                    this.___guid,
                    "projectionTextureMatrix",
                    (entity) =>
                    {
                        return new Matrix() { ___guid = entity.___guid };
                    }
                );
            }
            return __projectionTextureMatrix;
            }
        }

        
        public decimal projectionTextureLightNear
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "projectionTextureLightNear"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projectionTextureLightNear",
                    value
                );
            }
        }

        
        public decimal projectionTextureLightFar
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "projectionTextureLightFar"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projectionTextureLightFar",
                    value
                );
            }
        }

        private Vector3 __projectionTextureUpDirection;
        public Vector3 projectionTextureUpDirection
        {
            get
            {
            if(__projectionTextureUpDirection == null)
            {
                __projectionTextureUpDirection = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "projectionTextureUpDirection",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __projectionTextureUpDirection;
            }
            set
            {
__projectionTextureUpDirection = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projectionTextureUpDirection",
                    value
                );
            }
        }

        private BaseTexture __projectionTexture;
        public BaseTexture projectionTexture
        {
            get
            {
            if(__projectionTexture == null)
            {
                __projectionTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "projectionTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __projectionTexture;
            }
            set
            {
__projectionTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "projectionTexture",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public decimal exponent
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "exponent"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "exponent",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public SpotLight() : base() { }

        public SpotLight(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public SpotLight(
            string name, Vector3 position, Vector3 direction, decimal angle, decimal exponent, Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "SpotLight" },
                name, position, direction, angle, exponent, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public decimal getTypeID()
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getTypeID" }
                }
            );
        }

        public Light transferTexturesToEffect(Effect effect, string lightIndex)
        {
            return EventHorizonBlazorInterop.FuncClass<Light>(
                entity => new Light() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferTexturesToEffect" }, effect, lightIndex
                }
            );
        }

        public SpotLight transferToEffect(Effect effect, string lightIndex)
        {
            return EventHorizonBlazorInterop.FuncClass<SpotLight>(
                entity => new SpotLight() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferToEffect" }, effect, lightIndex
                }
            );
        }

        public SpotLight transferToNodeMaterialEffect(Effect effect, string lightDataUniformName)
        {
            return EventHorizonBlazorInterop.FuncClass<SpotLight>(
                entity => new SpotLight() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "transferToNodeMaterialEffect" }, effect, lightDataUniformName
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        public void prepareLightSpecificDefines(object defines, decimal lightIndex)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "prepareLightSpecificDefines" }, defines, lightIndex
                }
            );
        }
        #endregion
    }
}