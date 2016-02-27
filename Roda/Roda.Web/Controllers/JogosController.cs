using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roda.Web.Controllers
{
    public class JogosController : Controller
    {
        // GET: Jogos
        public ActionResult Index()
        {
            return View("~/Views/Roda/Sobre.cshtml");
        }

        public ActionResult Home()
        {
            return View("~/Views/Roda/Home.cshtml");
        }
    }
}