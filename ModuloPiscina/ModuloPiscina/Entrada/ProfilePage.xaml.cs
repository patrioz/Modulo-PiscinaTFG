using ModuloPiscina.Classes;
using ModuloPiscina.QR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModuloPiscina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilePage : ContentPage
	{
        private List<User> listaUsuarios;
  
        public ProfilePage ()
        {
            LlenarUsuarios();
            InitializeComponent();
            listaUsuariosDisponibles.ItemsSource = listaUsuarios;
        }

        private void UsuarioSeleccionado(Object sender, ItemTappedEventArgs e)
        {
            var option = (User)listaUsuariosDisponibles.SelectedItem;
            Navigation.PushAsync(new FirstPage(option));
        }

        private void LlenarUsuarios()
        {
            listaUsuarios = new List<User>();
            listaUsuarios.Add(UsuariosPrueba.UsuarioEstudiante());
            listaUsuarios.Add(UsuariosPrueba.UsuarioTrabajador());
            listaUsuarios.Add(UsuariosPrueba.UsuarioTrabajadorAbono());
            listaUsuarios.Add(UsuariosPrueba.usuarioAlumniAbono10());
        }

        public void cambioFechaUso(int? id_Responsable,string id_entrada )
        {
            int i = 0, j = 0;
            bool usuarioEncontrado = false, entradaEncontrada = false;
            List<Entradas> lista = new List<Entradas>();

            while (i < listaUsuarios.Count() && !usuarioEncontrado) {

                if (listaUsuarios.ElementAt(i).Id_Usuario == id_Responsable)
                {

                    lista = listaUsuarios.ElementAt(i).HistoricoEntradas;
                    usuarioEncontrado = true;
                }
                else i++;
            }

            while (j < lista.Count() && !entradaEncontrada) {

                if (lista.ElementAt(j).Id_Entrada == id_entrada)
                {
                    listaUsuarios.ElementAt(i).HistoricoEntradas.ElementAt(i).Fecha_Uso = DateTime.Now;
                    entradaEncontrada = true;
                }
                else j++;
            }
        }
    }

}