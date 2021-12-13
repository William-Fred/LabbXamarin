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
    public partial class BrawlHallaLegendsPage : ContentPage
    {
        public BrawlHallaLegendsPage()
        {
            InitializeComponent();
            BindingContext = App.BrawlHallaLegendsViewModel;
            Title = "Legends";
        }
    }
}