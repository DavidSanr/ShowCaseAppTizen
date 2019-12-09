using MediaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShowCaseTizen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoSeleccionado : ContentPage
    {
        public VideoSeleccionado(Video video)
        {
            InitializeComponent();
            UrlVideo.Source = video.Videofile;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
            await Navigation.PushAsync(new ListVideos());
        }
    }
}