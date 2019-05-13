using ModuloPiscina.Classes;
using ModuloPiscina.Entrada;
using ModuloPiscina.QR;
using ModuloPiscina.ViewModel;
using Rg.Plugins.Popup.Services;
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
	public partial class AccesoPerfil : ContentPage
	{
        private string entradaSeleccionada;

        public AccesoPerfil(User user)
		{
            InitializeComponent();
            todasEntradas.ItemsSource = user.HistoricoEntradas;
        }

        private void EntradaSeleccionada(Object sender, ItemTappedEventArgs e)
        {
            var opcion = (Entradas)todasEntradas.SelectedItem;
            entradaSeleccionada = opcion.Id_Entrada;
            PopupNavigation.Instance.PushAsync(new EntradaInfoPopUp(opcion));
        }
    }
}