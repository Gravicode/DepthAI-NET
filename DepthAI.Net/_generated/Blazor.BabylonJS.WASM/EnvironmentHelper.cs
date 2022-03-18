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

    
    
    [JsonConverter(typeof(CachedEntityConverter<EnvironmentHelper>))]
    public class EnvironmentHelper : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        private Mesh __rootMesh;
        public Mesh rootMesh
        {
            get
            {
            if(__rootMesh == null)
            {
                __rootMesh = EventHorizonBlazorInterop.GetClass<Mesh>(
                    this.___guid,
                    "rootMesh",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __rootMesh;
            }
        }

        private Mesh __skybox;
        public Mesh skybox
        {
            get
            {
            if(__skybox == null)
            {
                __skybox = EventHorizonBlazorInterop.GetClass<Mesh>(
                    this.___guid,
                    "skybox",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __skybox;
            }
        }

        private BaseTexture __skyboxTexture;
        public BaseTexture skyboxTexture
        {
            get
            {
            if(__skyboxTexture == null)
            {
                __skyboxTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "skyboxTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __skyboxTexture;
            }
        }

        private BackgroundMaterial __skyboxMaterial;
        public BackgroundMaterial skyboxMaterial
        {
            get
            {
            if(__skyboxMaterial == null)
            {
                __skyboxMaterial = EventHorizonBlazorInterop.GetClass<BackgroundMaterial>(
                    this.___guid,
                    "skyboxMaterial",
                    (entity) =>
                    {
                        return new BackgroundMaterial() { ___guid = entity.___guid };
                    }
                );
            }
            return __skyboxMaterial;
            }
        }

        private Mesh __ground;
        public Mesh ground
        {
            get
            {
            if(__ground == null)
            {
                __ground = EventHorizonBlazorInterop.GetClass<Mesh>(
                    this.___guid,
                    "ground",
                    (entity) =>
                    {
                        return new Mesh() { ___guid = entity.___guid };
                    }
                );
            }
            return __ground;
            }
        }

        private BaseTexture __groundTexture;
        public BaseTexture groundTexture
        {
            get
            {
            if(__groundTexture == null)
            {
                __groundTexture = EventHorizonBlazorInterop.GetClass<BaseTexture>(
                    this.___guid,
                    "groundTexture",
                    (entity) =>
                    {
                        return new BaseTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __groundTexture;
            }
        }

        private MirrorTexture __groundMirror;
        public MirrorTexture groundMirror
        {
            get
            {
            if(__groundMirror == null)
            {
                __groundMirror = EventHorizonBlazorInterop.GetClass<MirrorTexture>(
                    this.___guid,
                    "groundMirror",
                    (entity) =>
                    {
                        return new MirrorTexture() { ___guid = entity.___guid };
                    }
                );
            }
            return __groundMirror;
            }
        }

        
        public AbstractMesh[] groundMirrorRenderList
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<AbstractMesh>(
                    this.___guid,
                    "groundMirrorRenderList",
                    (entity) =>
                    {
                        return new AbstractMesh() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private BackgroundMaterial __groundMaterial;
        public BackgroundMaterial groundMaterial
        {
            get
            {
            if(__groundMaterial == null)
            {
                __groundMaterial = EventHorizonBlazorInterop.GetClass<BackgroundMaterial>(
                    this.___guid,
                    "groundMaterial",
                    (entity) =>
                    {
                        return new BackgroundMaterial() { ___guid = entity.___guid };
                    }
                );
            }
            return __groundMaterial;
            }
        }
        #endregion

        #region Properties
        private Observable<CachedEntity> __onErrorObservable;
        public Observable<CachedEntity> onErrorObservable
        {
            get
            {
            if(__onErrorObservable == null)
            {
                __onErrorObservable = EventHorizonBlazorInterop.GetClass<Observable<CachedEntity>>(
                    this.___guid,
                    "onErrorObservable",
                    (entity) =>
                    {
                        return new Observable<CachedEntity>() { ___guid = entity.___guid };
                    }
                );
            }
            return __onErrorObservable;
            }
            set
            {
__onErrorObservable = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onErrorObservable",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public EnvironmentHelper() : base() { }

        public EnvironmentHelper(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public EnvironmentHelper(
            IEnvironmentHelperOptions options, Scene scene
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "EnvironmentHelper" },
                options, scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void updateOptions(IEnvironmentHelperOptions options)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateOptions" }, options
                }
            );
        }

        public void setMainColor(Color3 color)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "setMainColor" }, color
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
        #endregion
    }
}