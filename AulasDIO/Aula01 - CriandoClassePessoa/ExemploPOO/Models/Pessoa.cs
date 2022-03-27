using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get ; set ;}
        public int Idade {get ; set ;}
        public virtual void Apresentar(){    // metodo pode ser sobrescrito 
            Console.WriteLine($"OLÁ MEU NOME É {Nome} e tenho {Idade} Anos ");
        }
                
    }
    
}