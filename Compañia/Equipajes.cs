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
