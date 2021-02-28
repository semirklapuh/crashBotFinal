using Android.Bluetooth;
using CrashBot.MobileUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static CrashBot.MobileUI.Views.HomeMenuPage;

namespace CrashBot.MobileUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JoystickPage : ContentPage
    {
       

      
    
    public JoystickPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Global.myConnection.thisSocket.OutputStream.WriteByte(Convert.ToByte('U'));
            System.Threading.Thread.Sleep(50);
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Global.myConnection.thisSocket.OutputStream.WriteByte(Convert.ToByte('L'));
            System.Threading.Thread.Sleep(50);
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Global.myConnection.thisSocket.OutputStream.WriteByte(Convert.ToByte('S'));
            System.Threading.Thread.Sleep(50);
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            Global.myConnection.thisSocket.OutputStream.WriteByte(Convert.ToByte('R'));
            System.Threading.Thread.Sleep(50);
        }

        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            Global.myConnection.thisSocket.OutputStream.WriteByte(Convert.ToByte('D'));
            System.Threading.Thread.Sleep(50);
        }

        private void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            Global.myConnection.thisSocket.OutputStream.WriteByte(Convert.ToByte('A'));
            System.Threading.Thread.Sleep(50);
        }
    }
}