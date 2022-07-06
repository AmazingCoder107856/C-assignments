using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// Contructor syntax:
    /// (1) It has the same name as the class and
    /// (2) It has a return type.
    /// The constructor is executed (runs) automatically every time an object of this class is being created med new.
    /// </summary>
    class WorkingSchedule
    {
        /// <summary>
        /// Method that reads user input and acts upon it.
        /// </summary>
        public void Start() //method
        {
            Console.WriteLine("Working Schedule"); //title     

            DisplayMenu(); // method that show the menu
                           
        }
        private void DisplayMenu() //method that display the menu
        {
            //variables
            int choice = -1; // invalid option
            bool goodNum = false;
            //Working schedule menu table for the user to see some options
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("               WORKING SCHEDULE MENU                        ");
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("         1 Show a list of the weekends to work              ");
            Console.WriteLine("         2 Show a list of the nights to work                ");
            Console.WriteLine("         0 Exit                                             ");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();

            while (choice != 0) //condition as long as user will not enter 0
            {
                Console.WriteLine(); //blankline
                Console.Write("YOUR CHOICE: "); //asking the user to enter a number of his choice
                string strInput = Console.ReadLine(); //variable that store the user's input
                int Length = strInput.Length; //variable that store the no. of characters the user entered

                if (Length == 0) //condition if the user input nothing and just press any key
                {
                    Console.Write("Are you sure you want to exit, y/n?: "); //message that will appear after the user pressed enter
                    string reply = Console.ReadLine(); //variable that store the user entered
                    reply = reply.Trim(); //delete leading and trailing spaces
                    Length = reply.Length; //variable that store the no. of characters the user entered
                    
                    if (Length == 0) //condition if the user just press any key other than y/n
                    {
                        Console.WriteLine("Invalid entry."); //message that will display telling the user that it's invalid
                        continue; //it ask again the user to choose a no. 
                    }
                    char response = reply[0]; //variable that store the first character the user entered

                    if ((response == 'y') || (response == 'Y')) //if the user entered y/Y, the program terminates and press enter to continue to the next
                    {
                        goodNum = true;
                        Console.WriteLine("Thank you for your time."); //display message after pressing y/Y
                        return;
                    }
                    if ((response == 'n') || (response == 'N')) //if the user entered n/N, it will go back to ask the user to choose a number
                    {
                        goodNum = false;
                        Console.WriteLine("Welcome back!"); //display message after pressing n/N
                        continue;
                    }
                }
                else //condition if the user input other than numbers.
                {
                    if (!int.TryParse(strInput, out choice)) //user inputed not a no.
                    {
                        //display message to the user that only numbers are allowed
                        Console.WriteLine(">> Only numbers are allowed. {0} is not a number. Please try again!", strInput);
                        continue;
                    }
                }
                choice = int.Parse(strInput); // user's input converted from string to integer


                switch (choice)
                {
                    case 0: // do nothing
                        Console.WriteLine();
                        break; // exit switch

                    case 1: // show the table of the list of weekends of work
                        ShowTableListWeekendsWork();
                        break;

                    case 2: // show the table of the list of nights of work
                        ShowTableListNightsWork();
                        break;

                    default: //if the user entered other than 1, 2 or 0, then the message below will diplay
                        Console.WriteLine("You must enter 1 to show list of the weekends to work or \n2 to show list of the nights to work or \n0 to exit!");
                        Console.WriteLine(); //blankline
                        break; //it will ask again the user to enter a nuber 1, 2 or 0 or press enter
                }
            }
        }
        private void ShowTableListWeekendsWork() //method that will display if the user choose 1
        {
            //variables
            const int columns = 4; //show the results in columns            
            var numberOfWeeksInYear = 51; ; //no. of weeks in a year to be shown in the conversion table
                                            //I used 51 weeks instead of 52 because the fisrt week is not needed for he will start working on the weekend of second week
            
            for (var i = 0; i < numberOfWeeksInYear; i+=3) //index interval 3
            {
                int num = i + 2;                

                if ((num % columns == 1) && (num >= columns))
                {
                    Console.WriteLine("Week" + "{0} ", num);
                }
                else
                {
                    Console.WriteLine("Week" + "{0} ", num);
                }
            }           
        }
        private void ShowTableListNightsWork() //method that will display if the user choose 2
        {
            //variables
            const int columns = 4; //show the results in columns            
            const int numberOfWeeksInYear = 52; ; //no. of weeks in a year to be shown in the conversion table
            
            for (int i = 0; i < numberOfWeeksInYear; i += 4) //index interval 4
            {
                int num = i + 1;
                
                if ((num % columns == 1) && (num >= columns))
                {
                    Console.WriteLine("Week" + "{0} ", num);
                }
                else
                {
                    Console.WriteLine("Week" + "{0} ", num);
                }                
            }
        }
    }
}
