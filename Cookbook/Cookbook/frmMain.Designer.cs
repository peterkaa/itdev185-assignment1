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
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipes";
            // 
            // listRecipes
            // 
            this.listRecipes.FormattingEnabled = true;
            this.listRecipes.Location = new System.Drawing.Point(15, 175);
            this.listRecipes.Name = "listRecipes";
            this.listRecipes.Size = new System.Drawing.Size(101, 173);
            this.listRecipes.TabIndex = 1;
            this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
            // 
            // listIngredients
            // 
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.Location = new System.Drawing.Point(131, 175);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(104, 173);
            this.listIngredients.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recipe Ingredients";
            // 
            // txtInputRecipe
            // 
            this.txtInputRecipe.Location = new System.Drawing.Point(90, 11);
            this.txtInputRecipe.Name = "txtInputRecipe";
            this.txtInputRecipe.Size = new System.Drawing.Size(100, 20);
            this.txtInputRecipe.TabIndex = 4;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(12, 125);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecipe.TabIndex = 5;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.Location = new System.Drawing.Point(93, 125);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateRecipe.TabIndex = 6;
            this.btnUpdateRecipe.Text = "Update Recipe";
            this.btnUpdateRecipe.UseVisualStyleBackColor = true;
            this.btnUpdateRecipe.Click += new System.EventHandler(this.btnUpdateRecipe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PrepTime (Minutes)";
            // 
            // txtPrepTime
            // 
            this.txtPrepTime.Location = new System.Drawing.Point(248, 175);
            this.txtPrepTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrepTime.Name = "txtPrepTime";
            this.txtPrepTime.Size = new System.Drawing.Size(98, 20);
            this.txtPrepTime.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Instructions";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(248, 214);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(309, 20);
            this.txtInstructions.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Recipe Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ingredients";
            // 
            // txtInputIngred
            // 
            this.txtInputIngred.Location = new System.Drawing.Point(90, 36);
            this.txtInputIngred.Name = "txtInputIngred";
            this.txtInputIngred.Size = new System.Drawing.Size(258, 20);
            this.txtInputIngred.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Prep Time (min)";
            // 
            // txtInputPrep
            // 
            this.txtInputPrep.Location = new System.Drawing.Point(90, 62);
            this.txtInputPrep.Name = "txtInputPrep";
            this.txtInputPrep.Size = new System.Drawing.Size(100, 20);
            this.txtInputPrep.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Instructions";
            // 
            // txtInputInst
            // 
            this.txtInputInst.Location = new System.Drawing.Point(90, 89);
            this.txtInputInst.Name = "txtInputInst";
            this.txtInputInst.Size = new System.Drawing.Size(258, 20);
            this.txtInputInst.TabIndex = 17;
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(202, 125);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteRecipe.TabIndex = 18;
            this.btnDeleteRecipe.Text = "Delete Recipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Help Menu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(517, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 367);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
    }
}

