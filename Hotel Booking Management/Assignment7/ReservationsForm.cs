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
    public partial class ReservationsForm : Form
    {
        //FIELDS
        private ReservationsManager reservationsManager;
        //Working with only one file located in the same directory as the application's EXE-file
        private string fileReservationName = Application.StartupPath + "\\Reservations.txt";

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReservationsForm()
        {
            InitializeComponent();
            reservationsManager = new ReservationsManager();//creates an instance of ReservationsManager            
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
            string[] infoReservationStrings = reservationsManager.GetInfoReservationStringsList();
            if (infoReservationStrings != null)
                listReservations.Items.AddRange(infoReservationStrings);
        }
        /// <summary>
        /// When list item is selected and deleted, it will move the other items in the listbox upward.
        /// </summary>
        private void RemoveTopItems()
        {
            if (listReservations.TopIndex != listReservations.SelectedIndex)
                listReservations.TopIndex = listReservations.SelectedIndex;
            for (int i = (listReservations.SelectedIndex - 1); i >= 0; i--)
            {
                listReservations.Items.RemoveAt(i);
            }
            listReservations.ClearSelected();
        }
        /// <summary>
        /// clears controls of info
        /// </summary>
        private void ClearForm()
        {
            listReservations.Items.Clear();
            txtResNum.Text = string.Empty;
            txtResName.Text = string.Empty;
            dateTimePickerFr.Format = DateTimePickerFormat.Custom;
            dateTimePickerFr.CustomFormat = "yyyy-MM-dd";
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "yyyy-MM-dd";
            cmbChild.Text = string.Empty;
            cmbAdult.Text = string.Empty;
            cmbPensioner.Text = string.Empty;
            cmbRoomTypeRes.Items.Clear();
            cmbRoomTypeRes.Items.AddRange(Enum.GetNames(typeof(RoomType)));
            cmbRoomTypeRes.SelectedIndex = (int)RoomType.Single_Room;            
            txtResNum1.Text = string.Empty;
            txtResName1.Text = string.Empty;
            dateTimePickerFr1.Format = DateTimePickerFormat.Custom;
            dateTimePickerFr1.CustomFormat = "yyyy-MM-dd";
            dateTimePickerTo1.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo1.CustomFormat = "yyyy-MM-dd";
            cmbChild1.Text = string.Empty;
            cmbAdult1.Text = string.Empty;
            cmbPensioner1.Text = string.Empty;
            cmbRoomTypeRes1.Items.Clear();
            cmbRoomTypeRes1.Items.AddRange(Enum.GetNames(typeof(RoomType)));
            cmbRoomTypeRes1.SelectedIndex = (int)RoomType.Single_Room;            
        }
        /// <summary>
        /// Event handler for the click event of Add listbox reservations item.        
        /// then update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFr.Value < new DateTime(2022, 01, 01) || dateTimePickerTo.Value < new DateTime(2022, 01, 01))
            {
                MessageBox.Show("Wrong date, year must be from 2022");
                return;
            }

            Reservations reservations = GetReservationInputs(out bool success);
            if (reservations != null)
            {
                if (success)
                {
                    reservations.ReservationNumber = txtResNum.Text;
                    reservations.ReservationName = txtResName.Text;
                    reservations.CheckInTime = dateTimePickerFr.Value;
                    reservations.CheckOutTime = dateTimePickerTo.Value;
                    reservations.GuestChild = cmbChild.Text;
                    reservations.GuestAdult = cmbAdult.Text;
                    reservations.GuestPensioner = cmbPensioner.Text;
                    reservations.RoomType = (RoomType)cmbRoomTypeRes.SelectedIndex;
                    reservationsManager.AddNewReservation(reservations);
                    grpAddNewReservation.Hide();
                    grpReservationDetails.Show();
                    UpdateGUI();
                }
            }
        }
        /// <summary>
        /// This method reads the input values from the form controls and
        /// creates a reservations object using the values as arguments for
        /// constructor with 8 parameters. If no description is added an error
        /// message is shown
        /// </summary>
        /// <returns>object of Reservations class</returns>
        private Reservations GetReservationInputs(out bool success)
        {
            Reservations reservations = new Reservations
            {
                CheckInTime = ReadCheckInTimeFromPicker(out success)
                
            };
            if (!success)
            {
                return null;
            }
            reservations.CheckOutTime = ReadCheckOutTimeFromPicker(out success);
            if (!success)
            {
                return null;
            }
            reservations.RoomType = ReadRoomType(out success);
            if (!success)
            {
                return null;
            }
            reservations.ReservationNumber = ReadReservationNumber(out success);
            reservations.ReservationName = ReadReservationName(out success);
            reservations.GuestChild = ReadGuestChild(out success);
            reservations.GuestAdult = ReadGuestAdult(out success);
            reservations.GuestPensioner = ReadGuestPensioner(out success);
            return reservations;
        }
        /// <summary>
        /// This method is used to convert the string value in checkInTime        
        /// </summary>
        /// <returns></returns>
        private DateTime ReadCheckInTimeFromPicker(out bool success)
        {
            success = false;
            DateTime dtt = Convert.ToDateTime(dateTimePickerFr.Value);
            DateTime datum = new DateTime(dtt.Year, dtt.Month, dtt.Day);
            if (!datum.Equals(null))
            {
                success = true;
            }
            else
                MessageBox.Show("Please enter a valid year!");
            return datum;
        }
        /// <summary>
        /// This method is used to convert the string value in checkOutTime       
        /// </summary>
        /// <returns></returns>
        private DateTime ReadCheckOutTimeFromPicker(out bool success)
        {
            success = false;
            DateTime dtt = Convert.ToDateTime(dateTimePickerTo.Value);
            DateTime datum = new DateTime(dtt.Year, dtt.Month, dtt.Day);
            if (!datum.Equals(null))
            {
                success = true;
            }
            else
                MessageBox.Show("Please enter a valid year!");
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
            if (cmbRoomTypeRes.SelectedIndex >= 0)
            {
                success = true;
                Rtype = (RoomType)cmbRoomTypeRes.SelectedIndex;
            }
            else
                MessageBox.Show("Wrong Room type");
            return Rtype;
        }
        /// <summary>
        /// This method is used to convert the string value in reservationNumber        
        /// </summary>
        /// <returns></returns>
        private string ReadReservationNumber(out bool success)
        {
            string text = txtResNum.Text.ToString();
            success = false;
            if (!string.IsNullOrEmpty(text))
            {
                success = true;
            }
            else
                MessageBox.Show("Enter a reservation number");
            return text;
        }
        /// <summary>
        /// This method is used to convert the string value in reservationName        
        /// </summary>
        /// <returns></returns>
        private string ReadReservationName(out bool success)
        {
            string text = txtResName.Text.ToString();
            success = false;
            if (!string.IsNullOrEmpty(text))
            {
                success = true;
            }
            else
                MessageBox.Show("Enter your complete name!");
            return text;
        }
        /// <summary>
        /// This method is used to convert the string value in guestChild       
        /// </summary>
        /// <returns></returns>
        private string ReadGuestChild(out bool success)
        {
            string text = cmbChild.Text.ToString();
            success = false;
            if (!string.IsNullOrEmpty(text))
            {
                success = true;
            }
            else
                MessageBox.Show("Enter number of children, if none choose 0!");
            return text;
        }
        /// <summary>
        /// This method is used to convert the string value in guestAdult        
        /// </summary>
        /// <returns></returns>
        private string ReadGuestAdult(out bool success)
        {
            string text = cmbAdult.Text.ToString();
            success = false;
            if (!string.IsNullOrEmpty(text))
            {
                success = true;
            }
            else
                MessageBox.Show("Enter number of Adults, if none choose 0!");
            return text;
        }
        /// <summary>
        /// This method is used to convert the string value in guestPensioner        
        /// </summary>
        /// <returns></returns>
        private string ReadGuestPensioner(out bool success)
        {
            string text = cmbPensioner.Text.ToString();
            success = false;
            if (!string.IsNullOrEmpty(text))
            {
                success = true;
            }
            else
                MessageBox.Show("Enter number of pensioner, if none choose 0!");
            return text;
        }
        /// <summary>
        // Event handler for the click event of Cancel the adding and changing listbox reservation item.        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                grpAddNewReservation.Hide();
                grpReservationDetails.Show();
                MessageBox.Show("No reservation has been added!");
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }
        /// <summary>
        // Event handler for the click event of Change listbox reservation item.        
        /// then update the GUI 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeRes_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFr1.Value < new DateTime(2022, 01, 01) || dateTimePickerTo1.Value < new DateTime(2022, 01, 01))
            {
                MessageBox.Show("Wrong date, year must be from 2022");
                return;
            }

            Reservations reservations = GetReservationInputs(out bool success);
            if (reservations != null)
            {
                if (success)
                {
                    reservations.ReservationNumber = txtResNum1.Text;
                    reservations.ReservationName = txtResName1.Text;
                    reservations.CheckInTime = dateTimePickerFr1.Value;
                    reservations.CheckOutTime = dateTimePickerTo1.Value;
                    reservations.GuestChild = cmbChild1.Text;
                    reservations.GuestAdult = cmbAdult1.Text;
                    reservations.GuestPensioner = cmbPensioner1.Text;
                    reservations.RoomType = (RoomType)cmbRoomTypeRes1.SelectedIndex;
                    reservationsManager.ChangeReservationAt(reservations, listReservations.SelectedIndex);
                    grpEditReservation.Hide();
                    grpReservationDetails.Show();
                    UpdateGUI();
                }
            }
        }
        /// <summary>
        // Event handler for the click event of Cancel the adding and changing listbox reservation item.        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelRes1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel and discard all data?", "Cancel Input",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                grpEditReservation.Hide();
                grpReservationDetails.Show();
                MessageBox.Show("No reservation has been added!");
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }
        /// <summary>
        /// When listbox index is changed the index is checked, 
        /// if index is valid for reservationList, the Change/Delete buttons are enabled 
        /// and a local reservation object is created to add the stored values to the 
        /// form controls
        /// </summary>
        private void listReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if a valid index has been selected
            bool ok = reservationsManager.CheckIndex(listReservations.SelectedIndex);
            if (ok)//index valid
            {
                Reservations reservations = new Reservations(reservationsManager.GetReservation(listReservations.SelectedIndex));
                //sets the values of reservation to the form controls
                txtResNum.Text = reservations.ReservationNumber;
                txtResName.Text = reservations.ReservationName;
                dateTimePickerFr.Value = reservations.CheckInTime;
                dateTimePickerTo.Value = reservations.CheckOutTime;
                cmbChild.Text = reservations.GuestChild;
                cmbAdult.Text = reservations.GuestAdult;
                cmbPensioner.Text = reservations.GuestPensioner;
                cmbRoomTypeRes.SelectedIndex = (int)reservations.RoomType;
            }
        }
        /// <summary>
        /// Event handler for the click event of Change listbox reservation item.
        /// If list box is not empty then allow the user to change details of the reervations
        /// at the selected index, else call showError() method
        /// then update the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            //perform the update if the list box is not empty                      
            if (listReservations.Items.Count != 0)
            {
                grpEditReservation.Show();
                grpReservationDetails.Hide();

                //check if a valid index has been selected
                bool ok = reservationsManager.CheckIndex(listReservations.SelectedIndex);
                if (ok)//index valid
                {
                    Reservations reservations = reservationsManager.GetReservation(listReservations.SelectedIndex);
                    //sets the values of reservation to the form controls
                    txtResNum1.Text = reservations.ReservationNumber;
                    txtResName1.Text = reservations.ReservationName;
                    dateTimePickerFr1.Value = reservations.CheckInTime;
                    dateTimePickerTo1.Value = reservations.CheckOutTime;
                    cmbChild1.Text = reservations.GuestChild;
                    cmbAdult1.Text = reservations.GuestAdult;
                    cmbPensioner1.Text = reservations.GuestPensioner;
                    cmbRoomTypeRes1.SelectedIndex = (int)reservations.RoomType;
                }
                else //if index is not selected then show error, otherwise continue                
                {
                    grpEditReservation.Hide();
                    grpReservationDetails.Show();
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
        /// This method is called form click event of Delete and reservations menuitems of reservations menu.
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("Reservationlist is empty.", "", MessageBoxButtons.OK);
        }
        // Event handler for the click event of Delete listbox reservations item.
        /// If listbox is not empty then allow the user to change details of the reservations
        /// at the selected index, else call showError() method
        /// then update the GUI
        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            //continue with the deletion only if listbox is not empty
            if (listReservations.Items.Count != 0)
            {
                //checks if index is valid
                bool ok = reservationsManager.CheckIndex(listReservations.SelectedIndex);
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
                        reservationsManager.DeleteReservationAt(listReservations.SelectedIndex);
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
        /// calls the method for saving data from ReservationManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveReservation_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = reservationsManager.WriteReservationDataToFile(fileReservationName);
            if (!ok) //if something went wrong
                MessageBox.Show(errMessage);
            else //display message that data was saved successfully
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileReservationName);
        }
        /// <summary>
        /// all that is needed is to call InitializeGUI and program will "reset"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newReservationCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
            grpAddNewReservation.Show();
            grpReservationDetails.Hide();
            txtResNum.Focus();
        }
        /// <summary>
        /// calls the method for opening data from ReservationsManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openReservationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "You are opening a file, any unsaved data will be lost.\nProceed?";
            //will warn user that opening a file will delete any unsaved data
            if (MessageBox.Show(message, "Open File?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string errorMessage = "Something went wrong when reading data from file";
                //calls the method for reading data from CustomerManager and store bool value in "ok"
                bool ok = reservationsManager.ReadReservationDataFromFile(fileReservationName);
                if (!ok)//something went wrong
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else//if successful will update GUI with the taskList to the listbox
                {
                    grpAddNewReservation.Hide();
                    grpReservationDetails.Show();
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
        private void btnCloseReservation_Click(object sender, EventArgs e)
        {
            grpReservationDetails.Hide();
            listReservations.Items.Clear();
        }
        /// <summary>
        /// calls the method for saving data from ReservationsManager and store bool value in "ok"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveReservationFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = reservationsManager.WriteReservationDataToFile(fileReservationName);
            if (!ok) //if something went wrong
                MessageBox.Show(errMessage);
            else //display message that data was saved successfully
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileReservationName);
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
