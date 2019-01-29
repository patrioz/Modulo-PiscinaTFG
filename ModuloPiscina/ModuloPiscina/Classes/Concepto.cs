using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloPiscina
{
    public class Concepto
    {

        public long Id { get; set; }
        public long Id_Pago { get; set; }
        public decimal Cuantos { get; set; }
        public Nullable<int> Id_Descuento { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public bool Unitario { get; set; }
        public bool Porcentaje { get; set; }
        public bool Precio_Hora { get; set; }
        public bool Aplicar_Al_PB { get; set; }
        public bool Acumulable { get; set; }
        public bool Devolucion { get; set; }
        public byte Tipo { get; set; }
        public Nullable<System.TimeSpan> Tiempo { get; set; }
    }
}
