using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment7
{
    public partial class CustomerForm : Form
    {
        //FIELDS
        private CustomerManager customerManager;
        //Working with only one file located in the same directory as the application's EXE-file
        private string fileName = Application.StartupPath + "\\Customers.txt";        

        //customer object receiving input and/or sending output
        private Customer customer;

        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerForm()
        {
            InitializeComponent();
            customerManager = new CustomerManager();//creates an instance of CustomerManager
            //customerManager.TestValues(); 
            InitializeGUI();   //initializes GUI to default values         
        }
        /// <summary>
        /// Property CustomerData to read customer value, with access to read and write.
        /// </summary>
        public Customer CustomerData
        {
            get
            {
                return customer;
            }
            set
            {
                if (value != null)
                    customer = value;                
            }
        }
        /// <summary>
        /// Initialization where method can be called to reset the program
        /// </summary>
        private void InitializeGUI()
        {
            ClearForm();
        }
        /// <summary>
        /// This method updates the GUI so it will display correct information
        /// in the listbox and sets the combobox to default value
        /// </summary>
        private void UpdateGUI()
        {            
            string[] infoStrings = customerManager.GetInfoStringsList();
            if (infoStrings != null)
                listCustomer.Items.AddRange(infoStrings);
            ClearForm();
        }
        // <summary>
        /// updates it with the customer values of the 
        /// customerMngr arraylist
        /// </summary>
        private void UpdateCustomerList()
        {
            {                
                for (int index = 0; index <= (customerManager.Count - 1); index++)
                {
                    listCustomer.Items.Add(customerManager.GetCustomer(index).ToString());
                }
            }
        }
        /// <summary>
        /// clears controls of info
        /// </summary>
        private void ClearForm()
        {           
            listCustomer.Items.Clear();
            txtID.Text = string.Empty;
            txtNumber.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            cmbGenderType.Items.Clear();
            cmbGenderType.Items.AddRange(Enum.GetNames(typeof(GenderType)));
            cmbGenderType.SelectedIndex = (int)GenderType.Male;
            txtStreet.Text = string.Empty;
            txtZipcode.Text = string.Empty;
            txtCity.Text = string.Empty;
            cmbCountry.Items.Clear();
            cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry.SelectedIndex = (int)Countries.Sverige;
            txtHomephone.Text = string.Empty;
            txtMobilephone.Text = string.Empty;
            txtEmailBus.Text = string.Empty;
            txtEmailPriv.Text = string.Empty;            
            txtID1.Text = string.Empty;
            txtNumber1.Text = string.Empty;
            txtName1.Text = string.Empty;
            txtAge1.Text = string.Empty;
            cmbGender1.Items.Clear();
            cmbGender1.Items.AddRange(Enum.GetNames(typeof(GenderType)));
            cmbGender1.SelectedIndex = (int)GenderType.Male;
            txtStreet1.Text = string.Empty;
            txtZipcode1.Text = string.Empty;
            txtCity1.Text = string.Empty;
            cmbCountry1.Items.Clear();
            cmbCountry1.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry1.SelectedIndex = (int)Countries.Sverige;
            txtHomephone1.Text = string.Empty;
            txtMobilephone1.Text = string.Empty;
            txtEmailBus1.Text = string.Empty;
            txtEmailPriv1.Text = string.Empty;
        }
        /// <summary>
        /// Event handler for the click event of Add to listbox customer item        
        /// then update the GUI and update customerList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            //Validate the user given values            
            if (!ReadInput())
            {
                return;
            }            
            else 
            {
                if (MessageBox.Show("Are you sure you want to add all data?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {                    
                    customer.ContactData.ID = txtID.Text;
                    customer.ContactData.IdNumber = txtNumber.Text;
                    customer.ContactData.FullName = txtName.Text;
                    customer.ContactData.Age = txtAge.Text;
                    customer.ContactData.Gender = (GenderType)cmbGenderType.SelectedIndex;
                    customer.ContactData.AddressData.Street = txtStreet.Text;
                    customer.ContactData.AddressData.City = txtCity.Text;
                    customer.ContactData.AddressData.ZipCode = txtZipcode.Text;
                    customer.ContactData.AddressData.Country = (Countries)cmbCountry.SelectedIndex;
                    customer.ContactData.PhoneData.PhoneHome = txtHomephone.Text;
                    customer.ContactData.PhoneData.PhoneWork = txtMobilephone.Text;
                    customer.ContactData.EmailData.EmailBusiness = txtEmailBus.Text;
                    customer.ContactData.EmailData.EmailPrivate = txtEmailPriv.Text;
                    customerManager.AddCustomer(customer);
                    grpAddNewCustomer.Hide();
                    grpCustomerDetails.Show();
                    UpdateGUI();
                    UpdateCustomerList();                                       
                }
                else
                {
                    if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        grpAddNewCustomer.Hide();
                        grpCustomerDetails.Show();
                        UpdateCustomerList();
                        MessageBox.Show("No changes have been added!");
                    }
                    else 
                    {
                        return;
                    }
                }
            }                
            //if no customer is present then create a new customer
            if (customer == null)
            {
                customer = new Customer();
            }                       
        }               
        /// <summary>
        /// Validates the user's inputs
        /// </summary>
        /// <returns>returns true if all the fields are validated</returns>
        private bool ReadInput()
        {
            //calls checkstring method of inpututility class
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("ID cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return false;
            }
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("ID number cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty! Please provide customer's complete name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return false;
            }
            if ((string.IsNullOrEmpty(txtStreet.Text)) || (string.IsNullOrEmpty(txtZipcode.Text)) || (string.IsNullOrEmpty(txtCity.Text)))
            {
                MessageBox.Show("Address cannot be empty! Please provide customer's complete address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((string.IsNullOrEmpty(txtHomephone.Text)) && (string.IsNullOrEmpty(txtMobilephone.Text)))
            {
                MessageBox.Show("Please provide at least one contact number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return false;
            }            
            if ((string.IsNullOrEmpty(txtEmailBus.Text)) && (string.IsNullOrEmpty(txtEmailPriv.Text)))
            {
                MessageBox.Show("Please provide at least one email address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return false;
            }            
            return true;
        }
        /// <summary>
        /// Event handler for the click event of Cancel the adding and the changing of a listbox item        
        /// then update the CustomerList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                grpAddNewCustomer.Hide();
                grpCustomerDetails.Show();
                UpdateCustomerList();
                MessageBox.Show("No changes have been added!");
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }            
        }
        /// <summary>
        /// Event handler for the click event of Cancel the adding and the changing of a listbox item        
        /// then update the GUI and CustomerList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            //Validate the user given values            
            if (!ReadInput())
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to change?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    customer.ContactData.ID = txtID1.Text;
                    customer.ContactData.IdNumber = txtNumber1.Text;
                    customer.ContactData.FullName = txtName1.Text;
                    customer.ContactData.Age = txtAge1.Text;
                    customer.ContactData.Gender = (GenderType)cmbGender1.SelectedIndex;
                    customer.ContactData.AddressData.Street = txtStreet1.Text;
                    customer.ContactData.AddressData.City = txtCity1.Text;
                    customer.ContactData.AddressData.ZipCode = txtZipcode1.Text;
                    customer.ContactData.AddressData.Country = (Countries)cmbCountry1.SelectedIndex;
                    customer.ContactData.PhoneData.PhoneHome = txtHomephone1.Text;
                    customer.ContactData.PhoneData.PhoneWork = txtMobilephone1.Text;
                    customer.ContactData.EmailData.EmailBusiness = txtEmailBus1.Text;
                    customer.ContactData.EmailData.EmailPrivate = txtEmailPriv1.Text;
                    customerManager.ChangeCustomer(customer.ContactData, listCustomer.SelectedIndex);
                    grpEditCustomer.Hide();
                    grpCustomerDetails.Show();                    
                    UpdateGUI();
                    UpdateCustomerList();
                }
                else
                {
                    if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        grpEditCustomer.Hide();
                        grpCustomerDetails.Show();                        
                        MessageBox.Show("No changes have been added!");
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        /// <summary>
        /// Event handler for the click event of Cancel the adding and the changing of a listbox item         
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                grpEditCustomer.Hide();
                grpCustomerDetails.Show();                
                MessageBox.Show("No changes have been added!");
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }
        /// <summary>
        /// When listbox index is changed the index is checked, 
        /// if index is valid for customerList, the Change/Delete buttons are enabled 
        /// and a local Customer object is created to add the stored values to the 
        /// form controls
        /// </summary>
        private void listCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if a valid index has been selected
            bool ok = customerManager.CheckIndex(listCustomer.SelectedIndex);
            if (ok)//index valid
            {                
                Customer customer = new Customer(customerManager.GetCustomer(listCustomer.SelectedIndex));
                //sets the values of task to the form controls
                txtID.Text = customer.ContactData.ID;
                txtNumber.Text = customer.ContactData.IdNumber;
                txtName.Text = customer.ContactData.FullName;
                txtAge.Text = customer.ContactData.Age;
                cmbGenderType.SelectedIndex = (int)customer.ContactData.Gender;
                txtStreet.Text = customer.ContactData.AddressData.Street;
                txtZipcode.Text = customer.ContactData.AddressData.ZipCode;
                txtCity.Text = customer.ContactData.AddressData.City;
                cmbCountry.SelectedIndex = (int)customer.ContactData.AddressData.Country;
                txtHomephone.Text = customer.ContactData.PhoneData.PhoneHome;
                txtMobilephone.Text = customer.ContactData.PhoneData.PhoneWork;
                txtEmailBus.Text = customer.ContactData.EmailData.EmailBusiness;
                txtEmailPriv.Text = customer.ContactData.EmailData.EmailPrivate;               
            }
        }
        /// <summary>
        /// Event handler for the click event of Change listbox customer item.
        /// If listbox is not empty then allow the user to change details of the customer
        /// at the selected index, else call showError() method
        /// then update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //perform the update if the list box is not empty                      
            if (listCustomer.Items.Count != 0)
            {                
                grpEditCustomer.Show();
                grpCustomerDetails.Hide();                

                //check if a valid index has been selected
                bool ok = customerManager.CheckIndex(listCustomer.SelectedIndex);
                if (ok)//index valid
                {
                    Customer customer = customerManager.GetCustomer(listCustomer.SelectedIndex);
                    //sets the values of task to the form controls
                    txtID1.Text = customer.ContactData.ID;
                    txtNumber1.Text = customer.ContactData.IdNumber;
                    txtName1.Text = customer.ContactData.FullName;
                    txtAge1.Text = customer.ContactData.Age;
                    cmbGender1.SelectedIndex = (int)customer.ContactData.Gender;
                    txtStreet1.Text = customer.ContactData.AddressData.Street;
                    txtZipcode1.Text = customer.ContactData.AddressData.ZipCode;
                    txtCity1.Text = customer.ContactData.AddressData.City;
                    cmbCountry1.SelectedIndex = (int)customer.ContactData.AddressData.Country;
                    txtHomephone1.Text = customer.ContactData.PhoneData.PhoneHome;
                    txtMobilephone1.Text = customer.ContactData.PhoneData.PhoneWork;
                    txtEmailBus1.Text = customer.ContactData.EmailData.EmailBusiness;
                    txtEmailPriv1.Text = customer.ContactData.EmailData.EmailPrivate;
                }
                else //if index is not selected then show error, otherwise continue                
                {
                    grpEditCustomer.Hide();
                    grpCustomerDetails.Show();
                    MessageBox.Show("Please select an item in the list first to change!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
        /// If listbox is empty then user will not be able to update or delete any values.
        /// This method is called form click event of Delete and Change menuitems of Customer menu.
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("Customer list is empty.", "", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Event handler for the click event of Delete listbox task item.
        /// If listbox is not empty then allow the user to delete details of the customer
        /// at the selected index, else call showError() method
        /// then update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //continue with the deletion only if listbox is not empty
            if (listCustomer.Items.Count != 0)
            {
                int index = listCustomer.SelectedIndex;
                //show error if no index is selected, otherwise call the removeCustomer method of customerMngr for
                //deleting specific customerdetails at selected index
                if (index == -1)
                {
                    MessageBox.Show("Please select an item firstly!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dlgResult = MessageBox.Show("You are about to delete. Are you sure?", "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dlgResult == DialogResult.Yes)//if yes is clicked
                    {
                        customerManager.DeleteCustomerAt(index);                        
                        UpdateGUI();
                        UpdateCustomerList();                        
                    }
                    else
                    {
                        return;
                    }
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
        /// calls the method for saving data from CustomerManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = customerManager.WriteDataToFile(fileName);
            if (!ok) //if something went wrong
                MessageBox.Show(errMessage);
            else //display message that data was saved successfully
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileName);            
        }
        /// <summary>
        /// all that is needed is to call InitializeGUI and program will "reset"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();            
            grpAddNewCustomer.Show();
            grpCustomerDetails.Hide();
            txtID.Focus();
        }
        /// <summary>
        /// calls the method for opening data from customerManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openCustomerFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "You are opening a file, any unsaved data will be lost.\nProceed?";
            //will warn user that opening a file will delete any unsaved data
            if (MessageBox.Show(message, "Open File?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string errorMessage = "Something went wrong when reading data from file";
                //calls the method for reading data from CustomerManager and store bool value in "ok"
                bool ok = customerManager.ReadDataFromFile(fileName);
                if (!ok)//something went wrong
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else//if successful will update GUI with the taskList to the listbox
                {
                    grpAddNewCustomer.Hide();
                    grpCustomerDetails.Show();
                    //customerManager.TestValues();
                    UpdateGUI();
                    UpdateCustomerList();                    
                }
            }            
        }
        /// <summary>
        /// Event handler for the click event of Closing the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            grpCustomerDetails.Hide();
            listCustomer.Items.Clear();
        }
        /// <summary>
        /// calls the method for saving data from customerManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveCustomerFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = customerManager.WriteDataToFile(fileName);
            if (!ok) //if something went wrong
                MessageBox.Show(errMessage);
            else //display message that data was saved successfully
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileName);
        }
        /// <summary>
        /// menuItem Exit Alt-F4, check if user really want to quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitAlt4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a DailogResult from a messagebox with YesNo buttons
            DialogResult dlgResult = MessageBox.Show("You are about to exit. Are you sure?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)//if yes is clicked
            {
                //call exit method
                this.Close();
            }
            else
            {
                return;
            }
        }        
    }
}
