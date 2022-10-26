using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia
{
    public class Equipajes
    {
        private bool bolsoMano;
        private int cantValijas;
        private double pesoTotal;

        public Equipajes() : this(false, -1, -1) { }

        public Equipajes(bool bolsoMano, int cantValijas, float pesoTotal)
        {
            this.bolsoMano = bolsoMano;
            this.cantValijas = cantValijas;
            this.pesoTotal = pesoTotal;
        }

        public string Bolso
        {
            get
            {
                string bolso = "No";
                if (bolsoMano == true)
                {
                    bolso = "Si";
                }
                return bolso;
            }
        }

        public bool BolsoMano
        {
            set
            {
                this.bolsoMano = value;
            }
        }
        public double KgValija
        {
            get
            {
                return this.pesoTotal;
            }
            set
            {
                this.pesoTotal = value;
            }
        }

        public int CountValijas
        {
            get
            {
                return this.cantValijas;
            }
            set
            {
                this.cantValijas = value;
            }
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Equipaje: \n" +
                          $"Bolso de mano: {this.Bolso}\n" +
                          $"Peso de valijas: {this.pesoTotal}kg\n" +
                          $"Cantidad de valijas {this.cantValijas}\n");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
