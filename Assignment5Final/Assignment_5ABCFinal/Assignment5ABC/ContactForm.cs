using Assignment5ABC.ContactFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5ABC
{
    public partial class ContactForm : Form
    {        
        //customer object receiving input and/or sending output
        private Customer currCustomer;

        //flag to handle the closing of the form
        private bool closeForm;        
        
        //constructor with one parameter (title of the form)
        public ContactForm(string title)
        {
            InitializeComponent();
            //other initailization
            this.Text = title;              
            InitializeGUI();
        }
        /// <summary>
        /// Property CustomerData to read customer value, with access to read and write.
        /// </summary>
        public Customer CustomerData
        {
            get
            {
                return currCustomer;
            }
            set
            {
                if (value != null)
                    currCustomer = value;
                UpdateGUI(); //update input controls
            }
        }        
        private void InitializeGUI()
        {
            //this.Text = MainForm.SetValueForName;
            //populate the combobox and selct the default country as Sverige
            comboBoxCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            comboBoxCountry.SelectedIndex = (int)Countries.Sverige;            
            closeForm = true;
            ClearForm();
        }
        /// <summary>
        /// Update the controls of contactForm to the currCustomer object values
        /// </summary>
        private void UpdateGUI()
        {
            ClearForm();
            comboBoxCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            comboBoxCountry.SelectedIndex = (int)Countries.Sverige;
        }
        /// <summary>
        /// event handler for the click event of cancel button. It closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                UpdateGUI();
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }        
        /// <summary>
        /// Event handler for click event of the OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            //Validate the user given values
            if (!ReadInput())
            {
                return;              
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to add all data?", "Confirmation?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();                    
                }
                else
                {
                    this.Close();                   
                }
            }                   
            //if no customer is present then create a new customer
            if (currCustomer == null)
            {
                currCustomer = new Customer();
            }
            // passing the values given by the user to the fields
            //get selected coutry
            Countries selectedCountry = (Countries)Enum.Parse(typeof(Countries), (string)this.comboBoxCountry.SelectedItem);
            currCustomer.ContactData.AddressData = new Address(txtStreet.Text, txtZipCode.Text, txtCity.Text, selectedCountry);
            currCustomer.ContactData.EmailData = new Email(txtEmailBus.Text, txtEmailPriv.Text);
            currCustomer.ContactData.PhoneData = new Phone(txtHomePhone.Text, txtCellPhone.Text);
            currCustomer.ContactData.FirstName = txtFirstName.Text;
            currCustomer.ContactData.LastName = txtLastName.Text;
            UpdateGUI();
        }
        /// <summary>
        /// Validates the firstname, lastname, city 
        /// </summary>
        /// <returns>returns true if all the fields are validated</returns>
        private bool ReadInput()
        {
            //calls checkstring method of inpututility class
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("First name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFirstName.Text = "First Name*";
                return false;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Last name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLastName.Text = "Last Name*";
                return false;
            }
            if ((string.IsNullOrEmpty(txtHomePhone.Text)) && (string.IsNullOrEmpty(txtCellPhone.Text)))
            {
                MessageBox.Show("Please provide at least one contact number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblHomePhone.Text = "Home Phone*";
                lblCellPhone.Text = "Work Phone*";
                return false;
            }            
            if ((string.IsNullOrEmpty(txtEmailBus.Text)) && (string.IsNullOrEmpty(txtEmailPriv.Text)))
            {
                MessageBox.Show("Please provide at least one email address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmailBus.Text = "Work Email*";
                lblEmailPriv.Text = "Personal Email*";
                return false;
            }                    
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("City is required", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCity.Text = "City*";
                return false;
            }
            return true;                      
        }        
        /// <summary>
        /// Event handler for formcolosing event of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false; //close the customer form
            else
                e.Cancel = true; //Do not close (user has chosen to cancel)
        }               
        private void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtHomePhone.Text = string.Empty;
            txtCellPhone.Text = string.Empty;
            txtEmailBus.Text = string.Empty;
            txtEmailPriv.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtZipCode.Text = string.Empty;
            comboBoxCountry.SelectedIndex = (int)Countries.Sverige;
        }
        Control ctrl;      
        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                {
                    this.SelectNextControl(ctrl, true, true, true, true);
                    e.Handled = e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    this.SelectNextControl(ctrl, false, true, true, true);
                    e.Handled = e.SuppressKeyPress = true;
                }
                else
                    return;
            }           
        }        
    }
}
