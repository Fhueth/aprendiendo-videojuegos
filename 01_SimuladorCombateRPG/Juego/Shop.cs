using System;
using System.Collections.Generic;
using System.Text;
using _01_SimuladorCombateRPG.Items;
using _01_SimuladorCombateRPG.Items.Weapons;
using _01_SimuladorCombateRPG.Items.Potions;

namespace _01_SimuladorCombateRPG.Juego
{
    internal class Shop
    {
        List<Item> ShopItems = new List<Item>();

        public Shop()
        {
            ShopItems.AddRange(new List<Item>
            {   
                new Weapon("Espada de Hierro", 40, WeaponTypes.Sword, 15, 25, 15, 90),
                new Weapon("Arco Corto", 45, WeaponTypes.Bow, 10, 20, 10, 95),
                new Weapon("Bastón de Mago", 50, WeaponTypes.Baton, 25, 40, 30, 85),
                new Potion("Poción de Vida", 20, PotionTypes.Health, 40),
                new Potion("Poción de Stamina", 15, PotionTypes.Stamina, 35),
            });
        }

        public void ShowShopItems()
        {
            int i = 1;
            Console.WriteLine("\nTienda\n");
            foreach (Item item in this.ShopItems)
            {
                Console.Write(i + ") ");
                item.Info();
                i++;
            }
        }
    }
}
