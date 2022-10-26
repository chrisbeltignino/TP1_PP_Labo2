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
        private Sexo sexo;

        public Pasaporte() : this(" ", " ", global::Sexo.Vacio) { }

        public Pasaporte(string numPasaporte, string nacionalidad, Sexo sexo)
        {
            this.numPasaporte = numPasaporte;
            this.nacionalidad = nacionalidad;
            this.sexo = sexo;        
        }

        public string Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        public string NumeroPasaporte
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

        public string Sexo
        {
            get
            {
                return this.sexo.ToString();
            }
            set
            {
                if (!(string.IsNullOrEmpty(value)))
                {
                    switch (value)
                    {
                        case "NoBinario":
                            this.eSexo = global::Sexo.Otro;
                        break;
                        case "Masculino":
                            this.eSexo = global::Sexo.Masculino;
                        break;
                        case "Femenino":
                            this.eSexo = global::Sexo.Femenino;
                        break;
                    }
                }
            }
        }

        public Sexo eSexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
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
                          $"Nacionalidad {this.nacionalidad} \n" +
                          $"Sexo {this.sexo}");

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
