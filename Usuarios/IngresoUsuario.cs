using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public class IngresoUsuario
    {
        private List<Usuario> usuario;

        public IngresoUsuario()
        {
            usuario = new List<Usuario>();
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Operadores: ");
            foreach (Usuario item in usuario)
            {
                sb.AppendLine(Usuario.Mostrar(item));
            }

            return sb.ToString();
        }

        private int Indice(Usuario usuario)
        {
            int index = -1;
            for (int i = 0; i < this.usuario.Count; i++)
            {
                if (usuario == this.usuario[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public string MostrarOperadores
        {
            get
            {
                return this.Mostrar();
            }
        }

        public static bool operator ==(IngresoUsuario op, Usuario usuario)
        {
            return op.Indice(usuario) > -1;
        }

        public static bool operator !=(IngresoUsuario op, Usuario usuario)
        {
            return !(op.Indice(usuario) > -1);
        }

        public static IngresoUsuario operator +(IngresoUsuario op, Usuario usuario)
        {
            if (op != usuario)
            {
                op.usuario.Add(usuario);
            }

            return op;
        }

        public int Count
        {
            get
            {
                return this.usuario.Count;
            }
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj is IngresoUsuario)
            {
                equals = this == ((IngresoUsuario)obj);
            }
            return equals;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
