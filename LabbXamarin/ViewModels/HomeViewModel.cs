using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Text;

namespace LabbXamarin.ViewModels
{
   public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "Home";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.brawlhalla.com/"));
        }
        public ICommand OpenWebCommand { get; }
    }
}
