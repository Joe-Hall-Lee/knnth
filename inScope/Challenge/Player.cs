using Challenge.Interfaces;
using Challenge.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Player
    {
        private int health;

        private int mana;

        private Item[] inventory;

        public Player()
        {
            inventory = new Item[10];
            health = 10;
            mana = 10;

            for (int i = 0; i < inventory.Length; i++)
            {
                if (i < 5)
                {
                    inventory[i] = new Potion();
                }
                else
                {
                    inventory[i] = new Apple();
                }
            }
        }

        public void Eat()
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Item item = inventory[i];

                if (item is IEatable)
                {
                    health += (item as IEatable).Eat();
                    inventory[i] = null;
                    Console.WriteLine($"You ate an {item}");
                    Console.WriteLine($"You have {health} health and {mana} mana");
                    break;
                }
            }

            Console.WriteLine("You have no eatable items left");
        }

        public void Drink()
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Item item = inventory[i];

                if (item is IEatable)
                {
                    mana += (item as IDrinkable).Drink();
                    inventory[i] = null;
                    Console.WriteLine($"You drank an {item}");
                    Console.WriteLine($"You have {health} health and {mana} mana");
                    break;
                }
            }

            Console.WriteLine("You have no drinkable items left");
        }


        public void InventoryStatus()
        {
            Console.WriteLine("The inventory contains");

            int counter = 1;

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] != null)
                {
                    Console.WriteLine($"{counter}. {inventory[i]}");
                    counter++;
                }

            }
        }
    }
}