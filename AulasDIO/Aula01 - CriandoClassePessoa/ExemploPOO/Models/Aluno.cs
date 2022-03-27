namespace ExemploPOO.Models
{
    public class Aluno : Pessoa    // realizado uma heranca da classe Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"OLA MEU NOME É {Nome} e sou um aluno nota {Nota}");
        }


        
        
    }
}