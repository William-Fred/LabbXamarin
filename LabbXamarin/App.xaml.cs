
using LabbXamarin.ViewModels;
using LabbXamarin.Views;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabbXamarin
{
    public partial class App : Application
    {
        static public BrawlHallaTopFiftyViewModel brawlHallaViewModel { get; set; } = new BrawlHallaTopFiftyViewModel();
        static public BrawlHallaLegendsViewModel BrawlHallaLegendsViewModel { get; set; } = new BrawlHallaLegendsViewModel();
        public App()
        {
            InitializeComponent();

          
            MainPage = new AppShell();
        }

        protected override async void OnStart()
        {
            await brawlHallaViewModel.LoadBrawlHallaAPIasync();
            await BrawlHallaLegendsViewModel.LoadLegendsAsync();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
