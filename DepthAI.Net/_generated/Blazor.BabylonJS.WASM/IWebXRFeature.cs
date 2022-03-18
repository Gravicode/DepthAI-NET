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

    public interface IWebXRFeature : ICachedEntity { }
    
    [JsonConverter(typeof(CachedEntityConverter<IWebXRFeatureCachedEntity>))]
    public class IWebXRFeatureCachedEntity : CachedEntityObject, IWebXRFeature
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
        
        public bool attached
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "attached"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "attached",
                    value
                );
            }
        }

        
        public bool disableAutoAttach
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "disableAutoAttach"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "disableAutoAttach",
                    value
                );
            }
        }

        
        public bool isDisposed
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isDisposed"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "isDisposed",
                    value
                );
            }
        }

        
        public string xrNativeFeatureName
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "xrNativeFeatureName"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "xrNativeFeatureName",
                    value
                );
            }
        }

        
        public string[] dependsOn
        {
            get
            {
            return EventHorizonBlazorInterop.GetArray<string>(
                    this.___guid,
                    "dependsOn"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "dependsOn",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public IWebXRFeatureCachedEntity() : base() { }

        public IWebXRFeatureCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public bool attach(System.Nullable<bool> force = null)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "attach" }, force
                }
            );
        }

        public bool detach()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "detach" }
                }
            );
        }

        public bool isCompatible()
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "isCompatible" }
                }
            );
        }
        #endregion
    }
}