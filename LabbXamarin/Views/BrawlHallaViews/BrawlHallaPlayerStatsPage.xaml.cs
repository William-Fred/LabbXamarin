using LabbXamarin.Models;
using LabbXamarin.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabbXamarin.Views.BrawlHallaViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrawlHallaPlayerStatsPage : ContentPage

    {
       
        private BrawHallaPlayerStatsViewModel playerStatsViewModel = new BrawHallaPlayerStatsViewModel();
        public BrawlHallaPlayerStatsPage()
        {
            InitializeComponent();
            Title = "Player stats";
            BindingContext = playerStatsViewModel;
        }

        private async void brawlHallaId_entry_CompletedAsync(object sender, EventArgs e)
        {
            
            var input = ((Entry)sender).Text; //cast sender to access the properties of the Entry
            playerStatsViewModel.userInputText(input);
            await playerStatsViewModel.getPlayerStats();
        }

        
        private void openModalLegends_Clicked(object sender, EventArgs e)
        {
            LegendsModal legendsModalPage = new LegendsModal(playerStatsViewModel.player);
            this.Navigation.PushModalAsync(legendsModalPage);
        }
    }
}