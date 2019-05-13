using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ModuloPiscina.QR;
using ModuloPiscina.Classes;
using ModuloPiscina;

namespace LecturaBarcode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScannerPage : ContentPage
    {
        private static int contadorTickets = 0, TotalTickets = 10;
        private static List<Entradas> listaEntradashoy;

        public ScannerPage()
        {
            listaEntradashoy = new List<Entradas>();
            LlenarListaEntradasHoy();
            InitializeComponent();
        }

        protected override void OnAppearing() {

            InitScan();
            base.OnAppearing();
        }

        private async void InitScan()
        {
            var scanner = DependencyService.Get<IQrCodeScanningService>();
            var result = await scanner.ScanAsync();

            if (result == null)
            {
                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                player.Load("error.wav");
                OnAppearing();
                player.Play();
                await DisplayAlert("ERROR", "HA HABIDO UN ERROR, CONCTACTA CON PERSONAL", "OK");
            }
            else CheckResult(result);
        }

        private void LlenarListaEntradasHoy()
        {

            for (int i = 0; i < TotalTickets; i++)
                listaEntradashoy.Add(new Entradas(DateTime.Now.Date, DateTime.Now.AddDays(1).AddSeconds(-1)));

            listaEntradashoy.ElementAt(contadorTickets).Id_Responsable = 1;
            listaEntradashoy.ElementAt(contadorTickets).Id_Entrada = Convert.ToString(1);
            contadorTickets++;
            listaEntradashoy.ElementAt(contadorTickets).Id_Responsable = 1;
            listaEntradashoy.ElementAt(contadorTickets).Id_Entrada = Convert.ToString(2);
            contadorTickets++;
        }

        private void CheckResult(string result)
        {
            String[] values = result.Split(' ');
            DateTime fecha_ini = Convert.ToDateTime(values[4]);
            DateTime fecha_fin = Convert.ToDateTime(values[5]);
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            bool existeEntrada = false;
            int i = 0;

            while (i < listaEntradashoy.Count() && !existeEntrada) {

                if (listaEntradashoy.ElementAt(i).Id_Responsable == Convert.ToInt32(values[0])
                    && listaEntradashoy.ElementAt(i).Id_Entrada == values[1] && 
                    listaEntradashoy.ElementAt(i).Fecha_Uso != null)
                    existeEntrada = true;
                else i++;
            }

            if (existeEntrada) {

                if (fecha_fin >= DateTime.Now.Date)
                {
                    listaEntradashoy.ElementAt(i).Fecha_Uso = DateTime.Now;
                    player.Load("correct.wav");
                    player.Play();
                    Navigation.PushAsync(new GreenPage(values[2], values[3]));
                }
                // Acceder a la lista de entradas del usuario y cambiarle la fecha de uso, borrarla de la de entradas 
                // y meterla en la de históricos.

                //ProfilePage.cambioFechaUso(Convert.ToInt32(values[0]), values[1]);
            }
            else {
                player.Load("error.wav");
                player.Play();
                Navigation.PushAsync(new RedPage());
            }
        }
        //public static void AddEntrada(int id_Usuario, string id_entrada)
        //{
        //    listaEntradashoy.ElementAt(contadorTickets).Id_Responsable = id_Usuario;
        //    listaEntradashoy.ElementAt(contadorTickets).Id_Entrada = id_entrada;
        //    contadorTickets++;
        //}
    }
}
        

