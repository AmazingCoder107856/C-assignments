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
    public partial class RoomForm : Form
    {
        //FIELDS
        private RoomManager roomManager;
        //Working with only one file located in the same directory as the application's EXE-file
        private string fileRoomName = Application.StartupPath + "\\Rooms.txt";       

        /// <summary>
        /// Default constructor
        /// </summary>
        public RoomForm()
        {
            InitializeComponent();
            roomManager = new RoomManager();//creates an instance of CustomerManager            
            InitializeGUI();   //initializes GUI to default values  
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
            ClearForm();            
            string[] infoRoomStrings = roomManager.GetInfoRoomStringsList();
            if (infoRoomStrings != null)
                listRooms.Items.AddRange(infoRoomStrings);            
        }
        /// <summary>
        /// When list item is selected and deleted, it will move the other items in the listbox upward.
        /// </summary>
        private void RemoveTopItems()
        {
            if (listRooms.TopIndex != listRooms.SelectedIndex)
                listRooms.TopIndex = listRooms.SelectedIndex;
            for (int i = (listRooms.SelectedIndex - 1); i >= 0; i--)
            {
                listRooms.Items.RemoveAt(i);
            }
            listRooms.ClearSelected();
        }
        /// <summary>
        /// clears controls of info
        /// </summary>
        private void ClearForm()
        {
            listRooms.Items.Clear();
            txtRoomNum.Text = string.Empty;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd        HH:mm:ss";
            txtStatus.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cmbRoomType.Items.Clear();
            cmbRoomType.Items.AddRange(Enum.GetNames(typeof(RoomType)));
            cmbRoomType.SelectedIndex = (int)RoomType.Single_Room;            
            txtRoomNum1.Text = string.Empty;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd        HH:mm:ss";
            txtStatus1.Text = string.Empty;
            txtPrice1.Text = string.Empty;
            cmbRoomType1.Items.Clear();
            cmbRoomType1.Items.AddRange(Enum.GetNames(typeof(RoomType)));
            cmbRoomType1.SelectedIndex = (int)RoomType.Single_Room;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(dateTimePicker, "Click to open calendar for date, write in time");
            toolTip.SetToolTip(dateTimePicker1, "Click to open calendar for date, write in time");
            toolTip.SetToolTip(cmbRoomType, "Select a room type");
            toolTip.SetToolTip(cmbRoomType1, "Select a room type");
        }
        /// <summary>
        /// Event handler for the click event of Add listbox room item.        
        /// then update the GUI 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dateTimePicker.Value < new DateTime(2022, 01, 01) || dateTimePicker.Value >= new DateTime(2222, 01, 01))
            {
                MessageBox.Show("Wrong date, must be between 2022 - 2222");
                return;
            }

            Room room = GetRoomInputs(out bool success);
            if (room != null)
            {
                if (success)
                {
                    room.RoomNumber = txtRoomNum.Text;
                    room.DateAndTime = dateTimePicker.Value;
                    room.CleaningStatus = txtStatus.Text;
                    room.RoomPrice = txtPrice.Text;
                    room.Rooms = (RoomType)cmbRoomType.SelectedIndex;
                    roomManager.AddNewRoom(room);
                    panelAddNewRoom.Hide();
                    panelRoomDetails.Show();
                    UpdateGUI();
                }
            }            
        }
        /// <summary>
        /// This method reads the input values from the form controls and
        /// creates a Room object using the values as arguments for
        /// constructor with 5 parameters. If no description is added an error
        /// message is shown
        /// </summary>
        /// <returns>object of Task class</returns>
        private Room GetRoomInputs(out bool success)
        {
            Room room = new Room
            {
                DateAndTime = ReadDateTimeFromPicker(out success)
            };
            if (!success)
            {
                return null;
            }
            room.Rooms = ReadRoomType(out success);
            if (!success)
            {
                return null;
            }
            room.RoomNumber = ReadRoomNumber(out success);            
            room.CleaningStatus = ReadCleaningStatus(out success);            
            room.RoomPrice = ReadRoomPrice(out success);
            return room;
        }
        /// <summary>
        /// This method is used to convert the string value in dateTime        
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
        /// This method is used to convert the string value in cmbRoomType
        /// to a RoomType enum by replacing " " with "_" then parsing
        /// </summary>
        /// <returns>PriorityType enum</returns>
        private RoomType ReadRoomType(out bool success)
        {
            success = false;
            RoomType Rtype = RoomType.Single_Room;
            if (cmbRoomType.SelectedIndex >= 0)
            {
                success = true;
                Rtype = (RoomType)cmbRoomType.SelectedIndex;
            }
            else
                MessageBox.Show("Wrong Room type");
            return Rtype;
        }
        /// <summary>
        /// This method is used to convert the string value in roomNumber        
        /// </summary>
        /// <returns></returns>
        private string ReadRoomNumber(out bool success)
        {
            string text = txtRoomNum.Text.ToString();
            success = false;
            if (!string.IsNullOrEmpty(text))
            {
                success = true;
            }
            else
                MessageBox.Show("Enter a room number");
            return text;
        }
        /// <summary>
        /// This method is used to convert the string value in cleaningStatus        
        /// </summary>
        /// <returns></returns>
        private string ReadCleaningStatus(out bool success)
        {
            string text = txtStatus.Text.ToString();
            success = false;
            if (!string.IsNullOrEmpty(text))
            {
                success = true;
            }
            else
                MessageBox.Show("Enter a room cleaning status");
            return text;
        }
        /// <summary>
        /// This method is used to convert the string value in roomPrice        
        /// </summary>
        /// <returns></returns>
        private string ReadRoomPrice(out bool success)
        {
            string text = txtPrice.Text.ToString();
            success = false;
            if (!string.IsNullOrEmpty(text))
            {
                success = true;
            }
            else
                MessageBox.Show("Enter a room price");
            return text;
        }
        /// <summary>
        /// Event handler for the click event of Cancel the adding and changing listbox room item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                panelAddNewRoom.Hide();
                panelRoomDetails.Show();                
                MessageBox.Show("No room has been added!");
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }
        /// <summary>
        // Event handler for the click event of Change listbox room item.        
        /// then update the GUI  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < new DateTime(2022, 01, 01) || dateTimePicker1.Value >= new DateTime(2222, 01, 01))
            {
                MessageBox.Show("Wrong date, must be between 2022 - 2222");
                return;
            }

            Room room = GetRoomInputs(out bool success);
            if (room != null)
            {
                if (success)
                {
                    room.RoomNumber = txtRoomNum1.Text;
                    room.DateAndTime = dateTimePicker1.Value;
                    room.CleaningStatus = txtStatus1.Text;
                    room.RoomPrice = txtPrice1.Text;
                    room.Rooms = (RoomType)cmbRoomType1.SelectedIndex;
                    roomManager.ChangeRoomAt(room, listRooms.SelectedIndex);
                    panelEditRoom.Hide();
                    panelRoomDetails.Show();
                    UpdateGUI();                    
                }
            }
        }
        /// <summary>
        /// Event handler for the click event of Cancel the adding and changing listbox room item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                panelEditRoom.Hide();
                panelRoomDetails.Show();
                MessageBox.Show("No room has been added!");
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }
        /// <summary>
        /// When listbox index is changed the index is checked, 
        /// if index is valid for roomList, the Change/Delete buttons are enabled 
        /// and a local Room object is created to add the stored values to the 
        /// form controls
        /// </summary>
        private void listRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if a valid index has been selected
            bool ok = roomManager.CheckIndex(listRooms.SelectedIndex);
            if (ok)//index valid
            {                
                Room room = new Room(roomManager.GetRoom(listRooms.SelectedIndex));
                //sets the values of room to the form controls
                txtRoomNum.Text = room.RoomNumber;
                dateTimePicker.Value = room.DateAndTime;
                txtStatus.Text = room.CleaningStatus;
                txtPrice.Text = room.RoomPrice;
                cmbRoomType.SelectedIndex = (int)room.Rooms;               
            }
        }        
        /// <summary>
        /// Event handler for the click event of Change listbox room item.
        /// If listbox is not empty then allow the user to change details of the room
        /// at the selected index, else call showError() method
        /// then update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //perform the update if the list box is not empty                      
            if (listRooms.Items.Count != 0)
            {
                panelEditRoom.Show();
                panelRoomDetails.Hide();

                //check if a valid index has been selected
                bool ok = roomManager.CheckIndex(listRooms.SelectedIndex);
                if (ok)//index valid
                {
                    Room room = roomManager.GetRoom(listRooms.SelectedIndex);
                    //sets the values of task to the form controls
                    txtRoomNum1.Text = room.RoomNumber;
                    dateTimePicker1.Value = room.DateAndTime;
                    txtStatus1.Text = room.CleaningStatus;
                    txtPrice1.Text = room.RoomPrice;
                    cmbRoomType1.SelectedIndex = (int)room.Rooms;
                }
                else //if index is not selected then show error, otherwise continue                
                {
                    panelEditRoom.Hide();
                    panelRoomDetails.Show();
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
        /// This method is called form click event of Delete and Change menuitems of Room menu.
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("Room list is empty.", "", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Event handler for the click event of Delete listbox room item.
        /// If listbox is not empty then allow the user to change details of the room
        /// at the selected index, else call showError() method
        /// then update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //continue with the deletion only if listbox is not empty
            if (listRooms.Items.Count != 0)
            {
                //checks if index is valid
                bool ok = roomManager.CheckIndex(listRooms.SelectedIndex);
                //int index = listRooms.SelectedIndex;
                //show error if no index is selected, otherwise call the removeCustomer method of customerMngr for
                //deleting specific customerdetails at selected index
                if (!ok)
                {
                    MessageBox.Show("Please select an item firstly!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dlgResult = MessageBox.Show("You are about to delete. Are you sure?", "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dlgResult == DialogResult.Yes)//if yes is clicked
                    {
                        roomManager.DeleteRoomAt(listRooms.SelectedIndex);
                        UpdateGUI();
                        RemoveTopItems();
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
        /// calls the method for saving data from RoomManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = roomManager.WriteRoomDataToFile(fileRoomName);
            if (!ok) //if something went wrong
                MessageBox.Show(errMessage);
            else //display message that data was saved successfully
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileRoomName);
        }
        /// <summary>
        /// all that is needed is to call InitializeGUI and program will "reset"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newRoomCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
            panelAddNewRoom.Show();
            panelRoomDetails.Hide();
            txtRoomNum.Focus();
        }
        /// <summary>
        /// calls the method for opening data from RoomManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openRoomFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "You are opening a file, any unsaved data will be lost.\nProceed?";
            //will warn user that opening a file will delete any unsaved data
            if (MessageBox.Show(message, "Open File?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string errorMessage = "Something went wrong when reading data from file";
                //calls the method for reading data from CustomerManager and store bool value in "ok"
                bool ok = roomManager.ReadRoomDataFromFile(fileRoomName);
                if (!ok)//something went wrong
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else//if successful will update GUI with the taskList to the listbox
                {
                    panelAddNewRoom.Hide();
                    panelRoomDetails.Show();
                    //customerManager.TestValues();
                    UpdateGUI();                    
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
            panelRoomDetails.Hide();
            listRooms.Items.Clear();
        }
        /// <summary>
        /// calls the method for saving data from RoomManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveRoomFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = roomManager.WriteRoomDataToFile(fileRoomName);
            if (!ok) //if something went wrong
                MessageBox.Show(errMessage);
            else //display message that data was saved successfully
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileRoomName);
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
