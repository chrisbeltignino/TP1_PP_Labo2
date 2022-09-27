using System;

namespace Usuarios
{
    public class Usuario
    {
        #region ATRIBUTOS
        private string nombreUsuario;
        private string contraseña;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Usuario(string nomUsua, string contra)
        {
            this.nombreUsuario = nomUsua;
            this.contraseña = contra;
        }
        #endregion CONSTRUCTOR

        #region PROPIEDAD
        private string NombreUsuario
        {
            get
            {
                return this.nombreUsuario;
            }
        }
        #endregion PROPIEDAD

        public static string Mostrar(Usuario usuario)
        {
            return usuario.NombreUsuario;
        }

        #region SOBRECARGA
        public static bool operator ==(Usuario usuarioX, Usuario usuarioY) 
        {
            bool isOk = false;
            {
                if (!(usuarioX is null) || (usuarioY is null))
                {
                    if ((usuarioX.nombreUsuario == usuarioY.nombreUsuario) && (usuarioX.contraseña == usuarioY.contraseña))
                    {
                        isOk = true;
                    }
                }
                return isOk;
            }
        }

        public static bool operator !=(Usuario usuarioX, Usuario usuarioY) //compara por el operador != dos usuarios
        {
            return !(usuarioX == usuarioY);
        }
        #endregion SOBRECARGA
    }
}
