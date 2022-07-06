namespace AssignmentAB
{
    partial class FormIngredients
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
            this.lblNumIngredients = new System.Windows.Forms.Label();
            this.lblCurrNumber = new System.Windows.Forms.Label();
            this.grpIngredient = new System.Windows.Forms.GroupBox();
            this.listIngredients = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNameIngredient = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumIngredients
            // 
            this.lblNumIngredients.Location = new System.Drawing.Point(12, 18);
            this.lblNumIngredients.Name = "lblNumIngredients";
            this.lblNumIngredients.Size = new System.Drawing.Size(261, 23);
            this.lblNumIngredients.TabIndex = 0;
            this.lblNumIngredients.Text = "Number of ingredients";
            this.lblNumIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrNumber
            // 
            this.lblCurrNumber.Location = new System.Drawing.Point(508, 18);
            this.lblCurrNumber.Name = "lblCurrNumber";
            this.lblCurrNumber.Size = new System.Drawing.Size(173, 23);
            this.lblCurrNumber.TabIndex = 1;
            this.lblCurrNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpIngredient
            // 
            this.grpIngredient.Controls.Add(this.listIngredients);
            this.grpIngredient.Controls.Add(this.btnEdit);
            this.grpIngredient.Controls.Add(this.btnDelete);
            this.grpIngredient.Controls.Add(this.btnAdd);
            this.grpIngredient.Controls.Add(this.txtNameIngredient);
            this.grpIngredient.Location = new System.Drawing.Point(22, 59);
            this.grpIngredient.Name = "grpIngredient";
            this.grpIngredient.Size = new System.Drawing.Size(686, 366);
            this.grpIngredient.TabIndex = 2;
            this.grpIngredient.TabStop = false;
            this.grpIngredient.Text = "Ingredient";
            // 
            // listIngredients
            // 
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.ItemHeight = 20;
            this.listIngredients.Location = new System.Drawing.Point(6, 67);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(562, 284);
            this.listIngredients.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(584, 77);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(584, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(584, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNameIngredient
            // 
            this.txtNameIngredient.Location = new System.Drawing.Point(6, 34);
            this.txtNameIngredient.Name = "txtNameIngredient";
            this.txtNameIngredient.Size = new System.Drawing.Size(562, 26);
            this.txtNameIngredient.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(323, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(198, 442);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(720, 506);
            this.Controls.Add(this.grpIngredient);
            this.Controls.Add(this.lblCurrNumber);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblNumIngredients);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormIngredients";
            this.Load += new System.EventHandler(this.FormIngredients_Load);
            this.grpIngredient.ResumeLayout(false);
            this.grpIngredient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumIngredients;
        private System.Windows.Forms.Label lblCurrNumber;
        private System.Windows.Forms.GroupBox grpIngredient;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNameIngredient;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.ListBox listIngredients;
    }
}