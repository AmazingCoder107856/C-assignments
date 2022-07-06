using Assignment5ABC.ContactFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Assignment5ABC
{
    public partial class MainForm : Form
    { 
        //creates the customerManager private object
        private CustomerManager customerManager;
        
        public MainForm()
        {
            InitializeComponent();
            //initialize customer manager object
            customerManager = new CustomerManager();            
            UpdateCustomerList();            
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            this.Text = "Customer Registry By Gloria Palm";            
        }
        // <summary>
        /// clears the listbox and updates it with the customer values of the 
        /// customerMngr arraylist
        /// </summary>
        private void UpdateCustomerList()
        {
            {                
                listCustomers.Items.Clear();                
                for (int index = 0; index <= (customerManager.Count - 1); index++)
                {
                    listCustomers.Items.Add(customerManager.GetCustomerAt(index).ToString());                    
                }
            }
        }
        /// <summary>
        /// Event handler for the click event of the Add menuítem of the Customer menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {            
            //create an instance of contactform(constructor with title as parameter)
            ContactForm contactForm = new ContactForm("Add new customer");
            DialogResult contactFormResult = contactForm.ShowDialog();            

            //if the user clicks OK on the customerform then call the UpdateCusomerList()
            //to update the listbox
            if (contactFormResult == DialogResult.OK) //show the ContactForm object
            {
                customerManager.AddCustomer(contactForm.CustomerData);                
                UpdateCustomerList();
            }
            if (contactFormResult == DialogResult.Cancel)
            {
                MessageBox.Show("No customer added!");
                return;
            }
        }
        /// <summary>
        /// Event handler for teh click event of Change menuitme of the Customer Menu.
        /// If list box is not empty then allow the user to change details of the customer
        /// at the selected index, else call showError() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //perform the update if the list box is not empty                      
            if (listCustomers.Items.Count > 0)
            {
                ContactForm contactForm = new ContactForm("Edit customer");
                int index = listCustomers.SelectedIndex;
                //if index is not selected then show error, otherwise continue
                if (index < 0)
                {
                    MessageBox.Show("Please select an item in the list", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else                
                {                    
                    Customer customer = customerManager.GetCustomerAt(index);
                    contactForm.txtFirstName.Text = customer.ContactData.FirstName;
                    contactForm.txtLastName.Text = customer.ContactData.LastName;
                    contactForm.txtHomePhone.Text = customer.ContactData.PhoneData.PhoneHome;
                    contactForm.txtCellPhone.Text = customer.ContactData.PhoneData.PhoneWork;
                    contactForm.txtEmailBus.Text = customer.ContactData.EmailData.EmailBusiness;
                    contactForm.txtEmailPriv.Text = customer.ContactData.EmailData.EmailPrivate;
                    contactForm.txtStreet.Text = customer.ContactData.AddressData.Street;
                    contactForm.txtCity.Text = customer.ContactData.AddressData.City;
                    contactForm.txtZipCode.Text = customer.ContactData.AddressData.ZipCode;                    
                    contactForm.comboBoxCountry.SelectedIndex = (int)customer.ContactData.AddressData.Country;

                    listCustomers.Enabled = false;
                    lblDisplay.Text = string.Empty;                    
                }
                //if the user clicks on the Ok button of the customerForm then continue with the updation
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show("Are you sure you want to change?", "Confirmation?", MessageBoxButtons.YesNo)
                    customerManager.ChangeCustomer(contactForm.CustomerData.ContactData, listCustomers.SelectedIndex);
                    UpdateCustomerList();
                    listCustomers.Enabled = true;
                    lblDisplay.Enabled = true;                                                          
                }
                else 
                {                   
                    MessageBox.Show("No changes were made!");
                    listCustomers.Enabled = true;
                    lblDisplay.Enabled = true;
                }
            }
            else
            {
                //if list box is empty, show error
                ShowError();
                return;
            }
        }
        /// <summary>
        /// If list box is empty then user will not be able to update or delete any values.
        /// This method is called form click event of Delete and Change menuitems of Customer menu.
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("Customer list is empty, choose the Add customer option to add a new customer.", "", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Event handler for click event of Delete menuitme of the Customer Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //continue with the deletion only if listbox is not empty
            if (listCustomers.Items.Count != 0)
            {
                int index = listCustomers.SelectedIndex;
                //show error if no index is selected, otherwise call the removeCustomer method of customerMngr for
                //deleting specific customerdetails at selected index
                if (index == -1)
                {
                    MessageBox.Show("Please select a listboax item!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show("Are you sure you want to delete all data?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {                    
                    customerManager.DeleteCustomerAt(index);
                    lblDisplay.Text = string.Empty;
                    UpdateCustomerList();
                }  
                else
                {

                }
            }
            else
            {
                //show error if list box is empty
                ShowError();
                return;
            }
        }
        /// <summary>
        /// Event handler for click event to select a menuitem of the Customer Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int index = listCustomers.SelectedIndex;
            if (index >= 0)
            {
                Customer customer = customerManager.GetCustomerAt(index);
                //lblDisplay.Text = String.Format(listCustomers.SelectedItem.ToString());
                lblDisplay.Text = customer.ContactData.FullName + "\n" + customer.ContactData.AddressData.Street.ToString() + "\n" +
                    customer.ContactData.AddressData.ZipCode.ToString() + customer.ContactData.AddressData.City.ToString() + "\n" +
                    customer.ContactData.AddressData.GetCountryString() + "\n" + "\n" + "Emails" + "\n" + "      Private      " +
                    customer.ContactData.EmailData.EmailPrivate.ToString() + "\n" + "      Office        " +
                    customer.ContactData.EmailData.EmailBusiness.ToString() + "\n" + "\n" + "Phone number" + "\n" + "      Private      " +
                    customer.ContactData.PhoneData.PhoneHome.ToString() + "\n" + "      Office        " +
                    customer.ContactData.PhoneData.PhoneWork.ToString();
            }            
            else
                MessageBox.Show("Select an item!");
        }        
        /// <summary>
        /// Event handler for the formClosing event of the MainForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //show message box to check whether user wants to close the form
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //close the form only if the user clicks on Yes button of the messagebox.
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }        
    }    
}
