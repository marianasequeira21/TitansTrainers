using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitansTrainer
{
   public class Powerup
    {
        private int m_Nome;
        private double m_Bonus;
        private Powerup[] m_NomePowerups;

        public int Nome
        {
            get
            {
                return m_Nome;
            }
            set
            {
                m_Nome = value;
            }
        }

        public double Bonus
        {
            get
            {
                return m_Bonus;
            }
            set
            {
                m_Bonus = value;
            }
        }
        
        public Powerup[] NomePowerups
        {
            get
            {
                return m_NomePowerups;
            }
            set
            {
                m_NomePowerups = value;
            }
        }

        //int[] Powerup = new int[5]
        //Powerup[0] = "Aumentar CP";
        //Powerup[1] = "Aumentar CP";
        //Powerup[2] = "Aumentar CP";
        // Powerup[3] = "Aumentar CP";
        // Powerup[4] = "Aumentar CP";

    }
}
