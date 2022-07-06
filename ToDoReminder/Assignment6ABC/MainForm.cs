using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6ABC
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager;
        //Working with only one file located in the same directory as the application's EXE-file
        private string fileName = Application.StartupPath + "\\Tasks.txt";
        private bool closing = false;//used for closing event

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();   //initializes GUI to default values         
        }
        /// <summary>
        /// Initialization where method can be called to reset the program
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "ToDo Reminder by Gloria Palm";            
            taskManager = new TaskManager(); //creates an instance of TaskManager
            listBoxToDo.Items.Clear();
            lblTime.Text = string.Empty;
            clockTimer.Start();
            cmbPriorityType.Items.Clear();
            cmbPriorityType.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
            cmbPriorityType.SelectedIndex = (int)PriorityType.Normal;            
            txtToDo.Text = string.Empty;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd        HH:mm:ss";
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(dateTimePicker, "Click to open calendar for date, write in time");
            toolTip.SetToolTip(cmbPriorityType, "Select the priority");
            string tips = "To CHANGE: Select an item first!" + Environment.NewLine;
            tips += "Make your changes in the input controls," + Environment.NewLine;
            tips += "Click the Change button!" + Environment.NewLine;            
            toolTip.SetToolTip(btnChange, tips);
            string delTips = "Select an item first and then click this button!";
            toolTip.SetToolTip(btnDelete, delTips);
            string desTips = "Write something description of the task";
            toolTip.SetToolTip(txtToDo, desTips);
            openDataFileToolStripMenuItem.Enabled = true;
            saveDataFileToolStripMenuItem.Enabled = true;
        }
        /// <summary>
        /// This method updates the GUI so it will display correct information
        /// in the listbox and sets the combobox to default value
        /// </summary>
        private void UpdateGUI()
        {
            //clears controls of info
            cmbPriorityType.SelectedIndex = (int)PriorityType.Normal;
            txtToDo.Text = string.Empty;
            listBoxToDo.Items.Clear();
            clockTimer.Start();
            string[] infoStrings = taskManager.GetInfoStringsList();
            if (infoStrings != null)
                listBoxToDo.Items.AddRange(infoStrings);

            //disables buttons, if an item in listbox has been selected before
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
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
        /// creates an object of Aboutbox and displays it as dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox dlgAbout = new AboutBox();
            dlgAbout.ShowDialog();
        }
        /// <summary>
        /// Event handler for the click event of Add listbox task item.        
        /// then update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            if (dateTimePicker.Value < new DateTime(2022, 01, 01) || dateTimePicker.Value >= new DateTime(2222, 01, 01))
            {
                MessageBox.Show("Wrong date, must be between 2022 - 2222");
                return;
            }

            Task task = GetTaskFromUserInputs(out bool success);
            if (task != null)
            {
                if (success)
                {
                    taskManager.AddNewTask(task);
                    UpdateGUI();
                }
            }
        }
        /// <summary>
        /// This method reads the input values from the form controls and
        /// creates a Task object using the values as arguments for
        /// constructor with 3 parameters. If no description is added an error
        /// message is shown
        /// </summary>
        /// <returns>object of Task class</returns>
        private Task GetTaskFromUserInputs(out bool success)
        {
            Task task = new Task
            {
                DateAndTime = ReadDateTimeFromPicker(out success)
            };
            if (!success)
            {
                return null;
            }
            task.Priority = ReadpriorityType(out success);
            if (!success)
            {
                return null;
            }
            task.Description = ReadDescription(out success);
            return task;
        }
        /// <summary>
        /// This method is used to convert the string value in cmbPriorityType
        /// to a PriorityType enum by replacing " " with "_" then parsing
        /// </summary>
        /// <returns>PriorityType enum</returns>
        private PriorityType ReadpriorityType(out bool success)
        {
            success = false;
            PriorityType Ptype = PriorityType.Normal;
            if (cmbPriorityType.SelectedIndex >= 0)
            {
                success = true;
                Ptype = (PriorityType)cmbPriorityType.SelectedIndex;
            }
            else
                MessageBox.Show("Wrong Priority type");
            return Ptype;
        }
        /// <summary>
        /// This method is used to convert the string value in description        
        /// </summary>
        /// <returns></returns>
        private string ReadDescription(out bool success)
        {
            string text = txtToDo.Text.ToString();
            success = false;
            if (!string.IsNullOrEmpty(text))
            {
                success = true;
            }
            else
                MessageBox.Show("Enter a description");
            return text;
        }
        /// <summary>
        /// This method is used to convert the string value in date        
        /// </summary>
        /// <returns></returns>
        private DateTime ReadDateTimeFromPicker(out bool success)
        {
            success = false;
            DateTime dtt = Convert.ToDateTime(dateTimePicker.Value);            
            DateTime datum = new DateTime(dtt.Year, dtt.Month, dtt.Day, dtt.Hour, dtt.Minute, dtt.Second);
            if (!datum.Equals(null))
            {
                success = true;
            }
            else
                MessageBox.Show("Please enter a valid date / time");
            return datum;
        }
        /// <summary>
        /// menuItem Exit Alt-F4, check if user really want to quit 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a DailogResult from a messagebox with YesNo buttons
            DialogResult dlgResult = MessageBox.Show("You are about to exit. Are you sure?", "Close Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)//if yes is clicked
            {
                //call exit method
                closing = true;
                Application.Exit();

            }
        }
        /// <summary>
        /// all that is needed is to call InitializeGUI and program will "reset"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            InitializeGUI();
        }
        /// <summary>
        /// calls the method for opening data from TaskManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "You are opening a file, any unsaved data will be lost.\nProceed?";
            //will warn user that opening a file will delete any unsaved data
            if (MessageBox.Show(message, "Open File?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string errorMessage = "Something went wrong when reading data from file";
                //calls the method for reading data from TaskManager and store bool value in "ok"
                bool ok = taskManager.ReadDataFromFile(fileName);
                if (!ok)//something went wrong
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else//if successful will update GUI with the taskList to the listbox
                {
                    UpdateGUI();
                }
            }
        }
        /// <summary>
        /// calls the method for saving data from TaskManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = taskManager.WriteDataToFile(fileName);
            if (!ok) //if something went wrong
                MessageBox.Show(errMessage);
            else //display message that data was saved successfully
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileName);
        }
        /// <summary>
        /// Event handler for the click event of Change listbox task item.
        /// If list box is not empty then allow the user to change details of the task
        /// at the selected index, else call showError() method
        /// then update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            bool ok = taskManager.CheckIndex(listBoxToDo.SelectedIndex);
            if (ok)//valid index
            {
                //this works just like in add method
                Task task = GetTaskFromUserInputs(out bool success);
                //saves the new task to the selected index, replacing the object that was stored there
                taskManager.ChangeTaskAt(task, listBoxToDo.SelectedIndex);
                //after changes in the taskList always update GUI to display correct info
                UpdateGUI();
            }
            else
                MessageBox.Show("Select an item in the list to change");
        }
        /// <summary>
        /// Deletebutton will delete/remove the task at selected index
        /// then update the GUI.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //checks if index is valid
            bool ok = taskManager.CheckIndex(listBoxToDo.SelectedIndex);
            if (ok)
            {
                //removes the task at selected index
                taskManager.DeleteTaskAt(listBoxToDo.SelectedIndex);
                //updates the listbox after the list has changed
                UpdateGUI();
            }
            else
                MessageBox.Show("Select an item in the list to change");
        }
        /// <summary>
        /// Makes used of the form Timer control to update labeltext on every tick
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");            
        }
        /// <summary>
        /// If user attempts to close form using the "X" button on form. If user
        /// has exited app using the menu exit then the form will automatically close
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing)//this will be true if user closed app using the menu
            {
                DialogResult dlgResult = MessageBox.Show("You are about to exit. Are you sure?", "Close Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.No)//if yes is clicked
                {
                    //cancel the exit event
                    e.Cancel = true;
                }
            }
        }
        /// <summary>
        /// When listbox index is changed the index is checked, 
        /// if index is valid for taskList, the Change/Delete buttons are enabled 
        /// and a local Task object is created to add the stored values to the 
        /// form controls
        /// </summary>
        private void listBoxToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if a valid index has been selected
            bool ok = taskManager.CheckIndex(listBoxToDo.SelectedIndex);
            if (ok)//index valid
            {
                //enables the Change and Delete buttons
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
                Task task = new Task(taskManager.GetTask(listBoxToDo.SelectedIndex));
                //sets the values of task to the form controls
                cmbPriorityType.SelectedIndex = (int)task.Priority;
                txtToDo.Text = task.Description;
                dateTimePicker.Value = task.DateAndTime;
            }
        }
    }
}
