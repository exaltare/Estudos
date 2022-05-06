using System.ComponentModel.DataAnnotations;

namespace Contatos.Model
{
    public class DadosModel
    { 
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }



    }
}
