using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresoDeNumerosYParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar el algoritmo que nos permita introducir 10 números por teclado y nos informe, por cada uno, si es par o impar. 
            //Como información adicional, nos debe indicar el total de números pares y el total de números impares.


            Console.WriteLine("ingrese 10 numeros:");

            int a, b, c, i;

            b = 0;
            c = 0; 
            for (i = 1; i <= 10; i++) 
            {
                a = Convert.ToInt32(Console.ReadLine());

                if (a %2== 0)
                {
                    b = b + 1;

                    Console.WriteLine(a + " es par");

                }
                if (a %2!= 0)
                {
                    c = c + 1;
                    Console.WriteLine(a + " es impar");
                }

            }
            Console.WriteLine("La cantidad de numeros pares es de: " + b);
            Console.WriteLine("La cantidad de numeros impares es de: " + c);

            Console.ReadKey();
        }
    }
}
