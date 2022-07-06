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
    public partial class EmployeeForm : Form
    {
        private EmployeeManager employeeManager;
        //Working with only one file located in the same directory as the application's EXE-file
        private string fileEmployeeName = Application.StartupPath + "\\Employees.txt";

        //customer object receiving input and/or sending output
        private Employee employee;

        /// <summary>
        /// Default constructor
        /// </summary>
        public EmployeeForm()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();//creates an instance of EmployeeManager
            //employeeManager.TestValues();            
            InitializeGUI();   //initializes GUI to default values         
        }
        /// <summary>
        /// Property EmployeeData to read employee value, with access to read and write.
        /// </summary>
        public Employee EmployeeData
        {
            get
            {
                return employee;
            }
            set
            {
                if (value != null)
                    employee = value;                
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
            string[] employeeInfoStrings = employeeManager.GetEmployeeInfoStringsList();
            if (employeeInfoStrings != null)
                listEmployee.Items.AddRange(employeeInfoStrings);
            ClearForm();
        }
        // <summary>
        /// updates it with the employee values of the 
        /// employeeMngr arraylist
        /// </summary>
        private void UpdateEmployeeList()
        {
            {                
                for (int index = 0; index <= (employeeManager.Count - 1); index++)
                {
                    listEmployee.Items.Add(employeeManager.GetEmployee(index).ToString());
                }
            }
        }
        /// <summary>
        /// clears controls of info
        /// </summary>
        private void ClearForm()
        {
            listEmployee.Items.Clear();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAge.Text = string.Empty;
            cmbGenderType.Items.Clear();
            cmbGenderType.Items.AddRange(Enum.GetNames(typeof(GenderType)));
            cmbGenderType.SelectedIndex = (int)GenderType.Male;
            cmbStatusType.Items.Clear();
            cmbStatusType.Items.AddRange(Enum.GetNames(typeof(StatusType)));
            cmbStatusType.SelectedIndex = (int)StatusType.Single;
            cmbJobType.Items.Clear();
            cmbJobType.Items.AddRange(Enum.GetNames(typeof(JobType)));
            cmbJobType.SelectedIndex = (int)JobType.Manager;
            txtSalary.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtZipcode.Text = string.Empty;
            txtCity.Text = string.Empty;
            cmbCountry.Items.Clear();
            cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry.SelectedIndex = (int)Countries.Sverige;
            txtMobilephone.Text = string.Empty;
            txtEmailPriv.Text = string.Empty;            
            txtFirstName1.Text = string.Empty;
            txtLastName1.Text = string.Empty;
            txtAge1.Text = string.Empty;
            cmbGender1.Items.Clear();
            cmbGender1.Items.AddRange(Enum.GetNames(typeof(GenderType)));
            cmbGender1.SelectedIndex = (int)GenderType.Male;
            cmbStatus1.Items.Clear();
            cmbStatus1.Items.AddRange(Enum.GetNames(typeof(StatusType)));
            cmbStatus1.SelectedIndex = (int)StatusType.Single;
            cmbJob1.Items.Clear();
            cmbJob1.Items.AddRange(Enum.GetNames(typeof(JobType)));
            cmbJob1.SelectedIndex = (int)JobType.Manager;
            txtSalary1.Text = string.Empty;
            txtStreet1.Text = string.Empty;
            txtZipcode1.Text = string.Empty;
            txtCity1.Text = string.Empty;
            cmbCountry1.Items.Clear();
            cmbCountry1.Items.AddRange(Enum.GetNames(typeof(Countries)));
            cmbCountry1.SelectedIndex = (int)Countries.Sverige;
            txtMobilephone1.Text = string.Empty;
            txtEmailPriv1.Text = string.Empty;
        }
        /// <summary>
        /// Event handler for the click event of Add to listbox employee item        
        /// then update the GUI and update employeeList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();            
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
                    employee.EmployeeContactData.FirstName = txtFirstName.Text;
                    employee.EmployeeContactData.LastName = txtLastName.Text;
                    employee.EmployeeContactData.Age = txtAge.Text;
                    employee.EmployeeContactData.Gender = (GenderType)cmbGenderType.SelectedIndex;
                    employee.EmployeeContactData.Status = (StatusType)cmbStatusType.SelectedIndex;
                    employee.EmployeeContactData.Job = (JobType)cmbJobType.SelectedIndex;
                    employee.EmployeeContactData.Salary = txtSalary.Text;
                    employee.EmployeeContactData.AddressData.Street = txtStreet.Text;
                    employee.EmployeeContactData.AddressData.City = txtCity.Text;
                    employee.EmployeeContactData.AddressData.ZipCode = txtZipcode.Text;
                    employee.EmployeeContactData.AddressData.Country = (Countries)cmbCountry.SelectedIndex;
                    employee.EmployeeContactData.PhoneData.PhoneWork = txtMobilephone.Text;
                    employee.EmployeeContactData.EmailData.EmailPrivate = txtEmailPriv.Text;
                    employeeManager.AddEmployee(employee);
                    panelAddEmployee.Hide();
                    panelEmployeeDetails.Show();
                    UpdateGUI();
                    UpdateEmployeeList();                    
                }
                else
                {
                    if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        panelAddEmployee.Hide();
                        panelEmployeeDetails.Show();
                        UpdateEmployeeList();
                        MessageBox.Show("No employee has been added!");                        
                    }
                    else
                    {
                        return;
                    }
                }
            }
            //if no customer is present then create a new customer
            if (employee == null)
            {
                employee = new Employee();
            }            
        }        
        /// <summary>
        /// Validates the user's inputs
        /// </summary>
        /// <returns>returns true if all the fields are validated</returns>
        private bool ReadInput()
        {
            //calls checkstring method of inpututility class
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("First name cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Surname cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Age cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtSalary.Text))
            {
                MessageBox.Show("Salary cannot be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((string.IsNullOrEmpty(txtStreet.Text)) || (string.IsNullOrEmpty(txtZipcode.Text)) || (string.IsNullOrEmpty(txtCity.Text)))
            {
                MessageBox.Show("Address cannot be empty! Please provide customer's complete address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtMobilephone.Text))
            {
                MessageBox.Show("Please provide at least one contact number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtEmailPriv.Text))
            {
                MessageBox.Show("Please provide at least one email address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        /// <summary>
        /// Event handler for the click event of Cancel the adding and the changing of a listbox item        
        /// then update the EmployeeList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                panelAddEmployee.Hide();
                panelEmployeeDetails.Show();
                UpdateEmployeeList();
                MessageBox.Show("No employee has been added!");               
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }        
        /// <summary>
        /// When listbox index is changed the index is checked, 
        /// if index is valid for employeeList, the Change/Delete buttons are enabled 
        /// and a local Employee object is created to add the stored values to the 
        /// form controls
        /// </summary>
        private void listEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if a valid index has been selected
            bool ok = employeeManager.CheckIndex(listEmployee.SelectedIndex);
            if (ok)//index valid
            {
                Employee employee = new Employee(employeeManager.GetEmployee(listEmployee.SelectedIndex));
                //sets the values to the form controls
                txtFirstName.Text = employee.EmployeeContactData.FirstName;
                txtLastName.Text = employee.EmployeeContactData.LastName;
                txtAge.Text = employee.EmployeeContactData.Age;
                cmbGenderType.SelectedIndex = (int)employee.EmployeeContactData.Gender;
                cmbStatusType.SelectedIndex = (int)employee.EmployeeContactData.Status;
                cmbJobType.SelectedIndex = (int)employee.EmployeeContactData.Job;
                txtSalary.Text = employee.EmployeeContactData.Salary;                
                txtStreet.Text = employee.EmployeeContactData.AddressData.Street;
                txtZipcode.Text = employee.EmployeeContactData.AddressData.ZipCode;
                txtCity.Text = employee.EmployeeContactData.AddressData.City;
                cmbCountry.SelectedIndex = (int)employee.EmployeeContactData.AddressData.Country;                
                txtMobilephone.Text = employee.EmployeeContactData.PhoneData.PhoneWork;                
                txtEmailPriv.Text = employee.EmployeeContactData.EmailData.EmailPrivate;
            }
        }
        /// <summary>
        /// Event handler for the click event of Change listbox task item.
        /// If listbox is not empty then allow the user to change details of the employee
        /// at the selected index, else call showError() method
        /// then update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //perform the update if the list box is not empty                      
            if (listEmployee.Items.Count != 0)
            {
                panelEditEmployee.Show();
                panelEmployeeDetails.Hide();

                //check if a valid index has been selected
                bool ok = employeeManager.CheckIndex(listEmployee.SelectedIndex);
                if (ok)//index valid
                {
                    Employee employee = employeeManager.GetEmployee(listEmployee.SelectedIndex);
                    //sets the values to the form controls
                    txtFirstName1.Text = employee.EmployeeContactData.FirstName;
                    txtLastName1.Text = employee.EmployeeContactData.LastName;
                    txtAge1.Text = employee.EmployeeContactData.Age;
                    cmbGender1.SelectedIndex = (int)employee.EmployeeContactData.Gender;
                    cmbStatus1.SelectedIndex = (int)employee.EmployeeContactData.Status;
                    cmbJob1.SelectedIndex = (int)employee.EmployeeContactData.Job;
                    txtSalary1.Text = employee.EmployeeContactData.Salary;
                    txtStreet1.Text = employee.EmployeeContactData.AddressData.Street;
                    txtZipcode1.Text = employee.EmployeeContactData.AddressData.ZipCode;
                    txtCity1.Text = employee.EmployeeContactData.AddressData.City;
                    cmbCountry1.SelectedIndex = (int)employee.EmployeeContactData.AddressData.Country;
                    txtMobilephone1.Text = employee.EmployeeContactData.PhoneData.PhoneWork;
                    txtEmailPriv1.Text = employee.EmployeeContactData.EmailData.EmailPrivate;
                }
                else //if index is not selected then show error, otherwise continue                
                {
                    panelEditEmployee.Hide();
                    panelEmployeeDetails.Show();
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
        /// This method is called form click event of Delete and Change menuitems of listemployee.
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("Employee list is empty.", "", MessageBoxButtons.OK);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
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
                    employee.EmployeeContactData.FirstName = txtFirstName1.Text;
                    employee.EmployeeContactData.LastName = txtLastName1.Text;
                    employee.EmployeeContactData.Age = txtAge1.Text;
                    employee.EmployeeContactData.Gender = (GenderType)cmbGender1.SelectedIndex;
                    employee.EmployeeContactData.Status = (StatusType)cmbStatus1.SelectedIndex;
                    employee.EmployeeContactData.Job = (JobType)cmbJob1.SelectedIndex;
                    employee.EmployeeContactData.Salary = txtSalary1.Text;
                    employee.EmployeeContactData.AddressData.Street = txtStreet1.Text;
                    employee.EmployeeContactData.AddressData.City = txtCity1.Text;
                    employee.EmployeeContactData.AddressData.ZipCode = txtZipcode1.Text;
                    employee.EmployeeContactData.AddressData.Country = (Countries)cmbCountry1.SelectedIndex;
                    employee.EmployeeContactData.PhoneData.PhoneWork = txtMobilephone1.Text;
                    employee.EmployeeContactData.EmailData.EmailPrivate = txtEmailPriv1.Text;
                    employeeManager.ChangeEmployee(employee.EmployeeContactData, listEmployee.SelectedIndex);
                    panelEditEmployee.Hide();
                    panelEmployeeDetails.Show();
                    UpdateGUI();
                    UpdateEmployeeList();
                }
                else
                {
                    if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        panelEditEmployee.Hide();
                        panelEmployeeDetails.Show();
                        MessageBox.Show("No employee has been added!");
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
        /// then update the EmployeeList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                panelEditEmployee.Hide();
                panelEmployeeDetails.Show();
                MessageBox.Show("No employee has been added!");
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }
        /// <summary>
        /// Event handler for click event of Delete menuitme of the listemployee Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //continue with the deletion only if listbox is not empty
            if (listEmployee.Items.Count != 0)
            {
                int index = listEmployee.SelectedIndex;
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
                        employeeManager.DeleteEmployeeAt(index);
                        UpdateGUI();
                        UpdateEmployeeList();
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
        /// calls the method for saving data from EmployeeManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = employeeManager.WriteEmployeeDataToFile(fileEmployeeName);
            if (!ok) //if something went wrong
                MessageBox.Show(errMessage);
            else //display message that data was saved successfully
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileEmployeeName);
        }
        /// <summary>
        /// Event handler for the click event of Closing the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            panelEmployeeDetails.Hide();
            listEmployee.Items.Clear();
        }
        /// <summary>
        /// all that is needed is to call InitializeGUI and program will "reset"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newEmployeeCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
            panelAddEmployee.Show();
            panelEmployeeDetails.Hide();
            txtFirstName.Focus();
        }
        /// <summary>
        /// calls the method for opening data from EmployeeManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openEmployeeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "You are opening a file, any unsaved data will be lost.\nProceed?";
            //will warn user that opening a file will delete any unsaved data
            if (MessageBox.Show(message, "Open File?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string errorMessage = "Something went wrong when reading data from file";
                //calls the method for reading data from CustomerManager and store bool value in "ok"
                bool ok = employeeManager.ReadEmployeeDataFromFile(fileEmployeeName);
                if (!ok)//something went wrong
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else//if successful will update GUI with the employeeList to the listbox
                {
                    //employeeManager.TestValues();
                    panelAddEmployee.Hide();
                    panelEmployeeDetails.Show();
                    UpdateGUI();
                    UpdateEmployeeList();
                }
            }
        }
        /// <summary>
        /// calls the method for saving data from employeeManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveEmployeeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = employeeManager.WriteEmployeeDataToFile(fileEmployeeName);
            if (!ok) //if something went wrong
                MessageBox.Show(errMessage);
            else //display message that data was saved successfully
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileEmployeeName);
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
