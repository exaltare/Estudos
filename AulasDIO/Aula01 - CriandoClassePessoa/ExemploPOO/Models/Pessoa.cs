using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get ; set ;}
        public int Idade {get ; set ;}
        public void Apresentar(){
            Console.WriteLine($"OLÁ MEU NOME É {Nome} e tenho {Idade} Anos ");
        }
                
    }
    
}