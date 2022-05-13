using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacebookMessenger
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new ChatsPage());

            MainPage = navPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
