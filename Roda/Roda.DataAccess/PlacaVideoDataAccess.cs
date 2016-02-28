using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roda.DataAccess
{
    public class PlacaVideoDataAccess
    {
        public List<PlacaVideo> ListarPlacasVideo()
        {
            using (RodaContext contexto = new RodaContext())
            {
                return contexto.rod_placa_video.ToList();
            }
        }
    }
}
