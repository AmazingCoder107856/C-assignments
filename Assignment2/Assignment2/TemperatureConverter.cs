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
    class TemperatureConverter 
    { 
        /// <summary>
        /// Method that reads user input and acts upon it.
        /// </summary>
        public void Start() //method
        {
            Console.WriteLine("Fahrenheit and Celsius Converter"); //title     
                        
            DisplayMenu(); // method that show the menu             
        }            
        private void DisplayMenu() //method that display the menu
        {
            //variables
            int choice = -1; // invalid option
            bool goodNum = false;
            //temperature converter menu table for the user to see some options
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("**************TEMPERATURE CONVERTER MENU********************");
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("    from Celcius to Fahrenheit                    :  1");
            Console.WriteLine("    from Fahrenheit to Celcius                    :  2");
            Console.WriteLine("    Exit                                          :  0");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
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
                    char response = reply[0];//variable that store the first character the user entered
                    
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

                    case 1: // convertToFahrenheit(double celTemp)
                        ShowTableCelsiusToFahrenheit();
                        break;

                    case 2: // convertToCelcius(double ferTemp)
                        ShowTableFahrenheitToCelsius();
                        break;

                    default: //if the user entered other than 1, 2 or 0, then the message below will diplay
                        Console.WriteLine("You must enter 1 to convert to Fahrenheit or 2 to convert to Celcius or 0 to exit!");
                        Console.WriteLine(); //blankline
                        break; //it will ask again the user to enter a nuber 1, 2 or 0 or press enter
                }
            }
        }
        private void ShowTableCelsiusToFahrenheit() //method that will display if the user choose 1
        {
            //variables
            const int columns = 2; //show the results in columns

            const int max = 100; //max no. to be shown in the conversion table
            int p = 0;
            for (int i = 0; i <= max; i += 4) //index, interval by 4
            {
                double result = CelsiusToFahrenheit(i); //calculate
                Console.Write("{0,6:f2}\u00B0C = {1,6:f2}\u00B0F ", i, result); //display message in celsius degree converted to fahrenheit degree from 0-100

                p++;
                if ((p % columns == 0) && (p >= columns)) //create 2 columns
                    Console.WriteLine(); //blankline
            }
        }
        private void ShowTableFahrenheitToCelsius() //method that will display if the user choose 2
        {
            //variables
            const int columns = 2; //show the results in columns

            const int max = 100;//max no. to be shown in the conversion table
            int p = 0;
            for (int i = 0; i <= max; i += 4)//index, interval by 4
            {
                double result = FahrenheitToCelsius(i); //calculate
                Console.Write("{0,6:f2}\u00B0F = {1,6:f2}\u00B0C ", i, result); //display message in fahrenheit degree converted to celcius degree from 0-100 

                p++;
                if ((p % columns == 0) && (p >= columns)) //create 2 columns
                    Console.WriteLine(); //blankline
            }
        }
        /// </summary>
        /// <param name = "celsius">Degrees in Celsius to convert.</param name>
        /// F = 9/5*C+32
        /// <returns>Degrees in Fahrenheit.</returns>
        private double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
        double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32.0) * 5.0 / 9.0;
        }    
    }
}
