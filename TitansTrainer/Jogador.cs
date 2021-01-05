using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitansTrainer
{
    public abstract class Jogador
    {
        
        private int m_CombatPower;
        private int m_GamePoints;
        private string m_NickName;
        private Jogador[] m_ListaJogadores;
        private int m_NumeroCombatesRealizados;
        private string m_Powerups;
        private bool m_TemHabilidadeSecreta;


        

        public int CombatPower
        {
            get
            {
                return m_CombatPower;
            }
            set
            {
                m_CombatPower = value;
            }
        }

        public int GamePoints
        {
            get
            {
                return m_GamePoints;
            }
            set
            {
                m_GamePoints = value;
            }
        }

      
        public string NickName
        {
            get
            {
                return m_NickName;
            }
            set
            {
                m_NickName = value;
            }
        }

        public Jogador[] ListaJogadores
        {
            get 
            {
                return m_ListaJogadores;
            }
            set
            {
                m_ListaJogadores = value;
            }
        }
        public int NumeroCombatesRealizados
        {
            get
            {
                return m_NumeroCombatesRealizados;
            }
            set
            {
                m_NumeroCombatesRealizados = value;
            }
        }

        public string PowerUps
        {
            get
            {
                return m_Powerups;
            }
            set
            {
                m_Powerups = value;
            }
        }

        public bool TemHabilidadeSecreta
        {
            get 
            {
                return m_TemHabilidadeSecreta;
            }
            set
            {
                m_TemHabilidadeSecreta = value;
            }
        }

        
        public Jogador(string NickName, int CombatPower)
        {
            m_NickName = NickName;
            m_CombatPower = CombatPower;
            m_Powerups = "Vazio";
            m_GamePoints = 0;
            m_NumeroCombatesRealizados = 0;
        }

        //public double TitanCP()
        //{
        //    CombatPower
        //}

        //public virtual void Apresentar()
        //{         
        //        return m_NickName;
        //        return m_CombatPower;
        //        return m_Powerups;
        //        return m_GamePoints;
        //        return m_NumeroCombatesRealizados;

        //}
        //public int PontosBase()

        public virtual int CustoUnitario()
        {
            GamePoints = GamePoints - 5;
            return GamePoints;
        }
        
    }
}
