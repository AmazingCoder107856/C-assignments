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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();            
        }
        /// <summary>              
        /// If user attempts to close form using the "X" button on form. If user
        /// has exited app using the menu exit then the form will automatically close        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("You are about to exit. Are you sure?", "Close Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)//if yes is clicked
            {
                //cancel the exit event
                Application.Exit();
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// creates an object of RoomForm and displays it as dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.ShowDialog();
        }
        /// <summary>
        /// creates an object of EmployeeForm and displays it as dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm addEmployeeForm = new EmployeeForm();
            addEmployeeForm.ShowDialog();
        }        
        /// <summary>
        /// Makes used of the form Timer control to update labeltext on every tick
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        /// <summary>
        /// Event handler for the MainForm load that displays the current time in labelTime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();            
        }
        /// <summary>
        /// creates an object of CustomerForm and displays it as dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }
        /// <summary>
        /// If user attempts to logout using the "Logout" button on form. 
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {            
            DialogResult dlgResult = MessageBox.Show("Are you sure you want to logout?", "Close Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)//if yes is clicked
            {
                this.Enabled = false;
                btnLogout.Text = "Login";                
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                btnLogout.Text = "Logout";
                this.Enabled = true;
            }
            else
            {
                return;                
            }            
        }
        /// <summary>
        /// creates an object of ReservationForm and displays it as dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationsForm reservationsForm = new ReservationsForm();
            reservationsForm.ShowDialog();
        }
        /// <summary>
        /// creates an object of AboutBox and displays it as dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }        
    }
}
