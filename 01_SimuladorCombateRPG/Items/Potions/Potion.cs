using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _01_SimuladorCombateRPG.Items.Potions
{
    public enum PotionTypes
    {
        Health,
        Stamina,
    }
    internal class Potion : Item
    {
        public int NumbersEffect { get; private set; }
        public PotionTypes Type { get; private set; }

        public Potion(string name, int cost, PotionTypes type, int effect) : base(name, cost)
        {
            this.NumbersEffect = effect;
            this.Type = type;
        }

        public override void Info()
        {
            switch (this.Type)
            {
                case PotionTypes.Health:
                    Console.WriteLine($"{this.cost}€ - {this.name} ({this.NumbersEffect}hp)");
                    break;
                case PotionTypes.Stamina:
                    Console.WriteLine($"{this.cost}€ - {this.name} ({this.NumbersEffect}en)");
                    break;
                default:
                    Console.WriteLine("Poción");
                    break;
            }
        }
        public override void Use()
        {
            switch(this.Type)
            {
                case PotionTypes.Health:
                    Console.WriteLine($"Has recuperado {this.NumbersEffect} de vida!");
                    break;
                case PotionTypes.Stamina:
                    Console.WriteLine($"Has recuperado {this.NumbersEffect} de resistencia!");
                    break;
                default:
                    Console.WriteLine("Has usado una poción");
                    break;
            }
        }
    }
}
