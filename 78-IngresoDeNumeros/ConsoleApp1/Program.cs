using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados dos vectores A y B de 30 elementos enteros 
            //generar un vector C que contenga la suma de los elementos de A y B.

            int []A = new int[30] { 10, 2, 25, 32, 20, 12, 21, 12, 15, 67, 26, 42, 14, 11, 54, 28, 1, 7, 3, 6, 3, 4, 68, 99, 39, 67, 87, 88, 24, 45 };

            int[] B = new int[30] { 12, 21, 20, 16, 32, 44, 23, 15, 18, 60, 20, 23, 16, 20, 70, 32, 2, 10, 12, 8, 12, 20, 36, 99, 41, 33, 25, 12, 16, 31 };

            int[] C = new int[30];

            for (int i =0; i<30; i++)
            {
                C[i] = A[i] + B[i];

                Console.WriteLine("La resultado en la posicion " + i + " es: " + C[i]);
            }

            Console.ReadKey();
        }
    }
}
