using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.YoutubePlayer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            VideoPlayer.ApiKey = "AIzaSyC1EwM8It6RYWLltt_e2JCBo8VPBsh8Od4";
            MainPage = new MainPage();
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
