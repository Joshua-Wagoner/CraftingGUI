using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting
{
    class PredefinedRecipeLibrary
    {
        private Recipe[] library;

        private static PredefinedRecipeLibrary prl = new PredefinedRecipeLibrary();

        private PredefinedItemCatalog itemCatalog = PredefinedItemCatalog.GetInstance();

        private PredefinedRecipeLibrary()
        {
            InitPreDefinedRecipes();
        }

        public Recipe[] Library { get { return library; } }

        public static PredefinedRecipeLibrary GetInstance()
        {
            return prl;
        }

        public Recipe GetRecipe(string name)
        {
            Recipe recipe = null;

            foreach(Recipe r in library)
                if(r.Name == name)
                    recipe = r;

            return recipe;
        }

        public Recipe GetRecipe(int id)
        {
            Recipe recipe = null;

            foreach (Recipe r in library)
                if (r.ID == id)
                    recipe = r;

            return recipe;
        }

        private void InitPreDefinedRecipes()
        {
            library = new Recipe[6];

            library[0] = new Recipe("Paper_Recipe", GetPaperRecipeItems(), itemCatalog.GetItem("Paper"));
            library[1] = new Recipe("Book_Recipe", GetBookRecipeItems(), itemCatalog.GetItem("Book"));
            library[2] = new Recipe("Plank_Recipe", GetPlankRecipeItems(), itemCatalog.GetItem("Plank"));
            library[3] = new Recipe("Bookshelf_Recipe", GetBookshelfRecipeItems(), itemCatalog.GetItem("Bookshelf"));
            library[4] = new Recipe("Stick_Recipe", GetStickRecipeItems(), itemCatalog.GetItem("Stick"));
            library[5] = new Recipe("Sandstone_Recipe", GetSandstoneRecipeItems(), itemCatalog.GetItem("Sandstone"));
        }

        private Item[] GetSandstoneRecipeItems()
        {
            Item[] sandstoneRecipe = new Item[4];

            sandstoneRecipe[0] = itemCatalog.GetItem("Sand");
            sandstoneRecipe[1] = itemCatalog.GetItem("Sand");
            sandstoneRecipe[2] = itemCatalog.GetItem("Sand");
            sandstoneRecipe[3] = itemCatalog.GetItem("Sand");

            return sandstoneRecipe;
        }

        private Item[] GetBookshelfRecipeItems()
        {
            Item[] bookshelfRecipe = new Item[9];

            bookshelfRecipe[0] = itemCatalog.GetItem("Plank");
            bookshelfRecipe[1] = itemCatalog.GetItem("Plank");
            bookshelfRecipe[2] = itemCatalog.GetItem("Plank");
            bookshelfRecipe[3] = itemCatalog.GetItem("Book");
            bookshelfRecipe[4] = itemCatalog.GetItem("Book");
            bookshelfRecipe[5] = itemCatalog.GetItem("Book");
            bookshelfRecipe[6] = itemCatalog.GetItem("Plank");
            bookshelfRecipe[7] = itemCatalog.GetItem("Plank");
            bookshelfRecipe[8] = itemCatalog.GetItem("Plank");

            return bookshelfRecipe;
        }

        private Item[] GetStickRecipeItems()
        {
            Item[] stickRecipe = new Item[2];

            stickRecipe[0] = itemCatalog.GetItem("Plank");
            stickRecipe[1] = itemCatalog.GetItem("Plank");

            return stickRecipe;
        }

        private Item[] GetPlankRecipeItems()
        {
            Item[] plankRecipe = new Item[1];

            plankRecipe[0] = itemCatalog.GetItem("Log");

            return plankRecipe;
        }

        private Item[] GetBookRecipeItems()
        {
            Item[] bookRecipe = new Item[4];

            bookRecipe[0] = itemCatalog.GetItem("Paper");
            bookRecipe[1] = itemCatalog.GetItem("Paper");
            bookRecipe[2] = itemCatalog.GetItem("Paper");
            bookRecipe[3] = itemCatalog.GetItem("Leather");

            return bookRecipe;
        }

        private Item[] GetPaperRecipeItems()
        {
            Item[] paperRecipe = new Item[3];

            paperRecipe[0] = itemCatalog.GetItem("Sugar_Cane");
            paperRecipe[1] = itemCatalog.GetItem("Sugar_Cane");
            paperRecipe[2] = itemCatalog.GetItem("Sugar_Cane");

            return paperRecipe;
        }
    }
}
