using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Email
    {
        private string emailBus; //business email
        private string emailPriv; //private email

        //Constructors are overloaded and called in a chain
        //Default constructor - calls another constructor in this class
        public Email() : this(string.Empty)
        {

        }
        /// <summary>
        /// <Constructor with one parameter - calls the constructor with 
        /// two parameters, usong a default value as the second argument.
        /// </summary>
        /// <param name="emailBus"></param>
        /// <param name="emailPriv"></param>
        public Email(string emailWork) : this(emailWork, string.Empty)
        {

        }
        /// <summary>
        /// Copy constructor returning copy
        /// </summary>
        /// <param name="theOther"></param>
        public Email(Email theOther)
        {
            this.emailBus = theOther.emailBus;
            this.emailPriv = theOther.emailPriv;
        }
        /// <summary>
        /// Constructor with two parameters. This is constructor that has most
        /// number of parameters.It is in this constructor that all coding should be done.
        /// </summary>
        /// <param name="emailWork"></param>
        /// <param name="emailPriv"></param>
        public Email(string emailWork, string emailPriv)
        {
            emailBus = emailWork;
            this.emailPriv = emailPriv;
        }
        /// <summary>
        /// Property related to the field EmailBusiness
        /// both read and write access
        /// </summary>
        public string EmailBusiness
        {
            get { return emailBus; }
            set { emailBus = value; }
        }
        /// <summary>
        /// Property related to the field EmailPrivate
        /// both read and write access
        /// </summary>
        public string EmailPrivate
        {
            get { return emailPriv; }
            set { emailPriv = value; }
        }
        /// <summary>
        /// This is to check and validate the emails entered.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidateEmail()
        {            
            bool emailBusOK = !string.IsNullOrEmpty(emailBus);
            bool emailPrivOK = !string.IsNullOrEmpty(emailPriv);
            return emailBusOK && emailPrivOK;
        }
        /// <summary>
        /// This Method prepares a format string is in sync with the ToString method.
        /// It will be used in the MainForm as part of the heading for the listbox
        /// before customer information is added in the listbox.
        /// </summary>
        /// <returns>A formatted string as heading for the values formatted in the ToString method below.</returns>
        public string GetToStringItemsHeadingsEmail
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
            string strOut = string.Format("{0, 15} {1, 15}", emailBus, emailPriv);
            return strOut;
        }
    }
}
