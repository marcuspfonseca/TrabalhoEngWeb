using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roda.DataAccess
{
    public class JogoDataAccess
    {
        public List<Roda.DataAccess.Jogo> listarJogos()
        {
            using (RodaContext contexto = new RodaContext())
            {                
                return contexto.rod_jogo.ToList();
            }
        }
    }
}
