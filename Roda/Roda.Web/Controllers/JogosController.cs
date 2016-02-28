using Roda.Component;
using Roda.Entities;
using Roda.Web.Models;
using Roda.Web.Utils;
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

        public ActionResult Home()
        {
            CookieRoda cookie = Utilidades.obterCookieRoda();
            return View("~/Views/Roda/Home.cshtml", cookie);
        }

        public ActionResult VerificarJogos(int Processador, int PlacaVideo, double QuantidadeMemoria, double QuantidadeHD)
        {
            Utilidades.adicionarCookieRequisitos(Processador, PlacaVideo, QuantidadeMemoria, QuantidadeHD);
            List<JogoEntity> jogosCadastrados = JogoComponent.Get().listarJogosCadastrados();
            return View("~/Views/Roda/Jogos.cshtml", jogosCadastrados);
        }
    }
}