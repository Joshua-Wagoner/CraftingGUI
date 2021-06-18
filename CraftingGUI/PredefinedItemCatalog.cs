using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting
{
    class PredefinedItemCatalog
    {
        private Item[] catalog;

        private static PredefinedItemCatalog pic = new PredefinedItemCatalog();

        private PredefinedItemCatalog()
        {
            InitPreDefinedItems();
        }

        public static PredefinedItemCatalog GetInstance()
        {
            return pic;
        }

        public Item[] Catalog { get { return catalog; } }

        public Item GetItem(string name)
        {
            Item item = null;

            foreach(Item i in catalog)
                if(i.Name == name)
                    item = i;

            return item;
        }

        public Item GetItem(int id)
        {
            Item item = null;

            foreach (Item i in catalog)
                if (i.ID == id)
                    item = i;

            return item;
        }

        private void InitPreDefinedItems()
        {
            catalog = new Item[14];

            catalog[0] = new Item("Plank", true);
            catalog[1] = new Item("Log");
            catalog[2] = new Item("Iron_Ingot");
            catalog[3] = new Item("String");
            catalog[4] = new Item("Leather");
            catalog[5] = new Item("Paper", true);
            catalog[6] = new Item("Book", true);
            catalog[7] = new Item("Sugar_Cane");
            catalog[8] = new Item("Stick", true);
            catalog[9] = new Item("Clay");
            catalog[10] = new Item("Sand");
            catalog[11] = new Item("Sandstone", true);
            catalog[12] = new Item("Brick");
            catalog[13] = new Item("Bookshelf", true);
        }
    }
}
