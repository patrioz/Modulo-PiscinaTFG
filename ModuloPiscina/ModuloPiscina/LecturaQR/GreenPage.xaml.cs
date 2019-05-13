using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LecturaBarcode
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreenPage : ContentPage
	{
		public GreenPage(string id_descuento, string num_usos)
		{
			InitializeComponent ();
            RedirectAsync();

            if (Convert.ToInt32(id_descuento) == 2)
            {
                esAbono10.Text = "HAS USADO TU ABONO DE 10, TE QUEDAN " + num_usos + " !";
            }
            else if (Convert.ToInt32(id_descuento) == 3)
                esAbono10.Text = "HAS USADO TU ABONO DE VERANO!";
        }

        private async Task RedirectAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            await Navigation.PopAsync();
        }
    }
}