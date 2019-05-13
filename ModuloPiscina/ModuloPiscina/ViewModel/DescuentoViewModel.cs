using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloPiscina.ViewModel
{
    class DescuentoViewModel
    {
        private Descuento descuento;

        public DescuentoViewModel(Descuento desc)
        {
            this.descuento = desc;
        }

        public string Nombre
        {
            get { return "Tipo de Descuento: " + descuento.Nombre; }
        }

        public string Usos
        {
            get { return  "Número de usos   " + descuento.Num_Usos.ToString(); }
        }

        public string Fecha_Adquisicion
        {
            get { return "Fecha de Adquisición " + descuento.Fecha_Inicio.ToString(); }
        }

        public string Fecha_Fin
        {
            get { return "Fecha Fin  " + descuento.Fecha_Fin; }
        }

        public string Descripcion
        {
            get { return descuento.Descripcion; }
        }

        public string Precio
        {
            get { return "Precio:  " + descuento.Precio.ToString(); }
        }
    }
}
