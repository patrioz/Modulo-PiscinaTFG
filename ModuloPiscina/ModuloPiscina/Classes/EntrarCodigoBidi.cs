using ModuloPiscina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace ModuloPiscina.QR
{
    public class EntrarCodigoBidi : ContentPage
    {
        private string id_entrada, id_usuario, id_descuento, num_usos;
        private DateTime fecha_adquisicion, fecha_fin;
        private ZXingBarcodeImageView barcode;

        public EntrarCodigoBidi(Entradas entrada)
        {
            this.id_usuario = entrada.Id_Responsable.ToString();
            this.id_entrada = entrada.Id_Entrada;
            this.id_descuento = entrada.Id_Descuento_Perteneciente.ToString();
            this.num_usos = entrada.Num_Usos_Descuento_Perteneciente.ToString();
            this.fecha_adquisicion = entrada.Fecha_Ini;
            this.fecha_fin = entrada.Fecha_Fin;

            GenerarCodigo();
        }

        public void GenerarCodigo()
        {
            try
            {
                barcode = new ZXingBarcodeImageView
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                };
                barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
                barcode.BarcodeOptions.Width = 250;
                barcode.BarcodeOptions.Height = 250;
                barcode.BarcodeValue = id_usuario + " " + id_entrada + " " + id_descuento + " " + num_usos +
                    " " + fecha_adquisicion.ToShortDateString() + " " + fecha_fin.ToShortDateString();

                var cabecera = new Grid { RowSpacing = 0, ColumnSpacing = 0, BackgroundColor = (Xamarin.Forms.Color)Application.Current.Resources["Color3"] };
                cabecera.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                cabecera.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                cabecera.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });


                var bottom1 = new Label { Text = "enttradas" };
                var bottom2 = new Label { Text = "info" };
                var bottom3 = new Label { Text = "maps" };

                cabecera.Children.Add(bottom1, 0, 0);
                cabecera.Children.Add(bottom2, 1, 0);
                cabecera.Children.Add(bottom3, 2, 0);


                //-------------------------------------------------------

                var info_usuario = new Grid { RowSpacing = 1, ColumnSpacing = 1 };

                info_usuario.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                info_usuario.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                info_usuario.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                info_usuario.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

                var info_entrada = new Label { Text = "Entrada: "+ id_entrada };
                var info_user = new Label { Text =  "Usuario: " + id_usuario };
                var info_usos = new Label { Text = "Usos Restantes: " + num_usos };
                var info_fecha = new Label { Text = "Fecha Fin: " + Convert.ToDateTime(fecha_fin).ToShortDateString() };

                info_usuario.Children.Add(info_entrada, 0, 0);
                info_usuario.Children.Add(info_user, 0, 1);
                info_usuario.Children.Add(info_usos, 1, 0);
                info_usuario.Children.Add(info_fecha, 1, 1);

                var boton_pdf = new Button { Text = "Descargar", Style = (Style)Application.Current.Resources["botonStyle2"] };

                var stack = new StackLayout()
                {
                    Children =
                   {
                       cabecera,
                       info_usuario,
                       barcode,
                       boton_pdf,
                   }
                };

                Content = stack;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                DisplayAlert("Alerta!", "Error al mostrar el código ", "OK");
            }
        }
    }
}