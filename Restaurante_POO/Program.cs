//ETAPA 1->Gravar Nome , Horario , Idade , e Mesa
//ETAPA 2->Alteracao de valores
//ETAPA 3->Codicao Idade , incluir 5 mesas
//ETAPA 4->Sorteio de 3 Pessoas com valor 0

using System;
using System.Collections.Generic;

namespace Restaurante_POO
{
      internal class Program
    {
        public static List<ReservaMesa> ListadeMesas = new();
        static void Main(string[] args)
        {
            string Nome;
            int idade , Numeromesas , mesa =0 ;
            double Consumo;
            
            //PREENCHIMENTO DAS INFORMAÇÕES

            Console.WriteLine("QUANTAS MESAS PARA ESTE EVENTO ");
            Numeromesas = int.Parse(Console.ReadLine());

            for (int i = 0; i < Numeromesas; i++)

            {
                mesa++;
                Console.WriteLine("QUAL O NOME DO CLIENTE : ");
                Nome = Console.ReadLine();
                Console.WriteLine("QUAL A IDADE DO CLIENTE : ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("QUAL O CONSUMO DO CLIENTE :");
                Consumo = double.Parse(Console.ReadLine());

                Console.Clear();
                ReservaMesa Reserva1 = new ReservaMesa(mesa, Nome, idade, Consumo);
                ListadeMesas.Add(Reserva1);
            } 
        }
        static void ListaMesas()
        {
            foreach (var item in ListadeMesas)
            {
                Console.WriteLine($"{item.NumeroMesa} Ocupada por {item.Nome} ");
            }

        }
    }
}
