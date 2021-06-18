using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crafting;

namespace CraftingGUI
{
    public partial class CraftingGUI : Form
    {
        private Recipe tempRecipe;
        private Item tempItem;

        public CraftingGUI()
        {
            InitializeComponent();
        }
        private void CraftingGUI_Load(object sender, EventArgs e)
        {

            foreach (Recipe recipe in PredefinedRecipeLibrary.GetInstance().Library)
                recipeComboBox.Items.Add(recipe);

            foreach (Item item in PredefinedItemCatalog.GetInstance().Catalog)
                itemComboBox.Items.Add(item);

            recipeComboBox.SelectedIndex = 0;
            itemComboBox.SelectedIndex = 0;

        }

        private void recipeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                tempRecipe = (Recipe)recipeComboBox.SelectedItem;
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                tempItem = (Item)itemComboBox.SelectedItem;
        }

        private void recipeConfirmBtn_Click(object sender, EventArgs e)
        {
            if (tempRecipe!= null)
                recipeOutputBox.Text = tempRecipe.GetFullRecipeInfo();
        }

        private void itemConfirmBtn_Click(object sender, EventArgs e)
        {
            if (tempItem != null)
                itemOutputBox.Text = tempItem.GetFullItemInfo();
        }

        private void createItemBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(createItemNameTextBox.Text))
            {
                itemComboBox.Items.Add(new Item(createItemNameTextBox.Text));
                createItemNameTextBox.Text = string.Empty;
            }
            else
                MessageBox.Show("Not a valid name for Item name!");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
