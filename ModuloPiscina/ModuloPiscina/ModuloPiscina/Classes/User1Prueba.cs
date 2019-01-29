using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloPiscina
{
    public class User1Prueba
    {
        public static Descuento descuentoUnitario = new Descuento
        {
            Id_Descuento = 1,
            Nombre = "Descuento Unitario",
            Descripcion = "Descuento unitario para un uso de piscina",
            Cantidad = 1,
            Precio = 5,
            Num_Usos = 1,
            Unitario = true,
            Acumulable = false
        };

        public static Descuento descuentoMensual = new Descuento
        {
            Id_Descuento = 2,
            Nombre = "Descuento Mensueal",
            Descripcion = "Descuento Mensual para un mes",
            Cantidad = 1,
            Precio = 25,
            Num_Usos = 30,
            Unitario = true,
            Acumulable = false
        };

        /*public static Desc_Usuario desc_usuario1 = new Desc_Usuario()
       {
           Id_Usuario = 1,
           Id_Descuento = 1

       };*/
        public static User Usuario1 = new User
        {
            Id_Usuario = 1,
            Nombre = "carlos",
            Apellidos = "martin gutierrez",
            Email_Preferido = "camart12@ucm.es",
            Fecha_Nacimiento = new DateTime(1995, 8, 14),
            Sexo = true,
            DNI = "51229181T",
            Tipo_Estudiante = "ESTUDIANTE",
            Descuentos = Lista(),
        };

        private static List<Descuento> Lista()
        {
            var lista = new List<Descuento>();
            lista.Add(descuentoUnitario);
            lista.Add(descuentoMensual);
            return lista;
        }
    }
}
