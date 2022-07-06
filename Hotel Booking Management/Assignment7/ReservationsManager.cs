using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class ReservationsManager
    {
        //FIELDS        
        private List<Reservations> reservationsList;  //declare object of the collection        

        /// <summary>
        /// Default contsructor. It creates a new arrylist object.        
        /// </summary>
        public ReservationsManager()
        {
            reservationsList = new List<Reservations>();            
        }        
        /// <summary>
        /// Returns the reservations object at the selected index of the reservations arrylist
        /// </summary>
        /// <param name="index">selectedindex by the user</param>
        /// <returns>reservations objects</returns>
        public Reservations GetReservation(int index)
        {
            if (CheckIndex(index))
                return reservationsList[index];
            else
                return null;
        }
        /// <summary>
        /// Controls so an index is not out of range.
        /// The results of the statements at the right side of the return keyword is 
        /// a bool value (true or false)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            bool ok = false;

            if ((index >= 0) && (index < reservationsList.Count))
            {
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// Add a new object at the end of the reservationList
        /// </summary>
        /// <param name="newReservation">The reservations object that is to be added</param>
        /// <returns>true if the reservation is added successfully, false otherwise</returns>
        public bool AddNewReservation(Reservations newReservation)
        {
            bool ok = true;

            if (newReservation != null)
                reservationsList.Add(newReservation);
            else
                ok = false;
            return ok;
        }
        /// <summary>
        /// Adds a new reservation to the reservationlist using the value sent by the caller via the method parameters
        /// </summary>
        /// <param name="reservationNumber"></param>
        /// <param name="reservationName"></param>
        /// <param name="checkinTime"></param>
        /// /// <param name="checkoutTime"></param>
        /// <param name="guestChild"></param>
        /// <param name="guestAdult"></param>
        /// /// <param name="guestPensioner"></param>
        /// <param name="roomType"></param>       
        /// <returns>true if the reservations is added successfully, false otherwise</returns>
        public bool AddNewReservation(string reservationNumber, string reservationName, DateTime checkinTime, DateTime checkoutTime, string guestChild, string guestAdult, string guestPensioner, RoomType roomType)
        {
            bool ok = true;
            //create a new object with the above given values
            Reservations newReservation = new Reservations(reservationNumber, reservationName, checkinTime, checkoutTime, guestChild, guestAdult, guestPensioner, roomType);
            if (newReservation != null)
                reservationsList.Add(newReservation);
            else
                ok = false;
            return ok;
        }
        /// <summary>
        /// Change an object in the reservationslist in a given position with a new object.
        /// </summary>
        /// <param name="reservation">The object to replace an existing at index position</param>
        /// <param name="index">the position of the given position with a new object</param>
        /// <returns>true if the reservation is added successfully, false otherwise</returns>
        public bool ChangeReservationAt(Reservations reservation, int index)
        {
            bool ok = true;
            //check so that task is not null and index is not out of range
            if ((reservation != null) && CheckIndex(index))
                reservationsList[index] = reservation;
            else
                ok = false;
            return ok;
        }
        /// <summary>
        /// Delete an object in the reservationslist in a given position
        /// </summary>
        /// <param name="index">The object deleted at index position</param>
        /// <returns>true if the reservation is added successfully, false otherwise</returns>
        public bool DeleteReservationAt(int index)
        {
            bool ok = false;

            if ((index >= 0) && (index < reservationsList.Count))
            {
                reservationsList.RemoveAt(index);
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// This method prepares an array of strings containing
        /// information about the reservations in reservationsList
        /// </summary>
        /// <returns>array of strings</returns>
        public string[] GetInfoReservationStringsList()
        {
            //create a local array of the string element with a capacity = num
            //elements in the customerlist
            string[] infoReservationStrings = new string[reservationsList.Count];
            for (int i = 0; i < infoReservationStrings.Length; i++)
            {
                infoReservationStrings[i] = reservationsList[i].ToString();
            }
            return infoReservationStrings;
        }
        /// <summary>
        /// FileManager is a class that handles the saving and reading data
        /// to and from a text file. Send the reservationslist from which data is read and saved
        /// to the file fileReservationName.
        /// </summary>
        /// <param name="fileResevationName"></param>
        /// <returns></returns>
        public bool WriteReservationDataToFile(string fileReservationName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveReservationListToFile(reservationsList, fileReservationName);
        }
        /// <summary>
        /// Send the reservationslist object declared in above to which data from the filename is saved.
        /// As reservationslist is an object it will have the changes made in the FileManager when the
        /// method ReadReservationsListFrFile returns.
        /// </summary>
        /// <param name="fileReservationName"></param>
        /// <returns></returns>
        public bool ReadReservationDataFromFile(string fileReservationName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.ReadReservationListFrFile(reservationsList, fileReservationName);
        }
    }    
}
