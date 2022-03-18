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

    
    
    [JsonConverter(typeof(CachedEntityConverter<WebXRFeaturesManager>))]
    public class WebXRFeaturesManager : CachedEntityObject, _IDisposable
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static void AddWebXRFeature(string featureName, ActionResultCallback<WebXRSessionManager, CachedEntity, ActionResultCallback<IWebXRFeature>> constructorFunction, System.Nullable<decimal> version = null, System.Nullable<bool> stable = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { "BABYLON", "WebXRFeaturesManager", "AddWebXRFeature" }, featureName, constructorFunction, version, stable
                }
            );
        }

        #region ConstructFeature TODO: Get Comments as metadata identification
        private static bool IsConstructFeatureEnabled = false;
        private static readonly IDictionary<string, Func<Task>> ConstructFeatureActionMap = new Dictionary<string, Func<Task>>();

        public static string ConstructFeature(
            Func<Task> callback
        )
        {
            SetupConstructFeatureStaticLoop();

            var handle = Guid.NewGuid().ToString();
            ConstructFeatureActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public static bool ConstructFeature_Remove(
            string handle
        )
        {
            return ConstructFeatureActionMap.Remove(
                handle
            );
        }

        private static void SetupConstructFeatureStaticLoop()
        {
            if (IsConstructFeatureEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.AssemblyFuncCallback(
                "Blazor.BabylonJS.WASM",
                "BABYLON.WebXRFeaturesManager.ConstructFeature",
                "CallConstructFeatureStaticActions"
            );
            IsConstructFeatureEnabled = true;
        }

        [JSInvokable]
        public static async Task CallConstructFeatureStaticActions()
        {
            foreach (var action in ConstructFeatureActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public static string[] GetAvailableFeatures()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { "BABYLON", "WebXRFeaturesManager", "GetAvailableFeatures" }
                }
            );
        }

        public static string[] GetAvailableVersions(string featureName)
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { "BABYLON", "WebXRFeaturesManager", "GetAvailableVersions" }, featureName
                }
            );
        }

        public static decimal GetLatestVersionOfFeature(string featureName)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "WebXRFeaturesManager", "GetLatestVersionOfFeature" }, featureName
                }
            );
        }

        public static decimal GetStableVersionOfFeature(string featureName)
        {
            return EventHorizonBlazorInterop.Func<decimal>(
                new object[]
                {
                    new string[] { "BABYLON", "WebXRFeaturesManager", "GetStableVersionOfFeature" }, featureName
                }
            );
        }
        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public WebXRFeaturesManager() : base() { }

        public WebXRFeaturesManager(
            ICachedEntity entity
        ) : base(entity)
        {
        }

        public WebXRFeaturesManager(
            WebXRSessionManager _xrSessionManager
        ) : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "WebXRFeaturesManager" },
                _xrSessionManager
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void attachFeature(string featureName)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "attachFeature" }, featureName
                }
            );
        }

        public void detachFeature(string featureName)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "detachFeature" }, featureName
                }
            );
        }

        public bool disableFeature(string featureName)
        {
            return EventHorizonBlazorInterop.Func<bool>(
                new object[]
                {
                    new string[] { this.___guid, "disableFeature" }, featureName
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

        public IWebXRFeatureCachedEntity enableFeature(string featureName, System.Nullable<decimal> version = null, object moduleOptions = null, System.Nullable<bool> attachIfPossible = null, System.Nullable<bool> required = null)
        {
            return EventHorizonBlazorInterop.FuncClass<IWebXRFeatureCachedEntity>(
                entity => new IWebXRFeatureCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "enableFeature" }, featureName, version, moduleOptions, attachIfPossible, required
                }
            );
        }

        public IWebXRFeatureCachedEntity getEnabledFeature(string featureName)
        {
            return EventHorizonBlazorInterop.FuncClass<IWebXRFeatureCachedEntity>(
                entity => new IWebXRFeatureCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getEnabledFeature" }, featureName
                }
            );
        }

        public string[] getEnabledFeatures()
        {
            return EventHorizonBlazorInterop.FuncArray<string>(
                new object[]
                {
                    new string[] { this.___guid, "getEnabledFeatures" }
                }
            );
        }

        public XRSessionInitCachedEntity extendXRSessionInitObject(XRSessionInit xrSessionInit)
        {
            return EventHorizonBlazorInterop.FuncClass<XRSessionInitCachedEntity>(
                entity => new XRSessionInitCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "extendXRSessionInitObject" }, xrSessionInit
                }
            );
        }
        #endregion
    }
}