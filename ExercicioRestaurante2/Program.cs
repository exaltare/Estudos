using System;
using System.Collections.Generic;

namespace ExercicioRestaurante2
{
    internal class Program
    {
        //private static List<Produto> produtos = new List<Produto>();
        public static void Main(string[] args)
        {

            Menu();

            //    string OpcaoEscolhido = "S";

            //    do
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Escolha a Opção Desejada");
            //        Console.WriteLine("1 -CADASTRAR NOVO PRODUTO");
            //        Console.WriteLine("2 -LISTAR PRODUTOS");
            //        Console.WriteLine("S -SAIR");

            //        Console.Write("Opção Desejada");
            //        OpcaoEscolhido = Console.ReadKey().KeyChar.ToString().ToUpper();    
            //        //RedKey(ler apenas uma tecla) keychar(transformar em caracter // ToUpper ( para converter para maiuscula e minuscula

            //        switch (OpcaoEscolhido)
            //        {
            //            case "1":
            //                Console.Write("Nome do Produto");
            //                string NomeProduto = Console.ReadLine();
            //                Console.WriteLine("Qual o Valor do Produto");
            //                string PreçoProduto = Console.ReadLine();

            //                Produto novoProduto = new Produto(NomeProduto, Convert.ToDouble(PreçoProduto));
            //                produtos.Add(novoProduto);  //adiciona este novoproduto a listagem
            //                Console.WriteLine("Produto Cadastrado");
            //                break;



            //        }




            //    }






            //}
            static void Menu()
            {
                while (true)
                {




                    int Codigo;
                    int Quantidade;

                    Console.Write("   |======FOGUETE NAO TEM RE RESTAURANT=======|\n");
                    Console.Write("\n");
                    Console.WriteLine("  |CodProd--------Descrição-------------Valor  |");
                    Console.Write("\n  |1\t\t\tCERVEJA\t\t\tR$8,00   |");
                    Console.Write("\n  |2\t\t\tREFRIGERANTE\t\t\tR$5,00   |");
                    Console.Write("\n  |3\t\t\tWISKY\t\t\tR$115,00 |");
                    Console.Write("\n  |4                 AGUA               R$5,00   |");
                    Console.Write("\n  |5                CIGARRO             R$10,00  |");
                    Console.Write("\n");
                    Console.WriteLine("Codigo do produto :");

                    Codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"COD SELECIONADO {Codigo}");

                    while ((Codigo < 1) | (Codigo > 5))
                    {
                        Console.WriteLine("COD INCORRETO FAVOR DIGITAR UM CODIGO VALIDO");
                        Codigo = Convert.ToInt32(Console.ReadLine());
                    }

                }

            }



        }
    }
}



