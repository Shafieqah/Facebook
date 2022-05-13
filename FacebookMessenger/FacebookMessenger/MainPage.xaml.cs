using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FacebookMessenger
{
    public partial class ChatsPage : ContentPage
    {
       public ChatsPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(5000);

            await Navigation.PushAsync(new ChatsPage());
        }
    }
    
}
