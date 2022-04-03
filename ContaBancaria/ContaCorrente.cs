using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaCorrente : ContaBancaria
    {
        public string CartaoCredito { get; set; }

        public ContaCorrente(int Agencia, int Numero, string Tipo, double Saldo) : base(Agencia, Numero, Tipo, Saldo)       
        {
            this.Tipo = "Conta Corrente";
          
        }
        
    }
}
