using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6ABC
{
    class FileManager
    {
        //This token will be written as the first line in the textfile as stample
        //to mark that the file is saved by this application
        private const string fileVersionToken = "ToDoRe_22";

        //The file version can help make old files compatible
        //The file version does not have to be the same as the app's version number
        private const double fileVersionNr = 1.0;

        /// <summary>
        /// this method is used to save a taskList to file
        /// </summary>
        /// <param name="taskList">taskList to be saved</param>
        /// <param name="fileName">path of the file</param>
        /// <returns></returns>
        public bool SaveTaskListToFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamWriter sw = null; //writer must be declared here, to be accessed by try, catch and finally
            try
            {
                //write information about file version and taskList
                sw = new StreamWriter(fileName);
                sw.WriteLine(fileVersionToken);
                sw.WriteLine(fileVersionNr);
                sw.WriteLine(taskList.Count);

                //save the items in the list, one field at a time
                //the DateTime is split up so that year and month etc can be read seperately
                for (int i = 0; i < taskList.Count; i++)
                {
                    sw.WriteLine(taskList[i].Description);
                    sw.WriteLine(taskList[i].Priority.ToString());
                    sw.WriteLine(taskList[i].DateAndTime.Year);
                    sw.WriteLine(taskList[i].DateAndTime.Month);
                    sw.WriteLine(taskList[i].DateAndTime.Day);
                    sw.WriteLine(taskList[i].DateAndTime.Hour);
                    sw.WriteLine(taskList[i].DateAndTime.Minute);
                    sw.WriteLine(taskList[i].DateAndTime.Second);
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
        /// this method is used to read taskList from file and 
        /// add tasks to list to be displayed in the ToDo Reminder
        /// </summary>
        /// <param name="taskList">list where the tasks will be added</param>
        /// <param name="fileName">path of the file to read</param>
        /// <returns></returns>
        public bool ReadTaskListFrFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamReader sr = null; // reader must be declared here, to be accessed by try, catch and finally

            try
            {
                //clear the contents of tasklist
                if (taskList != null)
                    taskList.Clear();
                else //if taskList as null (not created)
                    taskList = new List<Task>();

                sr = new StreamReader(fileName);

                //Ensure that it is the correct file
                string versionTest = sr.ReadLine();
                //Ensure that it has the correct version nr.
                double versionNr = double.Parse(sr.ReadLine());

                if ((versionTest == fileVersionToken) && (versionNr == fileVersionNr)) //correct file
                {
                    int count = int.Parse(sr.ReadLine()); //read number of tasks saved to taskList
                    for (int i = 0; i < count; i++) //create task, read values and add to list
                    {
                        Task task = new Task();
                        task.Description = sr.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), sr.ReadLine());

                        //DateTime.Year, Month, etc. are readonly
                        int year = 0, month = 0, day = 0;
                        int hour = 0, minute = 0, second = 0;

                        year = int.Parse(sr.ReadLine());
                        month = int.Parse(sr.ReadLine());
                        day = int.Parse(sr.ReadLine());
                        hour = int.Parse(sr.ReadLine());
                        minute = int.Parse(sr.ReadLine());
                        second = int.Parse(sr.ReadLine());

                        task.DateAndTime = new DateTime(year, month, day, hour, minute, second);
                        
                        taskList.Add(task);
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
