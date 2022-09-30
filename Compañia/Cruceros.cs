using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia
{
    public class Cruceros
    {
        private string matricula;
        private string nombre;
        private int camarotes;
        private double bodega;
        private Salones salones;
        private List<Pasajeros> pasajeros;

        private Cruceros()
        {
            this.pasajeros = new List<Pasajeros>();
        }

        public Cruceros(string matricula, string nombre, int camarotes, float bodega, Salones salones) : this()
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.camarotes = camarotes;
            this.bodega = bodega;
            this.salones = salones;
        }

        public static explicit operator int(Cruceros c)
        {
            return c.camarotes;
        }

        public static explicit operator double(Cruceros c)
        {
            return c.bodega;
        }

        public string Matricula
        {
            get
            {
                return this.matricula;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public static bool operator ==(Cruceros c, Pasajeros p)
        {
            bool isOk = false;
            if (!(c is null || p is null))
            {
                isOk = (c.pasajeros.Contains(p));
            }
            return isOk;
        }
        public static bool operator !=(Cruceros c, Pasajeros p)
        {
            return !(c == p);
        }

        public static bool operator ==(Cruceros c1, Cruceros c2)
        {
            bool isOk = false;
            if (!(c1 is null || c2 is null))
            {
                isOk = c1.matricula == c2.matricula;
            }
            return isOk;
        }

        public static bool operator !=(Cruceros c1, Cruceros c2)
        {
            return !(c1 == c2);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool isOk = false;
            if (obj is Cruceros)
            {
                isOk = this == ((Cruceros)obj);
            }
            return isOk;
        }

        public static Cruceros operator +(Cruceros c, Pasajeros p)
        {
            if (c != p)
            {
                c.pasajeros.Add(p);
            }

            return c;
        }

        public static Cruceros operator -(Cruceros c, Pasajeros p)
        {
            if (c == p)
            {
                c.pasajeros.Remove(p);
            }

            return c;
        }
    }


}
