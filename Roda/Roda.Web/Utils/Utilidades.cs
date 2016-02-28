using Roda.Component;
using Roda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roda.Web.Utils
{
    public class Utilidades
    {
        public static List<SelectListItem> obterSelectListProcessadores()
        {
            List<SelectListItem> listItens = new List<SelectListItem>();
            listItens.Add(new SelectListItem());
            List<ProcessadorEntity> processadores = ProcessadorComponent.Get().ListarProcessadoresCadastrados();
            processadores.ForEach(proc => listItens.Add(new SelectListItem() { Text = proc.Descricao + " " + proc.Clock + "Ghz", Value = proc.ID.ToString() }));
            
            return listItens;
        }

        public static List<SelectListItem> obterSelectListPlacasVideo()
        {
            List<SelectListItem> listItens = new List<SelectListItem>();
            listItens.Add(new SelectListItem());
            List<PlacaVideoEntity> processadores = PlacaVideoComponent.Get().ListarPlacasVideoCadastradas();
            processadores.ForEach(proc => listItens.Add(new SelectListItem() { Text = proc.Descricao + " " + proc.Clock + "Ghz", Value = proc.ID.ToString() }));
            return listItens;
        }
    }
}