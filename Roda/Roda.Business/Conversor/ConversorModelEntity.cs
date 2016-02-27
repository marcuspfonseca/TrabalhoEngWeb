﻿using Roda.DataAccess;
using Roda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roda.Business.Conversor
{
    public class ConversorModelEntity
    {
        public static List<JogoEntity> ConverterJogoModelParaJogoEntity(ICollection<Jogo> jogo)
        {
            return jogo.Select(_jogo => ConverterJogoModelParaJogoEntity(_jogo)).ToList();
        }

        public static JogoEntity ConverterJogoModelParaJogoEntity(Jogo jogo)
        {
            JogoEntity jogoEntity = new JogoEntity();
            jogoEntity.ID = jogo.ID;
            jogoEntity.Nome = jogo.Nome;
            jogoEntity.Descricao = jogo.Descricao;
            jogoEntity.NomeEmpresa = jogo.NomeEmpresa;
            jogoEntity.MinimoHD = jogo.MinimoHD;
            jogoEntity.MinimoMemoria = jogo.MinimoMemoria;
            return jogoEntity;
        }

        public static PlacaVideoEntity ConverterPlacaVideoModelParaPlacaVideoEntity(PlacaVideo placaVideoModel)
        {
            PlacaVideoEntity placaVideo = new PlacaVideoEntity();
            return placaVideo;
        }

        public static List<ProcessadorEntity> ConverterProcessadorModelParaProcessadorEntity(ICollection<Processador> processadorModel)
        {
            return processadorModel.Select(_processador => ConverterProcessadorModelParaProcessadorEntity(_processador)).ToList();
        }

        public static ProcessadorEntity ConverterProcessadorModelParaProcessadorEntity(Processador processadorModel)
        {
            ProcessadorEntity processadorEntity = new ProcessadorEntity();
            processadorEntity.Clock = processadorModel.Clock;
            processadorEntity.Descricao = processadorModel.Descricao;
            processadorEntity.ID = processadorEntity.ID;
            processadorEntity.IDProcessadorEquivalente = processadorEntity.IDProcessadorEquivalente;
            processadorEntity.Potencia = processadorEntity.Potencia;            
            return processadorEntity;
        }
    }
}
