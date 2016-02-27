﻿using Roda.Business;
using Roda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roda.Component
{
    public class JogoComponent
    {


        private JogoBusiness _jogoBusiness;
        private JogoBusiness JogoBusiness
        {
            get
            {
                if (_jogoBusiness == null)
                    _jogoBusiness = new JogoBusiness();
                return _jogoBusiness;
            }
        }

        private JogoComponent() { }

        public static JogoComponent Get()
        {
            return new JogoComponent();
        }

        public List<JogoEntity> listarJogosCadastrados()
        {
            return JogoBusiness.listarJogosCadastrados();
        }
    }
}