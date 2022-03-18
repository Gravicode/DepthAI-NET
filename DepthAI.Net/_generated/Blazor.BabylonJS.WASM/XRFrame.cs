/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRFrame : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRFrameCachedEntity>))]
public class XRFrameCachedEntity : CachedEntityObject, XRFrame
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
        private XRSessionCachedEntity __session;
        public XRSessionCachedEntity session
        {
            get
            {
            if(__session == null)
            {
                __session = EventHorizonBlazorInterop.GetClass<XRSessionCachedEntity>(
                    this.___guid,
                    "session",
                    (entity) =>
                    {
                        return new XRSessionCachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            return __session;
            }
        }

        
        public ISet<XRAnchorCachedEntity> trackedAnchors
        {
            get
            {
            return EventHorizonBlazorInterop.Get<ISet<XRAnchorCachedEntity>>(
                    this.___guid,
                    "trackedAnchors"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "trackedAnchors",
                    value
                );
            }
        }

        
        public CachedEntity worldInformation
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "worldInformation",
                    (entity) =>
                    {
                        return new CachedEntity() { ___guid = entity.___guid };
                    }
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "worldInformation",
                    value
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRFrameCachedEntity() : base() { }

        public XRFrameCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods
        public XRPoseCachedEntity getPose(XRSpace space, XRSpace baseSpace)
        {
            return EventHorizonBlazorInterop.FuncClass<XRPoseCachedEntity>(
                entity => new XRPoseCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getPose" }, space, baseSpace
                }
            );
        }

        public XRViewerPoseCachedEntity getViewerPose(XRReferenceSpace referenceSpace)
        {
            return EventHorizonBlazorInterop.FuncClass<XRViewerPoseCachedEntity>(
                entity => new XRViewerPoseCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getViewerPose" }, referenceSpace
                }
            );
        }

        public XRHitTestResultCachedEntity[] getHitTestResults(XRHitTestSource hitTestSource)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<XRHitTestResultCachedEntity>(
                entity => new XRHitTestResultCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getHitTestResults" }, hitTestSource
                }
            );
        }

        public XRTransientInputHitTestResultCachedEntity[] getHitTestResultsForTransientInput(XRTransientInputHitTestSource hitTestSource)
        {
            return EventHorizonBlazorInterop.FuncArrayClass<XRTransientInputHitTestResultCachedEntity>(
                entity => new XRTransientInputHitTestResultCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getHitTestResultsForTransientInput" }, hitTestSource
                }
            );
        }

        public ValueTask<XRAnchorCachedEntity> createAnchor(XRRigidTransform pose, XRSpace space)
        {
            return EventHorizonBlazorInterop.TaskClass<XRAnchorCachedEntity>(
                entity => new XRAnchorCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "createAnchor" }, pose, space
                }
            );
        }

        public XRJointPoseCachedEntity getJointPose(XRJointSpace joint, XRSpace baseSpace)
        {
            return EventHorizonBlazorInterop.FuncClass<XRJointPoseCachedEntity>(
                entity => new XRJointPoseCachedEntity() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { this.___guid, "getJointPose" }, joint, baseSpace
                }
            );
        }
    #endregion
}
