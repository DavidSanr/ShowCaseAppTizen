using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShowCaseTizen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListVideos : ContentPage
    {
        public ObservableCollection<int> Items { get; set; }
        public ListVideos()
        {
            InitializeComponent();

           var videos = RestService.GetVideos();

            Items = new ObservableCollection<int>();
            foreach (var item in videos.results)
            {
                Items.Add(item.Id);
            }

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var videos = RestService.GetVideos();
            foreach (var item in videos.results)
            {
                if (e.Item.ToString().Equals(item.Id.ToString()))
                {
                    await Navigation.PushAsync(new VideoSeleccionado(item));
                }
            }
        }

    }
}
