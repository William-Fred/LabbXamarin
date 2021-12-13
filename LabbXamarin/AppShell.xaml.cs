using LabbXamarin.ViewModels;
using LabbXamarin.Views;
using LabbXamarin.Views.BrawlHallaViews;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LabbXamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(BrawlHallaLegendsPage), typeof(BrawlHallaLegendsPage));
        }

    }
}
