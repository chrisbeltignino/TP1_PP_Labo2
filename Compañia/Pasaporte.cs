using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia
{
    public class Pasaporte
    {
        private string numPasaporte;
        private string nacionalidad;
        private int dni;
        private Sexo sexo;
        private DateTime vencimiento;

        public Pasaporte(string numPasaporte, string nacionalidad, int dni, Sexo sexo, DateTime vencimiento)
        {
            this.numPasaporte = numPasaporte;
            this.nacionalidad = nacionalidad;
            this.dni = dni;
            this.sexo = sexo;
            this.vencimiento = vencimiento;
        }

        public string Sexo
        {
            get
            {
                return this.sexo.ToString();
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public static bool operator ==(Pasaporte p1, Pasaporte p2)
        {
            bool isOk = false;
            if (!(p1 is null || p2 is null))
            {
                isOk = (p1.numPasaporte == p2.numPasaporte);
            }
            return isOk;
        }

        public static bool operator !=(Pasaporte p1, Pasaporte p2)
        {
            return !(p1 == p2);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pasaporte: \n" +
                          $"Numero {this.numPasaporte} \n" +
                          $"DNI {this.dni} \n" +
                          $"Nacionalidad {this.nacionalidad} \n" +
                          $"Sexo {this.sexo} \n" +
                          $"Fecha Venc: {this.vencimiento}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool isOk = false;
            if (obj is Pasaporte)
            {
                isOk = this == ((Pasaporte)obj);
            }
            return isOk;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
