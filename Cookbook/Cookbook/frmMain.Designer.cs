namespace Cookbook
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listRecipes = new System.Windows.Forms.ListBox();
            this.listIngredients = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipes";
            // 
            // listRecipes
            // 
            this.listRecipes.FormattingEnabled = true;
            this.listRecipes.Location = new System.Drawing.Point(15, 222);
            this.listRecipes.Name = "listRecipes";
            this.listRecipes.Size = new System.Drawing.Size(120, 173);
            this.listRecipes.TabIndex = 1;
            this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
            // 
            // listIngredients
            // 
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.Location = new System.Drawing.Point(141, 222);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(120, 173);
            this.listIngredients.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recipe Ingredients";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(15, 13);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(100, 20);
            this.txtRecipeName.TabIndex = 4;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(40, 39);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecipe.TabIndex = 5;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(131, 39);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateName.TabIndex = 6;
            this.btnUpdateName.Text = "Update Recipe";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 407);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.listIngredients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRecipes);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Cookbook";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRecipes;
        private System.Windows.Forms.ListBox listIngredients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnUpdateName;
    }
}

