using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    internal class Merchant
    {
        public string name;
        public Vector2 position;
        public char symbol;
        public ConsoleColor color;
        public List<Item>? inventory;
    }
}
