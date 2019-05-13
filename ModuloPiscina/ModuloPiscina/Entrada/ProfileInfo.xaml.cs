using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModuloPiscina.Entrada
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileInfo : ContentPage
	{
        private User user;

        public ProfileInfo(User usuario)
        {
            user = usuario;
            InitializeComponent();
            BindingContext = new ProfileViewModel(user);
            listaMisDescuentos.ItemsSource = user.Descuentos;
        }

        private void DescuentoSeleccionado(Object sender, ItemTappedEventArgs e)
        {
            var opcion = (Descuento)listaMisDescuentos.SelectedItem;
            PopupNavigation.Instance.PushAsync(new DescuentoInfoPopUp(opcion));
        }

    }
}