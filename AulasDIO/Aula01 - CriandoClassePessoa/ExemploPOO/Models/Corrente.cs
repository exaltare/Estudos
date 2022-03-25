namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)    //sobrescrevi o metodo 
        {
            base.saldo = valor;                 //base mostra atributo pertence a classe pai 
        }
    }
}