using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Room
    {
        //Fields        
        private string roomNumber;
        private DateTime dateTime; //date and time of the availability of the room
        private string cleaningStatus; //status of the room if it's cleaned or in progress
        private string roomPrice; //room price
        private RoomType rooms; //room type selected

        /// <summary>
        /// Default constructor (parameterless)
        /// </summary>
        public Room()
        {
            //set a default priority type
            rooms = RoomType.Single_Room;
        }
        /// <summary>
        /// Constructor with one parameter
        /// calling the constructor with 5 parameters sending the one parameter
        /// that comes from the caller (dateTime) and three default value.
        /// The other constructor is called using the keyword this.
        /// </summary>
        /// <param name="dateTime">Input coming as a parameter from the caller</param>
        public Room(DateTime dateTime) : this(string.Empty, dateTime, string.Empty, string.Empty, RoomType.Single_Room)
        {

        }
        /// <summary>
        /// Constructor with 5 parameters to be used when all data is available 
        /// upon creating the object. Other constructors calls this one.
        /// </summary>
        /// <param name="roomNumber">saves string to the roomNumber variable</param>
        /// <param name="dateTime">saves data to dateTime variable</param>
        /// <param name="cleaningStatus">saves string to the cleaningStatus variable</param>
        /// <param name="roomPrice">saves string to the roomPrice variable</param>
        /// <param name="rooms">saves data to enum roomType variable</param>        
        public Room(string roomNumber, DateTime dateTime, string cleaningStatus, string roomPrice, RoomType rooms)
        {
            this.roomNumber = roomNumber;
            this.dateTime = dateTime;
            this.cleaningStatus = cleaningStatus;
            this.roomPrice = roomPrice;
            this.rooms = rooms;
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">object to be copied</param>
        public Room(Room other)
        {
            this.roomNumber = other.roomNumber;
            this.dateTime = other.dateTime;
            this.cleaningStatus = other.cleaningStatus;
            this.roomPrice = other.roomPrice;
            this.rooms = other.rooms;
        }
        /// <summary>
        /// Property connected to the field roomNumber
        /// </summary>
        public string RoomNumber
        {
            get { return roomNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    roomNumber = value;
            }
        }
        /// <summary>
        /// Property connected to the date instance variable. 
        /// Both read and write acces
        /// </summary>
        public DateTime DateAndTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        /// <summary>
        /// Property connected to the field cleaningStatus
        /// </summary>
        public string CleaningStatus
        {
            get { return cleaningStatus; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    cleaningStatus = value;
            }
        }
        /// <summary>
        /// Property connected to the field roomPrice
        /// </summary>
        public string RoomPrice
        {
            get { return roomPrice; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    roomPrice = value;
            }
        }
        /// <summary>
        /// Property connected to the rooms instance variable. 
        /// Both read and write acces
        /// </summary>
        public RoomType Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }
        
        /// <summary>
        /// This method returns a string in the form of 
        /// HH:mm to represent when a room is to be performed.
        /// </summary>
        /// <returns>string of time formatted to HH:mm</returns>
        private string GetTimeString()
        {
            string time = string.Format("{0}:{1}:{2}", dateTime.Hour.ToString("00"), dateTime.Minute.ToString("00"), dateTime.Second.ToString("00"));
            return time;
        }
        /// <summary>
        /// This method is used to return a string representing a 
        /// rooms enum with the "_" replaced with " "
        /// </summary>
        /// <returns>string with character replaced</returns>
        public string GetRoomString()
        {
            string txtOut = Enum.GetName(typeof(RoomType), rooms);
            txtOut = txtOut.Replace("_", " ");
            return txtOut;
        }
        //// <summary>
        /// Overrides the ToString to return a formatted string with room information
        /// </summary>
        /// <returns>formatted string with room information</returns>
        public override string ToString()
        {
            return $"{roomNumber,5}" +
                $"{dateTime.ToLongDateString(),25}" +
                $"{GetTimeString(),10} {" ",6}" +
                $"{ cleaningStatus,25}" +
                $"{ roomPrice,25}" +
                $"{ GetRoomString(),25} {" ",10}";                
        }
    }   
}

