using System;

namespace _6_50PrimeirosElementos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerador = 1000;
            int denominador = 1;
            int resultado =0;


            // testar os pares dos impares 


            for (denominador = 1; denominador < 50; denominador++)
            {
                             
                
                numerador = numerador - 3;
                resultado = (numerador / denominador) * ((-1) ^ (denominador - 1));

            }
            Console.WriteLine($"O RESULTADOS É {resultado}");

        }
    }
}
