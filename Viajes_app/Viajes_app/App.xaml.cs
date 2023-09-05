using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Viajes_app.Views;

namespace Viajes_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            MainPage = new NavigationPage(new Viajes_app.Views.LoginPage());
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
