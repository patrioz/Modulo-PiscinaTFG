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
    public partial class MostrarAbonosParaEntrar : ContentPage
    {
        public ObservableCollection<Descuento> ListaDescuentos { get; set; }
        private Descuento selectedDescuento;
        private User user;

        public MostrarAbonosParaEntrar(User usuario)
        {
            this.user = usuario;
            InitializeComponent();
            BindingContext = new ProfileViewModel(usuario);
            listaMisDescuentos.ItemsSource = user.Descuentos;
        }

        private void ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            this.selectedDescuento = (sender as ListView).SelectedItem as Descuento;
        }

        private void MostrarCodigo(Object sender, EventArgs e) {

            Button btn = (Button)sender;

            if (btn.ClassId == "MostrarCodigo")
            {

                Navigation.PushAsync(new EntrarCodigoBidi(user, this.selectedDescuento));


                if (selectedDescuento.Nombre == "Descuento Unitario" && selectedDescuento.Nombre == "Descuento Descuento 10 Usos") {

                    this.selectedDescuento.Num_Usos--;

                    if (selectedDescuento.Num_Usos == 0)
                        user.Descuentos.Remove(this.selectedDescuento);
                }
            }
        }

    }
}