using ControleDeContatos.Data;
using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        private readonly BancoContext _bancoContext;


        public ContatoController(IContatoRepositorio contatoRepositorio, BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
            _contatoRepositorio = contatoRepositorio;
        }

        public async Task<IActionResult> Index()
        {
            var contatos = await _bancoContext.BancoContatos.ToListAsync();
            //List<ContatoModel> contatos = new List<ContatoModel>();
            //contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato Cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(contato);

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não Foi Possível cadastrar o Cadastro, tente novamente! detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato Alterado com Sucesso";
                    return RedirectToAction("Index");
                }

                return View("Editar", contato);

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não Foi Possível atualizar o Cadastro, tente novamente! detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.FindById(id);
            return View(contato);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.FindById(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _contatoRepositorio.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Contato Apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = $"Não Foi Possivel Remover o Contanto, tente novamente!";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não Foi Possível Remover o  Contanto, tente novamente! detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
