﻿using Roda.Business.Conversor;
using Roda.DataAccess;
using Roda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roda.Business
{
    public class PlacaVideoBusiness
    {
        private PlacaVideoDataAccess _placaVideoDataAccess;
        private PlacaVideoDataAccess PlacaVideoDataAccess
        {
            get
            {
                if (_placaVideoDataAccess == null)
                    _placaVideoDataAccess = new PlacaVideoDataAccess();
                return _placaVideoDataAccess;
            }
        }
        
        public List<PlacaVideoEntity> ListarPlacasVideoCadastradas()
        {
            List<PlacaVideo> placasVideo = PlacaVideoDataAccess.ListarPlacasVideo();
            return ConversorModelEntity.ConverterPlacaVideoModelParaPlacaVideoEntity(placasVideo);
        }
    }
}