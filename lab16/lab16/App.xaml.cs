
using lab16.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab16
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new lab16.View.GatosView();
            //MainPage = new MainPage();
            //DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
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
