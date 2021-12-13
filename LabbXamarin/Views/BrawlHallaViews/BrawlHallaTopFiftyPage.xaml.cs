using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabbXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabbXamarin.Views.BrawlHallaViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrawlHallaTopFiftyPage : ContentPage
    {
        public BrawlHallaTopFiftyPage()
        {
            InitializeComponent();
            BindingContext = App.brawlHallaViewModel;
        }
    }
}