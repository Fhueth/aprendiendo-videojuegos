using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace _01_SimuladorCombateRPG.Items
{
    abstract internal class Item
    {
        public string name { get; private set; }
        public int cost { get; private set; }

        public Item(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public abstract void Info();
        public abstract void Use();
    }
}
