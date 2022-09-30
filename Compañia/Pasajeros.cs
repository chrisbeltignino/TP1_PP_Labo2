using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia
{
    public class Pasajeros
    {
        private string nombre;
        private string apellido;
        private int edad;
        private Pasaporte numPasaporte;
        private Equipajes equipajes;

        public Pasajeros(string nombre, string apellido, int edad, Pasaporte numPasaporte, Equipajes equipajes)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.numPasaporte = numPasaporte;
            this.equipajes = equipajes;
        }

        public virtual int DniPasajero
        {
            get
            {
                return this.numPasaporte.Dni;
            }
        }

        public virtual Pasaporte Pasaporte
        {
            get
            {
                return this.numPasaporte;
            }
        }

        public static bool operator ==(Pasajeros pj1, Pasajeros pj2)
        {
            bool equals = false;
            if (!(pj1 is null || pj2 is null))
            {
                equals = (pj1.numPasaporte == pj2.numPasaporte);
            }

            return equals;
        }

        public static bool operator !=(Pasajeros pj1, Pasajeros pj2)
        {
            return !(pj1 == pj2);
        }

        protected virtual string Mostrar()
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
