using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class LoginForm : Form
    {
        MainForm mainForm = new MainForm(); 
        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            
        }
        
        /// <summary>        
        /// If user attempts to login using the "Login" button on form. 
        /// </summary>        
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "hotelbooking" && txtPassword.Text == "hotel")
            {
                lblError.Visible = false;
                this.Hide();
                mainForm.Enabled = true;
                mainForm.Show();
                mainForm.StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                lblError.Visible = true;
                txtPassword.Clear();
            }
        }
        /// <summary>
        /// LoginForm showDialog is loading together with MainForm but MainForm 
        /// is inactive until the user press the login button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {            
            mainForm.Show();
            mainForm.Enabled = false;            
        }
    }
}
