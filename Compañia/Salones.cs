using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia
{
    public class Salones
    {
        private int piscinas;
        private int comedores;
        private int casinos;
        private int salonBaile;

        public Salones()
        {
            this.piscinas = 0;
            this.comedores = 1;
            this.casinos = 0;
            this.salonBaile = 0;

        }

        public Salones(int casinos) : this()
        {
            this.casinos = casinos;
        }

        public Salones(int casinos, int piscinas, int salonBaile) : this(casinos)
        {
            this.piscinas = piscinas;
            this.salonBaile = salonBaile;
        }

        public Salones(int casinos, int piscinas, int salonBaile, int comedores) : this(casinos, piscinas, salonBaile)
        {
            this.comedores = comedores;
        }
        /*
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Salones del Crucero:");
            sb.AppendLine($"Comedores {this.comedores}; Casinos {this.casinos}; Piscinas {this.piscinas}; Salones de Baile {this.salonBaile}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        */
    }
}
