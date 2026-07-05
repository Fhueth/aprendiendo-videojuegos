using System;
using System.Collections.Generic;
using System.Text;

namespace _01_SimuladorCombateRPG
{
    internal class Character
    {
        public string name { get; private set; }
        public Statistics statistics { get; private set; }
        
        public Character(string name, Statistics statistics)
        {
            this.name = name;
            this.statistics = statistics;
        }
        

    }
}
