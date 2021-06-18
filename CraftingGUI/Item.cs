using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting
{
    class Item
    {
        private static int id;

        private bool isCraftable;
        private string itemName;
        private int itemId; 

        public Item(string itemName) : this(itemName, false) { }

        public Item(string itemName, bool isCraftable)
        {
            this.itemName = itemName;
            this.isCraftable = isCraftable;

            id++;
            itemId = id;
        }
        public string Name { get { return itemName; } }
        public int ID { get { return itemId; } }
        public bool Craftable { get { return isCraftable; } }

        public string GetFullItemInfo()
        {
            return "Item Name: "+ ToString() + (id < 10 ? " ID: 0" + ID : " ID: " + ID) + "\nCraftable: " + Craftable + "\n";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
