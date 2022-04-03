using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{

   
    public class ContaBancaria

    {
        public ContaBancaria()
        {
        }

        public int Agencia { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public double Saldo { get; set; }

        public void Sacar()
        {

        } 

        public void Depositar()
        {
            
        }
        
        public ContaBancaria(int Agencia , int Numero , string Tipo , double Saldo)
        {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Tipo = Tipo;
            this.Saldo = Saldo;


        }
       
        
    }

}
