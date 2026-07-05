using System;
using System.Collections.Generic;
using System.Text;

namespace _01_SimuladorCombateRPG
{
    internal class Statistics
    {
        public int life { get; private set; }
        public int stamina { get; private set; }
        public int money { get; private set; }

        public Statistics(int life, int stamina, int money = 100)
        {
            this.life = life;
            this.money = money;
            this.stamina = stamina;
        }
    }
}
