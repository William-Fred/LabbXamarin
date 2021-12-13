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
    public class BrawlHallaTopFiftyViewModel : INotifyPropertyChanged
    {
        private string apiKey = "S2BJOY1UVBWYITJ13CYF";
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<BrawlHallaTopFifty> brawlList { get; set; } = new ObservableCollection<BrawlHallaTopFifty>();
        public ObservableCollection<BrawlHallaLegends> legendList { get; set; } = new ObservableCollection<BrawlHallaLegends>();
        //public BrawlHalla BrawlData { get; set; } = new BrawlHalla();
        //BrawlHalla brawlData = new BrawlHalla();

        internal async Task LoadBrawlHallaAPIasync()
        {
            try
            {
                string urlTop50 = @"https://api.brawlhalla.com/rankings/1v1/us-e/1?api_key=" + apiKey;
                
                HttpClient httpClient = new HttpClient();

                //Get top 50 US
                HttpResponseMessage response = await httpClient.GetAsync(new Uri(urlTop50));
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    brawlList = JsonConvert.DeserializeObject<ObservableCollection<BrawlHallaTopFifty>>(content);
                    
                    RaisePropertyChanged("brawlList");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Fel", "Går inte att hämta från api, !", "Cancel");
                }
                //Get Legends
                string urlLegends = @"https://api.brawlhalla.com/legend/all?api_key=" + apiKey;
                response = await httpClient.GetAsync(new Uri(urlLegends));
                
                if (response.IsSuccessStatusCode)
                {
                    string legendContent = await response.Content.ReadAsStringAsync();
                    legendList = JsonConvert.DeserializeObject<ObservableCollection<BrawlHallaLegends>>(legendContent);
                    RaisePropertyChanged("legendList");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Fel", "Går inte att hämta från api, !", "Cancel");
                }

                //Here we need to convert the bestlegend id to the legend name. This for displaying only the name in the view
                foreach (var brawlItem in brawlList)
                {
                    foreach (var legend in legendList)
                    {
                        if(brawlItem.BestLegend == legend.legend_id)
                        {
                            brawlItem.bestLegendName = legend.legend_name_key;
                        }
                    }
                }
               

            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Fel", "Internetuppkopplingen är ostabil, kolla anslutningen (" + ex.Message + ")", "Cancel");
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
