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

            switch (btn.ClassId)
            {

                case "codigoBidiEntrada": {

                        switch (selectedDescuento.Nombre)
                        {

                            case "Descuento Unitario": {

                                    // meter infor en el QR
                                    user.Descuentos.Remove(selectedDescuento); break;
                                } 

                            case "Descuento 10 Usos": {

                                    if (this.selectedDescuento.Num_Usos > 0)
                                    {
                                        this.selectedDescuento.Num_Usos--;
                                    }                                     

                                } user.Descuentos.Remove(selectedDescuento); break;

                            case "Descuento Mensual": user.Descuentos.Remove(selectedDescuento); break;
                        }
                        Navigation.PushAsync(new EntrarCodigoBidi(this.user));

                    }break;
            }
        }
    }

}