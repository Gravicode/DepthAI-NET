/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRSession : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRSessionCachedEntity>))]
public class XRSessionCachedEntity : CachedEntityObject, XRSession
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
        
        public XRInputSourceCachedEntity[] inputSources
        {
            get
            {
            return EventHorizonBlazorInterop.GetArrayClass<XRInputSourceCachedEntity>(
                    this.___guid,
                    "inputSources",
                    (entity) =>
                    {
                        return new XRInputSourceCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
        }

        private XRRenderStateCachedEntity __renderState;
        public XRRenderStateCachedEntity renderState
        {
            get
            {
            if(__renderState == null)
            {
                __renderState = EventHorizonBlazorInterop.GetClass<XRRenderStateCachedEntity>(
                    this.___guid,
                    "renderState",
                    (entity) =>
                    {
                        return new XRRenderStateCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __renderState;
            }
        }

        
        public object visibilityState
        {
            get
            {
            return EventHorizonBlazorInterop.Get<object>(
                    this.___guid,
                    "visibilityState"
                );
            }
        }

        
        public ActionCallback<DOMHighResTimeStamp, XRFrameCachedEntity> requestAnimationFrame
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<DOMHighResTimeStamp, XRFrameCachedEntity>>(
                    this.___guid,
                    "requestAnimationFrame"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "requestAnimationFrame",
                    value
                );
            }
        }

        
        public ActionCallback<CachedEntity> onend
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<CachedEntity>>(
                    this.___guid,
                    "onend"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onend",
                    value
                );
            }
        }

        
        public ActionCallback<CachedEntity> oninputsourceschange
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<CachedEntity>>(
                    this.___guid,
                    "oninputsourceschange"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "oninputsourceschange",
                    value
                );
            }
        }

        
        public ActionCallback<CachedEntity> onselect
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<CachedEntity>>(
                    this.___guid,
                    "onselect"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onselect",
                    value
                );
            }
        }

        
        public ActionCallback<CachedEntity> onselectstart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<CachedEntity>>(
                    this.___guid,
                    "onselectstart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onselectstart",
                    value
                );
            }
        }

        
        public ActionCallback<CachedEntity> onselectend
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<CachedEntity>>(
                    this.___guid,
                    "onselectend"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onselectend",
                    value
                );
            }
        }

        
        public ActionCallback<CachedEntity> onsqueeze
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<CachedEntity>>(
                    this.___guid,
                    "onsqueeze"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onsqueeze",
                    value
                );
            }
        }

        
        public ActionCallback<CachedEntity> onsqueezestart
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<CachedEntity>>(
                    this.___guid,
                    "onsqueezestart"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onsqueezestart",
                    value
                );
            }
        }

        
        public ActionCallback<CachedEntity> onsqueezeend
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<CachedEntity>>(
                    this.___guid,
                    "onsqueezeend"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onsqueezeend",
                    value
                );
            }
        }

        
        public ActionCallback<CachedEntity> onvisibilitychange
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ActionCallback<CachedEntity>>(
                    this.___guid,
                    "onvisibilitychange"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "onvisibilitychange",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRSessionCachedEntity() : base() { }

        public XRSessionCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public void addEventListener(object type, ActionCallback<CachedEntity> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "addEventListener" }, type, listener, options
                }
            );
        }

        public void removeEventListener(object type, ActionCallback<CachedEntity> listener, System.Nullable<bool> options = null)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "removeEventListener" }, type, listener, options
                }
            );
        }

        #region cancelAnimationFrame TODO: Get Comments as metadata identification
        private bool _isCancelAnimationFrameEnabled = false;
        private readonly IDictionary<string, Func<Task>> _cancelAnimationFrameActionMap = new Dictionary<string, Func<Task>>();

        public string cancelAnimationFrame(
            Func<Task> callback
        )
        {
            SetupCancelAnimationFrameLoop();

            var handle = Guid.NewGuid().ToString();
            _cancelAnimationFrameActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool cancelAnimationFrame_Remove(
            string handle
        )
        {
            return _cancelAnimationFrameActionMap.Remove(
                handle
            );
        }

        private void SetupCancelAnimationFrameLoop()
        {
            if (_isCancelAnimationFrameEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "cancelAnimationFrame",
                "CallCancelAnimationFrameActions",
                _invokableReference
            );
            _isCancelAnimationFrameEnabled = true;
        }

        [JSInvokable]
        public async Task CallCancelAnimationFrameActions()
        {
            foreach (var action in _cancelAnimationFrameActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public async ValueTask end()
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "end" }
                }
            );
        }

        public ValueTask<XRReferenceSpaceCachedEntity> requestReferenceSpace(object type)
        {
            return EventHorizonBlazorInterop.TaskClass<XRReferenceSpaceCachedEntity>(
                entity => new XRReferenceSpaceCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "requestReferenceSpace" }, type
                }
            );
        }

        public async ValueTask updateRenderState(XRRenderState XRRenderStateInit)
        {
            await EventHorizonBlazorInterop.Task<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateRenderState" }, XRRenderStateInit
                }
            );
        }

        public ValueTask<XRHitTestSourceCachedEntity> requestHitTestSource(XRHitTestOptionsInit options)
        {
            return EventHorizonBlazorInterop.TaskClass<XRHitTestSourceCachedEntity>(
                entity => new XRHitTestSourceCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "requestHitTestSource" }, options
                }
            );
        }

        public ValueTask<XRTransientInputHitTestSourceCachedEntity> requestHitTestSourceForTransientInput(XRTransientInputHitTestOptionsInit options)
        {
            return EventHorizonBlazorInterop.TaskClass<XRTransientInputHitTestSourceCachedEntity>(
                entity => new XRTransientInputHitTestSourceCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "requestHitTestSourceForTransientInput" }, options
                }
            );
        }

        public ValueTask<XRHitResultCachedEntity[]> requestHitTest(XRRay ray, XRReferenceSpace referenceSpace)
        {
            return EventHorizonBlazorInterop.TaskArrayClass<XRHitResultCachedEntity>(
                entity => new XRHitResultCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "requestHitTest" }, ray, referenceSpace
                }
            );
        }

        public void updateWorldTrackingState(object options)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "updateWorldTrackingState" }, options
                }
            );
        }
    #endregion
}
