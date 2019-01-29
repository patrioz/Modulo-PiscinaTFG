using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModuloPiscina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilePage : ContentPage
	{
        private User user;
        private Descuento selectedDescuento;

        public ProfilePage (User usuario)
		{
            user = usuario;
            InitializeComponent();
            BindingContext = new ProfileViewModel(user);
            listaMisDescuentos.ItemsSource = user.Descuentos;
        }

        private void ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            this.selectedDescuento = (sender as ListView).SelectedItem as Descuento;
        }

        void ProfileButtons(Object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.ClassId == "codigoBidiEntrada")
                Navigation.PushAsync(new EntrarCodigoBidi(this.user, this.selectedDescuento));
        }
    }

}