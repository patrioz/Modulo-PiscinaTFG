using ModuloPiscina.ViewModel;
using Rg.Plugins.Popup.Services;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModuloPiscina.Entrada
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ComprarAbonoPopUp 
	{
        Descuento descuento;
        User usuario;

		public ComprarAbonoPopUp (Descuento desc, User user)
		{
            descuento = desc;
            usuario = user;
            InitializeComponent ();
            BindingContext = new DescuentoViewModel(descuento);
        }

        void ok(Object sender, EventArgs e)
        {
            DisplayAlert("COMPRA REALIZADA!", "El compra se ha realizado con éxito!", "OK");
            Navigation.PopAsync();
            PopupNavigation.Instance.PopAllAsync(true);
            Navigation.PushAsync(new ProfileInfo(usuario)); 
        }
    }
}