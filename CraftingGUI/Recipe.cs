using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting
{
    class Recipe
    {
        private Item[] itemsForRecipe;
        private Item output;

        private static int id;

        private string recipeName;
        private int recipeId;

        public Recipe(string recipeName, Item[] itemsForRecipe, Item output)
        {
            this.recipeName = recipeName;
            this.itemsForRecipe = itemsForRecipe;
            this.output = output;

            id++;
            recipeId = id;
        }

        public Item[] Items { get { return itemsForRecipe; } }
        public Item Output { get { return output; } }
        public string Name { get { return recipeName; } }
        public int ID { get { return recipeId; } }


        public string GetFullRecipeInfo()
        {
            return "Name: "+ ToString() + (id < 10 ? " ID: 0" + ID : " ID: " + ID)
                + "\n\nItems for Recipe: \n" + IterateItems()
                + "\nOutput: " + Output;
        }

        private string IterateItems()
        {
            string s = string.Empty;

            foreach (Item item in itemsForRecipe)
                s += item + "\n";

            return s;
        }

        public override string ToString()
        {
            return Name;
        }

        
    }
}
