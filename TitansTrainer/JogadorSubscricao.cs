using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitansTrainer
{
    class JogadorSubscricao : Jogador
    {
        private int m_NumeroCombatesPermitidos;
        private string m_TipoSubscricao;
        private bool m_HabilidadeSecreta;

        public int Combater
        {
            get
            {
                return m_NumeroCombatesPermitidos;
            }
            set
            {
                 m_NumeroCombatesPermitidos = value;
            }
        }
        public string TipoSubscricao
        {
            get
            {
                return m_TipoSubscricao;
            }
            set
            {
                m_TipoSubscricao = value;
            }
        }
        public bool HabilidadeSecreta
        {
            get
            {
                return m_HabilidadeSecreta;
            }
            set
            {
                m_HabilidadeSecreta = value;
            }
        }
        public void NumeroCombatesPermitidos()
        {
            if (TipoSubscricao == "Bronze")
            {
                Combater = 1000;
            }
            else if (TipoSubscricao == "Silver")
            {
                Combater = 5000;
            }
            else if (TipoSubscricao == "Gold")
            {
                Combater = 10000;
            }
            else
            {
                Combater = 0;
            }
           
        }

            public JogadorSubscricao(string NickName, int CombatPower) : base(NickName, CombatPower)
            {
                
            }
        
       //public string Apresentar()
       // {
                 
            
       //         return m_TipoSubscricao;
       //     return m_NumeroCombatesPermitidos;
            

       // }
        public override int CustoUnitario()
        {
            GamePoints = GamePoints - 7;
            return GamePoints;

        }
    }
}
