/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Interop;
using EventHorizon.Blazor.Interop.Callbacks;
using EventHorizon.Blazor.Interop.ResultCallbacks;
using Microsoft.JSInterop;

public interface XRHand : ICachedEntity { }

[JsonConverter(typeof(CachedEntityConverter<XRHandCachedEntity>))]
public class XRHandCachedEntity : CachedEntityObject, XRHand
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
        
        public decimal length
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "length"
                );
            }
        }

        
        public decimal WRIST
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "WRIST"
                );
            }
        }

        
        public decimal THUMB_METACARPAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "THUMB_METACARPAL"
                );
            }
        }

        
        public decimal THUMB_PHALANX_PROXIMAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "THUMB_PHALANX_PROXIMAL"
                );
            }
        }

        
        public decimal THUMB_PHALANX_DISTAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "THUMB_PHALANX_DISTAL"
                );
            }
        }

        
        public decimal THUMB_PHALANX_TIP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "THUMB_PHALANX_TIP"
                );
            }
        }

        
        public decimal INDEX_METACARPAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INDEX_METACARPAL"
                );
            }
        }

        
        public decimal INDEX_PHALANX_PROXIMAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INDEX_PHALANX_PROXIMAL"
                );
            }
        }

        
        public decimal INDEX_PHALANX_INTERMEDIATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INDEX_PHALANX_INTERMEDIATE"
                );
            }
        }

        
        public decimal INDEX_PHALANX_DISTAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INDEX_PHALANX_DISTAL"
                );
            }
        }

        
        public decimal INDEX_PHALANX_TIP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "INDEX_PHALANX_TIP"
                );
            }
        }

        
        public decimal MIDDLE_METACARPAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MIDDLE_METACARPAL"
                );
            }
        }

        
        public decimal MIDDLE_PHALANX_PROXIMAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MIDDLE_PHALANX_PROXIMAL"
                );
            }
        }

        
        public decimal MIDDLE_PHALANX_INTERMEDIATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MIDDLE_PHALANX_INTERMEDIATE"
                );
            }
        }

        
        public decimal MIDDLE_PHALANX_DISTAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MIDDLE_PHALANX_DISTAL"
                );
            }
        }

        
        public decimal MIDDLE_PHALANX_TIP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "MIDDLE_PHALANX_TIP"
                );
            }
        }

        
        public decimal RING_METACARPAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RING_METACARPAL"
                );
            }
        }

        
        public decimal RING_PHALANX_PROXIMAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RING_PHALANX_PROXIMAL"
                );
            }
        }

        
        public decimal RING_PHALANX_INTERMEDIATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RING_PHALANX_INTERMEDIATE"
                );
            }
        }

        
        public decimal RING_PHALANX_DISTAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RING_PHALANX_DISTAL"
                );
            }
        }

        
        public decimal RING_PHALANX_TIP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "RING_PHALANX_TIP"
                );
            }
        }

        
        public decimal LITTLE_METACARPAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LITTLE_METACARPAL"
                );
            }
        }

        
        public decimal LITTLE_PHALANX_PROXIMAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LITTLE_PHALANX_PROXIMAL"
                );
            }
        }

        
        public decimal LITTLE_PHALANX_INTERMEDIATE
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LITTLE_PHALANX_INTERMEDIATE"
                );
            }
        }

        
        public decimal LITTLE_PHALANX_DISTAL
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LITTLE_PHALANX_DISTAL"
                );
            }
        }

        
        public decimal LITTLE_PHALANX_TIP
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "LITTLE_PHALANX_TIP"
                );
            }
        }
    #endregion
    
    #region Constructor
        public XRHandCachedEntity() : base() { }

        public XRHandCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


    #endregion

    #region Methods

    #endregion
}
