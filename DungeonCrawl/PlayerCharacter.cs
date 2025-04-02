using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    internal class PlayerCharacter
    {
        public string name;
        public string hairColor;
        public int hitpoints;
        public int maxHitpoints;
        public Item weapon;
        public Item armor;
        public int gold;
        public Vector2 position;
        public List<Item> inventory;

        public PlayerCharacter()
        {
            inventory = new List<Item>();
        }
        public bool CanAfford(Item item)
        {
            return gold >= item.quality;  
        }
        public void BuyItem(Merchant merchant, Item item)
        {
            if (CanAfford(item))
            {
                gold -= item.quality;  
                inventory.Add(item);   
                merchant.inventory.Remove(item); 
                Console.WriteLine($"You bought {item.name} for {item.quality} gold.");
            }
        }
        public void ShowInventory()
        {
            Console.WriteLine("\nYour Inventory:");
            if (inventory.Count == 0)
            {
                Console.WriteLine("Your inventory is empty.");
            }
            else
            {
                foreach (var item in inventory)
                {
                    Console.WriteLine($"{item.name} (Quality: {item.quality})");
                }
            }
            Console.WriteLine($"Gold: {gold}");
        }
    }
}
