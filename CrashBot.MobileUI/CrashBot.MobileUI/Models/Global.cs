using Android.Bluetooth;
using System;
using System.Collections.Generic;
using System.Text;
using static CrashBot.MobileUI.Views.HomeMenuPage;

namespace CrashBot.MobileUI.Models
{
    public class Global
    {
        public static BluetoothConnection myConnection { get; set; }

       public static BluetoothSocket _socket { get; set; }
    }
}
