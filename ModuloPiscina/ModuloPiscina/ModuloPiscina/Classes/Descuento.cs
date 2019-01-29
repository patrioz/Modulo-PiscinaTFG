using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloPiscina
{
    public class Descuento
    {
        public Descuento() { }

        public Descuento(int id_descuento, string Nombre, string Descripcion, int cantidad, int Precio, Nullable<int> numUsos, bool unitario, bool acumulable)
        {
            this.Id_Descuento = id_descuento;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Cantidad = cantidad;
            this.Precio = Precio;
            this.Unitario = unitario;
            this.Acumulable = Acumulable;
        }

        public int Id_Descuento { get; set; }
        public byte Tipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public short Id_Gestor { get; set; }
        public decimal Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> Num_Usos { get; set; }
        public bool Unitario { get; set; }
        public bool Porcentaje { get; set; }
        public bool Precio_Hora { get; set; }
        public bool Aplicar_Al_PB { get; set; }
        public bool Acumulable { get; set; }
        public Nullable<System.TimeSpan> Tiempo { get; set; }
        public Nullable<System.DateTime> Fecha_Inicio { get; set; }
        public Nullable<System.DateTime> Fecha_Fin { get; set; }
        public Nullable<int> Caducidad { get; set; }
        /*public bool Aplica_Reserva { get; set; }
        public bool Aplica_Partido { get; set; }
        public bool Aplica_Escuela { get; set; }
        public bool Aplica_Torneo { get; set; }
        public bool Aplica_Reserva_Recurrente { get; set; }
        public bool Gestiona_PistaVirtual { get; set; }
        public bool Avisar { get; set; }*/
        public bool Activo { get; set; }

        


    }
}
