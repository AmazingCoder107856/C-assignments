using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6ABC
{
    public class Task
    {
        //Fields
        private DateTime date; //date and time or a task
        private string description; //task's notes
        private PriorityType priority; //priority selected

        /// <summary>
        /// Default constructor (parameterless)
        /// </summary>
        public Task()
        {
            //set a default priority type
            priority = PriorityType.Normal;
        }
        /// <summary>
        /// Constructor with one parameter
        /// calling the constructor with 3 parameters sending the one parameter
        /// that comes from the caller (taskDate) and three default value.
        /// The other constructor is called using the keyword this.
        /// </summary>
        /// <param name="taskDate">Input coming as a parameter from the caller</param>
        public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityType.Normal)
        {

        }
        /// <summary>
        /// Constructor with 3 parameters to be used when all data is available 
        /// upon creating the object. Other constructors calls this one.
        /// </summary>
        /// <param name="taskDate">saves data to the date variable</param>
        /// <param name="description">saves a string to the description variable</param>
        /// <param name="priority">sets the priority enum value</param>
        public Task(DateTime taskDate, string description, PriorityType priority)
        {
            this.date = taskDate;
            this.description = description;
            this.priority = priority;
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other">object to be copied</param>
        public Task(Task other)
        {
            this.date = other.date;
            this.description = other.description;
            this.priority = other.priority;
        }
        /// <summary>
        /// Property connected to the date instance variable. 
        /// Both read and write acces
        /// </summary>
        public DateTime DateAndTime
        {
            get { return date; }
            set { date = value; }
        }
        /// <summary>
        /// Property connected to the priority instance variable. 
        /// Both read and write acces
        /// </summary>
        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        /// <summary>
        /// Property connected to the field description
        /// </summary>
        public string Description
        {
            get { return description; }
            set 
            { 
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }
        /// <summary>
        /// This method returns a string in the form of 
        /// HH:mm to represent when a task is to be performed.
        /// </summary>
        /// <returns>string of time formatted to HH:mm</returns>
        private string GetTimeString()
        {
            string time = string.Format("{0}:{1}", date.Hour.ToString("00"), date.Minute.ToString("00"));
            return time;
        }
        /// <summary>
        /// This method is used to return a string representing a 
        /// priority enum with the "_" replaced with " "
        /// </summary>
        /// <returns>string with character replaced</returns>
        public string GetPriorityString()
        {
            string txtOut = Enum.GetName(typeof(PriorityType), priority);
            txtOut = txtOut.Replace("_", " ");
            return txtOut;
        }
        //// <summary>
        /// Overrides the ToString to return a formatted string with task information
        /// </summary>
        /// <returns>formatted string with task information</returns>
        public override string ToString()
        {
            return $"{date.ToLongDateString(),-25}" +
                $"{GetTimeString(),12} {" ",6}" +
                $"{ GetPriorityString(),-16} {" ",10}" +
                $"{ description,-20}";            
        }
    }
}
