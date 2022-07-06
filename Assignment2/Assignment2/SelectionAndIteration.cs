using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SelectionAndIteration
    {
        /// <summary>
        /// Constructor - the sequence of lines coded inside the constructor
        /// will be called automatically when an object of this class is
        /// created using the keyword "new" as:
        /// SelectionAndIteration selection = new SelectionAndIteration();
        /// </summary>

        public void Start()
        {
            Console.WriteLine(); // blankline
            Console.WriteLine("Hello, my name is Gloria Palm. I am a student of Programming in C# Spring 2022 semester!");
            Console.WriteLine(); // blankline

            ShowStringLength();//call method to read a text, calculate and display no. of chars.
            MakeMyDay(); //call method to read a number 1 to 7 and display the corresponding name of the day (1 = Monday, 7 = Sunday).
            SumNumbers(); //call method to sum up all values between two integer numbers, calculate sum and display it.
        }

        private void ShowStringLength() //to show the length of the text
        {
            //variables
            string text = string.Empty; //same as ""
            bool done = false;
            //display text 
            Console.WriteLine("Let me calculate the length of the text/phrase for you!");

            do
            {
                //let the user to write a text/phrase
                Console.WriteLine("Give me a text/phrase of any length, or press Enter to exit!\n");
                text = Console.ReadLine();// waiting for user to write text/phrase

                int length = text.Length; //variable for storing text length

                if (length == 0) //condition if user input nothing or just press enter, program terminates
                {
                    done = true;
                    Console.WriteLine("Ok.You pressed Enter. Hope to see you again!"); //message that will appear after the user presses enter
                }
                else //condition if the user write something, the output will be the text the user wrote but in all capital letters
                {
                    Console.WriteLine();//blankline
                    text = text.ToUpper(); //to convert the text to all capital letters
                    Console.WriteLine("The text you input: \"" + text + "\""); //the text inputed converted into capital letters
                    text = text.Substring(length); //variable that convert string text length to integers
                    Console.WriteLine("Number of characters: " + length); //output that display the no. of characters of the text or phrase.
                    Console.WriteLine(); //blankline
                }
            } while (!done); //not done and just pressed enter then it will continue to the next
            Console.WriteLine("Press any key to continue!"); //message to press enter to continue
            Console.ReadLine();//blankline
        }

        private void MakeMyDay() //method that will display daily horoscope
        {
            //variable
            int input = -1; //invalid option
            string fortune = string.Empty; //same as ""
            bool goodNum = false;
            
            Console.WriteLine(); //blankline
            Console.WriteLine("Welcome to Make My Daily Horoscope!"); //display message welcoming the user
            Console.WriteLine(); //blankline
            Console.WriteLine("Let me predict how your day will be like."); //display message what the user can expect to happen
            
            while(input!=0) //true as long as the user will not input 0
            {
                //asking the user to enter no. between 1-7 or just press enter to terminate the program
                Console.Write("Choose a number between 1 and 7, or press Enter exit: ");
                string userInput = Console.ReadLine(); //variable that store the users input
                int Length = userInput.Length; //variable that store the length/no. of characters the user entered
                
                if (Length == 0) //condition if the user input nothing and just pressed enter to exit
                {
                    goodNum = true;
                    Console.WriteLine("Thank you for your time.");// display message to the user
                    Console.WriteLine("Press any key to continue!");//press any key to continue to the next
                    Console.ReadLine(); //waiting for the user to press any key
                    return;                    
                }                
                else //condition if the user input other than numbers.
                {
                    if (!int.TryParse(userInput, out input)) //user inputed not a no.
                    {
                        //display message to the user that only numbers are allowed
                        Console.WriteLine(">> Only numbers are allowed. {0} is not a number.", userInput);
                        Console.WriteLine("Press any key to continue!"); //ask the user to press any key to continue to the next
                        Console.ReadLine(); //waiting for the user to press any key
                        return;
                    }                    
                }
                
                switch (input = int.Parse(userInput)) //user's input converted from string to integer
                {
                    case 0: //user input 0 and a message display and ask the user to press any key to continue to the next
                        Console.WriteLine("Sad you Exit. Press any key to continue!");
                        Console.ReadLine(); //waiting for the user to press any key
                        return;
                    case 1: //user input 1 and corresponds to a day Monday and display the message below
                        fortune = "Monday: A good day for you to think about your ambitions.";
                        break;
                    case 2: //user input 2 and corresponds to a day Tuesday and display the message below
                        fortune = "Tuesday: You might be feeling a bit hesitant than usual when it comes to making decisions.";
                        break;
                    case 3: //user input 3 and corresponds to a day Wednesday and display the message below
                        fortune = "Wednesday: You may feel that you have to defend your motives today.";
                        break;
                    case 4: //user input 4 and corresponds to a day Thursday and display the message below
                        fortune = "Thursday: There is a good person in your life who keeps coming to mind again and again.";
                        break;
                    case 5: //user input 5 and corresponds to a day Friday and display the message below
                        fortune = "Friday: Your usual outgoing and often radical nature may be far more conservative today.";
                        break;
                    case 6: //user input 6 and corresponds to a day Saturday and display the message below
                        fortune = "Saturday: Today is an excellent day to set some new goals.";
                        break;
                    case 7://user input 7 and corresponds to a day Sunday and display the message below
                        fortune = "Sunday: Another person will probably bring you much comfort today.";
                        break;
                    default: //user input a number not between 1-7 and a message below will appear 
                        Console.WriteLine("Invalid number. Please try again!");                        
                        Console.ReadLine(); //waiting for the the user to press any key to continue to enter another number betwee 1-7 or exit
                        continue;
                }
                Console.WriteLine(); //blankline
                Console.WriteLine(fortune); //display the message of the chosen number
                Console.WriteLine(); //blankline
            }            
            Console.ReadLine(); //waiting for the user to press enter or any key to continue to the next
        }

        private void SumNumbers() //method that calculate the sum of numbers between two numbers
        {
            //variables
            int startNum;
            int endNum;
            int input;
            bool done = false;

            Console.WriteLine(); //blankline
            Console.WriteLine("Let me calculate the sum of numbers between any two numbers!"); //diplay message to the user
            Console.WriteLine(); //blankline

            do
            {
                //asking the user to enter a number or press enter to exit
                Console.Write("Please enter a number, or press ENTER to exit: ");
                string userInput1 = Console.ReadLine(); //variable that store the users input
                int length = userInput1.Length; //variable that store the no. of characters the user entered
                
                if (length == 0) //if the user input nothing and just press enter then the program terminates
                {
                    done = true;
                    Console.WriteLine("Hope to see you again!"); //display message to the user after pressing exit
                    return;
                }
                else //condition if the user enter other than numbers
                {
                    if (!int.TryParse(userInput1, out input)) //convert the user input and if not an integer, the message below will appear
                    {
                        Console.WriteLine(">> Only numbers are allowed. {0} is not a number. Please try again!", userInput1);
                        continue; //it will ask the user again to enter a number or press enter to exit
                    }                    
                }
                //asking the user to enter another number or press enter to exit
                Console.Write("Please enter another number, greater than or lesser than the previous number, or press ENTER to exit: ");
                string userInput2 = Console.ReadLine(); //variable that store the users input
                length = userInput2.Length; //variable that store the no. of characters the user entered

                if (length == 0) //if the user input nothing and just press enter then the program terminates
                {
                    done = true;
                    Console.WriteLine("Hope to see you again!"); //display message to the user after pressing exit
                    return;                   
                }
                if (userInput2 == userInput1) //condition if the user input same number as the previous one
                {
                    Console.WriteLine(">> Invalid entry. Please try again."); //invalid message prompt up and ask the user to try again                  
                    Console.WriteLine(); //blankline
                    continue;
                }
                else //conditon if the user enter other than numbers
                {                    
                    if (!int.TryParse(userInput2, out input)) //variable that convert the users input to integers. if user input not numbers, the message below will pop up
                    {
                        Console.WriteLine(">> Only numbers are allowed. {0} is not a number. Please try again!", userInput2);
                        continue; //it will continue to ask the user to input a number
                    }                    
                }                
                //variables to calculate the sum of numbers between the two numbers from the user
                startNum = int.Parse(userInput1); endNum = int.Parse(userInput2);
                
                int min = Math.Min(startNum, endNum); //variable store the min of the two numbers the user entered
                int max = Math.Max(startNum, endNum); //variable store the max of the two numbers the user entered
                int sumNum = 0; //variable to store the sum of the numbers between two numbers the user entered

                for (int i = min; i <= max; i++) //index 
                {
                    sumNum = sumNum + i; //to calculate the sum of all numbers
                }
                //display the result showing the minimum and maximum of the two numbers and the result
                Console.WriteLine("\r\nThe sum of numbers between " + min + " and " + max + " is: " + sumNum.ToString());
                Console.WriteLine(); //blankline
            } while (!done); //if the conditions are not done, the program terminates and ask the user to press enter to continue to the next
            return;
        } 
    }
}
