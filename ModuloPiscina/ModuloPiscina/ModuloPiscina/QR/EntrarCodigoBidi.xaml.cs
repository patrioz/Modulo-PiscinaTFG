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
		public EntrarCodigoBidi (User usuario)
		{
			InitializeComponent();
		}

        private ZXingBarcodeImageView barcode;

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (contentEntry.Text != string.Empty)
                {
                    barcode = new ZXingBarcodeImageView
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                    };
                    barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
                    barcode.BarcodeOptions.Width = 500;
                    barcode.BarcodeOptions.Height = 500;
                    barcode.BarcodeValue = contentEntry.Text.Trim();
                    qrResult.Content = barcode;
                }
                else
                {
                    DisplayAlert("Alert", "Introduzca el valor que desea convertir código QR", "OK");
                }


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                DisplayAlert("Alert", "Introduzca el valor que desea convertir código QR", "OK");
            }
        }
    }
}