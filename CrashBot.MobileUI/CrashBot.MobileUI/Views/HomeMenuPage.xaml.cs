using Plugin.BLE.Abstractions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.BLE;
using Android.Bluetooth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.App;
using CrashBot.MobileUI.Models;

namespace CrashBot.MobileUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeMenuPage : ContentPage
    {
        //BluetoothConnection myConnection = new BluetoothConnection();

        //BluetoothSocket _socket = null;
        public HomeMenuPage()
        {
            InitializeComponent();
        }



        private void Connect_Clicked(object sender, EventArgs e)
        {

           Global.myConnection = new BluetoothConnection();
           Global.myConnection.getAdapter();
            Global.myConnection.thisAdapter.StartDiscovery();

            try
            {
                Global.myConnection.getDevice();
                Global.myConnection.thisDevice.SetPairingConfirmation(false);

                Global.myConnection.thisDevice.SetPairingConfirmation(true);
                Global.myConnection.thisDevice.CreateBond();

            }
            catch (Exception deviceEX)
            {
            }
            Global.myConnection.thisAdapter.CancelDiscovery();

            try
            { Global._socket = Global.myConnection.thisDevice.CreateRfcommSocketToServiceRecord(Java.Util.UUID.FromString("00001101-0000-1000-8000-00805f9b34fb")); } //the UUID of HC-05 and HC-06 is the same
            catch (Exception ex)
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", "Please go to settings and connect with the bluetooth module first.", "Ok");
            }

            Global.myConnection.thisSocket = Global._socket;

            try
            {
                Global.myConnection.thisSocket.Connect();

                IsConnected.Text = "Device is connected!";
                Joystick.IsEnabled = true;
            }
            catch (Exception CloseEX)
            { }
            
        }

        private void Disconnect_Clicked(object sender, EventArgs e)
        {
            try
            {


                Global.myConnection.thisDevice.Dispose();

                Global.myConnection.thisSocket.OutputStream.WriteByte(200);
                Global.myConnection.thisSocket.OutputStream.Close();

                Global.myConnection.thisSocket.Close();

                Global.myConnection = new BluetoothConnection();
                Global._socket = null;

                IsConnected.Text = "Device is not connected!";
                Joystick.IsEnabled = false;
            }
            catch { }
            
        }
        public class BluetoothConnection
        {

            public void getAdapter() { this.thisAdapter = BluetoothAdapter.DefaultAdapter; }
           
            public void getDevice() { this.thisDevice = (from bd in this.thisAdapter.BondedDevices where bd.Name == "HC-05" select bd).FirstOrDefault(); }

            public BluetoothAdapter thisAdapter { get; set; }
            public BluetoothDevice thisDevice { get; set; }

            public BluetoothSocket thisSocket { get; set; }
        }

        private void Joystick_Clicked(object sender, EventArgs e)
        {
           
           Navigation.PushAsync(new JoystickPage());
        }
    }
}