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
    public partial class BrawlHallaMainPage : ContentPage
    {
        public BrawlHallaMainPage()
        {
            InitializeComponent();
            Title= "Stats";
        }

        private async void btnTop50_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrawlHallaTopFiftyPage());
        }

        private async void btnLegends_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrawlHallaLegendsPage());
        }

        private async void btnPlayerStats_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrawlHallaPlayerStatsPage());
        }
    }
}