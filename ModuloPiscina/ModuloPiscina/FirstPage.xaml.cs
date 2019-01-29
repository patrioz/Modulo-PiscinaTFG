using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModuloPiscina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        private User usuario = User1Prueba.Usuario1;

        public FirstPage()
        {
            BindingContext = new ProfileViewModel(User1Prueba.Usuario1);
            InitializeComponent();
        }

        void NavigationBarButtons(Object sender, EventArgs e) {

            Button btn = (Button) sender;

            switch (btn.ClassId) {

                case "ChargeBonoButton": Navigation.PushAsync(new ChargeBono(usuario)); break;

                case "ProfileButton": Navigation.PushAsync(new ProfilePage(usuario)); break;

                case "InformacionButton": Navigation.PushAsync(new InformacionPage()); break;

                case "EntrarButton": Navigation.PushAsync(new MostrarAbonosParaEntrar(usuario)); break;
            }
        }
    }
}