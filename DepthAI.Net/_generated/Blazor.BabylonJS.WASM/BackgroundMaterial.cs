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

    
    
    [JsonConverter(typeof(CachedEntityConverter<BackgroundMaterial>))]
    public class BackgroundMaterial : PushMaterial
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal StandardReflectance0
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BackgroundMaterial.StandardReflectance0"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BackgroundMaterial.StandardReflectance0",
                    value
                );
            }
        }

        
        public static decimal StandardReflectance90
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "BackgroundMaterial.StandardReflectance90"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "BackgroundMaterial.StandardReflectance90",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static BackgroundMaterial Parse(object source, Scene scene, string rootUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<BackgroundMaterial>(
                entity => new BackgroundMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "BackgroundMaterial", "Parse" }, source, scene, rootUrl
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal primaryColorShadowLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "primaryColorShadowLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "primaryColorShadowLevel",
                    value
                );
            }
        }

        
        public decimal primaryColorHighlightLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "primaryColorHighlightLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "primaryColorHighlightLevel",
                    value
                );
            }
        }

        
        public decimal fovMultiplier
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "fovMultiplier"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "fovMultiplier",
                    value
                );
            }
        }

        private ImageProcessingConfiguration __imageProcessingConfiguration;
        public ImageProcessingConfiguration imageProcessingConfiguration
        {
            get
            {
            if(__imageProcessingConfiguration == null)
            {
                __imageProcessingConfiguration = EventHorizonBlazorInterop.GetClass<ImageProcessingConfiguration>(
                    this.___guid,
                    "imageProcessingConfiguration",
                    (entity) =>
                    {
                        return new ImageProcessingConfiguration() { ___guid = entity.___guid };
                    }
                );
            }
            return __imageProcessingConfiguration;
            }
            set
            {
__imageProcessingConfiguration = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "imageProcessingConfiguration",
                    value
                );
            }
        }

        
        public bool cameraColorCurvesEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cameraColorCurvesEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraColorCurvesEnabled",
                    value
                );
            }
        }

        
        public bool cameraColorGradingEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cameraColorGradingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraColorGradingEnabled",
                    value
                );
            }
        }

        
        public bool cameraToneMappingEnabled
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "cameraToneMappingEnabled"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraToneMappingEnabled",
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

        private BaseTexture __cameraColorGradingTexture;
        public BaseTexture cameraColorGradingTexture
        {
            get
            {
            if(__cameraColorGradingTexture == null)
            {
                __cameraColorGradingTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "cameraColorGradingTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameraColorGradingTexture;
            }
            set
            {
__cameraColorGradingTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraColorGradingTexture",
                    value
                );
            }
        }

        private ColorCurves __cameraColorCurves;
        public ColorCurves cameraColorCurves
        {
            get
            {
            if(__cameraColorCurves == null)
            {
                __cameraColorCurves = EventHorizonBlazorInterop.GetClass<ColorCurves>(
                    this.___guid,
                    "cameraColorCurves",
                    (entity) =>
                    {
                        return new ColorCurves() { ___guid = entity.___guid };
                    }
                );
            }
            return __cameraColorCurves;
            }
            set
            {
__cameraColorCurves = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "cameraColorCurves",
                    value
                );
            }
        }

        
        public bool hasRenderTargetTextures
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "hasRenderTargetTextures"
                );
            }
        }
        #endregion

        #region Properties
        private Color3 __primaryColor;
        public Color3 primaryColor
        {
            get
            {
            if(__primaryColor == null)
            {
                __primaryColor = EventHorizonBlazorInterop.GetClass<Color3>(
                    this.___guid,
                    "primaryColor",
                    (entity) =>
                    {
                        return new Color3() { ___guid = entity.___guid };
                    }
                );
            }
            return __primaryColor;
            }
            set
            {
__primaryColor = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "primaryColor",
                    value
                );
            }
        }

        private BaseTexture __reflectionTexture;
        public BaseTexture reflectionTexture
        {
            get
            {
            if(__reflectionTexture == null)
            {
                __reflectionTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "reflectionTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __reflectionTexture;
            }
            set
            {
__reflectionTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reflectionTexture",
                    value
                );
            }
        }

        
        public decimal reflectionBlur
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "reflectionBlur"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reflectionBlur",
                    value
                );
            }
        }

        private BaseTexture __diffuseTexture;
        public BaseTexture diffuseTexture
        {
            get
            {
            if(__diffuseTexture == null)
            {
                __diffuseTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "diffuseTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __diffuseTexture;
            }
            set
            {
__diffuseTexture = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "diffuseTexture",
                    value
                );
            }
        }

        
        public IShadowLightCachedEntity[] shadowLights
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<IShadowLightCachedEntity>(
                    this.___guid,
                    "shadowLights",
                    (entity) =>
                    {
                        return new IShadowLightCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowLights",
                    value
                );
            }
        }

        
        public decimal shadowLevel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "shadowLevel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowLevel",
                    value
                );
            }
        }

        private Vector3 __sceneCenter;
        public Vector3 sceneCenter
        {
            get
            {
            if(__sceneCenter == null)
            {
                __sceneCenter = EventHorizonBlazorInterop.GetClass<Vector3>(
                    this.___guid,
                    "sceneCenter",
                    (entity) =>
                    {
                        return new Vector3() { ___guid = entity.___guid };
                    }
                );
            }
            return __sceneCenter;
            }
            set
            {
__sceneCenter = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "sceneCenter",
                    value
                );
            }
        }

        
        public bool opacityFresnel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "opacityFresnel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "opacityFresnel",
                    value
                );
            }
        }

        
        public bool reflectionFresnel
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "reflectionFresnel"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reflectionFresnel",
                    value
                );
            }
        }

        
        public decimal reflectionFalloffDistance
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "reflectionFalloffDistance"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reflectionFalloffDistance",
                    value
                );
            }
        }

        
        public decimal reflectionAmount
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "reflectionAmount"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reflectionAmount",
                    value
                );
            }
        }

        
        public decimal reflectionReflectance0
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "reflectionReflectance0"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reflectionReflectance0",
                    value
                );
            }
        }

        
        public decimal reflectionReflectance90
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "reflectionReflectance90"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "reflectionReflectance90",
                    value
                );
            }
        }

        
        public bool useRGBColor
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useRGBColor"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useRGBColor",
                    value
                );
            }
        }

        
        public bool enableNoise
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "enableNoise"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "enableNoise",
                    value
                );
            }
        }

        
        public bool useEquirectangularFOV
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "useEquirectangularFOV"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "useEquirectangularFOV",
                    value
                );
            }
        }

        
        public decimal maxSimultaneousLights
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "maxSimultaneousLights"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "maxSimultaneousLights",
                    value
                );
            }
        }

        
        public bool shadowOnly
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "shadowOnly"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "shadowOnly",
                    value
                );
            }
        }

        
        public bool switchToBGR
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "switchToBGR"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "switchToBGR",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public BackgroundMaterial() : base() { }

        public BackgroundMaterial(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public BackgroundMaterial(
            string name, Scene scene
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "BackgroundMaterial" },
                name, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool needAlphaTesting()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "needAlphaTesting" }
                }
            );
        }

        public bool needAlphaBlending()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "needAlphaBlending" }
                }
            );
        }

        public bool isReadyForSubMesh(AbstractMesh mesh, SubMesh subMesh, System.Nullable<bool> useInstances = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isReadyForSubMesh" }, mesh, subMesh, useInstances
                }
            );
        }

        public void buildUniformLayout()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "buildUniformLayout" }
                }
            );
        }

        public void unbind()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "unbind" }
                }
            );
        }

        public void bindOnlyWorldMatrix(Matrix world)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindOnlyWorldMatrix" }, world
                }
            );
        }

        public void bindForSubMesh(Matrix world, Mesh mesh, SubMesh subMesh)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "bindForSubMesh" }, world, mesh, subMesh
                }
            );
        }

        public bool hasTexture(BaseTexture texture)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "hasTexture" }, texture
                }
            );
        }

        public void dispose(System.Nullable<bool> forceDisposeEffect = null, System.Nullable<bool> forceDisposeTextures = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "dispose" }, forceDisposeEffect, forceDisposeTextures
                }
            );
        }

        public BackgroundMaterial clone(string name)
        {
            return EventHorizonBlazorInterop.FuncClass<BackgroundMaterial>(
                entity => new BackgroundMaterial() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }, name
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInterop.Func<string>(
                new object[]
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }
        #endregion
    }
}