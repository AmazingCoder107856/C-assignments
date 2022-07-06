using Assignment5ABC.ContactFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    public class Contact 
    {
        //Fields
        private string m_firstName;
        private string m_lastName;        

        //Aggregation - "has a" relation
        private Address m_address;
        private Email m_email;
        private Phone m_phone;
        
        /// <summary>
        /// Default constructor. It calls constructor with 5 parameters
        /// passing the default values.
        /// </summary>
        public Contact() : this(string.Empty, string.Empty, new Address(), new Phone(), new Email())
        {

        }

        /// <summary>
        /// Constructor with 5 parameters. This is the constructor that has the most
        /// number of parameters.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="adr"></param>
        /// <param name="mail"></param>
        /// <param name="phoneNum"></param>
        public Contact(string firstName, string lastName, Address adr, Phone phoneNum, Email mail) 
        {            
            this.m_firstName = firstName;
            this.m_lastName = lastName;
            this.m_address = adr;
            this.m_email = mail;
            this.m_phone = phoneNum;            
        }        
        /// <summary>
        /// Copy constructor returning copy
        /// </summary>
        /// <param name="theOther"></param>
        public Contact(Contact theOther)
        {
            this.m_firstName = theOther.m_firstName;
            this.m_lastName = theOther.m_lastName;
            this.m_address = new Address(theOther.m_address);
            this.m_email = new Email(theOther.m_email);
            this.m_phone = new Phone(theOther.m_phone);
        }
        /// <summary>
        /// Property related to the field FirstName
        /// both read and write access
        /// </summary>
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        /// <summary>
        /// Property related to the field LastName
        /// both read and write access
        /// </summary>
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        /// <summary>
        /// Property related to the field FullName
        /// both read and write access
        /// </summary>
        public string FullName
        {
            get { return m_firstName + " " + m_lastName; }
           
        }
        /// <summary>
        /// Property related to the field Address
        /// both read and write access
        /// </summary>
        public Address AddressData
        {
            get { return m_address; }
            set { m_address = value; }
        }
        /// <summary>
        /// Property related to the field Email
        /// both read and write access
        /// </summary>
        public Email EmailData
        {
            get { return m_email; }
            set { m_email = value; }
        }
        /// <summary>
        /// Property related to the field Phone
        /// both read and write access
        /// </summary>
        public Phone PhoneData
        {
            get { return m_phone; }
            set { m_phone = value; }
        }
        /// <summary>
        /// Do some validation of data. The address, email and phone object should validate itself
        /// The first and last name should be given by the user
        /// </summary>
        /// <returns></returns>
        public bool ValidateContact()
        {
            bool addrOK = m_address.Validate();
            bool emailOK = m_email.ValidateEmail();
            bool phoneOK = m_phone.Validate();
            bool namesOK = (!string.IsNullOrEmpty(m_firstName)) && (!string.IsNullOrEmpty(m_lastName));
            return addrOK && emailOK && phoneOK && namesOK;
        }
        public string GetAddressInfo(string street, string zipCode, string city, Countries country)
        {
            string strout = street + Environment.NewLine;
            strout += zipCode + " " + city + Environment.NewLine;
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strout;
        }
        public string GetEmailInfo(string emailBus, string emailPriv)
        {
            string strout = emailBus + Environment.NewLine;
            strout += emailPriv + Environment.NewLine;
            return strout;
        }
        public string GetPhoneInfo(string phoneHome, string phoneCellphone)
        {
            string strout = phoneHome + Environment.NewLine;
            strout += phoneCellphone + Environment.NewLine;
            return strout;
        }
        /// <summary>
        /// Format the contact's first and last name and the address, email and phone info
        /// Call address. email, phone's to get the info.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strout = string.Format("{0, -30} {1} {2} {3}", FullName, m_address.ToString(), m_email.ToString(), m_phone.ToString());            
            return strout;            
        }        
    }
}
