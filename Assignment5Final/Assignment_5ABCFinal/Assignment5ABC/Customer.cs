using Assignment5ABC.ContactFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    public class Customer
    {
        //Fields        
        private string m_id;
        private Contact _contacts;

        /// <summary>
        /// Constructor that takes 2 parameters and add id for the customer.
        /// </summary>
        /// <param name="contact">th contact object</param>
        /// <param name="id">id for the customer</param>
        public Customer(string id, Contact contact)
        {
            _contacts = contact;
            m_id = id;
        }
        /// <summary>
        /// Constructor that takes 1 parameter.
        /// It calls the constructor with 2 parameter
        /// </summary>
        /// <param name="customerIn"></param>
        public Customer(Customer customerIn) : this(customerIn.ID, customerIn.ContactData)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="contactIn"></param>
        /// <param name="id"></param>
        public Customer() : this(new Contact())
        {

        }
        /// <summary>
        /// Construtor with one parameter which calls 
        /// the constructor with two parameters passing default value for id.
        /// </summary>
        /// <param name="contactIn"></param>
        public Customer(Contact contactIn) : this(string.Empty, contactIn)
        {

        }
        /// <summary>
        /// Property related to th field contact object
        /// both read and write access
        /// </summary>
        public Contact ContactData
        {
            get { return _contacts; }
            set { _contacts = value; }
        }
        /// <summary>
        /// Property related to th field contact m_id
        /// both read and write access
        /// </summary>
        public string ID
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public override string ToString()
        {      
            string fullName = _contacts.LastName.ToString() + ", " + _contacts.FirstName.ToString();
            string strOut = string.Format("{0, -5} {1, -10} {2, 40} {3, 40}", m_id, fullName, _contacts.PhoneData.PhoneWork.ToString(), _contacts.EmailData.EmailBusiness.ToString());
            return strOut;
            //return m_id + " " + fullName + _contacts.PhoneData.PhoneWork.ToString() + _contacts.EmailData.EmailBusiness.ToString();
        }
    }
}
