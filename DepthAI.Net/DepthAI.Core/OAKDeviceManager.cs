using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SimpleJSON;

namespace DepthAI.Core
{
    public class OAKDeviceManager
    {

        [DllImport("depthai-unity", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GetAllDevices();

        // Scroll position
        //private Vector2 _scrollPos = Vector2.zero;
        // device information
        private string _devicesJson = "";
        private string _devices = "";
        List<OakDeviceItem> _devicesList = new List<OakDeviceItem>();
        public OAKDeviceManager()
        {

            _devices = "";
            _devicesJson = Marshal.PtrToStringAnsi(GetAllDevices());
            if (_devicesJson != "" && _devicesJson != "null")
            {
                var obj = JSON.Parse(_devicesJson);
                _devices += "Device ID\t\t\tDevice State\t\t\tDevice Name\n";
                // foreach device parse information
                foreach (JSONNode arr in obj)
                {
                    var newItem = new OakDeviceItem() {
                     deviceId = arr["deviceId"],
                     deviceName = arr["deviceName"],
                     deviceState = arr["deviceState"]};
                    _devicesList.Add(newItem);
                    // build line with device information
                    //_devices = _devices + deviceId + "\t\t" + deviceState + "\t\t\t" + deviceName + "\n";
                }
            }

        }

        public List<OakDeviceItem> GetAvailableDevices()
        {
            return _devicesList;
        }

    }

    public class OakDeviceItem { 
    
        public string deviceId  { set; get;}
        public string deviceName  {set;get;}
        public string deviceState {set;get;}
    }
}