namespace ModuloPiscina
{
    public class Des_Usuario
    {
        public int Id_Usuario { get; set; }
        public int Id_Descuento { get; set; }
        public System.Nullable<System.DateTime> Caducidad { get; set; }
        public System.Nullable<int> Usos { get; set; }
        public System.Nullable<System.TimeSpan> Tiempo { get; set; }
        public System.Nullable<decimal> Saldo_Restante { get; set; }

        //public virtual DescuentoEntity Descuento { get; set; }
    }
}