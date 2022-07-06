using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class RoomManager
    {
        //FIELDS        
        private List<Room> roomList;  //declare object of the collection              

        /// <summary>
        /// Default contsructor. It creates a new arrylist object.        
        /// </summary>
        public RoomManager()
        {
            roomList = new List<Room>();            
        }
        /// <summary>
        /// Returns the room object at the selected index of the rooms arrylist
        /// </summary>
        /// <param name="index">selectedindex by the user</param>
        /// <returns>room objects</returns>
        public Room GetRoom(int index)
        {
            if (CheckIndex(index))
                return roomList[index];
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

            if ((index >= 0) && (index < roomList.Count))
            {
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// Add a new object at the end of the roomList
        /// </summary>
        /// <param name="newRoom">The room object that is to be added</param>
        /// <returns>true if the room is added successfully, false otherwise</returns>
        public bool AddNewRoom(Room newRoom)
        {
            bool ok = true;

            if (newRoom != null)
                roomList.Add(newRoom);
            else
                ok = false;
            return ok;
        }
        /// <summary>
        /// Adds a new room to the roomlist using the value sent by the caller via the method parameters
        /// </summary>
        /// <param name="roomNum"></param>
        /// <param name="newTime"></param>
        /// <param name="cleaningStat"></param>
        /// <param name="roomP"></param>
        /// <param name="room"></param>
        /// <returns>true if the room is added successfully, false otherwise</returns>
        public bool AddNewRoom(string roomNum, DateTime newTime, string cleaningStat, string roomP, RoomType room)
        {
            bool ok = true;
            //create a new object with the above given values
            Room newRoom = new Room(roomNum, newTime, cleaningStat, roomP, room);
            if (newRoom != null)
                roomList.Add(newRoom);
            else
                ok = false;
            return ok;
        }
        /// <summary>
        /// Change an object in the roomlist in a given position with a new object.
        /// </summary>
        /// <param name="room">The object to replace an existing at index position</param>
        /// <param name="index">the position of the given position with a new object</param>
        /// <returns>true if the room is added successfully, false otherwise</returns>
        public bool ChangeRoomAt(Room room, int index)
        {
            bool ok = true;
            //check so that task is not null and index is not out of range
            if ((room != null) && CheckIndex(index))
                roomList[index] = room;
            else
                ok = false;
            return ok;
        }
        /// <summary>
        /// Delete an object in the roomlist in a given position
        /// </summary>
        /// <param name="index">The object deleted at index position</param>
        /// <returns>true if the room is added successfully, false otherwise</returns>
        public bool DeleteRoomAt(int index)
        {
            bool ok = false;

            if ((index >= 0) && (index < roomList.Count))
            {
                roomList.RemoveAt(index);
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// This method prepares an array of strings containing
        /// information about the rooms in roomList
        /// </summary>
        /// <returns>array of strings</returns>
        public string[] GetInfoRoomStringsList()
        {
            //create a local array of the string element with a capacity = num
            //elements in the customerlist
            string[] infoRoomStrings = new string[roomList.Count];
            for (int i = 0; i < infoRoomStrings.Length; i++)
            {
                infoRoomStrings[i] = roomList[i].ToString();
            }
            return infoRoomStrings;
        }        
        /// <summary>
        /// FileManager is a class that handles the saving and reading data
        /// to and from a text file. Send the roomlist from which data is read and saved
        /// to the file fileRoomName.
        /// </summary>
        /// <param name="fileRoomName"></param>
        /// <returns></returns>
        public bool WriteRoomDataToFile(string fileRoomName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveRoomListToFile(roomList, fileRoomName);
        }
        /// <summary>
        /// Send the roomlist object declared in above to which data from the filename is saved.
        /// As roomlist is an object it will have the changes made in the FileManager when the
        /// method ReadRoomListFrFile returns.
        /// </summary>
        /// <param name="fileRoomName"></param>
        /// <returns></returns>
        public bool ReadRoomDataFromFile(string fileRoomName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.ReadRoomListFrFile(roomList, fileRoomName);
        }
    }
}
