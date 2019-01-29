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
	public partial class ChargeBono : ContentPage
	{
        public ObservableCollection<Descuento> ListaDescuentos { get; set; }
        private Descuento selectedDescuento;
        private User user;

        public ChargeBono(User usuario)
        {
            this.user = usuario;
            LLenarListaAbonosDisponibles();
            InitializeComponent();
            listaTodosDescuentos.ItemsSource = ListaDescuentos;
            BindingContext = new ProfileViewModel(usuario);
        }

        private void ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            this.selectedDescuento = (sender as ListView).SelectedItem as Descuento;
            user.Descuentos.Add(selectedDescuento);
        }

        private void CargarBono(Object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.ClassId == "cargarButton") {

                Navigation.PushAsync(new ProfilePage(user));
            }
               
        }

        private void LLenarListaAbonosDisponibles()
        {
            this.ListaDescuentos = new ObservableCollection<Descuento>();

            this.ListaDescuentos.Add(new Descuento()
            {
                Id_Descuento = 1,
                Nombre = "Descuento Unitario",
                Descripcion = "Descuento de un único uso",
                Precio = 5,
                Fecha_Inicio = new DateTime(),
                Fecha_Fin = new DateTime(),
                Num_Usos = 1
            });
            this.ListaDescuentos.Add(new Descuento()
            {
                Id_Descuento = 2,
                Nombre = "Descuento 10 Usos",
                Descripcion = "Descuento de 10 usos",
                Precio = 13,
                Fecha_Inicio = new DateTime(),
                Fecha_Fin = new DateTime(),
                Num_Usos = 10
            });
            this.ListaDescuentos.Add(new Descuento()
            {
                Id_Descuento = 3,
                Nombre = "Descuento Mensual",
                Descripcion = "Descuento para un mes",
                Precio = 25,
                Fecha_Inicio = new DateTime(),
                Fecha_Fin = new DateTime(),
                Num_Usos = null
            });
            this.ListaDescuentos.Add(new Descuento()
            {
                Id_Descuento = 4,
                Nombre = "Descuento Trimestral",
                Descripcion = "Descuento valido para un trimestre",
                Precio = 70,
                Fecha_Inicio = new DateTime(),
                Fecha_Fin = new DateTime(),
                Num_Usos = null
            });
            this.ListaDescuentos.Add(new Descuento()
            {
                Id_Descuento = 5,
                Nombre = "Descuento Anual",
                Descripcion = "Descuento valido para todo el año",
                Precio = 100,
                Fecha_Inicio = new DateTime(),
                Fecha_Fin = new DateTime(),
                Num_Usos = null
            });
        }
    }
}