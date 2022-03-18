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

    
    
    [JsonConverter(typeof(CachedEntityConverter<MirrorTexture>))]
    public class MirrorTexture : RenderTargetTexture
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public decimal blurRatio
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurRatio"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurRatio",
                    value
                );
            }
        }

        
        public decimal blurKernelX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurKernelX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurKernelX",
                    value
                );
            }
        }

        
        public decimal blurKernelY
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "blurKernelY"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "blurKernelY",
                    value
                );
            }
        }
        #endregion

        #region Properties
        private Plane __mirrorPlane;
        public Plane mirrorPlane
        {
            get
            {
            if(__mirrorPlane == null)
            {
                __mirrorPlane = EventHorizonBlazorInterop.GetClass<Plane>(
                    this.___guid,
                    "mirrorPlane",
                    (entity) =>
                    {
                        return new Plane() { ___guid = entity.___guid };
                    }
                );
            }
            return __mirrorPlane;
            }
            set
            {
__mirrorPlane = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "mirrorPlane",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public MirrorTexture() : base() { }

        public MirrorTexture(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public MirrorTexture(
            string name, decimal size, Scene scene, System.Nullable<bool> generateMipMaps = null, System.Nullable<decimal> type = null, System.Nullable<decimal> samplingMode = null, System.Nullable<bool> generateDepthBuffer = null
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "MirrorTexture" },
                name, size, scene, generateMipMaps, type, samplingMode, generateDepthBuffer
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public MirrorTexture clone()
        {
            return EventHorizonBlazorInterop.FuncClass<MirrorTexture>(
                entity => new MirrorTexture() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "clone" }
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