using Roda.Business.Conversor;
using Roda.DataAccess;
using Roda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roda.Business
{
    public class JogoBusiness
    {
        private JogoDataAccess _jogoDataAcess;
        private JogoDataAccess JogoDataAccess
        {
            get
            {
                if (_jogoDataAcess == null)
                    _jogoDataAcess = new JogoDataAccess();
                return _jogoDataAcess;
            }
        }
        public List<JogoEntity> listarJogosCadastrados()
        {
            List<Jogo> jogos = JogoDataAccess.listarJogos();
            return ConversorModelEntity.ConverterJogoModelParaJogoEntity(jogos);
        }
    }
}
