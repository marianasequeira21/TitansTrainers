﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitansTrainer
{
    class JogadorProfissional : JogadorSubscricao
    {
        private int m_Moedas;
       

       public int Moedas
        {
            get
            {
                return m_Moedas;
            }
            set
            {
                m_Moedas = value;
            }
        }

      

     
        public JogadorProfissional(string NickName, int CombatPower, int Moedas) : base(NickName, CombatPower)
        {
            m_Moedas = 10;
        }
        //public string Apresentar()
        //{
        //    return m_Moedas;
        //    return m_ApostaAtual;
        //}
        public override int CustoUnitario()
        {
            GamePoints = GamePoints - 5;
            return GamePoints;
        }
    }

}
