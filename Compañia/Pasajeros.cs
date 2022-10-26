using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia
{
    public class Pasajeros : Persona
    {
        private bool esPremium;
        private Pasaporte numPasaporte;
        private Equipajes equipajes;

        public Pasajeros() : base(" ", " ", 0, 0)
        {
            this.numPasaporte = null;
            this.equipajes = null;
            this.esPremium = false;
        }
        public Pasajeros(string nombre, string apellido, int edad, int dni, bool esPremium, Pasaporte numPasaporte, Equipajes equipajes) : base(nombre, apellido, edad, dni)
        {
            this.esPremium = esPremium;
            this.numPasaporte = numPasaporte;
            this.equipajes = equipajes;
        }

        public Pasaporte Pasaporte
        {
            get
            {
                return this.numPasaporte;
            }
            set
            {
                this.numPasaporte = value;
            }
        }
        public virtual Equipajes Equipaje
        {
            get
            {
                return this.equipajes;
            }
            set
            {
                this.equipajes = value;
            }
        }

        public bool EsPremium
        {
            get
            {
                return this.esPremium;
            }
            set
            {
                this.esPremium = value;
            }
        }

        public static bool operator ==(Pasajeros pj1, Pasajeros pj2)
        {
            bool isOk = false;
            if (!(pj1 is null || pj2 is null))
            {
                isOk = (pj1.numPasaporte == pj2.numPasaporte);
            }

            return isOk;
        }

        public static bool operator !=(Pasajeros pj1, Pasajeros pj2)
        {
            return !(pj1 == pj2);
        }
        
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos Pasajero: \n" +
                          $"Nombre: {this.nombre}\n" +
                          $"Apellido: {this.apellido}\n" +
                          $"Edad: {this.edad}\n" +
                          $"Num Pasaporte: {this.numPasaporte.ToString()}\n" +
                          $"Equipaje: {this.equipajes.ToString()}");

            return sb.ToString();
        }
        
        public override string ToString()
        {
            return this.Mostrar();
        }

        public static implicit operator string(Pasajeros p)
        {
            return p.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool isOk = false;
            if (obj is Pasajeros)
            {
                isOk = this == ((Pasajeros)obj);
            }
            return isOk;
        }
    }
}
