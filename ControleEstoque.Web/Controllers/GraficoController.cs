using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class GraficoController : Controller
    {
        // GET: Grafico

        [Authorize]
        public ActionResult IndPerdaMesex()
        {
            return View();
        }

        [Authorize]
        public ActionResult EntradaSaidaMesa()
        {
            return View();
        }
    }

}