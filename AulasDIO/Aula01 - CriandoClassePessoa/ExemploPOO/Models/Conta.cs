namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;  //protected para somente a propria classe e //  a classe filha pode acessar 
                               
        public abstract void Creditar();

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu Saldo é :" + saldo); 
    }
    
}