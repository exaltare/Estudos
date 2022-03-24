namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double Comprimento;
        private double Largura;
        private bool Valido;

        public void DefinirMedidas(double Comprimento , double Largura)   //recebimento de dois paramentros
        {
          
          if (Comprimento > 0 && Largura > 0)
          {
            // atributo que vai receber como parametro para os atributos privados da classe Retangulo
            this.Comprimento = Comprimento;
            this.Largura = Largura; 
            Valido = true;

          }else 
          {
              System.Console.WriteLine("Valores Invalidos");

          } 
        }
        public double ObterArea()
        {
            if (Valido)
            {
                return Comprimento * Largura;
            }
            else
            {
                System.Console.WriteLine("Preencha valores válidos");
                return 0;
                
            }
               
        }
    }
}