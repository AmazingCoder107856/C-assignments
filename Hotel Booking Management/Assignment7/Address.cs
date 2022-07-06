using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// This class stores the information of Address of the customer.
    /// It calls list of enum the Countries.cs
    /// </summary>
    public class Address
    {
        //Fields = instance vaiables
        //input fields
        private string street; //street of the city entered
        private string zipCode; //zip code of the city entered
        private string city; //city entered
        private Countries country; //country selected
        private string strErrorMessage;

        /// <summary>
        /// Constrauctor with 4 parameters - used by other constructors too
        /// String are initiated to null by the compiler.
        /// It is better to assign then an empty so they are no longer null.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Address(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.zipCode = zip;
            this.city = city;
            this.country = country;
        }
        //Constructor - call the next constructor for reuse.
        public Address(string street, string zip, string city) : this(street, zip, city, Countries.Sverige)
        {

        }
        //Default constructor calling another constructor in the class
        public Address() : this(string.Empty, string.Empty, string.Empty)
        {

        }
        /// <summary>
        /// Copy constructor returning copy
        /// </summary>
        /// <param name="theOther"></param>
        public Address(Address theOther)
        {
            this.street = theOther.street;
            this.zipCode = theOther.zipCode;
            this.city = theOther.city;
            this.country = theOther.country;
        }
        /// <summary>
        /// Property related to the field Street
        /// both read and write access
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        /// <summary>
        /// Property related to the field ZipCode
        /// both read and write access
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        /// <summary>
        /// Property related to the field City
        /// both read and write access
        /// </summary>
        public string City
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    city = value;
            }
        }
        /// <summary>
        /// Property related to the field Country
        /// both read and write access
        /// </summary>
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }
        /// <summary>
        /// Property related to the field strErrorMessage
        /// both read and write access
        /// </summary>
        public string ErrorMessage
        {
            get { return strErrorMessage; }
            set { strErrorMessage = value; }
        }
        /// <summary>
        /// This function simply deletes the '_'s from country names as saved in the
        /// </summary>
        /// <returns>the country name without the underscore char</returns>
        public string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }
        /// <summary>
        /// Formatting text into several lines
        /// </summary>
        /// <returns></returns>
        public string GetAddressInfo()
        {
            string strout = street + Environment.NewLine;
            strout += zipCode + " " + city + Environment.NewLine;
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strout;
        }
        /// <summary>
        /// Do some chaecking av data.
        /// Address must hav a city and country. Country is an Enum.
        /// It will always have a default value.
        /// City is initiated to null so it should get validated.
        /// But it is ok if the rest is not given.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            if (string.IsNullOrEmpty(city))
            {
                strErrorMessage = "City is required!";
                return false;
            }
            else
                return true;
        }
        /// <summary>
        /// Override the ToString method to return a string made of the address details
        /// formatted in one line.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("{0, 10} {1, 8} {2, 10}{3, 20}", street, zipCode, city, GetCountryString());
            return strOut;
        }
    }
}
