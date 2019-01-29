using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloPiscina
{
    public class User
    {
        public User()
        {
            Descuentos = new List<Descuento>();

        }

        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Tipo_Estudiante { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public string Email_Preferido { get; set; }
        public string Foto { get; set; }
        public Nullable<bool> Sexo { get; set; }
        public string Direccion { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Poblacion { get; set; }
        public string CPostal { get; set; }
        public string Password { get; set; }
        public string Numero_Cuenta { get; set; }
        public decimal Saldo { get; set; }
        public bool Email_Validado { get; set; }
        public bool Activo { get; set; }

        public virtual List<Descuento> Descuentos { get; set; }
    }
}
