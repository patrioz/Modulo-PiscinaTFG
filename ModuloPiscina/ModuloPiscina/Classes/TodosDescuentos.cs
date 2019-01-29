using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ModuloPiscina
{
    public class TodosDescuentos
    {
        public static ObservableCollection<Descuento> lista;

        public TodosDescuentos() {

            lista = new ObservableCollection<Descuento>();
            lista.Add(new Descuento(1,"descuento1", "Descuento unitario para un uso de piscina", 1, 5, 1, true, true));
            lista.Add(new Descuento(2, "descuento2", "Descuento mensual para uso de piscina", 1, 25, null, true, true));
            lista.Add(new Descuento(3, "descuento1", "Descuento unitario para un uso de piscina", 1, 70, null, true, true));
        }

    }
}
