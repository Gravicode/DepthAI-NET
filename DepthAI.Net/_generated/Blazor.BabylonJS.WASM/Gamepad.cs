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

    
    
    [JsonConverter(typeof(CachedEntityConverter<Gamepad>))]
    public class Gamepad : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties
        
        public static decimal GAMEPAD
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Gamepad.GAMEPAD"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Gamepad.GAMEPAD",
                    value
                );
            }
        }

        
        public static decimal GENERIC
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Gamepad.GENERIC"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Gamepad.GENERIC",
                    value
                );
            }
        }

        
        public static decimal XBOX
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Gamepad.XBOX"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Gamepad.XBOX",
                    value
                );
            }
        }

        
        public static decimal POSE_ENABLED
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Gamepad.POSE_ENABLED"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Gamepad.POSE_ENABLED",
                    value
                );
            }
        }

        
        public static decimal DUALSHOCK
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    "BABYLON",
                    "Gamepad.DUALSHOCK"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    "BABYLON",
                    "Gamepad.DUALSHOCK",
                    value
                );
            }
        }
        #endregion

        #region Static Methods

        #endregion

        #region Accessors
        
        public bool isConnected
        {
            get
            {
            return EventHorizonBlazorInterop.Get<bool>(
                    this.___guid,
                    "isConnected"
                );
            }
        }

        private StickValues __leftStick;
        public StickValues leftStick
        {
            get
            {
            if(__leftStick == null)
            {
                __leftStick = EventHorizonBlazorInterop.GetClass<StickValues>(
                    this.___guid,
                    "leftStick",
                    (entity) =>
                    {
                        return new StickValues() { ___guid = entity.___guid };
                    }
                );
            }
            return __leftStick;
            }
            set
            {
__leftStick = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "leftStick",
                    value
                );
            }
        }

        private StickValues __rightStick;
        public StickValues rightStick
        {
            get
            {
            if(__rightStick == null)
            {
                __rightStick = EventHorizonBlazorInterop.GetClass<StickValues>(
                    this.___guid,
                    "rightStick",
                    (entity) =>
                    {
                        return new StickValues() { ___guid = entity.___guid };
                    }
                );
            }
            return __rightStick;
            }
            set
            {
__rightStick = null;
                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rightStick",
                    value
                );
            }
        }
        #endregion

        #region Properties
        
        public string id
        {
            get
            {
            return EventHorizonBlazorInterop.Get<string>(
                    this.___guid,
                    "id"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "id",
                    value
                );
            }
        }

        
        public decimal index
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "index"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "index",
                    value
                );
            }
        }

        
        public CachedEntity browserGamepad
        {
            get
            {
            return EventHorizonBlazorInterop.GetClass<CachedEntity>(
                    this.___guid,
                    "browserGamepad",
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
                    "browserGamepad",
                    value
                );
            }
        }

        
        public decimal type
        {
            get
            {
            return EventHorizonBlazorInterop.Get<decimal>(
                    this.___guid,
                    "type"
                );
            }
            set
            {

                EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "type",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public Gamepad() : base() { }

        public Gamepad(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public Gamepad(
            string id, decimal index, object browserGamepad, System.Nullable<decimal> leftStickX = null, System.Nullable<decimal> leftStickY = null, System.Nullable<decimal> rightStickX = null, System.Nullable<decimal> rightStickY = null
        )
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "Gamepad" },
                id, index, browserGamepad, leftStickX, leftStickY, rightStickX, rightStickY
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        #region onleftstickchanged TODO: Get Comments as metadata identification
        private bool _isOnleftstickchangedEnabled = false;
        private readonly IDictionary<string, Func<StickValues, Task>> _onleftstickchangedActionMap = new Dictionary<string, Func<StickValues, Task>>();

        public string onleftstickchanged(
            Func<StickValues, Task> callback
        )
        {
            SetupOnleftstickchangedLoop();

            var handle = Guid.NewGuid().ToString();
            _onleftstickchangedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onleftstickchanged_Remove(
            string handle
        )
        {
            return _onleftstickchangedActionMap.Remove(
                handle
            );
        }

        private void SetupOnleftstickchangedLoop()
        {
            if (_isOnleftstickchangedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onleftstickchanged",
                "CallOnleftstickchangedActions",
                _invokableReference
            );
            _isOnleftstickchangedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnleftstickchangedActions(StickValues values)
        {
            foreach (var action in _onleftstickchangedActionMap.Values)
            {
                await action(values);
            }
        }
        #endregion

        #region onrightstickchanged TODO: Get Comments as metadata identification
        private bool _isOnrightstickchangedEnabled = false;
        private readonly IDictionary<string, Func<StickValues, Task>> _onrightstickchangedActionMap = new Dictionary<string, Func<StickValues, Task>>();

        public string onrightstickchanged(
            Func<StickValues, Task> callback
        )
        {
            SetupOnrightstickchangedLoop();

            var handle = Guid.NewGuid().ToString();
            _onrightstickchangedActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        public bool onrightstickchanged_Remove(
            string handle
        )
        {
            return _onrightstickchangedActionMap.Remove(
                handle
            );
        }

        private void SetupOnrightstickchangedLoop()
        {
            if (_isOnrightstickchangedEnabled)
            {
                return;
            }
            EventHorizonBlazorInterop.FuncCallback(
                this,
                "onrightstickchanged",
                "CallOnrightstickchangedActions",
                _invokableReference
            );
            _isOnrightstickchangedEnabled = true;
        }

        [JSInvokable]
        public async Task CallOnrightstickchangedActions(StickValues values)
        {
            foreach (var action in _onrightstickchangedActionMap.Values)
            {
                await action(values);
            }
        }
        #endregion

        public void update()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "update" }
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