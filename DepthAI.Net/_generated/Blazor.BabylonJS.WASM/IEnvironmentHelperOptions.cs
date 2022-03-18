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

    public interface IEnvironmentHelperOptions : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IEnvironmentHelperOptionsCachedEntity>))]
    public class IEnvironmentHelperOptionsCachedEntity : CachedEntityObject, IEnvironmentHelperOptions
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
        
        public bool createGround
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "createGround"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "createGround",
                    value
                );
            }
        }

        
        public decimal groundSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groundSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundSize",
                    value
                );
            }
        }

        
        public string groundTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "groundTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundTexture",
                    value
                );
            }
        }

        private Color3 __groundColor;
        public Color3 groundColor
        {
            get
            {
            if(__groundColor == null)
            {
                __groundColor = EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "groundColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __groundColor;
            }
            set
            {
__groundColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundColor",
                    value
                );
            }
        }

        
        public decimal groundOpacity
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groundOpacity"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundOpacity",
                    value
                );
            }
        }

        
        public bool enableGroundShadow
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableGroundShadow"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableGroundShadow",
                    value
                );
            }
        }

        
        public decimal groundShadowLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groundShadowLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundShadowLevel",
                    value
                );
            }
        }

        
        public bool enableGroundMirror
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableGroundMirror"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableGroundMirror",
                    value
                );
            }
        }

        
        public decimal groundMirrorSizeRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groundMirrorSizeRatio"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundMirrorSizeRatio",
                    value
                );
            }
        }

        
        public decimal groundMirrorBlurKernel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groundMirrorBlurKernel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundMirrorBlurKernel",
                    value
                );
            }
        }

        
        public decimal groundMirrorAmount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groundMirrorAmount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundMirrorAmount",
                    value
                );
            }
        }

        
        public decimal groundMirrorFresnelWeight
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groundMirrorFresnelWeight"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundMirrorFresnelWeight",
                    value
                );
            }
        }

        
        public decimal groundMirrorFallOffDistance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groundMirrorFallOffDistance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundMirrorFallOffDistance",
                    value
                );
            }
        }

        
        public decimal groundMirrorTextureType
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groundMirrorTextureType"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundMirrorTextureType",
                    value
                );
            }
        }

        
        public decimal groundYBias
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "groundYBias"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "groundYBias",
                    value
                );
            }
        }

        
        public bool createSkybox
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "createSkybox"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "createSkybox",
                    value
                );
            }
        }

        
        public decimal skyboxSize
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "skyboxSize"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skyboxSize",
                    value
                );
            }
        }

        
        public string skyboxTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "skyboxTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skyboxTexture",
                    value
                );
            }
        }

        private Color3 __skyboxColor;
        public Color3 skyboxColor
        {
            get
            {
            if(__skyboxColor == null)
            {
                __skyboxColor = EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "skyboxColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __skyboxColor;
            }
            set
            {
__skyboxColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skyboxColor",
                    value
                );
            }
        }

        
        public decimal backgroundYRotation
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "backgroundYRotation"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "backgroundYRotation",
                    value
                );
            }
        }

        
        public bool sizeAuto
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "sizeAuto"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sizeAuto",
                    value
                );
            }
        }

        private Vector3 __rootPosition;
        public Vector3 rootPosition
        {
            get
            {
            if(__rootPosition == null)
            {
                __rootPosition = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "rootPosition",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __rootPosition;
            }
            set
            {
__rootPosition = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rootPosition",
                    value
                );
            }
        }

        
        public bool setupImageProcessing
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "setupImageProcessing"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "setupImageProcessing",
                    value
                );
            }
        }

        
        public string environmentTexture
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "environmentTexture"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "environmentTexture",
                    value
                );
            }
        }

        
        public decimal cameraExposure
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraExposure"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraExposure",
                    value
                );
            }
        }

        
        public decimal cameraContrast
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "cameraContrast"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraContrast",
                    value
                );
            }
        }

        
        public bool toneMappingEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "toneMappingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "toneMappingEnabled",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IEnvironmentHelperOptionsCachedEntity() : base() { }

        public IEnvironmentHelperOptionsCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods

        #endregion
    }
}