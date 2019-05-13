using ModuloPiscina.Classes;
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
	public partial class ReservarEntrada : ContentPage
	{
        private User usuario;
        private Descuento descuento;
        private List<AcompanantesList> listaEntradas;

        public ReservarEntrada(int numero, Descuento descuentoEncontrado, User usuario)
        {
            InitializeComponent();
            this.descuento = descuentoEncontrado;
            this.usuario = usuario;

            for (int i = 1; i <= numero; i++)
            {
                numeroEntradas.Items.Add(i.ToString() + " entrada/s");
            }
            listaEntradas = new List<AcompanantesList>();
        }

        private void NumeroEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = numeroEntradas.SelectedIndex;

            for( int k = 0; k < i+1; k++)
            {
                if (descuento != null)
                {
                    Entradas entrada = new Entradas(usuario.HistoricoEntradas.Count().ToString(), usuario.Id_Usuario, descuento.Id_Descuento,
                        descuento.Num_Usos, DateTime.Now.Date, DateTime.Now.Date.AddDays(1).AddSeconds(-1), null);

                    listaEntradas.Add(new AcompanantesList(entrada));
                }
                else
                {
                    Entradas entrada = new Entradas(usuario.HistoricoEntradas.Count().ToString(), usuario.Id_Usuario, null, null,
                     DateTime.Now.Date, DateTime.Now.Date.AddDays(1).AddSeconds(-1), null);

                    listaEntradas.Add(new AcompanantesList(entrada));
                }
            }
            acompanantesLista.ItemsSource = listaEntradas;

            int valorEuros = 0;
            for (int x = 0; x < listaEntradas.Count(); x++)
                valorEuros += Convert.ToInt32(listaEntradas.ElementAt(x).Cantidad);

            totalPagar.Text = "Total a paga " + valorEuros + " €";
        }

        void Pagar(Object sender, EventArgs e)
        {

            //pagar y comprobaciones de campos rellenos

            for (int i = 0; i < listaEntradas.Count(); i++)
            {
                //METER LAS ENTRADAS EN LA LISTA DE ENTRADAS DE LA PARTE DE LECTURA solo cn id_usuario y con el id_entrada
                usuario.HistoricoEntradas.Add(listaEntradas.ElementAt(i).Entrada);
                FirstPage.ticketsActuales++;
            }

            if (descuento.Id_Descuento == 2)
            {
                int index = usuario.Descuentos.IndexOf(descuento);
                usuario.Descuentos.ElementAt(index).Num_Usos--;

                if (usuario.Descuentos.ElementAt(index).Num_Usos == 0)
                    usuario.Descuentos.ElementAt(index).Fecha_Fin = DateTime.Now;
            }

            Navigation.PushAsync(new AccesoPerfil(usuario));
        }
    }
}