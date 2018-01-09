using System;
using FloorballApp.Services;
using FloorballApp.Views;
using Xamarin.Forms;

namespace FloorballApp
{
    public class App : Application
    {
        public static FloorballManager Manager { get; set; }

        public App()
        {
            Manager = new FloorballManager(new ApiService());

            MainPage = new NavigationPage(new MainPage()){ BarBackgroundColor = Color.FromRgb(255, 255, 51) };
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
