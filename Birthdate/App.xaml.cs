using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Birthdate
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTE1MzUzQDMxMzcyZTMxMmUzMEVNQ3JHQVhncFd3UmttMUV5Tkx0NVNFZ255bUdGdkZycHZpaXpqa2tudzQ9");

            InitializeComponent();

            //var navPage = new NavigationPage(new MainPage());
            var navPage = new NavigationPage(new MainPage());

            MainPage = navPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
