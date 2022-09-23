using System;

namespace Usuarios
{
    public class Usuario
    {
        private string nombreUsuario;
        private string contraseña;

        public Usuario(string nomUsua, string contra)
        {
            this.nombreUsuario = nomUsua;
            this.contraseña = contra;
        }

    }
}
