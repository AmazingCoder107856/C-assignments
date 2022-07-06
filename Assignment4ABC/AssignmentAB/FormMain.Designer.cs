namespace AssignmentAB
{
    partial class FormMain
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
            this.grpAddRecipe = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.comboxCategory = new System.Windows.Forms.ComboBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.txtNameRecipe = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblNameRecipe = new System.Windows.Forms.Label();
            this.lblListRecipe = new System.Windows.Forms.Label();
            this.lblListNumOfIngredients = new System.Windows.Forms.Label();
            this.lblListCategory = new System.Windows.Forms.Label();
            this.listRecipe = new System.Windows.Forms.ListBox();
            this.btnEditBegin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.grpAddRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddRecipe
            // 
            this.grpAddRecipe.Controls.Add(this.lblDescription1);
            this.grpAddRecipe.Controls.Add(this.txtDescription);
            this.grpAddRecipe.Controls.Add(this.btnAddRecipe);
            this.grpAddRecipe.Controls.Add(this.comboxCategory);
            this.grpAddRecipe.Controls.Add(this.btnAddIngredients);
            this.grpAddRecipe.Controls.Add(this.txtNameRecipe);
            this.grpAddRecipe.Controls.Add(this.lblCategory);
            this.grpAddRecipe.Controls.Add(this.lblNameRecipe);
            this.grpAddRecipe.Location = new System.Drawing.Point(21, 22);
            this.grpAddRecipe.Name = "grpAddRecipe";
            this.grpAddRecipe.Size = new System.Drawing.Size(598, 524);
            this.grpAddRecipe.TabIndex = 0;
            this.grpAddRecipe.TabStop = false;
            this.grpAddRecipe.Text = "Add new recipe";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtDescription.Location = new System.Drawing.Point(19, 147);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(573, 306);
            this.txtDescription.TabIndex = 8;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(19, 469);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(573, 34);
            this.btnAddRecipe.TabIndex = 7;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // comboxCategory
            // 
            this.comboxCategory.FormattingEnabled = true;
            this.comboxCategory.Items.AddRange(new object[] {
            "Meats",
            "Pasta",
            "Pizza",
            "Fish",
            "Seafood",
            "Soups",
            "Stew",
            "Vegan",
            "Vegetarian",
            "Vegetarian_Dairy_Egg",
            "Other"});
            this.comboxCategory.Location = new System.Drawing.Point(106, 72);
            this.comboxCategory.Name = "comboxCategory";
            this.comboxCategory.Size = new System.Drawing.Size(236, 28);
            this.comboxCategory.TabIndex = 5;
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(348, 69);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(244, 32);
            this.btnAddIngredients.TabIndex = 4;
            this.btnAddIngredients.Text = "Add Ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // txtNameRecipe
            // 
            this.txtNameRecipe.Location = new System.Drawing.Point(167, 34);
            this.txtNameRecipe.Name = "txtNameRecipe";
            this.txtNameRecipe.Size = new System.Drawing.Size(425, 26);
            this.txtNameRecipe.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(15, 75);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 23);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblNameRecipe
            // 
            this.lblNameRecipe.Location = new System.Drawing.Point(15, 37);
            this.lblNameRecipe.Name = "lblNameRecipe";
            this.lblNameRecipe.Size = new System.Drawing.Size(127, 23);
            this.lblNameRecipe.TabIndex = 0;
            this.lblNameRecipe.Text = "Name of recipe";
            // 
            // lblListRecipe
            // 
            this.lblListRecipe.Location = new System.Drawing.Point(648, 28);
            this.lblListRecipe.Name = "lblListRecipe";
            this.lblListRecipe.Size = new System.Drawing.Size(85, 23);
            this.lblListRecipe.TabIndex = 2;
            this.lblListRecipe.Text = "Name";
            this.lblListRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListNumOfIngredients
            // 
            this.lblListNumOfIngredients.Location = new System.Drawing.Point(912, 9);
            this.lblListNumOfIngredients.Name = "lblListNumOfIngredients";
            this.lblListNumOfIngredients.Size = new System.Drawing.Size(97, 55);
            this.lblListNumOfIngredients.TabIndex = 3;
            this.lblListNumOfIngredients.Text = "No. of indgredients";
            this.lblListNumOfIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListCategory
            // 
            this.lblListCategory.Location = new System.Drawing.Point(769, 28);
            this.lblListCategory.Name = "lblListCategory";
            this.lblListCategory.Size = new System.Drawing.Size(85, 23);
            this.lblListCategory.TabIndex = 4;
            this.lblListCategory.Text = "Category";
            this.lblListCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listRecipe
            // 
            this.listRecipe.FormattingEnabled = true;
            this.listRecipe.ItemHeight = 20;
            this.listRecipe.Location = new System.Drawing.Point(651, 67);
            this.listRecipe.Name = "listRecipe";
            this.listRecipe.Size = new System.Drawing.Size(543, 384);
            this.listRecipe.TabIndex = 5;
            this.listRecipe.SelectedIndexChanged += new System.EventHandler(this.listRecipe_SelectedIndexChanged);
            this.listRecipe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listRecipe_MouseDoubleClick);
            // 
            // btnEditBegin
            // 
            this.btnEditBegin.Location = new System.Drawing.Point(652, 467);
            this.btnEditBegin.Name = "btnEditBegin";
            this.btnEditBegin.Size = new System.Drawing.Size(115, 30);
            this.btnEditBegin.TabIndex = 6;
            this.btnEditBegin.Text = "Edit-Begin";
            this.btnEditBegin.UseVisualStyleBackColor = true;
            this.btnEditBegin.Click += new System.EventHandler(this.btnEditBegin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1015, 467);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(894, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditFinish
            // 
            this.btnEditFinish.Location = new System.Drawing.Point(773, 467);
            this.btnEditFinish.Name = "btnEditFinish";
            this.btnEditFinish.Size = new System.Drawing.Size(115, 30);
            this.btnEditFinish.TabIndex = 9;
            this.btnEditFinish.Text = "Edit-Finish";
            this.btnEditFinish.UseVisualStyleBackColor = true;
            this.btnEditFinish.Click += new System.EventHandler(this.btnEditFinish_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1052, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(718, 514);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 20);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription1
            // 
            this.lblDescription1.BackColor = System.Drawing.Color.White;
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDescription1.Location = new System.Drawing.Point(19, 112);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(573, 41);
            this.lblDescription1.TabIndex = 9;
            this.lblDescription1.Text = "Ingredients and cooking instructions:";
            this.lblDescription1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1248, 603);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditFinish);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEditBegin);
            this.Controls.Add(this.listRecipe);
            this.Controls.Add(this.lblListCategory);
            this.Controls.Add(this.lblListNumOfIngredients);
            this.Controls.Add(this.lblListRecipe);
            this.Controls.Add(this.grpAddRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Favorite Recipes by";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.grpAddRecipe.ResumeLayout(false);
            this.grpAddRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddRecipe;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.Label lblNameRecipe;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Label lblListRecipe;
        private System.Windows.Forms.Label lblListNumOfIngredients;
        private System.Windows.Forms.Label lblListCategory;
        private System.Windows.Forms.Button btnEditBegin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditFinish;
        public System.Windows.Forms.TextBox txtNameRecipe;
        public System.Windows.Forms.ListBox listRecipe;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox comboxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDescription1;
    }
}