using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ModuloPiscina
{
    public class ProfileViewModel : BindableObject
    {
        private User usuario;

        public ProfileViewModel(User user)
        {
            this.usuario = user;
        }

        public string Nombre1
        {

            get { return usuario.Nombre; }

            set
            {
                if (usuario.Nombre != value)
                {
                    usuario.Nombre = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Apellido1
        {

            get { return usuario.Apellidos; }

            set
            {
                if (usuario.Apellidos != value)
                {
                    usuario.Apellidos = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email1
        {

            get { return usuario.Email_Preferido; }

            set
            {
                if (usuario.Email_Preferido != value)
                {
                    usuario.Email_Preferido = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Sexo1
        {

            get
            {
                if (usuario.Sexo == false)
                    return "M";
                else if (usuario.Sexo == true)
                    return "H";
                else return "Sin Sexo";
            }

            /*set
            {
                if (usuario.Sexo != value)
                {
                    usuario.Nombre = value;
                    OnPropertyChanged();
                }
            }*/
        }

        public string FechaNacimiento1
        {

            get { return usuario.Fecha_Nacimiento.ToShortDateString(); }

            set
            {
                /*if (usuario.Fecha_Nacimiento != value)
                {
                    usuario.Nombre = value;
                    OnPropertyChanged();
                }*/
            }
        }

        public string DNI1
        {

            get { return usuario.DNI; }
        }

        public string Telefono1
        {

            get { return usuario.Telefono; }

            set
            {
                /*if (usuario.Fecha_Nacimiento != value)
                {
                    usuario.Nombre = value;
                    OnPropertyChanged();
                }*/
            }
        }

        public string Tipo_Estudiante
        {
            get { return usuario.Tipo_Estudiante; }
        }
    }
}
    