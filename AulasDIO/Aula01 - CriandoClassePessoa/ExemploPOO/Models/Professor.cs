namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
        
        public override void Apresentar()
        {
            Console.WriteLine($"OLA MEU NOME É {Nome} e ganho  {Salario}");
        }

        
    }
}