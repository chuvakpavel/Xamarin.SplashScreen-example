using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Xamarin.SplashScreen_example.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void IgniscorButton_OnClicked(object sender, EventArgs e)
        {
            try
            {
                await Browser.OpenAsync(new Uri("https://www.igniscor.com/"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }
        }
    }
}
