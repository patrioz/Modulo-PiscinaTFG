using LecturaBarcode;
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


            Button btn = (Button)sender;

            switch (btn.ClassId) {

                case "usuario": await Navigation.PushAsync(new ProfilePage()); break;
                     
                case "trabajador": await Navigation.PushAsync(new ScannerPage()); break;
            }
        }
    }
}
