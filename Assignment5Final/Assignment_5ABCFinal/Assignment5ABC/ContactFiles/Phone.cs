using Assignment5ABC.ContactFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    public class Phone 
    { 
        //Fields
        private string phoneHome; //Home phone or landline phone
        private string phoneCellphone; //mobilephone 

        /// <summary>
        /// Constructors are overloaded and called in a chain
        ///Default constructor - calls another constructor in this class
        /// </summary>
        /// <param name="homePhone"></param>
        /// <param name="cellPhone"></param>
        public Phone(string homePhone, string cellPhone)
        {
            phoneHome = homePhone;
            phoneCellphone = cellPhone;
        }
        /// <summary>
        /// <Constructor with one parameter - calls the constructor with 
        /// three parameters, using a default value as the second argument.
        /// </summary>
        /// <param name="emailBus"></param>
        /// <param name="emailPriv"></param>
        public Phone(string homePhone) : this(homePhone, string.Empty)
        {

        }
        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Phone() : this(string.Empty, string.Empty)
        {

        }
        /// <summary>
        /// Copy constructor returning copy
        /// </summary>
        /// <param name="theOther"></param>
        public Phone(Phone theOther)
        {            
            this.phoneHome = theOther.phoneHome;
            this.phoneCellphone = theOther.phoneCellphone;
        }
        
        /// <summary>
        /// Property related to the field PhoneWork
        /// both read and write access
        /// </summary>
        public string PhoneWork
        {
            get { return phoneCellphone; }
            set
            {
                if (value.Length == 15)
                {
                    phoneCellphone = value;
                }
                else
                {
                    phoneCellphone = "(000) 00 000000";
                }
            }
        }
        /// <summary>
        /// Property related to the field PhoneHome
        /// both read and write access
        /// </summary>
        public string PhoneHome
        {
            get { return phoneHome; }
            set
            {
                if (value.Length == 15)
                {
                    phoneHome= value;
                }
                else
                {
                    phoneHome = "(000) 00 000000";
                }
            }
        }
        /// <summary>
        /// This is to check and validate the phones entered.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool Validate()
        {
            bool phoneHomeOK = !string.IsNullOrEmpty(phoneHome);
            bool phoneWorkOK = !string.IsNullOrEmpty(phoneCellphone);            
            return phoneHomeOK && phoneWorkOK;
        }
        /// <summary>
        /// This Method prepares a format string is in sync with the ToString method.
        /// It will be used in the MainForm as part of the heading for the listbox
        /// before customer information is added in the listbox.
        /// </summary>
        /// <returns>A formatted string as heading for the values formatted in the ToString method below.</returns>
        public string GetToStringItemsHeadingsPhone
        {
            get { return string.Format("{0, -20} {1, -20}", "Private", "Office"); }
        }
        /// <summary>
        /// Delivers a formatted string with data stored in the object.
        /// The values will appear a columns.
        /// </summary>
        /// <returns>The formatted strings.</returns>
        public override string ToString()
        {            
            string strOut = string.Format("{0, -20} {1, -20}", phoneHome, phoneCellphone);            
            return strOut;
            
            

        }        
    }
}
