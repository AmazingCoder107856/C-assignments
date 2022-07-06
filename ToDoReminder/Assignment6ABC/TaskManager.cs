using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6ABC
{
    /// <summary>
    /// A container class handling a lsit of task objects
    /// Uses a generic list to store tasks
    /// [serializable]
    /// </summary>
    class TaskManager
    {
        //Declare a List<T> object where T is a task type
        private List<Task> taskList;

        /// <summary>
        /// Create the taskList in the constructor
        /// </summary>
        public TaskManager()
        {
            taskList = new List<Task>();
        }
        /// <summary>
        /// This method is used to get the task at specified index
        /// </summary>
        /// <param name="index">index to get task from</param>
        /// <returns>the Task object at specified index</returns>
        public Task GetTask(int index)
        {
            if (CheckIndex(index))
                return taskList[index];
            else
                return null;
        }
        /// <summary>
        /// Controls so an index is not out of range.
        /// The results of the statements at the right side of the return keyword is 
        /// a bool value (true or false)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            bool ok = false;

            if ((index >= 0) && (index < taskList.Count)) 
            {
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// Add a new object at the end of the taskList
        /// </summary>
        /// <param name="newTask">The task object that is to be added</param>
        /// <returns>true if the task is added successfully, false otherwise</returns>
        public bool AddNewTask(Task newTask)
        {
            bool ok = true;
            
            if (newTask != null)
                taskList.Add(newTask);
            else
                ok = false;
            return ok;
        }
        /// <summary>
        /// Adds a new task to the tasklist using the value sent by the caller via the method parameters
        /// </summary>
        /// <param name="newTime"></param>
        /// <param name="description"></param>
        /// <param name="priority"></param>
        /// <returns>true if the task is added successfully, false otherwise</returns>
        public bool AddNewTask(DateTime newTime, string description, PriorityType priority)
        {
            bool ok = true;
            //create a new object with the above given values
            Task newTask = new Task(newTime, description, priority);
            if (newTask != null)
                taskList.Add(newTask);
            else
                ok = false;
            return ok;
        }
        /// <summary>
        /// Change an object in the tasklist in a given position with a new object.
        /// </summary>
        /// <param name="task">The object to replace an existing at index position</param>
        /// <param name="index">the position of the given position with a new object</param>
        /// <returns>true if the task is added successfully, false otherwise</returns>
        public bool ChangeTaskAt(Task task, int index)
        {
            bool ok = true;
            //check so that task is not null and index is not out of range
            if ((task != null) && CheckIndex(index))
                    taskList[index] = task;
            else
                ok = false;
            return ok;
        }
        /// <summary>
        /// Delete an object in the tasklist in a given position
        /// </summary>
        /// <param name="index">The object deleted at index position</param>
        /// <returns>true if the task is added successfully, false otherwise</returns>
        public bool DeleteTaskAt(int index)
        {
            bool ok = false;

            if ((index >= 0) && (index < taskList.Count))
            {
                taskList.RemoveAt(index);
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// This method prepares an array of strings containing
        /// information about the tasks in taskList
        /// </summary>
        /// <returns>array of strings</returns>
        public string[] GetInfoStringsList()
        {
            //create a local array of the string element with a capacity = num
            //elements in the tasklist
            string[] infoStrings = new string[taskList.Count];
            for (int i = 0; i < infoStrings.Length; i++)
            {
                infoStrings[i] = taskList[i].ToString();                
            }
            return infoStrings;
        }
        /// <summary>
        /// FileManager is a class that handles the saving and reading data
        /// to and from a text file. Send the tasklist from which data is read and saved
        /// to the file fileName.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }
        /// <summary>
        /// Send the tasklist object declared in above to which data from the filename is saved.
        /// As tasklist is an object it will have the changes made in the FileManager when the
        /// method ReadTaskListFrFile returns.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.ReadTaskListFrFile(taskList, fileName);
        }
    }    
}
