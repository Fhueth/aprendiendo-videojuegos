using _01_SimuladorCombateRPG.Items.Potions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_SimuladorCombateRPG.Items.Weapons
{
    public enum WeaponTypes
    {
        Sword,
        Baton,
        Bow,
    }
    internal class Weapon : Item
    {
        
        public int MinDMG { get; private set; }
        public int MaxDMG { get; private set; }
        public int StaminaUse { get; private set; }
        public int Probability { get; private set; }
        public WeaponTypes Type { get; private set; }
        public Weapon(string name, int cost, WeaponTypes type, int minDMG, int maxDMG, int stamina, int prob)
            : base(name, cost)
        {
            this.MinDMG = minDMG;
            this.MaxDMG = maxDMG;
            this.StaminaUse = stamina;
            this.Probability = prob;
            this.Type = type;
        }

        public override void Info()
        {
            Console.WriteLine($"{this.cost}€ - {this.name} ({this.MinDMG}~{this.MaxDMG}dmg)");
        }

        public override void Use()
        {
            switch(this.Type)
            {
                case WeaponTypes.Sword:
                    Console.WriteLine($"Tu espadazo le ha quitado 100 de vida");
                    break;
                case WeaponTypes.Baton:
                    Console.WriteLine($"Tu hechizo le ha quitado 50 de vida");
                    break;
                case WeaponTypes.Bow:
                    Console.WriteLine($"Tu disparo le ha quitado 60 de vida");
                    break;
                default:
                    Console.WriteLine("Has usado tu arma");
                    break;
            }
        }
    }
}
