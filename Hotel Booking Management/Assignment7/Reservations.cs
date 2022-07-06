using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Reservations
    {
        //Fields    
        private string reservationNumber; //booking no.
        private string reservationName; //booking name
        private DateTime checkinTime; //date of checking in
        private DateTime checkoutTime; //date of checking out
        private string guestChild; //no. of child guest
        private string guestAdult; //no. of adult guest
        private string guestPensioner; //no. of senior guest
        private RoomType roomtype; //room type selected

        /// <summary>
        /// Default constructor (parameterless)
        /// </summary>
        public Reservations()
        {
            //set a default room type
            roomtype = RoomType.Single_Room;            
        }
        /// <summary>
        /// Constructor with one parameter
        /// calling the constructor with 8 parameters sending the 2 parameters
        /// that comes from the caller (taskDate) and three default value.
        /// The other constructor is called using the keyword this.
        /// </summary>
        /// <param name="">Input coming as a parameter from the caller</param>
        public Reservations(DateTime checkinTime, DateTime checkoutTime) : this(string.Empty, string.Empty, checkinTime, checkoutTime, string.Empty, string.Empty, string.Empty, RoomType.Single_Room)
        {

        }
        /// <summary>
        /// Constructor with 8 parameters to be used when all data is available 
        /// upon creating the object. Other constructors calls this one.
        /// </summary>
        /// <param name="reservationNumber">saves data to the reservationNumber variable</param>
        /// <param name="reservationName">saves a string to the reservationName variable</param>
        /// <param name="checkinTime">saves data to the checkInTime variable</param>
        /// /// <param name="checkoutTime">saves data to the checkOutTime variable</param>
        /// <param name="guestChild">saves a string to the guestChild variable</param>
        /// <param name="guestAdult">saves a string to the guestAdult variable</param>
        /// /// <param name="guestPensioner">saves a string to the guestPensioner variablee</param>
        /// <param name="roomtype">sets the roomtype enum value</param>        
        public Reservations(string reservationNumber, string reservationName, DateTime checkinTime, DateTime checkoutTime, string guestChild, string guestAdult, string guestPensioner, RoomType roomtype)
        {
            this.reservationNumber = reservationNumber;
            this.reservationName = reservationName;
            this.checkinTime = checkinTime;
            this.checkoutTime = checkoutTime;
            this.guestChild = guestChild;
            this.guestAdult = guestAdult;
            this.guestPensioner = guestPensioner;
            this.roomtype = roomtype;
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">object to be copied</param>
        public Reservations(Reservations other)
        {
            this.reservationNumber = other.reservationNumber;
            this.reservationName = other.reservationName;
            this.checkinTime = other.checkinTime;
            this.checkoutTime = other.checkoutTime;
            this.guestChild = other.guestChild;
            this.guestAdult = other.guestAdult;
            this.guestPensioner = other.guestPensioner;
            this.roomtype = other.roomtype;
        }
        /// <summary>
        /// Property related to th field reservationNumber
        /// both read and write access
        /// </summary>
        public string ReservationNumber
        {
            get { return reservationNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    reservationNumber = value;
            }
        }
        /// <summary>
        /// Property connected to the field reservationName
        /// </summary>
        public string ReservationName
        {
            get { return reservationName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    reservationName = value;
            }
        }
        /// <summary>
        /// Property connected to the date instance variable. 
        /// Both read and write acces
        /// </summary>
        public DateTime CheckInTime
        {
            get { return checkinTime; }
            set { checkinTime = value; }
        }
        /// <summary>
        /// Property connected to the date instance variable. 
        /// Both read and write acces
        /// </summary>
        public DateTime CheckOutTime
        {
            get { return checkoutTime; }
            set { checkoutTime = value; }
        }
        /// <summary>
        /// Property connected to the field guestChild
        /// </summary>
        public string GuestChild
        {
            get { return guestChild; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    guestChild = value;
            }
        }
        /// <summary>
        /// Property connected to the field guestAdult
        /// </summary>
        public string GuestAdult
        {
            get { return guestAdult; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    guestAdult = value;
            }
        }
        /// <summary>
        /// Property connected to the field guestPensioner
        /// </summary>
        public string GuestPensioner
        {
            get { return guestPensioner; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    guestPensioner = value;
            }
        }
        /// <summary>
        /// Property connected to the priority instance variable. 
        /// Both read and write acces
        /// </summary>
        public RoomType RoomType
        {
            get { return roomtype; }
            set { roomtype = value; }
        }        
        /// <summary>
        /// This method is used to return a string representing a 
        /// priority enum with the "_" replaced with " "
        /// </summary>
        /// <returns>string with character replaced</returns>
        public string GetRoomString()
        {
            string txtOut = Enum.GetName(typeof(RoomType), roomtype);
            txtOut = txtOut.Replace("_", " ");
            return txtOut;
        }
        //// <summary>
        /// Overrides the ToString to return a formatted string with reservations information
        /// </summary>
        /// <returns>formatted string with reservations information</returns>
        public override string ToString()
        {
            return $"{reservationNumber,5}" +
                $"{reservationName,20}" +
                $"{"  from: "}{checkinTime.ToShortDateString(),10}\n" +
                $"{"  to: "}{checkoutTime.ToShortDateString(),10}" +
                $"{"  Children: "} {guestChild,2}{", "}\n" +
                $"{"  Adult(s): "}{ guestAdult,2}{", "}\n" +
                $"{"  Senior(s): "}{ guestPensioner,2}" +
                $"{ GetRoomString(),25} {" ",10}";
        }
    }    
}
