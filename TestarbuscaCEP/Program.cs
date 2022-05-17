using System;
using DocumentValidator;

namespace TestarbuscaCEP
{
    internal class Program
    {
        static void Main(string[] args)
                      
        
        {
            string CPF ;
            Console.WriteLine("POR FAVOR ENTRE COM O NUMERO DO CPF PARA VALIDAÇÃO");
            CPF = Convert.ToString(Console.ReadLine());

            if (CpfValidation.Validate(CPF))
                Console.WriteLine("CPF Válido!");
            else
                Console.WriteLine("CPF Inválido!");

        }


            
    }
    
}
