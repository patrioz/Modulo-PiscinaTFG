using ModuloPiscina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloPiscina
{
    public class UsuariosPrueba
    {     
        public static User UsuarioEstudiante() {

            User usuario = new User
            {
                Id_Usuario = 1,
                Nombre = "carlos",
                Apellidos = "martin gutierrez",
                Email_Preferido = "camart12@ucm.es",
                Fecha_Nacimiento = new DateTime(1995, 8, 14),
                Sexo = true,
                DNI = "51229181T",
                Descuentos = new List<Descuento>(),
                Gestores = new List<Usuario_Gestor>(),
                HistoricoEntradas = new List<Entradas>()
            };

            usuario.Gestores.Add(new Usuario_Gestor(usuario.Id_Usuario, "gestorALUMNO"));

            usuario.Descuentos.Add(new Descuento
            {
                Id_Descuento = 2,
                Nombre = "Abono de 10 usos",
                Descripcion = "Este bono de 10 baños es para uso individual, no transferible. El uso de este abono esta limitado" +
                        "a usuarios de la UCM mayores de edad.",
                Precio = 25,
                Num_Usos = 8,
                Fecha_Inicio = DateTime.Now,
            });

            usuario.HistoricoEntradas.Add(new Entradas(2.ToString(), usuario.Id_Usuario,  2, 9, new DateTime(2009, 08, 25), new DateTime(2018, 08, 26), null )); //caducada
            usuario.HistoricoEntradas.Add(new Entradas(1.ToString(), usuario.Id_Usuario, 2, 8, DateTime.Now, DateTime.Now.AddDays(1).AddTicks(-1), null)); //activa
            usuario.HistoricoEntradas.Add(new Entradas(usuario.HistoricoEntradas.Count().ToString(), usuario.Id_Usuario, 2 , 9 ,  new DateTime(2018, 08, 25), new DateTime(2009, 08, 26), new DateTime(2009, 08, 25)));
            usuario.HistoricoEntradas.Add(new Entradas(usuario.HistoricoEntradas.Count().ToString(), usuario.Id_Usuario, 3, null, new DateTime(2006, 08, 25), new DateTime(2009, 08, 26), new DateTime(2015, 08, 25)));
            usuario.HistoricoEntradas.Add(new Entradas(usuario.HistoricoEntradas.Count().ToString(), usuario.Id_Usuario, 3, null, new DateTime(2011, 08, 25), new DateTime(2009, 08, 26), new DateTime(2005, 08, 25)));

            return usuario;
        }
        
        public static User UsuarioTrabajador() {

            User usuario = new User
            {
                Id_Usuario = 3,
                Nombre = "roiston",
                Apellidos = "drhente",
                Email_Preferido = "ROISTON@DRHENTE.ES",
                Fecha_Nacimiento = new DateTime(1975, 08, 14),
                Sexo = true,
                DNI = "51229181T",
                Descuentos = new List<Descuento>(),
                Gestores = new List<Usuario_Gestor>(),
                HistoricoEntradas = new List<Entradas>()
            };

            usuario.Gestores.Add(new Usuario_Gestor(usuario.Id_Usuario, "gestorUCM"));
            return usuario;
        }

        public static User UsuarioTrabajadorAbono()
        {
            User usuario = new User
            {
                Id_Usuario = 4,
                Nombre = "sara",
                Apellidos = "lopez",
                Email_Preferido = "sarita@profeucm.es",
                Fecha_Nacimiento = new DateTime(1985, 08, 14),
                Sexo = false,
                DNI = "51229181T",
                Descuentos = new List<Descuento>(),
                Gestores = new List<Usuario_Gestor>(),
                HistoricoEntradas = new List<Entradas>()
            };
           

            usuario.Descuentos.Add(new Descuento
            {
                Id_Descuento = 3,
                Nombre = "Piscina de Verano",
                Descripcion = "Abono para pasar todo el verano",
                Cantidad = 1,
                Precio = 105,
                Num_Usos = 1,
                Unitario = true,
                Acumulable = false
            });

            usuario.Gestores.Add(new Usuario_Gestor(usuario.Id_Usuario, "gestorUCM"));
            return usuario;
        }

        public static User usuarioAlumniAbono10()
        {
            User usuario = new User
            {
                Id_Usuario = 6,
                Nombre = "gamo",
                Apellidos = "garcia",
                Email_Preferido = "gamo garcia",
                Fecha_Nacimiento = new DateTime(1985, 08, 14),
                Sexo = false,
                DNI = "51229181T",
                Descuentos = new List<Descuento>(),
                Gestores = new List<Usuario_Gestor>(),
                HistoricoEntradas = new List<Entradas>()
            };

            usuario.Descuentos.Add(new Descuento
            {
                Id_Descuento = 2,
                Nombre = "Abono de 10 usos",
                Descripcion = "Abono con 10 entradas",
                Cantidad = 1,
                Precio = 25,
                Num_Usos = 5,
                Unitario = true,
                Acumulable = false
            });

            usuario.Descuentos.Add(new Descuento
            {
                Id_Descuento = 3,
                Nombre = "Piscina de Verano",
                Descripcion = "Abono para pasar todo el verano",
                Cantidad = 1,
                Precio = 105,
                Unitario = true,
                Acumulable = false
            });
            usuario.HistoricoEntradas.Add(new Entradas(usuario.HistoricoEntradas.Count().ToString(), 3, null, usuario.Id_Usuario, new DateTime(2018, 08, 25), new DateTime(2009, 08, 26), new DateTime(2009, 08, 25)));

            usuario.Gestores.Add(new Usuario_Gestor(usuario.Id_Usuario, "gestorALUMNI"));
            return usuario;
        }
    }
}
