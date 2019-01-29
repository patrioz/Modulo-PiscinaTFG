using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ModuloPiscina
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(Object sender, EventArgs e){

            await Navigation.PushAsync(new FirstPage());

        }
    }
}
