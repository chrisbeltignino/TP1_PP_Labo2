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

        public static bool operator ==(Pasaporte p1, Pasaporte p2)
        {
            bool isOk = false;
            if (p1 == p2)
            {
                isOk = true;
            }
            return isOk;
        }
    }
}
