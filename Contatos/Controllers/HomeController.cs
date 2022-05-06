using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contatos.Data;
using System.Collections.Generic;
using Contatos.Model;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Contatos.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        //[Route("all")]
        public async Task <ActionResult<IEnumerable<DadosModel>>> GetAll()
        {
            var teste = _context.Dados.ToList();
            return await _context.Dados.ToListAsync(); 
        } 

    }
}
