using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Employee
    {
        //Fields        
        private string _employeeNumber;
        private EmployeeContacts _employeeContacts;    
        
        /// <summary>
        /// Constructor that takes 2 parameters and add id for the employee.
        /// </summary>
        /// <param name="contact">th contact object</param>
        /// <param name="employeeNumber">number for the customer</param>
        public Employee(string empNumber, EmployeeContacts employeeContacts)
        {
            _employeeContacts = employeeContacts;
            _employeeNumber = empNumber;
        }
        /// <summary>
        /// Constructor that takes 1 parameter.
        /// It calls the constructor with 2 parameter
        /// </summary>
        /// <param name="employeeIn"></param>
        public Employee(Employee employeeIn) : this(employeeIn.EmployeeNumber, employeeIn.EmployeeContactData)
        {

        }
        /// <summary>
        /// Default constructor (parameterless)
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        public Employee() : this(new EmployeeContacts())
        {

        }
        /// <summary>
        /// Construtor with one parameter which calls 
        /// the constructor with two parameters passing default value for id.
        /// </summary>
        /// <param name="contactIn"></param>
        public Employee(EmployeeContacts contactIn) : this(string.Empty, contactIn)
        {

        }
        /// <summary>
        /// Property related to th field _employeeContact object
        /// both read and write access
        /// </summary>
        public EmployeeContacts EmployeeContactData
        {
            get { return _employeeContacts; }
            set { _employeeContacts = value; }
        }
        /// <summary>
        /// Property related to th field _employeeNumber
        /// both read and write access
        /// </summary>
        public string EmployeeNumber
        {
            get { return _employeeNumber; }
            set { _employeeNumber = value; }
        }
        /// <summary>
        /// Delivers a formatted string to the listbox of employee details with data stored in the object.
        /// The values will appear a columns.
        /// </summary>
        /// <returns>The formatted strings.</returns>
        public override string ToString()
        {
            string fullName = _employeeContacts.FirstName.ToString() + " " + _employeeContacts.LastName.ToString();
            string strOut = string.Format("{0, -8}{1, -30}{2, -5}{3, -20}{4, -10}{5, -10}{6, -10}{7, -10}{8, 15}{9, -15}", _employeeNumber, fullName, 
                _employeeContacts.Age.ToString(), _employeeContacts.Gender.ToString(), _employeeContacts.Status.ToString(), _employeeContacts.Job.ToString(), 
                _employeeContacts.Salary.ToString(), _employeeContacts.AddressData.ToString(), _employeeContacts.PhoneData.ToString(), _employeeContacts.EmailData.ToString());
            return strOut;
        }
    }
}
