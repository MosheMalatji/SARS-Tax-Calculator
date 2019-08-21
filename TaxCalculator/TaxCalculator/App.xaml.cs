using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TaxCalculator.Services;
using TaxCalculator.Views;

namespace TaxCalculator
{
    public partial class App : Application
    {

        public App()
        {


            try
            {
                InitializeComponent();
            }
            catch (Exception)
            {

                throw;
            }


            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

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
