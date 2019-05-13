using ModuloPiscina.ViewModel;
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
	public partial class DescuentoInfoPopUp
    {
		public DescuentoInfoPopUp (Descuento descuento)
		{
            BindingContext = new DescuentoViewModel(descuento);
			InitializeComponent ();
		}
	}
}