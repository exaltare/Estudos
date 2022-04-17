using ControleDeContatos.Data;
using ControleDeContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;            //_ por que ela é privada 

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel FindById(int id)
        {
            return _bancoContext.Contato.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contato.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
           //grava no banco de dados 
            _bancoContext.Contato.Add(contato);      //inserindo no banco
            _bancoContext.SaveChanges();            //comintando as informacoes salvechanges para salvar as alteracoes
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = FindById(contato.Id);

            if (contatoDB == null) throw new Exception("Houve um erro na atualização do contato");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;
            contatoDB.Nacionalidade = contato.Nacionalidade;
            contatoDB.CEP = contato.CEP;
            contatoDB.Estado = contato.Estado;
            contatoDB.Cidade = contato.Cidade;
            contatoDB.Logradouro = contato.Logradouro;


            _bancoContext.Contato.Update(contatoDB);
            _bancoContext.SaveChanges();
            return contatoDB;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = FindById(id);

            if (contatoDB == null) throw new Exception("Houve um erro na exclusão do contato");

            _bancoContext.Remove(contatoDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}