using System;
using Tizen.TV.UIControls.Forms;
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
            var page = new OverlayPage();
            var player = new MediaPlayer();
            player.VideoOutput = page;
            player.Source = video.Videofile;
            player.Start();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
            await Navigation.PushAsync(new ListVideos());
        }
    }
}