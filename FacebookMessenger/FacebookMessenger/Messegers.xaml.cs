using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacebookMessenger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Messegers : ContentPage
    {
        public Messegers()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(5000);

            await Navigation.PushAsync(new Messegers());
        }
    }
}