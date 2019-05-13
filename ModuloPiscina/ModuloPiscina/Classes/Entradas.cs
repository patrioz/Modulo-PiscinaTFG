using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloPiscina.Classes
{
    public class Entradas
    {
        public Entradas() {

            ListaPrecios = new Dictionary<string, string>()
            {
                { "NO UCM",  4.ToString() },
                { "UCM",  5.ToString() },
            };
        }

        public Entradas(DateTime ini, DateTime fin)
        {
            Fecha_Ini = ini;
            Fecha_Fin = fin;
        }

        public Entradas(string Id_entrada, int? Id_responsable, int? Id_Descuento, int? usos_descuento, DateTime fecha_Inicio, DateTime fecha_Fin, DateTime? fecha_uso)
        {
            Id_Entrada = Id_entrada;
            Id_Responsable = Id_responsable;
            Id_Descuento_Perteneciente = Id_Descuento;
            Num_Usos_Descuento_Perteneciente = usos_descuento;
            Fecha_Ini = fecha_Inicio;
            Fecha_Fin = fecha_Fin;
            Fecha_Uso = fecha_uso;

            // To String
            Fecha_Ini_String = "Fecha Reserva: " + Fecha_Ini.ToShortDateString();
            Fecha_Fin_String = "Fecha Fin:  " + Fecha_Fin.ToShortDateString();

            if (fecha_uso != null)
                Fecha_Uso_String = "Fecha Uso:  " + Fecha_Uso.ToString();
            else Fecha_Uso_String = "Fecha Uso: Sin uso ";

            Id_entrada_String = "Número Entrada  " + Id_entrada;
            Fecha_Entrada_String = Fecha_Ini.DayOfWeek + ", " + Fecha_Ini.Day + " de " + Fecha_Ini.Month + " de " + Fecha_Ini.Year;

            if (Id_Descuento_Perteneciente == 2)
                Tipo_Entrada_String = "Tipo Entrada:  Abono 10 Usos";
            else if (Id_Descuento_Perteneciente == 3)
                Tipo_Entrada_String = "Tipo Entrada:  Abono de Verano";
            else Tipo_Entrada_String = "Tipo Entrada: Sin Abono";

            ListaPrecios = new Dictionary<string, string>()
            {
                { "NO UCM",  4.ToString() },
                { "UCM",  5.ToString() },
            };
        }

        public string Id_Entrada { get; set; }
        public string Tipo_Entrada { get; set; }
        public Nullable<int> Id_Responsable { get; set; }
        public System.DateTime Fecha_Ini { get; set; }
        public System.DateTime Fecha_Fin { get; set; }
        public Nullable<System.DateTime> Fecha_Uso { get; set; }

        public Nullable<int> Id_Descuento_Perteneciente { get; set; }
        public Nullable<int> Num_Usos_Descuento_Perteneciente { get; set; }
        public Dictionary<string, string> ListaPrecios { get; set; }

        public string Fecha_Ini_String { get; set; }
        public string Fecha_Uso_String { get; set; }
        public string Fecha_Fin_String { get; set; }
        public string Id_entrada_String { get; set; }
        public string Tipo_Entrada_String { get; set; }
        public string Fecha_Entrada_String { get; set; }
    }
}
