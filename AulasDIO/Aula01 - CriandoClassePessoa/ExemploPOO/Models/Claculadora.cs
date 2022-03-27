using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Claculadora : ICalculadora
    {
        // public int Dividir(int num1, int num2)
        // {
        //     return num1 / num2;
        // }

        public int Multiplar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1 , int numm2)
        {
            return num1 + numm2;
            
        }

        // public int Somar(int num1 , int numm2 , int num3)
        // {
        //     return num1 + numm2 + num3;
            
        // }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}