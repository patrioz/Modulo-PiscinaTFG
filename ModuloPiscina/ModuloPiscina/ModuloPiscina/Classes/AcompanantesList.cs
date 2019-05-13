using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ModuloPiscina.Classes
{
    class AcompanantesList : INotifyPropertyChanged
    {
        public AcompanantesList(Entradas _entrada)
        {
            Entrada = _entrada;
        }

        public Entradas Entrada { get; set; }
        public List<string> ValoresPicker { get; set; } = new List<string>() { "UCM", "NO UCM" };

        public event PropertyChangedEventHandler PropertyChanged;

        string _valorseleccionado;
        public string _cantidad;

        public string ValorSeleccionado
        {
            get { return _valorseleccionado; }

            set {
                _valorseleccionado = value;
                Entrada.ListaPrecios.TryGetValue(_valorseleccionado, out _cantidad);
                OnPropertyChanged("Cantidad");
            }
        }

        public string Cantidad
        {
            get { return _cantidad; }

            set { _cantidad = value; }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
