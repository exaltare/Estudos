#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompugrafTest;

namespace CompugrafTest.Controllers
{
    
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        
        [HttpGet]
        [Route("localizar")]

        public async Task<ActionResult<IEnumerable<ContatoModel>>> ObterContatos()
        {
            return await _context.Contato.ToListAsync();
        }

        
        [HttpGet("{id}")]
        [Route("localizar_id")]
        public async Task<ActionResult<ContatoModel>> ObterContatos(int id)
        {
            var contatoModel = await _context.Contato.FindAsync(id);

            if (contatoModel == null)
            {
                return NotFound();
            }

            return contatoModel;
        }

        
        [HttpPut("{id}")]
        [Route("atualizar_id")]
        public async Task<IActionResult> AtualizarContato(int id, ContatoModel contatoModel)
        {
            if (id != contatoModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(contatoModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContatoModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        
        [HttpPost]
        [Route("incluir")]
        public async Task<ActionResult<ContatoModel>> IncluirContato(ContatoModel contatoModel)
        {
            _context.Contato.Add(contatoModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContatoModel", new { id = contatoModel.Id }, contatoModel);
        }

        [HttpDelete("{id}")]
        [Route("excluir")]
        public async Task<IActionResult> ExcluirContato(int id)
        {
            var contatoModel = await _context.Contato.FindAsync(id);
            if (contatoModel == null)
            {
                return NotFound();
            }

            _context.Contato.Remove(contatoModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContatoModelExists(int id)
        {
            return _context.Contato.Any(e => e.Id == id);
        }
    }
}
