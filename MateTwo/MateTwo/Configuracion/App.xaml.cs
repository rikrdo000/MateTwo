using System;
using MateTwo.Shell;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MateTwo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            //MainPage = new NavigationPage(new MainPage());

            MainPage = new AppShell();
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
