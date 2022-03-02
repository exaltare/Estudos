using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AumentoSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int opcao;
            Console.WriteLine(">>>>>EXALTARE<<<<<");
            Console.WriteLine("ESCOLHA QUAL DESAFIO DESEJA ACESSAR : ");
            Console.WriteLine("[1] DESAFIO IDADE MÉDIA ");
            Console.WriteLine("[2] DESAFIO NUMERO PAR OU IMPAR ");
            Console.WriteLine("[3] DESAFIO MAIORIDADE");
            Console.WriteLine("[4] DESAFIO AUMENTO DE SALÁRIO");
            Console.WriteLine("[999] SAIR DO PROGRAMA ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    IdadeMedia();     //chamado do metodo
                    break;

                case 2:
                    Console.Clear();
                    ParOuImpar();      //chamada do metodo
                    break;

                case 3:
                    Console.Clear();
                    Maiores18Anos();
                    break;

                case 4:
                    Console.Clear();
                    Aumento();
                    break;


                case 999:
                    Console.WriteLine("OPCAO INVALIDA");
                    break;

                default:
                    Console.WriteLine("OPCAO INVALIDA");
                    break;

            }

        }
        public static void IdadeMedia()
        {
            {

                int indice;
                float total = 0;
                float[] idade = new float[4];

                for (indice = 0; indice < 4; indice++)
                {
                    Console.WriteLine("ENTRE COM A IDADE DO ALUNO", indice);
                    idade[indice] = float.Parse(Console.ReadLine());

                }

                Console.WriteLine("IDADES : ");
                for (indice = 0; indice < 4; indice++)
                {
                    Console.WriteLine(idade[indice]);
                    total += idade[indice];

                }
                Console.WriteLine("A IDADE MÉDIA DOS ALUNOS É  :  {0} ", total / 4);
            }
            Console.ReadKey();
        }

        public static void ParOuImpar()
        {
            int numero;

            Console.WriteLine("VERIFICAR SE O NUMERO É PAR OU IMPAR");
            Console.WriteLine("DIGITE O NUMERO PARA FAZER A VERIFICAÇÃO :");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O NUMERO {0} É PAR ", numero);
            }
            else
            {
                Console.WriteLine("O NUMERO {0} É IMPAR", numero);

            }
            Console.ReadKey();

        }

        public static void Maiores18Anos()
        {

            int NumeroPessoas, idade;
            int i = 0;
            int maioridade = 0;
            double IdadesTotal = 0;

            Console.WriteLine("QUAL A QUANTIDADE DE PESSOAS QUE DESEJA COMPARAR : ");
            NumeroPessoas = int.Parse(Console.ReadLine());
            int[] numero = new int[NumeroPessoas];

            while (i < NumeroPessoas)
            {

                i = i + 1;
                Console.WriteLine("QUAL A IDADE DA {0}ª PESSOA ", i);
                idade = int.Parse(Console.ReadLine());
                IdadesTotal += idade;

                if (idade >= 18)
                {
                    maioridade = maioridade + 1;

                }
            }
            Console.WriteLine(" ||||||DADOS COLETADOS|||||| ");
            Console.WriteLine("TOTAL DE DADOS COLETADO {0} : ", NumeroPessoas);
            Console.WriteLine("NO TOTAL {0} PESSOAS SÃO MAIORES DE IDADE ", maioridade);
            Console.WriteLine("A MEDIA DE IDADE É DE {0}", IdadesTotal / NumeroPessoas);
        }

        public static void Aumento()
        {
            double salario = 0;
            double aumento = 0;
            int quantidade;
            string[] ListaFuncionarios;

            Console.WriteLine("Quantos funcionarios deseja calcular ?");
            quantidade = int.Parse(Console.ReadLine());
            ListaFuncionarios = new string[quantidade];

            Console.Clear();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("DIGITE O NOME DO FUNCIONARIO ");
                string NomeFuncionario = Console.ReadLine();

                Console.WriteLine("QUAL O VALOR DO SALARIO DO FUNCIONÁRIO ? ");
                salario = double.Parse(Console.ReadLine());

                if (salario <= 300)
                {
                    aumento = ((0.50 * salario) + salario);
                }
                else
                {
                    aumento = ((0.30 * salario) + salario);
                }

                ListaFuncionarios[i] = ("O " + NomeFuncionario + " com o Salario R$ " + salario + " , Passará a ganhar R$ " + aumento + " por mês ");

            }

            for (int i = 0; i < ListaFuncionarios.Length; i++)
            {
                Console.WriteLine(ListaFuncionarios[i]);
            }
        }
    }
}
