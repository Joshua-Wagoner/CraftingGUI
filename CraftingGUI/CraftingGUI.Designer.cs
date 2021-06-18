
namespace CraftingGUI
{
    partial class CraftingGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recipeComboBox = new System.Windows.Forms.ComboBox();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.recipeOutputBox = new System.Windows.Forms.RichTextBox();
            this.recipeConfirmBtn = new System.Windows.Forms.Button();
            this.itemOutputBox = new System.Windows.Forms.RichTextBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemConfirmBtn = new System.Windows.Forms.Button();
            this.itemCreationBox = new System.Windows.Forms.GroupBox();
            this.createItemNameTextBox = new System.Windows.Forms.TextBox();
            this.createItemNameLabel = new System.Windows.Forms.Label();
            this.createItemBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.itemCreationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipeComboBox
            // 
            this.recipeComboBox.FormattingEnabled = true;
            this.recipeComboBox.Location = new System.Drawing.Point(12, 35);
            this.recipeComboBox.MaxDropDownItems = 6;
            this.recipeComboBox.Name = "recipeComboBox";
            this.recipeComboBox.Size = new System.Drawing.Size(121, 23);
            this.recipeComboBox.TabIndex = 0;
            this.recipeComboBox.SelectedIndexChanged += new System.EventHandler(this.recipeComboBox_SelectedIndexChanged);
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Location = new System.Drawing.Point(13, 13);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(42, 15);
            this.recipeLabel.TabIndex = 1;
            this.recipeLabel.Text = "Recipe";
            // 
            // recipeOutputBox
            // 
            this.recipeOutputBox.Location = new System.Drawing.Point(12, 82);
            this.recipeOutputBox.Name = "recipeOutputBox";
            this.recipeOutputBox.ReadOnly = true;
            this.recipeOutputBox.Size = new System.Drawing.Size(230, 167);
            this.recipeOutputBox.TabIndex = 2;
            this.recipeOutputBox.Text = "";
            this.recipeOutputBox.WordWrap = false;
            // 
            // recipeConfirmBtn
            // 
            this.recipeConfirmBtn.Location = new System.Drawing.Point(167, 34);
            this.recipeConfirmBtn.Name = "recipeConfirmBtn";
            this.recipeConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.recipeConfirmBtn.TabIndex = 3;
            this.recipeConfirmBtn.Text = "Display";
            this.recipeConfirmBtn.UseVisualStyleBackColor = true;
            this.recipeConfirmBtn.Click += new System.EventHandler(this.recipeConfirmBtn_Click);
            // 
            // itemOutputBox
            // 
            this.itemOutputBox.Location = new System.Drawing.Point(260, 82);
            this.itemOutputBox.Name = "itemOutputBox";
            this.itemOutputBox.ReadOnly = true;
            this.itemOutputBox.Size = new System.Drawing.Size(230, 101);
            this.itemOutputBox.TabIndex = 6;
            this.itemOutputBox.Text = "";
            this.itemOutputBox.WordWrap = false;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(261, 13);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(31, 15);
            this.itemLabel.TabIndex = 5;
            this.itemLabel.Text = "Item";
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(260, 35);
            this.itemComboBox.MaxDropDownItems = 5;
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(121, 23);
            this.itemComboBox.TabIndex = 4;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // itemConfirmBtn
            // 
            this.itemConfirmBtn.Location = new System.Drawing.Point(415, 35);
            this.itemConfirmBtn.Name = "itemConfirmBtn";
            this.itemConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.itemConfirmBtn.TabIndex = 7;
            this.itemConfirmBtn.Text = "Display";
            this.itemConfirmBtn.UseVisualStyleBackColor = true;
            this.itemConfirmBtn.Click += new System.EventHandler(this.itemConfirmBtn_Click);
            // 
            // itemCreationBox
            // 
            this.itemCreationBox.Controls.Add(this.createItemNameTextBox);
            this.itemCreationBox.Controls.Add(this.createItemNameLabel);
            this.itemCreationBox.Controls.Add(this.createItemBtn);
            this.itemCreationBox.Location = new System.Drawing.Point(261, 207);
            this.itemCreationBox.Name = "itemCreationBox";
            this.itemCreationBox.Size = new System.Drawing.Size(200, 101);
            this.itemCreationBox.TabIndex = 9;
            this.itemCreationBox.TabStop = false;
            this.itemCreationBox.Text = "Create Item";
            // 
            // createItemNameTextBox
            // 
            this.createItemNameTextBox.Location = new System.Drawing.Point(81, 28);
            this.createItemNameTextBox.Name = "createItemNameTextBox";
            this.createItemNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.createItemNameTextBox.TabIndex = 3;
            // 
            // createItemNameLabel
            // 
            this.createItemNameLabel.AutoSize = true;
            this.createItemNameLabel.Location = new System.Drawing.Point(6, 28);
            this.createItemNameLabel.Name = "createItemNameLabel";
            this.createItemNameLabel.Size = new System.Drawing.Size(69, 15);
            this.createItemNameLabel.TabIndex = 2;
            this.createItemNameLabel.Text = "Item Name:";
            // 
            // createItemBtn
            // 
            this.createItemBtn.Location = new System.Drawing.Point(61, 69);
            this.createItemBtn.Name = "createItemBtn";
            this.createItemBtn.Size = new System.Drawing.Size(75, 23);
            this.createItemBtn.TabIndex = 1;
            this.createItemBtn.Text = "Create";
            this.createItemBtn.UseVisualStyleBackColor = true;
            this.createItemBtn.Click += new System.EventHandler(this.createItemBtn_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(86, 285);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CraftingGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 324);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.itemCreationBox);
            this.Controls.Add(this.itemConfirmBtn);
            this.Controls.Add(this.itemOutputBox);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.recipeConfirmBtn);
            this.Controls.Add(this.recipeOutputBox);
            this.Controls.Add(this.recipeLabel);
            this.Controls.Add(this.recipeComboBox);
            this.Name = "CraftingGUI";
            this.Text = "Crafting";
            this.Load += new System.EventHandler(this.CraftingGUI_Load);
            this.itemCreationBox.ResumeLayout(false);
            this.itemCreationBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox recipeComboBox;
        private System.Windows.Forms.Label recipeLabel;
        private System.Windows.Forms.RichTextBox recipeOutputBox;
        private System.Windows.Forms.Button recipeConfirmBtn;
        private System.Windows.Forms.RichTextBox itemOutputBox;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Button itemConfirmBtn;
        private System.Windows.Forms.GroupBox itemCreationBox;
        private System.Windows.Forms.TextBox createItemNameTextBox;
        private System.Windows.Forms.Label createItemNameLabel;
        private System.Windows.Forms.Button createItemBtn;
        private System.Windows.Forms.Button exitButton;
    }
}

