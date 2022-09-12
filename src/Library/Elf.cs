using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class Elf
    {
        List<Item> equippedItems = new List<Item>();
        private string name;
        private int health = 100;

        public void EquipItem(Item item)
        {
            equippedItems.Add(item);
        }

        public int GetTotalDamage()
        {
            foreach (Item item in equippedItems)
            {
                //
            }
        }

        public int GetTotalArmor()
        {
            foreach (Item item in equippedItems)
            {
                //
            }
        }

        public void Heal(int ammount)
        {
            health += ammount;
            System.Console.WriteLine($"{name} se curó {ammount} puntos de salud");
        }

        public void RecieveDamage(int damage)
        {
            health -= damage;
            System.Console.WriteLine($"{name} recibió {damage} puntos de daño");
        }
    }
}