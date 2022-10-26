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

        public Cruceros()
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
            set
            {
                this.matricula = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public Salones SalonesDelCrucero
        {
            get
            {
                return this.salones;
            }
            set
            {
                this.salones = value;
            }
        }

        public int Camarotes
        {
            get
            {
                return (int)this;
            }
            set
            {
                this.camarotes = value;
            }
        }

        public double Bodega
        {
            get
            {
                return (double)this;
            }
            set
            {
                this.bodega = value;
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

        public List<Pasajeros> Pasajeros
        {
            get
            {
                return this.pasajeros;
            }
            set
            {
                if (this.pasajeros.Count == 0)
                {
                    this.pasajeros = value;
                }
            }
        }

        public int Count
        {
            get
            {
                return this.pasajeros.Count;
            }
        }

        public static int PasajeroMasFrecuente(Pasajeros p, Cruceros c)
        {
            int count;
            bool flag = true;
            int max = 0;
            int i = 0;
            foreach (Pasajeros item in c.Pasajeros)
            {
                count = 0;
                if (p == c.Pasajeros[i])
                {
                    count++;
                }
                if (flag || count > max)
                {
                    flag = false;
                    max = count;
                }

                i++;
            }

            return max;
        }

        public static Cruceros ObtenerCrucero(string nombre, List<Cruceros> list)
        {
            Cruceros aux = new Cruceros();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Nombre == nombre)
                {
                    aux = list[i];
                    break;
                }
            }
            return aux;
        }

        public Pasajeros BuscarPasajeroDni(int dni)
        {
            Pasajeros aux = null;
            foreach (Pasajeros item in this.pasajeros)
            {
                if (item.DNI == dni)
                {
                    aux = item;
                    break;
                }
            }
            return aux;
        }

        public static bool ActualizarCrucero(Cruceros crucero, List<Cruceros> list)
        {
            bool isOk = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (crucero == list[i])
                {
                    list[i] = crucero;
                    isOk = true;
                    break;
                }
            }

            return isOk;
        }
    }


}
