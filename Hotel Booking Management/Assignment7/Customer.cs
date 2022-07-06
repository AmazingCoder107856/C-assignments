using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Customer
    {
        //Fields        
        private string customerNumber;
        private Contact _contacts;

        /// <summary>
        /// Constructor that takes 2 parameters and add id for the customer.
        /// </summary>
        /// <param name="contact">th contact object</param>
        /// <param name="customerNumber">number for the customer</param>
        public Customer(string custNumber, Contact contact)
        {
            _contacts = contact;
            customerNumber = custNumber;
        }
        /// <summary>
        /// Constructor that takes 1 parameter.
        /// It calls the constructor with 2 parameter
        /// </summary>
        /// <param name="customerIn"></param>
        public Customer(Customer customerIn) : this(customerIn.CustomerNumber, customerIn.ContactData)
        {

        }
        /// <summary>
        /// Default constructor (parameterless)
        /// </summary>        
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
        /// Property related to the field _contacts object
        /// both read and write access
        /// </summary>
        public Contact ContactData
        {
            get { return _contacts; }
            set { _contacts = value; }
        }
        /// <summary>
        /// Property related to the field customerNumber
        /// both read and write access
        /// </summary>
        public string CustomerNumber
        {
            get { return customerNumber; }
            set { customerNumber = value; }
        }
        /// <summary>
        /// Override the ToString method to return a string made of the customer details
        /// formatted in one line.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {            
            string strOut = string.Format("{0, 4} {1, 15} {2, 20} {3, -10} {4, 20} {5, 15} {6, 15} {7, 8} {8, 15} {9, 20} {10, 15} {11, 15} {12, 50} {13, 50}", customerNumber, _contacts.ID.ToString(), _contacts.IdNumber.ToString(), 
                _contacts.FullName.ToString(), _contacts.Age.ToString(), _contacts.Gender.ToString(), _contacts.AddressData.Street.ToString(), 
                _contacts.AddressData.ZipCode.ToString(), _contacts.AddressData.City.ToString(), _contacts.AddressData.GetCountryString(),
                _contacts.PhoneData.PhoneHome.ToString(), _contacts.PhoneData.PhoneWork.ToString(), _contacts.EmailData.EmailBusiness.ToString(), _contacts.EmailData.EmailPrivate.ToString());
            return strOut;            
        }
    }
}
