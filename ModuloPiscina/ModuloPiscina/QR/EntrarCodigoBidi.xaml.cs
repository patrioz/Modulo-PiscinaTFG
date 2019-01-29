using ModuloPiscina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace ModuloPiscina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntrarCodigoBidi : ContentPage
	{
        private User usuario;
        private Descuento descuento;

		public EntrarCodigoBidi (User usuario, Descuento descuento)
		{
            this.usuario = usuario;
            this.descuento = descuento;
            InitializeComponent();
            GenerarCodigo();
		}

        private ZXingBarcodeImageView barcode;

        public void GenerarCodigo() {

            try
            {
                barcode = new ZXingBarcodeImageView
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                };
                barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
                barcode.BarcodeOptions.Width = 500;
                barcode.BarcodeOptions.Height = 500;
                barcode.BarcodeValue = /*descuento.Id_Descuento.ToString() + descuento.Num_Usos.ToString() + usuario.Id_Usuario.ToString()*/ usuario.Nombre ;
                qrResult.Content = barcode;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                DisplayAlert("Alert", "Introduzca el valor que desea convertir código QR", "OK");
            }
            }
        }
}
