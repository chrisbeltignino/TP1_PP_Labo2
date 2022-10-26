using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia
{
    public class Premium : Pasajeros
    {
        /*
        public Premium() : base(" ", " ", -1, null, null)
        {

        }*/
        public Premium(string nombre, string apellido, int edad, int dni, bool esPremium, Pasaporte numPasaporte, Equipajes equipajes) : base(nombre, apellido, edad, dni, esPremium, numPasaporte, equipajes)
        {
        }
        public static bool operator ==(Premium pjp, Pasajeros pj)
        {
            bool isOk = false;
            if (!(pjp is null || pj is null))
            {
                isOk = (pj == (Pasajeros)pjp);
            }

            return isOk;
        }
        public static bool operator !=(Premium pjp, Pasajeros pj)
        {
            return !(pjp == pj);
        }

        public static bool operator ==(Premium pjp1, Premium pjp2)
        {
            bool isOk = false;
            if (!(pjp1 is null || pjp2 is null))
            {
                isOk = ((Pasajeros)pjp1 == (Pasajeros)pjp2);
            }

            return isOk;
        }
        public static bool operator !=(Premium pjp1, Premium pjp2)
        {
            return !(pjp1 == pjp2);
        }
        public override bool Equals(object obj)
        {
            bool isOk = false;
            if (obj is Premium)
            {
                isOk = this == ((Premium)obj);
            }
            return isOk;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("| Premium");
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        }
    }
}
