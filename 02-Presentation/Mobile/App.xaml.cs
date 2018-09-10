using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Plugins;
using System;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Mobile
{
    public partial class App : IMvxApplication
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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

        public void LoadPlugins(IMvxPluginManager pluginManager)
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public IMvxViewModelLocator FindViewModelLocator(MvxViewModelRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
