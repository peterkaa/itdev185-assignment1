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
            this.txtInputRecipe = new System.Windows.Forms.TextBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnUpdateRecipe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrepTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInputIngred = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInputPrep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInputInst = new System.Windows.Forms.TextBox();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipes";
            // 
            // listRecipes
            // 
            this.listRecipes.FormattingEnabled = true;
            this.listRecipes.ItemHeight = 16;
            this.listRecipes.Location = new System.Drawing.Point(22, 248);
            this.listRecipes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listRecipes.Name = "listRecipes";
            this.listRecipes.Size = new System.Drawing.Size(133, 212);
            this.listRecipes.TabIndex = 1;
            this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
            // 
            // listIngredients
            // 
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.ItemHeight = 16;
            this.listIngredients.Location = new System.Drawing.Point(177, 248);
            this.listIngredients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(137, 212);
            this.listIngredients.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recipe Ingredients";
            // 
            // txtInputRecipe
            // 
            this.txtInputRecipe.Location = new System.Drawing.Point(122, 47);
            this.txtInputRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputRecipe.Name = "txtInputRecipe";
            this.txtInputRecipe.Size = new System.Drawing.Size(132, 22);
            this.txtInputRecipe.TabIndex = 4;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(18, 187);
            this.btnAddRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(100, 28);
            this.btnAddRecipe.TabIndex = 5;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.Location = new System.Drawing.Point(126, 187);
            this.btnUpdateRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.Size = new System.Drawing.Size(137, 28);
            this.btnUpdateRecipe.TabIndex = 6;
            this.btnUpdateRecipe.Text = "Update Recipe";
            this.btnUpdateRecipe.UseVisualStyleBackColor = true;
            this.btnUpdateRecipe.Click += new System.EventHandler(this.btnUpdateRecipe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "PrepTime (Minutes)";
            // 
            // txtPrepTime
            // 
            this.txtPrepTime.Location = new System.Drawing.Point(333, 248);
            this.txtPrepTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrepTime.Name = "txtPrepTime";
            this.txtPrepTime.Size = new System.Drawing.Size(129, 22);
            this.txtPrepTime.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Instructions";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(333, 296);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(411, 22);
            this.txtInstructions.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Recipe Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ingredients";
            // 
            // txtInputIngred
            // 
            this.txtInputIngred.Location = new System.Drawing.Point(122, 77);
            this.txtInputIngred.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputIngred.Name = "txtInputIngred";
            this.txtInputIngred.Size = new System.Drawing.Size(343, 22);
            this.txtInputIngred.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Prep Time (min)";
            // 
            // txtInputPrep
            // 
            this.txtInputPrep.Location = new System.Drawing.Point(122, 109);
            this.txtInputPrep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputPrep.Name = "txtInputPrep";
            this.txtInputPrep.Size = new System.Drawing.Size(132, 22);
            this.txtInputPrep.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Instructions";
            // 
            // txtInputInst
            // 
            this.txtInputInst.Location = new System.Drawing.Point(122, 143);
            this.txtInputInst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInputInst.Name = "txtInputInst";
            this.txtInputInst.Size = new System.Drawing.Size(343, 22);
            this.txtInputInst.TabIndex = 17;
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(271, 187);
            this.btnDeleteRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(137, 28);
            this.btnDeleteRecipe.TabIndex = 18;
            this.btnDeleteRecipe.Text = "Delete Recipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(691, 442);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 485);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.txtInputInst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInputPrep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInputIngred);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrepTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateRecipe);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.txtInputRecipe);
            this.Controls.Add(this.listIngredients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRecipes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Cookbook";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRecipes;
        private System.Windows.Forms.ListBox listIngredients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInputRecipe;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnUpdateRecipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrepTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInputIngred;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInputPrep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInputInst;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

