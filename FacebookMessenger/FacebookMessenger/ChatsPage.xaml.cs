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
    public partial class ChatsPage : ContentPage
    {
        public ChatsPage()
        { 
            InitializeComponent();
        }

        private async Task EnterClickedAsync(object sender, EventArgs e)
        { 

               await Task.Delay(5000);

               await Navigation.PushAsync(new Messegers());
               


        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}