using System;

namespace Desafio_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador;
            

            Console.WriteLine("QUAL O FATORIA DESEJA CALCULAR ? ");
            numero = int.Parse(Console.ReadLine());
            contador = numero;

            double fatorial = 1;
            while (contador != 1)
            {
                fatorial = fatorial * contador;
                contador -= 1;

            }
            Console.WriteLine($"O FATORIAL DE {numero} é {fatorial}");


            //double i, fatorial, num;
            //Console.WriteLine("Qual o Fatorial Deseja Calcular ? ");
            //num = double.Parse(Console.ReadLine());

            //fatorial = num;

            //for (i = num - 1 ; i >= 1; i--)
            //{
            //    fatorial = fatorial * i;

            //}
            //Console.WriteLine($"O Fatorial de {num} é {fatorial}");





        }
    }
}
