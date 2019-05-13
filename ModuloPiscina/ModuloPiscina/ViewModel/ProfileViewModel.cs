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

        public string Nombre
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

        public string Fecha_ini_nuevo
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

        public string Apellido
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

        public string Email
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

        public string Sexo
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

        public string FechaNacimiento
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

        public string DNI
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
    }
}
    