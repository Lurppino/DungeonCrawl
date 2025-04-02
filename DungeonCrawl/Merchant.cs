using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using DungeonCrawl;  

namespace DungeonCrawl
{
    internal class Merchant
    {
        public string name;
        public Vector2 position;
        public char symbol;
        public ConsoleColor color;
        public List<Item> inventory;

        public Merchant(string name, char symbol, ConsoleColor color, Vector2 position)
        {
            this.name = name;
            this.symbol = symbol;
            this.color = color;
            this.position = position;
            this.inventory = new List<Item>();

            
            Item potion = new Item();
            potion.name = "Apple Juice";
            potion.quality = 10;
            potion.position = position;
            potion.type = ItemType.Potion;  

            Item sword = new Item();
            sword.name = "Helmet";
            sword.quality = 50;
            sword.position = position;
            sword.type = ItemType.Weapon;

            Item armor = new Item();
            armor.name = "Sword";
            armor.quality = 30;
            armor.position = position;
            armor.type = ItemType.Armor;

            
            inventory.Add(potion);
            inventory.Add(armor);
            inventory.Add(sword);
        }
    }
}
