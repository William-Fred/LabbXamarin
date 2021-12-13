using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabbXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraPage : ContentPage
    {
        public CameraPage()
        {
            InitializeComponent();
            Title = "Camera";
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            
           var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Pick a photo"
            }) ;
            if(result != null) { 
            var stream = result.OpenReadAsync();
            resultImage.Source = ImageSource.FromStream(() => stream.Result);
            }
            
        }
        async void Take_Photo_Clicked(object sender, EventArgs e)
        {
            var result = await MediaPicker.CapturePhotoAsync();

            if(result != null) { 
            var stream = await result.OpenReadAsync();
            resultImage.Source = ImageSource.FromStream(() => stream);
            }
        }
    }
}