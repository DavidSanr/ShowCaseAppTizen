using ShowCaseTizen.Views;
using Xamarin.Forms;

namespace ShowCaseTizen
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new ListVideos());
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
