using ModuloPiscina.Entrada;
using Rg.Plugins.Popup.Services;
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
        private List<Descuento> ListaDescuentos;
        private List<string> ListaMetodosPago;
        private User user;
        private Descuento descuento;
        private string metodopago;

        public ChargeBono(User usuario)
        {
            InitializeComponent();

            this.user = usuario;
            LLenarListaAbonosDisponibles();
            foreach (var nombre in ListaDescuentos)
                tipoBono.Items.Add(nombre.Nombre);

            ListaMetodosPago = new List<string>() { "Tarjeta Bancaria", "Cargo en cuenta" };
            tipoPago.ItemsSource = ListaMetodosPago;
            //tipoPago.Items.Add("Tarjeta Bancaria");
            totalPagar.Text = "Total a pagar 0 €";
            pagarboton.IsEnabled = false;
        }

        private void TipoBono_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = tipoBono.SelectedIndex;
            descuento = ListaDescuentos[i];
            totalPagar.Text = "Total a pagar " + ListaDescuentos[i].Precio + " €";

            if (metodopago != null)
                pagarboton.IsEnabled = true;
        }

        private void TipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = tipoBono.SelectedIndex;
            metodopago = ListaMetodosPago[i];

            if (descuento != null)
                pagarboton.IsEnabled = true;
        }


        private void Pagar(Object sender, EventArgs e)
        {
            
            PopupNavigation.Instance.PushAsync(new ComprarAbonoPopUp(descuento, user));
            //TPV 

            int i = 0;
            bool encontrado = false;

            while (i < user.Descuentos.Count() && !encontrado)
            {

                if (user.Descuentos.ElementAt(i).Id_Descuento == 2)
                {

                    user.Descuentos.ElementAt(i).Num_Usos += 10;
                    encontrado = true;
                }
                else i++;
            }

            if (!encontrado)
                user.Descuentos.Add(descuento);
        }

        private void LLenarListaAbonosDisponibles()
        {
            ListaDescuentos  = new List<Descuento>();

            switch (user.Gestores.ElementAt(0).Grupo)
            {
                case "gestorALUMNO":

                    ListaDescuentos.Add(new Descuento()
                    {
                        Id_Descuento = 2,
                        Nombre = "Descuento 10 baños",
                        Descripcion = "Este bono de 10 baños es para uso individual, no transferible. El uso de este abono esta limitado" +
                        "a usuarios de la UCM mayores de edad.",
                        Precio = 15,
                        Num_Usos = 10,
                        Fecha_Inicio = DateTime.Now,
                    }); break;

                case "gestorUCM":
                    ListaDescuentos.Add(new Descuento()
                    {
                        Id_Descuento = 2,
                        Nombre = "Descuento 10 baños",
                        Descripcion = "Este bono de 10 baños es para uso individual, no transferible. El uso de este abono esta limitado" +
                        "a usuarios de la UCM mayores de edad.",
                        Precio = 25,
                        Num_Usos = 10,
                        Fecha_Inicio = DateTime.Now
                    }); break;

                case "gestorALUMNI":
                    ListaDescuentos.Add(new Descuento()
                    {
                        Id_Descuento = 2,
                        Nombre = "Descuento 10 baños",
                        Descripcion = "Este bono de 10 baños es para uso individual, no transferible. El uso de este abono esta limitado" +
                        "a usuarios de la UCM mayores de edad.",
                        Precio = 35,
                        Num_Usos = 10,
                        Fecha_Inicio = DateTime.Now
                    }); break;
            }
        }
    }
}