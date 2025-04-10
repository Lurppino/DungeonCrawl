﻿using System;
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
        public Vector2 position = new Vector2(1,1);
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
            potion.quality = 2;
            potion.position = position;
            potion.type = ItemType.Potion;

            Item sword = new Item();
            sword.name = "Helmet";
            sword.quality = 4;
            sword.position = position;
            sword.type = ItemType.Armor;

            Item armor = new Item();
            armor.name = "Sword";
            armor.quality = 6;
            armor.position = position;
            armor.type = ItemType.Weapon;

            
            inventory.Add(potion);
            inventory.Add(armor);
            inventory.Add(sword);
        }

        public void ShowInventory()
        {

            if (inventory.Count == 0)
            {
                Console.WriteLine("No items available.");
                return;
            }

            for (int i = 0; i < inventory.Count; i++)
            {
                var item = inventory[i];
                Console.WriteLine($"{i + 1}. {item.name} ({item.type}) - Quality: {item.quality}");
            }
        }
    }
}