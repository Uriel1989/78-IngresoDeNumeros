using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresoDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer 20 números enteros positivos, indicar cuál es el mayor y en qué orden fue leído
            //(a que elemento pertenece).Mostrar el vector completo.
            int[] array = new int[20];

            array[00] = 12;
            array[01] = 13;
            array[02] = 09;
            array[03] = 08;
            array[04] = 45;
            array[05] = 50;
            array[06] = 14;
            array[07] = 18;
            array[08] = 20;
            array[09] = 25;
            array[10] = 41;
            array[11] = 23;
            array[12] = 25;
            array[13] = 31;
            array[14] = 99;
            array[15] = 88;
            array[16] = 75;
            array[17] = 43;
            array[18] = 45;
            array[19] = 52;

            int posicion;

            int mayor = array[00];

            for (posicion=0; posicion < array.Length; posicion++)
            {
                Console.WriteLine("En la posicion " + posicion + " esta: " + array[posicion]);
            }

            for (int i= 0; i<20; i++)
            {
                if (array[i] > mayor)
                {
                    mayor = array[i];
                }
            }

            Console.WriteLine("El mayor es: " + mayor);

            Console.ReadKey();
        }
    }
}
