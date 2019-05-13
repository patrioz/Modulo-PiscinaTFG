using ModuloPiscina.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloPiscina.ViewModel
{
    class EntradasViewModel
    {
        private Entradas entrada;

        public EntradasViewModel(Entradas entr) {
            this.entrada = entr;
        }

        public string Tipo_Entrada_String
        {
            get { return entrada.Tipo_Entrada_String; }
        }

        public string Fecha_Ini_String
        {
            get { return entrada.Fecha_Ini_String; }
        }

        public string Fecha_Fin_String
        {
            get { return entrada.Fecha_Fin_String; }
        }

        public string Id_entrada_String
        {
            get { return entrada.Id_entrada_String; }
        }

        public string Fecha_Uso_String {

            get { return entrada.Fecha_Uso_String;  }
        }
    }
}
