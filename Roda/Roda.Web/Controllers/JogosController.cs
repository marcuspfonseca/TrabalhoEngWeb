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

        public ActionResult Roda()
        {
            return View("~/Views/Roda/Roda.cshtml");
        }

        public ActionResult NaoRoda()
        {
            return View("~/Views/Roda/NaoRoda.cshtml");
        }
    }
}