using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloPiscina
{
    class Pago
    {

        public long Id_Pago { get; set; }
        public byte Tipo { get; set; }
        public short Id_Gestor { get; set; }
        public bool Cobrado { get; set; }
        public decimal Cantidad { get; set; }
        public Nullable<int> Id_Usuario { get; set; }
        public Nullable<int> Id_Pagador { get; set; }
        public int Id_Trabajador { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Id_Caja { get; set; }
        public Nullable<long> Id_Cierre { get; set; }
        public Nullable<int> Id_Remesa { get; set; }
        public bool Devolucion { get; set; }
        public Nullable<short> Id_Gestor_Factura { get; set; }
        public string Id_Factura { get; set; }
        public Nullable<short> Id_Gestor_Pagador { get; set; }
        public Nullable<long> Id_Pago_Devolucion { get; set; }
        public Nullable<long> Id_Pago_Fraccionado { get; set; }

        //public virtual IEnumerable<ConceptoEntity> Conceptos { get; set; }
    }
}
