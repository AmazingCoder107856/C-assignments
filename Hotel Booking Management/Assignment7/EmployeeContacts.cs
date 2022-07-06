using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class EmployeeContacts
    {
        //Fields
        private string m_firstName;
        private string m_lastName;
        private string m_age;
        private GenderType m_gender;
        private StatusType m_status;        
        private JobType m_job;
        private string m_salary;

        //Aggregation - "has a" relation
        private Address m_address;
        private Email m_email;
        private Phone m_phone;

        /// <summary>
        /// Default constructor. It calls constructor with 10 parameters
        /// passing the default values.
        /// </summary>
        public EmployeeContacts() : this(string.Empty, string.Empty, string.Empty, GenderType.Male, StatusType.Single, JobType.Manager, String.Empty, new Address(), new Phone(), new Email())
        {

        }
        /// <summary>
        /// Constructor with 10 parameters. This is the constructor that has the most
        /// number of parameters.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="status"></param>
        /// <param name="job"></param>
        /// <param name="salary"></param>
        /// <param name="adr"></param>
        /// <param name="phoneNum"></param>
        /// <param name="mail"></param>
        public EmployeeContacts(string firstName, string lastName, string age, GenderType gender, StatusType status, JobType job, string salary, Address adr, Phone phoneNum, Email mail)
        {
            this.m_firstName = firstName;
            this.m_lastName = lastName;
            this.m_age = age;
            this.m_gender = gender;
            this.m_status = status;
            this.m_job = job;
            this.m_salary = salary;
            this.m_address = adr;
            this.m_email = mail;
            this.m_phone = phoneNum;
        }
        /// <summary>
        /// Copy constructor returning copy
        /// </summary>
        /// <param name="theOther"></param>
        public EmployeeContacts(EmployeeContacts theOther)
        {
            this.m_firstName = theOther.m_firstName;
            this.m_lastName = theOther.m_lastName;
            this.m_age = theOther.m_age;
            this.m_gender = theOther.m_gender;
            this.m_status = theOther.m_status;
            this.m_job = theOther.m_job;
            this.m_salary = theOther.m_salary;
            this.m_address = new Address(theOther.m_address);
            this.m_email = new Email(theOther.m_email);
            this.m_phone = new Phone(theOther.m_phone);
        }
        /// <summary>
        /// Property related to the field firstName
        /// both read and write access
        /// </summary>
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        /// <summary>
        /// Property related to the field lastName
        /// both read and write access
        /// </summary>
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        /// <summary>
        /// Property connected to the date instance variable. 
        /// Both read and write acces
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
            get { return m_gender; }
            set { m_gender = value; }

        }
        /// <summary>
        /// Property related to the field status
        /// both read and write access
        /// </summary>
        public StatusType Status
        {
            get { return m_status; }
            set { m_status = value; }

        }
        /// <summary>
        /// Property related to the field job
        /// both read and write access
        /// </summary>
        public JobType Job
        {
            get { return m_job; }
            set { m_job = value; }

        }
        /// <summary>
        /// Property related to the field salary
        /// both read and write access
        /// </summary>
        public string Salary
        {
            get { return m_salary; }
            set { m_salary = value; }

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
            bool namesOK = ((!string.IsNullOrEmpty(m_firstName)) && (!string.IsNullOrEmpty(m_lastName)));
            bool salaryOK = (!string.IsNullOrEmpty(m_salary));            
            return addrOK && emailOK && phoneOK && namesOK && salaryOK;
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
        /// Format the contact's first and last name, date of birth, gender, status, job, salary and the address, email and phone info
        /// Call address. email, phone's to get the info.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strout = string.Format("{0, -10}{1, -30}{2, -30}{3, 5}{4, 8}{5, 8}{6, 8}{7, 8}{8}{9}{10}", m_firstName, m_lastName, m_age, m_gender, m_status, m_job, m_salary, m_address.ToString(), m_phone.ToString(), m_email.ToString());
            return strout;
        }
    }
}
