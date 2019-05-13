using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloPiscina.Classes
{
    public class Usuario_Gestor
    {
 
        public Usuario_Gestor(int id_Usuario, string grupo)
        {
            Id_Usuario = id_Usuario;
            Grupo = grupo;
        }

        public int Id_Usuario { get; set; }
        public string Grupo { get; set; }
    }
}
