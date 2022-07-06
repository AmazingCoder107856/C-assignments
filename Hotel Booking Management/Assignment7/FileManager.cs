using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment7
{
    class FileManager
    {
        //This token will be written as the first line in the textfile as stample
        //to mark that the file is saved by this application
        private const string fileVersionToken = "CustomerInfo_22";

        //The file version can help make old files compatible
        //The file version does not have to be the same as the app's version number
        private const double fileVersionNr = 1.0;

        /// <summary>
        /// this method is used to save a customer to file
        /// </summary>
        /// <param name="customers">customers to be saved</param>
        /// <param name="fileName">path of the file</param>
        /// <returns></returns>
        public bool SaveCustomerToFile(List<Customer> customerList, string fileName)
        {
            bool ok = true;
            StreamWriter sw = null; //writer must be declared here, to be accessed by try, catch and finally
            try
            {
                //write information about file version and customerList
                sw = new StreamWriter(fileName);
                sw.WriteLine(fileVersionToken);
                sw.WriteLine(fileVersionNr);
                sw.WriteLine(customerList.Count);

                //save the items in the list, one field at a time                
                for (int i = 0; i < customerList.Count; i++)
                {
                    sw.WriteLine(customerList[i].CustomerNumber.ToString());
                    sw.WriteLine(customerList[i].ContactData.ID.ToString());
                    sw.WriteLine(customerList[i].ContactData.IdNumber.ToString());
                    sw.WriteLine(customerList[i].ContactData.FullName.ToString());
                    sw.WriteLine(customerList[i].ContactData.Age.ToString());
                    sw.WriteLine(customerList[i].ContactData.Gender.ToString());
                    sw.WriteLine(customerList[i].ContactData.AddressData.Street.ToString());
                    sw.WriteLine(customerList[i].ContactData.AddressData.ZipCode.ToString());
                    sw.WriteLine(customerList[i].ContactData.AddressData.City.ToString());
                    sw.WriteLine(customerList[i].ContactData.AddressData.Country.ToString());
                    sw.WriteLine(customerList[i].ContactData.PhoneData.PhoneHome.ToString());
                    sw.WriteLine(customerList[i].ContactData.PhoneData.PhoneWork.ToString());
                    sw.WriteLine(customerList[i].ContactData.EmailData.EmailBusiness.ToString());
                    sw.WriteLine(customerList[i].ContactData.EmailData.EmailPrivate.ToString());
                }
            }
            catch
            {
                //if any error in above try_block, the execution will jump to this block
                //Avoiding program crash
                ok = false;
            }
            finally //always executed
            {
                //this block is always executed no matter if an error occurs or not
                if (sw != null)
                    sw.Close();
            }
            return ok;
        }
        /// <summary>
        /// this method is used to read customers from file and 
        /// add customers to list to be displayed in the listbox
        /// </summary>
        /// <param name="customers">list where the customers will be added</param>
        /// <param name="fileName">path of the file to read</param>
        /// <returns></returns>
        public bool ReadCustomerFrFile(List<Customer> customerList, string fileName)
        {
            bool ok = true;
            StreamReader sr = null; // reader must be declared here, to be accessed by try, catch and finally

            try
            {
                //clear the contents of customerlist
                if (customerList != null)
                    customerList.Clear();
                else //if customers as null (not created)
                    customerList = new List<Customer>();

                sr = new StreamReader(fileName);

                //Ensure that it is the correct file
                string versionTest = sr.ReadLine();
                //Ensure that it has the correct version nr.
                double versionNr = double.Parse(sr.ReadLine());

                if ((versionTest == fileVersionToken) && (versionNr == fileVersionNr)) //correct file
                {
                    int count = int.Parse(sr.ReadLine()); //read number of customers saved to list
                    for (int i = 0; i < count; i++) //create customerlist, read values and add to list
                    {
                        Customer customer = new Customer();
                        customer.CustomerNumber = sr.ReadLine();
                        customer.ContactData.ID = sr.ReadLine();
                        customer.ContactData.IdNumber = sr.ReadLine();
                        customer.ContactData.FullName = sr.ReadLine();
                        customer.ContactData.Age = sr.ReadLine();
                        customer.ContactData.Gender = (GenderType)Enum.Parse(typeof(GenderType), sr.ReadLine());
                        customer.ContactData.AddressData.Street = sr.ReadLine();
                        customer.ContactData.AddressData.ZipCode = sr.ReadLine();
                        customer.ContactData.AddressData.City = sr.ReadLine();
                        customer.ContactData.AddressData.Country = (Countries)Enum.Parse(typeof(Countries), sr.ReadLine());
                        customer.ContactData.PhoneData.PhoneHome = sr.ReadLine();
                        customer.ContactData.PhoneData.PhoneWork = sr.ReadLine();
                        customer.ContactData.EmailData.EmailBusiness = sr.ReadLine();
                        customer.ContactData.EmailData.EmailPrivate = sr.ReadLine();
                                                
                        customerList.Add(customer);
                    }
                }
                else //if versionnumber not compatible
                    ok = false;
            }
            catch //if anything goes wrong
            {
                ok = false;
            }
            finally //always executed
            {
                if (sr != null) //if reader not null, close reader
                    sr.Close();
            }
            return ok;
        }
        //This token will be written as the first line in the textfile as stample
        //to mark that the file is saved by this application
        private const string fileVersionToken1 = "EmployeeInfo_22";

        //The file version can help make old files compatible
        //The file version does not have to be the same as the app's version number
        private const double fileVersionNr1 = 1.0;

        /// <summary>
        /// this method is used to save a employee to file
        /// </summary>
        /// <param name="employeeList">employeeList to be saved</param>
        /// <param name="fileEmployeeName">path of the file</param>
        /// <returns></returns>
        public bool SaveEmployeeToFile(List<Employee> employeeList, string fileEmployeeName)
        {
            bool ok = true;
            StreamWriter sw = null; //writer must be declared here, to be accessed by try, catch and finally
            try
            {
                //write information about file version and employeeList
                sw = new StreamWriter(fileEmployeeName);
                sw.WriteLine(fileVersionToken1);
                sw.WriteLine(fileVersionNr1);
                sw.WriteLine(employeeList.Count);
                
                for (int i = 0; i < employeeList.Count; i++)
                {
                    sw.WriteLine(employeeList[i].EmployeeNumber.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.FirstName.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.LastName.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.Age.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.Gender.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.Status.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.Job.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.Salary.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.AddressData.Street.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.AddressData.ZipCode.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.AddressData.City.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.AddressData.Country.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.PhoneData.PhoneHome.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.PhoneData.PhoneWork.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.EmailData.EmailBusiness.ToString());
                    sw.WriteLine(employeeList[i].EmployeeContactData.EmailData.EmailPrivate.ToString());
                }
            }
            catch
            {
                //if any error in above try_block, the execution will jump to this block
                //Avoiding program crash
                ok = false;
            }
            finally //always executed
            {
                //this block is always executed no matter if an error occurs or not
                if (sw != null)
                    sw.Close();
            }
            return ok;
        }
        /// <summary>
        /// this method is used to read employeeList from file and 
        /// add employees to list to be displayed in the listbox
        /// </summary>
        /// <param name="employeeList">list where the employees will be added</param>
        /// <param name="fileEmployeeName">path of the file to read</param>
        /// <returns></returns>
        public bool ReadEmployeeFrFile(List<Employee> employeeList, string fileEmployeeName)
        {
            bool ok = true;
            StreamReader sr = null; // reader must be declared here, to be accessed by try, catch and finally

            try
            {
                //clear the contents of employeelist
                if (employeeList != null)
                    employeeList.Clear();
                else //if employeeList as null (not created)
                    employeeList = new List<Employee>();

                sr = new StreamReader(fileEmployeeName);

                //Ensure that it is the correct file
                string versionTest1 = sr.ReadLine();
                //Ensure that it has the correct version nr.
                double versionNr1 = double.Parse(sr.ReadLine());

                if ((versionTest1 == fileVersionToken1) && (versionNr1 == fileVersionNr1)) //correct file
                {
                    int count = int.Parse(sr.ReadLine()); //read number of employees saved to list
                    for (int i = 0; i < count; i++) //create employeelist, read values and add to list
                    {
                        Employee employee = new Employee();
                        employee.EmployeeNumber = sr.ReadLine();
                        employee.EmployeeContactData.FirstName = sr.ReadLine();
                        employee.EmployeeContactData.LastName = sr.ReadLine();
                        employee.EmployeeContactData.Age = sr.ReadLine();
                        employee.EmployeeContactData.Gender = (GenderType)Enum.Parse(typeof(GenderType), sr.ReadLine());
                        employee.EmployeeContactData.Status = (StatusType)Enum.Parse(typeof(StatusType), sr.ReadLine());
                        employee.EmployeeContactData.Job = (JobType)Enum.Parse(typeof(JobType), sr.ReadLine());
                        employee.EmployeeContactData.Salary = sr.ReadLine();
                        employee.EmployeeContactData.AddressData.Street = sr.ReadLine();
                        employee.EmployeeContactData.AddressData.ZipCode = sr.ReadLine();
                        employee.EmployeeContactData.AddressData.City = sr.ReadLine();
                        employee.EmployeeContactData.AddressData.Country = (Countries)Enum.Parse(typeof(Countries), sr.ReadLine());
                        employee.EmployeeContactData.PhoneData.PhoneHome = sr.ReadLine();
                        employee.EmployeeContactData.PhoneData.PhoneWork = sr.ReadLine();
                        employee.EmployeeContactData.EmailData.EmailBusiness = sr.ReadLine();
                        employee.EmployeeContactData.EmailData.EmailPrivate = sr.ReadLine();
                        employeeList.Add(employee);
                    }
                }
                else //if versionnumber not compatible
                    ok = false;
            }
            catch //if anything goes wrong
            {
                ok = false;
            }
            finally //always executed
            {
                if (sr != null) //if reader not null, close reader
                    sr.Close();
            }
            return ok;
        }
        //This token will be written as the first line in the textfile as stample
        //to mark that the file is saved by this application
        private const string fileVersionToken2 = "RoomInfo_22";

        //The file version can help make old files compatible
        //The file version does not have to be the same as the app's version number
        private const double fileVersionNr2 = 1.0;

        /// <summary>
        /// this method is used to save a roomList to file
        /// </summary>
        /// <param name="roomList">taskList to be saved</param>
        /// <param name="fileRoomName">path of the file</param>
        /// <returns></returns>
        public bool SaveRoomListToFile(List<Room> roomList, string fileRoomName)
        {
            bool ok = true;
            StreamWriter sw = null; //writer must be declared here, to be accessed by try, catch and finally
            try
            {
                //write information about file version and roomList
                sw = new StreamWriter(fileRoomName);
                sw.WriteLine(fileVersionToken2);
                sw.WriteLine(fileVersionNr2);
                sw.WriteLine(roomList.Count);

                //save the items in the list, one field at a time
                //the DateTime is split up so that year and month etc can be read seperately
                for (int i = 0; i < roomList.Count; i++)
                {
                    sw.WriteLine(roomList[i].RoomNumber);
                    sw.WriteLine(roomList[i].DateAndTime.Year);
                    sw.WriteLine(roomList[i].DateAndTime.Month);
                    sw.WriteLine(roomList[i].DateAndTime.Day);
                    sw.WriteLine(roomList[i].DateAndTime.Hour);
                    sw.WriteLine(roomList[i].DateAndTime.Minute);
                    sw.WriteLine(roomList[i].DateAndTime.Second);
                    sw.WriteLine(roomList[i].CleaningStatus);
                    sw.WriteLine(roomList[i].RoomPrice);
                    sw.WriteLine(roomList[i].Rooms.ToString());
                    
                }
            }
            catch
            {
                //if any error in above try_block, the execution will jump to this block
                //Avoiding program crash
                ok = false;
            }
            finally //always executed
            {
                //this block is always executed no matter if an error occurs or not
                if (sw != null)
                    sw.Close();
            }
            return ok;
        }
        /// <summary>
        /// this method is used to read roomList from file and 
        /// add rooms to list to be displayed in the list
        /// </summary>
        /// <param name="roomList">list where the rooms will be added</param>
        /// <param name="fileRoomName">path of the file to read</param>
        /// <returns></returns>
        public bool ReadRoomListFrFile(List<Room> roomList, string fileRoomName)
        {
            bool ok = true;
            StreamReader sr = null; // reader must be declared here, to be accessed by try, catch and finally

            try
            {
                //clear the contents of roomlist
                if (roomList != null)
                    roomList.Clear();
                else //if roomList as null (not created)
                    roomList = new List<Room>();

                sr = new StreamReader(fileRoomName);

                //Ensure that it is the correct file
                string versionTest2 = sr.ReadLine();
                //Ensure that it has the correct version nr.
                double versionNr2 = double.Parse(sr.ReadLine());

                if ((versionTest2 == fileVersionToken2) && (versionNr2 == fileVersionNr2)) //correct file
                {
                    int count = int.Parse(sr.ReadLine()); //read number of rooms saved to roomList
                    for (int i = 0; i < count; i++) //create room, read values and add to list
                    {
                        Room room = new Room();
                        room.RoomNumber = sr.ReadLine();
                        //DateTime.Year, Month, etc. are readonly
                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute = 0, second = 0;

                        year = int.Parse(sr.ReadLine());
                        month = int.Parse(sr.ReadLine());
                        day = int.Parse(sr.ReadLine());
                        hour = int.Parse(sr.ReadLine());
                        minute = int.Parse(sr.ReadLine());
                        second = int.Parse(sr.ReadLine());

                        room.DateAndTime = new DateTime(year, month, day, hour, minute, second);
                        room.CleaningStatus = sr.ReadLine();
                        room.RoomPrice = sr.ReadLine();
                        room.Rooms = (RoomType)Enum.Parse(typeof(RoomType), sr.ReadLine());                        

                        roomList.Add(room);
                    }
                }
                else //if versionnumber not compatible
                    ok = false;
            }
            catch //if anything goes wrong
            {
                ok = false;
            }
            finally //always executed
            {
                if (sr != null) //if reader not null, close reader
                    sr.Close();
            }
            return ok;
        }
        //This token will be written as the first line in the textfile as stample
        //to mark that the file is saved by this application
        private const string fileVersionToken3 = "ReservationInfo_22";

        //The file version can help make old files compatible
        //The file version does not have to be the same as the app's version number
        private const double fileVersionNr3 = 1.0;

        /// <summary>
        /// this method is used to save a reservationsList to file
        /// </summary>
        /// <param name="reservationsList">taskList to be saved</param>
        /// <param name="fileReservationName">path of the file</param>
        /// <returns></returns>
        public bool SaveReservationListToFile(List<Reservations> reservationsList, string fileReservationName)
        {
            bool ok = true;
            StreamWriter sw = null; //writer must be declared here, to be accessed by try, catch and finally
            try
            {
                //write information about file version and reservationList
                sw = new StreamWriter(fileReservationName);
                sw.WriteLine(fileVersionToken3);
                sw.WriteLine(fileVersionNr3);
                sw.WriteLine(reservationsList.Count);

                //save the items in the list, one field at a time
                //the DateTime is split up so that year and month etc can be read seperately
                for (int i = 0; i < reservationsList.Count; i++)
                {
                    sw.WriteLine(reservationsList[i].ReservationNumber.ToString());
                    sw.WriteLine(reservationsList[i].ReservationName.ToString());
                    sw.WriteLine(reservationsList[i].CheckInTime.Year);
                    sw.WriteLine(reservationsList[i].CheckInTime.Month);
                    sw.WriteLine(reservationsList[i].CheckInTime.Day);
                    sw.WriteLine(reservationsList[i].CheckOutTime.Year);
                    sw.WriteLine(reservationsList[i].CheckOutTime.Month);
                    sw.WriteLine(reservationsList[i].CheckOutTime.Day);
                    sw.WriteLine(reservationsList[i].GuestChild.ToString());
                    sw.WriteLine(reservationsList[i].GuestAdult.ToString());
                    sw.WriteLine(reservationsList[i].GuestPensioner.ToString());
                    sw.WriteLine(reservationsList[i].RoomType.ToString());

                }
            }
            catch
            {
                //if any error in above try_block, the execution will jump to this block
                //Avoiding program crash
                ok = false;
            }
            finally //always executed
            {
                //this block is always executed no matter if an error occurs or not
                if (sw != null)
                    sw.Close();
            }
            return ok;
        }
        /// <summary>
        /// this method is used to read reservationsList from file and 
        /// add reservations to list to be displayed in the list
        /// </summary>
        /// <param name="reservationsList">list where the rooms will be added</param>
        /// <param name="fileReservationName">path of the file to read</param>
        /// <returns></returns>
        public bool ReadReservationListFrFile(List<Reservations> reservationsList, string fileReservationName)
        {
            bool ok = true;
            StreamReader sr = null; // reader must be declared here, to be accessed by try, catch and finally

            try
            {
                //clear the contents of reservationslist
                if (reservationsList != null)
                    reservationsList.Clear();
                else //if reservationsList as null (not created)
                    reservationsList = new List<Reservations>();

                sr = new StreamReader(fileReservationName);

                //Ensure that it is the correct file
                string versionTest3 = sr.ReadLine();
                //Ensure that it has the correct version nr.
                double versionNr3 = double.Parse(sr.ReadLine());

                if ((versionTest3 == fileVersionToken3) && (versionNr3 == fileVersionNr3)) //correct file
                {
                    int count = int.Parse(sr.ReadLine()); //read number of reservations saved to reservationsList
                    for (int i = 0; i < count; i++) //create reservations, read values and add to list
                    {
                        Reservations reservations = new Reservations();
                        reservations.ReservationNumber = sr.ReadLine();
                        reservations.ReservationName = sr.ReadLine();

                        //DateTime.Year, Month, etc. are readonly
                        int year = 0, month = 0, day = 0;                        
                        year = int.Parse(sr.ReadLine());
                        month = int.Parse(sr.ReadLine());
                        day = int.Parse(sr.ReadLine());                        

                        reservations.CheckInTime = new DateTime(year, month, day);

                        //DateTime.Year, Month, etc. are readonly
                        year = int.Parse(sr.ReadLine());
                        month = int.Parse(sr.ReadLine());
                        day = int.Parse(sr.ReadLine());

                        reservations.CheckOutTime = new DateTime(year, month, day);
                        reservations.GuestChild = sr.ReadLine();
                        reservations.GuestAdult = sr.ReadLine();
                        reservations.GuestPensioner = sr.ReadLine();
                        reservations.RoomType = (RoomType)Enum.Parse(typeof(RoomType), sr.ReadLine());

                        reservationsList.Add(reservations);
                    }
                }
                else //if versionnumber not compatible
                    ok = false;
            }
            catch //if anything goes wrong
            {
                ok = false;
            }
            finally //always executed
            {
                if (sr != null) //if reader not null, close reader
                    sr.Close();
            }
            return ok;
        }
    }
}
