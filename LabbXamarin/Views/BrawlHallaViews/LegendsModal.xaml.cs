using LabbXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabbXamarin.Views.BrawlHallaViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LegendsModal : ContentPage
    {
        public LegendsModal(BrawlHallaPlayerStats player)
        {
            InitializeComponent();
            BindingContext = player;
            legendsList.ItemsSource = player.legends;
        }

        private void btnModalClose_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }

        private void legendsList_ItemTappedAsync(object sender, ItemTappedEventArgs e)
        {
            var content = e.Item as PlayerLegends;
            var page = new NavigationPage(new LegendsDetailsPage(content));
            this.Navigation.PushModalAsync(page);
        }
    }
}