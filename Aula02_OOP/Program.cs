using System;

namespace Aula02_OOP
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("APRENDENDO OOP");

            Conta conta1 = new Conta();   //Para criar um objeto, voce precisa criar uma instancia da class Conta (conta1 é uma variavel) 

            Conta conta2 = new Conta();   //Para criar um objeto, voce precisa criar uma instancia da class Conta (conta1 é uma variavel) 


            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;


            conta2.Saldo = 2500;
            conta2.Limite = 700;
            conta2.Numero = 456;

            Console.WriteLine("Olá o Seu Saldo é : " + conta1.Saldo);
            Console.WriteLine("Limite : " + conta1.Limite);
            Console.WriteLine("O Numero da Conta é : " + conta1.Numero);



            Console.WriteLine("Olá o Seu Saldo é : " + conta2.Saldo);
            Console.WriteLine("Limite : " + conta2.Limite);
            Console.WriteLine("O Numero da Conta é : " + conta2.Numero);





        }
    }
}
