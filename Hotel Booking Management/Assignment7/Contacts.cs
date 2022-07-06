using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Contact
    {
        //Fields
        private string m_fullName;        
        private string m_id;
        private string m_idNumber;
        private string m_age;
        private GenderType gender;

        //Aggregation - "has a" relation
        private Address m_address;
        private Email m_email;
        private Phone m_phone;

        /// <summary>
        /// Default constructor. It calls constructor with 8 parameters
        /// passing the default values.
        /// </summary>
        public Contact() : this(string.Empty, string.Empty, string.Empty, string.Empty, GenderType.Male, new Address(), new Phone(), new Email())
        {

        }

        /// <summary>
        /// Constructor with 8 parameters. This is the constructor that has the most
        /// number of parameters.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="adr"></param>
        /// <param name="mail"></param>
        /// <param name="phoneNum"></param>
        public Contact(string id, string idNumber, string fullName, string age, GenderType gender, Address adr, Phone phoneNum, Email mail)
        {
            this.m_fullName = fullName;
            this.m_id = id;
            this.m_idNumber = idNumber;
            this.m_age = age;
            this.gender = gender;
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
            this.m_fullName = theOther.m_fullName;
            this.m_id = theOther.m_id;
            this.m_idNumber = theOther.m_idNumber;
            this.m_age = theOther.m_age;
            this.gender = theOther.gender;
            this.m_address = new Address(theOther.m_address);
            this.m_email = new Email(theOther.m_email);
            this.m_phone = new Phone(theOther.m_phone);
        }
        /// <summary>
        /// Property related to the field fullName
        /// both read and write access
        /// </summary>
        public string FullName
        {
            get { return m_fullName; }
            set { m_fullName = value; }
        }
        /// <summary>
        /// Property related to the field id
        /// both read and write access
        /// </summary>
        public string ID
        {
            get { return m_id; }
            set { m_id = value; }
        }
        /// <summary>
        /// Property related to the field idNumber
        /// both read and write access
        /// </summary>
        public string IdNumber
        {
            get { return m_idNumber; }
            set { m_idNumber = value; }
        }
        /// <summary>
        /// Property related to the field age
        /// both read and write access
        /// </summary>
        public string Age
        {
            get { return m_age; }
            set { m_age = value; }

        }
        /// <summary>
        /// Property related to the field gender
        /// both read and write access
        /// </summary>
        public GenderType Gender
        {
            get { return gender; }
            set { gender = value; }

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
            bool namesOK = (!string.IsNullOrEmpty(m_fullName));
            bool idOK = (!string.IsNullOrEmpty(m_id));
            bool idNumberOK = (!string.IsNullOrEmpty(m_idNumber));
            bool ageOK = (!string.IsNullOrEmpty(m_age));            
            return addrOK && emailOK && phoneOK && namesOK && idOK && idNumberOK && ageOK;
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
            string strout = string.Format("{0, -10} {1, -30} {2, -30} {3, 5} {4, 8} {5} {6} {7}", m_id, m_idNumber, m_fullName, m_age, gender, m_address.ToString(), m_email.ToString(), m_phone.ToString());
            return strout;
        }
    }
}
