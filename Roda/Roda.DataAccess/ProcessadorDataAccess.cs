using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roda.DataAccess
{
    public class ProcessadorDataAccess
    {
        public List<Roda.DataAccess.Processador> ListaProcessadores()
        {
            using (RodaContext contexto = new RodaContext())
            {
                return contexto.rod_processador.ToList();
            }
        }
    }
}
