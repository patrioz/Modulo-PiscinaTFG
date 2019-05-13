using ModuloPiscina.Classes;
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

namespace ModuloPiscina.Entrada
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntradaInfoPopUp 
	{
        private Entradas entrada;

        public EntradaInfoPopUp (Entradas entradaSeleccionada)
		{
            entrada = entradaSeleccionada;
            BindingContext = new EntradasViewModel(entradaSeleccionada);
			InitializeComponent ();

            if (entradaSeleccionada.Fecha_Uso != null)
                bidibot.IsVisible = false;
        }

        void PopUpButtons(Object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAllAsync(true);
            Navigation.PushAsync(new EntrarCodigoBidi(entrada));
        }

    }
}