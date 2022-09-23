using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 numero;
            Int32 contador = 0;
            Int32 minimo = 0;
            Int32 maximo = 0;
            Int32 acumulador = 0;
            float promedio;

            for(int i=0; i<5; i++)
            {
                Console.Write("Ingresar 5 numeros: ");
                numero = int.Parse(Console.ReadLine());

                acumulador += numero;
                contador++;

                if(numero > maximo)
                {
                    maximo = numero;
                }
                if(numero < minimo)
                {
                    minimo = numero;
                }
            }
            promedio = (float)(acumulador / contador);

            Console.WriteLine("Minimo: {0}, Maximo: {1}, Promedio: {2}", minimo, maximo, promedio);
            Console.ReadLine();
        }
    }
}
