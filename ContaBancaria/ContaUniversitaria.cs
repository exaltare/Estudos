using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaUniversitaria : ContaBancaria

    {
        public double Saldo
        {
            get; set;

        }
        public ContaUniversitaria() : base()
        {
            
        }
        public ContaUniversitaria(int Agencia, int Numero, string Tipo, double Saldo) : base(Agencia, Numero, Tipo, Saldo)

        {

            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Tipo = Tipo;
            this.Saldo = Saldo;
        }
        public void  Sacar(double valor)

        {
            if(valor < 500 )
            {
                this.Saldo =  this.Saldo - valor;
                
            }
        }

    }
}
