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
            List<ProcessadorEntity> processadores = ProcessadorComponent.Get().listarProcessadoresCadastrados();
            processadores.ForEach(proc => listItens.Add(new SelectListItem() { Text = proc.Descricao, Value = proc.ID.ToString() }));
            return listItens;
        }
    }
}