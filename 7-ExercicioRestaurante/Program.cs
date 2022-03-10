using System;

namespace _7_ExercicioRestaurante
{
    internal class Program
    {

        public static string[] Nome;
        public static string[] Horario;
        public static int[] Idade;       
        public static double[] Valor;

        static void Main(string[] args)
        {
            //ETAPA 1->Gravar Nome , Horario , Idade , e Mesa
            //ETAPA 2->Alteracao de valores
            //ETAPA 3->Codicao Idade , incluir 5 mesas
            //ETAPA 4->Sorteio de 3 Pessoas com valor 0

            Console.WriteLine("QUANTAS QUANTAS MESAS SERÃO reservadas ?  ");
            int Quantidade = int.Parse(Console.ReadLine());

            //Mesa = new string[Quantidade];
            Nome = new string[Quantidade];
            Horario = new string[Quantidade];
            Idade = new int[Quantidade];
            Valor = new double[Quantidade];
                        
        }
        public static void Mesas(int Quantidade)
        {
            for (int i = 1; i <= Quantidade; i++)
            {
                Console.WriteLine($"DIGITE O NOME DO CLIENTE DA MESA {i} :");
                Nome[i - 1] = Console.ReadLine();

                Console.WriteLine($"DIGITE A IDADE DO CLIENTE {i} :");
                Idade[i - 1] = int.Parse(Console.ReadLine());

                DateTime HorarioAtual = new DateTime();
                Console.WriteLine(HorarioAtual);   
                

            }
            Console.WriteLine($"{Nome}, {Idade} ");
        }
    }
}
