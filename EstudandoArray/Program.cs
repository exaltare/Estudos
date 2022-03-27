using System;

namespace EstudandoArray
{
    internal class Program
    {

        static int qtd = 20;
        static int[] Numeral, Par, Impar;
        static int IndicePar = 0, IndiceImpar = 0; 

        static void Main(string[] args)
        {
            Numeral = new int[qtd];
            Random r = new Random();

            for (int i = 0; i < Numeral.Length; i++)
            {
                Numeral[i] = r.Next(1,100);
                if (r.Next(1,100)%2==0)
                {
                    IndicePar++;

                }
                else
                {
                    IndiceImpar++;
                }
            }
            Par = new int[IndicePar];
            Impar = new int[IndiceImpar];
            
            foreach(var item in Numeral)
            {
                if (item%2==0)
                {
                    Par[IndicePar - 1] = item;
                    IndicePar--;
                }
            }
            
            }

            


            

        }
    }
}
