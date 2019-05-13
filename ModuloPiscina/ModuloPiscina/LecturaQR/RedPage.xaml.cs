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
	public partial class RedPage : ContentPage
	{
		public RedPage ()
		{
			InitializeComponent ();
            RedirectAsync();
        }

        private async Task RedirectAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            await Navigation.PopAsync();
        }
    }
}