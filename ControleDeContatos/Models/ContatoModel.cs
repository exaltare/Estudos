using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do Contato!")]                  //Required para obrigar a digitação do campo 
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Sobrenome do Contato!")]               //Required para obrigar a digitação do campo 
        [StringLength(50)]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Digite o CPF !")]        
        [StringLength (14)]
        public string CPF { get; set; } 

        [Required(ErrorMessage = "Digite o email do Contato!")]                 //Required para obrigar a digitação do campo 
        [EmailAddress(ErrorMessage = "O email informado não é válido")]         //Validação se o email é valido
        public string Email { get; set; }
       
        [Required(ErrorMessage = "Digite o celular do Contato!")]               //Required para obrigar a digitação do campo 
        [Phone(ErrorMessage = "O celular informado não é válido")]              //Validação se o telefone é valido
        public string Celular { get; set; }

        [Required(ErrorMessage = "Digite a Nacionalidade do Contato!")]         //Required para obrigar a digitação do campo 
        [StringLength (25)]                                                     //Validação a nacionalidade 
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "Digite o CEP do Contato!")]                   //Required para obrigar a digitação do campo 
        [StringLength(9)]
        public string CEP { get; set; }


        [Required(ErrorMessage = "Digite a Cidade do Contato!")]                //Required para obrigar a digitação do campo 
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Digite o Estado do Contato!")]                //Required para obrigar a digitação do campo 
        [StringLength(50)]
        public string Estado { get; set; }


        [Required(ErrorMessage = "Digite o Logradouro do Contato!")]               //Required para obrigar a digitação do campo 
        [StringLength(150)]
        public string Logradouro { get; set; }

        
    }
}