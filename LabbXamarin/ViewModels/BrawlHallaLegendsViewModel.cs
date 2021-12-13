using LabbXamarin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabbXamarin.ViewModels
{
    public class BrawlHallaLegendsViewModel : INotifyPropertyChanged
    {
        private string apiKey = "S2BJOY1UVBWYITJ13CYF";
        public ObservableCollection<BrawlHallaLegends> legendsList { get; set; } = new ObservableCollection<BrawlHallaLegends>();
        public event PropertyChangedEventHandler PropertyChanged;

        internal async Task LoadLegendsAsync()
        {
            string urlLegends = @"https://api.brawlhalla.com/legend/all?api_key=" + apiKey;
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(new Uri(urlLegends));

            if (response.IsSuccessStatusCode)
            {
                string legendContent = await response.Content.ReadAsStringAsync();
                legendsList = JsonConvert.DeserializeObject<ObservableCollection<BrawlHallaLegends>>(legendContent);

                RaisePropertyChanged("legendsList");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Fel", "Går inte att hämta från api, !", "Cancel");
            }

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
