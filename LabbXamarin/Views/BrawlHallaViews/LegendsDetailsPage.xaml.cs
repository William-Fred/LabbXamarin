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
    public partial class LegendsDetailsPage : ContentPage
    {
        public LegendsDetailsPage(PlayerLegends playerLegends)
        {
            InitializeComponent();
            name.Text = playerLegends.legend_name_key;
            games.Text = playerLegends.games.ToString();
            wins.Text = playerLegends.wins.ToString();
            damageDealt.Text = playerLegends.damagedealt;
            damageTaken.Text = playerLegends.damagetaken;
            kos.Text = playerLegends.kos.ToString();
        }
    }
}