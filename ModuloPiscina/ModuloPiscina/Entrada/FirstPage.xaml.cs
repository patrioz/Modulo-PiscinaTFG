using LecturaBarcode;
using ModuloPiscina.Classes;
using ModuloPiscina.Entrada;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace ModuloPiscina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        private User usuario;
        private Descuento descuentoEncontrado;
        private int TotalTicket = 10;
        public static int  ticketsActuales = 7;
        
     
        public FirstPage(User user){
            usuario = user;
            descuentoEncontrado = ChecktodosDesuentos();
            InitializeComponent();
        }

        // encuentra el descuento de id=2 o id=3 en la lista de Descuentos del usuario
        private Descuento ChecktodosDesuentos()
        {
            Descuento descuento = null;
            int i = 0;
            bool encontrado = false;

            while (i < usuario.Descuentos.Count() && !encontrado) {

                if (usuario.Descuentos.ElementAt(i).Id_Descuento == 2 || usuario.Descuentos.ElementAt(i).Id_Descuento == 3){

                    descuento = usuario.Descuentos.ElementAt(i);
                    encontrado = true;
                }
                else i++;
            }
            return descuento;
        }

        private int EntradasDisponibles(int entradasPorHoy)
        {
            //List<int> lista = new List<int>();
            int sizeList = 0;

            if (descuentoEncontrado.Id_Descuento == 2) {

                if ((TotalTicket - ticketsActuales) == 1)
                    sizeList = 1;

                else if ((TotalTicket - ticketsActuales) == 2 && entradasPorHoy == 0)
                {

                    if (descuentoEncontrado.Num_Usos == 1)
                        sizeList = 1;
                    else sizeList = 2;
                }
                else if ((TotalTicket - ticketsActuales) == 2 && entradasPorHoy == 1)
                {

                    if (descuentoEncontrado.Num_Usos == 1)
                        sizeList = 1;
                    else sizeList = 2;
                }
                else if ((TotalTicket - ticketsActuales) == 2 && entradasPorHoy == 2)
                    sizeList = 1;


                else if ((TotalTicket - ticketsActuales) > 2 && entradasPorHoy == 0)
                {

                    if (descuentoEncontrado.Num_Usos == 1)
                        sizeList = 1;
                    else if (descuentoEncontrado.Num_Usos == 2)
                        sizeList = 2;
                    else sizeList = 3;
                }

                else if ((TotalTicket - ticketsActuales) > 2 && entradasPorHoy == 1)
                {
                    if (descuentoEncontrado.Num_Usos == 1)
                        sizeList = 1;
                    else sizeList = 2;
                }
                else if ((TotalTicket - ticketsActuales) > 2 && entradasPorHoy == 2)
                    sizeList = 1;
            }
            else {

                if ((TotalTicket - ticketsActuales) == 1)
                    sizeList = 1;

                else if ((TotalTicket - ticketsActuales) == 2 && entradasPorHoy == 0)
                    sizeList = 2;
                else if ((TotalTicket - ticketsActuales) == 2 && entradasPorHoy == 1)
                    sizeList = 2;
                else if ((TotalTicket - ticketsActuales) == 2 && entradasPorHoy == 2)
                    sizeList = 1;

                else if ((TotalTicket - ticketsActuales) > 2 && entradasPorHoy == 0)
                    sizeList = 3;
                else if ((TotalTicket - ticketsActuales) > 2 && entradasPorHoy == 1)
                    sizeList = 2;
                else if ((TotalTicket - ticketsActuales) > 2 && entradasPorHoy == 2)
                    sizeList = 1;
            }

            //for (int i = 1; i <= sizeList; i++)
            //    lista.Add(i);
           
            return sizeList;
        }
              
        void NavigationBarButtons(Object sender, EventArgs e) {

            Button btn = (Button)sender;
            switch (btn.ClassId) {

                case "comprarBono": Navigation.PushAsync(new ChargeBono(usuario)); break;

                case "comprarEntrada":

                    if (TotalTicket > ticketsActuales) { 

                        int entradasPorHoy = 0;

                        for (int i = 0; i < usuario.HistoricoEntradas.Count(); i++) {
                            if (usuario.HistoricoEntradas.ElementAt(i).Fecha_Ini.Date == DateTime.Today)
                                entradasPorHoy++;
                        }

                        if (entradasPorHoy < 3) {
                            Navigation.PushAsync(new ReservarEntrada(EntradasDisponibles(entradasPorHoy), descuentoEncontrado, usuario));
                            //PopupNavigation.Instance.PushAsync(new NumeroEntradasPopUp(EntradasDisponibles(entradasPorHoy), descuentoEncontrado, usuario));
                        }
                        else DisplayAlert("UPS!", "Ya has reservado 3 entradas para hoy", "OK"); 
                    }
                    else DisplayAlert("UPS!", "AFORO COMPLETO", "OK");
                    break;

                case "misEventos": Navigation.PushAsync(new AccesoPerfil(usuario)); break;
                    
                //case "perfil": Navigation.PushAsync(new ProfileInfo(usuario)); break;
            }
        }
    }
}