using LabbXamarin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabbXamarin.ViewModels
{
    public class BrawHallaPlayerStatsViewModel : INotifyPropertyChanged
    {
        public string UserInput { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private string apiKey = "S2BJOY1UVBWYITJ13CYF";
        public BrawlHallaPlayerStats player { get; set; } = new BrawlHallaPlayerStats();
        public bool IsBusy { get; set; }
        
        public void userInputText(string input)
        {
            UserInput = input;
        }
        internal async Task getPlayerStats()
        {
            IsBusy = true;
            RaisePropertyChanged("IsBusy");
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(new Uri($"https://api.brawlhalla.com/player/${UserInput}/stats?api_key=" + apiKey));

            if (response.IsSuccessStatusCode)
            {
                string playerContent = await response.Content.ReadAsStringAsync();
                player = JsonConvert.DeserializeObject<BrawlHallaPlayerStats>(playerContent);
                player.winRatio = player.wins / player.games;
                RaisePropertyChanged("player");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Fel", "Går inte att hämta från api, !", "Cancel");
            }
            IsBusy = false;
            RaisePropertyChanged("IsBusy");

        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
