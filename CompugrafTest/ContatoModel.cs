using System.ComponentModel.DataAnnotations;

namespace CompugrafTest
{
    public class ContatoModel
    {
        [Key]   
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string Nacionalidade { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


    }
}