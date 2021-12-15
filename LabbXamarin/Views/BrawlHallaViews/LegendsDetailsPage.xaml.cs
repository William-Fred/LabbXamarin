using Android.Widget;
using LabbXamarin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabbXamarin.Views.BrawlHallaViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LegendsDetailsPage : ContentPage
    {
      
        public LegendsDetailsPage(PlayerLegends playerLegends)
        {
           
            InitializeComponent();
            Title = playerLegends.legend_name_key.ToUpper();



            var assembly = typeof(App).GetTypeInfo().Assembly;
            var list = assembly.GetManifestResourceNames();
            List<string> imageFile = new List<string>();
            foreach (var legend in list)
            {

                imageFile.Add(legend);
                
            }
            foreach (var item in imageFile)
            {
              if(item.Contains(playerLegends.legend_name_key.ToString()))
                {
                    imageLegend.Source = ImageSource.FromResource(item, typeof(LegendsDetailsPage).GetTypeInfo().Assembly);
                }
            }
            

            //Display right values from the object the user has tapped
            name.Text = playerLegends.legend_name_key;
                games.Text = playerLegends.games.ToString();
                wins.Text = playerLegends.wins.ToString();
                damageDealt.Text = playerLegends.damagedealt;
                damageTaken.Text = playerLegends.damagetaken;
                kos.Text = playerLegends.kos.ToString();
        }
    }
}