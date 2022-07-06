namespace Assignment5ABC
{
    partial class ContactForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpEmail = new System.Windows.Forms.GroupBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtEmailPriv = new System.Windows.Forms.TextBox();
            this.txtEmailBus = new System.Windows.Forms.TextBox();
            this.lblEmailPriv = new System.Windows.Forms.Label();
            this.lblEmailBus = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.grpName.SuspendLayout();
            this.grpEmail.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOk.Location = new System.Drawing.Point(115, 627);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(180, 36);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(357, 627);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.txtLastName);
            this.grpName.Controls.Add(this.txtFirstName);
            this.grpName.Controls.Add(this.lblLastName);
            this.grpName.Controls.Add(this.lblFirstName);
            this.grpName.Location = new System.Drawing.Point(12, 21);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(575, 114);
            this.grpName.TabIndex = 0;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(158, 67);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(381, 26);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Tag = "TextBoxes";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(158, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(381, 26);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Tag = "TextBoxes";
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(68, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(68, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpEmail
            // 
            this.grpEmail.Controls.Add(this.txtHomePhone);
            this.grpEmail.Controls.Add(this.txtCellPhone);
            this.grpEmail.Controls.Add(this.txtEmailPriv);
            this.grpEmail.Controls.Add(this.txtEmailBus);
            this.grpEmail.Controls.Add(this.lblEmailPriv);
            this.grpEmail.Controls.Add(this.lblEmailBus);
            this.grpEmail.Controls.Add(this.lblCellPhone);
            this.grpEmail.Controls.Add(this.lblHomePhone);
            this.grpEmail.Location = new System.Drawing.Point(12, 164);
            this.grpEmail.Name = "grpEmail";
            this.grpEmail.Size = new System.Drawing.Size(575, 218);
            this.grpEmail.TabIndex = 1;
            this.grpEmail.TabStop = false;
            this.grpEmail.Text = "Email and phone";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(158, 33);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(381, 26);
            this.txtHomePhone.TabIndex = 0;
            this.txtHomePhone.Tag = "TextBoxes";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(158, 73);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(381, 26);
            this.txtCellPhone.TabIndex = 1;
            this.txtCellPhone.Tag = "TextBoxes";
            // 
            // txtEmailPriv
            // 
            this.txtEmailPriv.Location = new System.Drawing.Point(158, 172);
            this.txtEmailPriv.Name = "txtEmailPriv";
            this.txtEmailPriv.Size = new System.Drawing.Size(381, 26);
            this.txtEmailPriv.TabIndex = 3;
            this.txtEmailPriv.Tag = "TextBoxes";
            // 
            // txtEmailBus
            // 
            this.txtEmailBus.Location = new System.Drawing.Point(158, 123);
            this.txtEmailBus.Name = "txtEmailBus";
            this.txtEmailBus.Size = new System.Drawing.Size(381, 26);
            this.txtEmailBus.TabIndex = 2;
            this.txtEmailBus.Tag = "TextBoxes";
            // 
            // lblEmailPriv
            // 
            this.lblEmailPriv.AutoSize = true;
            this.lblEmailPriv.Location = new System.Drawing.Point(44, 178);
            this.lblEmailPriv.Name = "lblEmailPriv";
            this.lblEmailPriv.Size = new System.Drawing.Size(108, 20);
            this.lblEmailPriv.TabIndex = 4;
            this.lblEmailPriv.Text = "E-mail, private";
            this.lblEmailPriv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailBus
            // 
            this.lblEmailBus.AutoSize = true;
            this.lblEmailBus.Location = new System.Drawing.Point(28, 126);
            this.lblEmailBus.Name = "lblEmailBus";
            this.lblEmailBus.Size = new System.Drawing.Size(124, 20);
            this.lblEmailBus.TabIndex = 3;
            this.lblEmailBus.Text = "E-mail, business";
            this.lblEmailBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(68, 79);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(84, 20);
            this.lblCellPhone.TabIndex = 2;
            this.lblCellPhone.Text = "Cell phone";
            this.lblCellPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(51, 39);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(101, 20);
            this.lblHomePhone.TabIndex = 1;
            this.lblHomePhone.Text = "Home phone";
            this.lblHomePhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.comboBoxCountry);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.txtZipCode);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.lblZipCode);
            this.grpAddress.Controls.Add(this.lblCountry);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Location = new System.Drawing.Point(12, 412);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(575, 194);
            this.grpAddress.TabIndex = 2;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(158, 147);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(381, 28);
            this.comboBoxCountry.TabIndex = 3;
            this.comboBoxCountry.Tag = "";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(158, 25);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(381, 26);
            this.txtStreet.TabIndex = 0;
            this.txtStreet.Tag = "TextBoxes";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(158, 101);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(381, 26);
            this.txtZipCode.TabIndex = 2;
            this.txtZipCode.Tag = "TextBoxes";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(158, 59);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(381, 26);
            this.txtCity.TabIndex = 1;
            this.txtCity.Tag = "TextBoxes";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(117, 65);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(82, 107);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(70, 20);
            this.lblZipCode.TabIndex = 3;
            this.lblZipCode.Text = "Zip code";
            this.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(88, 155);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(64, 20);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(99, 31);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(53, 20);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "Street";
            this.lblStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 684);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpEmail);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "ContactForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactForm_FormClosing);
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpEmail.ResumeLayout(false);
            this.grpEmail.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmailPriv;
        private System.Windows.Forms.Label lblEmailBus;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblStreet;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtHomePhone;
        public System.Windows.Forms.TextBox txtCellPhone;
        public System.Windows.Forms.TextBox txtEmailPriv;
        public System.Windows.Forms.TextBox txtEmailBus;
        public System.Windows.Forms.TextBox txtStreet;
        public System.Windows.Forms.TextBox txtZipCode;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.ComboBox comboBoxCountry;
        public System.Windows.Forms.GroupBox grpName;
        public System.Windows.Forms.GroupBox grpEmail;
        public System.Windows.Forms.GroupBox grpAddress;
    }
}