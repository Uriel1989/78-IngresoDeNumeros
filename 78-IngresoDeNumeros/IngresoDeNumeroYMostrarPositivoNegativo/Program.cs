using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresoDeNumeroYMostrarPositivoNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar el algoritmo que nos permita introducir 10 números por teclado 
            //y nos informe, por cada uno, si es positivo o negativo.

            Console.WriteLine("Ingrese 10 numeros:");

            int[] ingresos = new int[10];

            for (int i=0; i <10; i++)
            {
                ingresos[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i=0; i<10; i++)
            {
                if (ingresos[i] > 0)
                {
                    Console.WriteLine("El numero: " + ingresos[i] + " es positivo");
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (ingresos[i] < 0)
                {
                    Console.WriteLine("El numero: " + ingresos[i] + " es negativo");
                }
            }
                Console.ReadKey();
        }
    }
}
