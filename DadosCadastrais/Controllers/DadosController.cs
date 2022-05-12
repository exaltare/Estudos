using DadosCadastrais.Context;
using DadosCadastrais.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DadosCadastrais.Controllers
{
    [Route("v1")]
    [ApiController]
    public class DadosController : ControllerBase
    {
        private readonly AppDbContext _DataContext;

        public DadosController(AppDbContext dataContext)
        {
            _DataContext = dataContext;

        }
       
        [HttpGet]
        [Route("getall")]

        public IActionResult GetAll()
        {
            return Ok(_DataContext.Dados.ToList());

        }

        [HttpPost]
        [Route("incluir")]

        public IActionResult AddData([FromBody] ContatoModel InputModel)
        {
            _DataContext.Dados.Add(InputModel);
            _DataContext.SaveChanges();
            return Ok();

        }


        //[HttpGet("{id}")]
        //[Route("localizar")]

        //public IActionResult GetId(int id)
        //{
        //    ContatoModel Contato = _DataContext.Dados.FirstOrDefault(Contato => Contato.Id == id);
        //    if (Contato == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(Contato);
        //    }

        //}


        [HttpPut]
        [Route("atualizar")]

        public async Task<IActionResult> UpdateDataAsync(int id, [FromBody] ContatoModel model)
        {
            
            ContatoModel contato = _DataContext.Dados.FirstOrDefault(contato => contato.Id == id);


            if (contato == null)
            {
                return NotFound();
            }
            else
            {
                _DataContext.Update(model);
                await _DataContext.SaveChangesAsync();

                return Ok(contato);
            }
        }

        [HttpDelete]
        [Route("excluir")]
        public async Task<IActionResult> DeleteData(int id)
        {
            ContatoModel contato = await _DataContext.Dados.FindAsync(id);
            if (contato == null)
            {
                return NotFound();
            }
            else
            {
                _DataContext.Remove(contato);
                await _DataContext.SaveChangesAsync();

                return NoContent();
            }
        }

        [HttpGet]
        [Route("localizarid")]
        public async Task<IActionResult> GetForIdAsync(int id)
        {
            ContatoModel contato = await _DataContext.Dados.FindAsync(id);
            if (contato == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(contato);
            }
        }
    }
}
