using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 
{
    class Pet
    {
        //base variables and datatype declaration
        private string ownerName;
        private string petName; //name of the pet
        private int petAge; // age of the pet
        private bool isFemale; // true if female, false otherwise

        public void Start()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Welcome to Pet Day at school!"); //Greeting phrase
            Console.WriteLine(); //blankline

            ReadAndSavePetData(); //method to input pet's data
            
        }

        public void ReadAndSavePetData() 
        {
            //Read a line of text
            Console.Write("Please input your name: ");
            ownerName = Console.ReadLine();

            Console.Write("What is the name of your pet? ");
            petName = Console.ReadLine();

            //Read a whole number...converting string to integers
            Console.Write("What is " + petName + "'s age? ");
            petAge = Convert.ToInt32(Console.ReadLine());

            //Reading a logical value (y/n)
            Console.Write("Is " + petName + " a female, (y/n)? ");
            string userInput = Console.ReadLine();
            userInput = userInput.Trim(); //delete leading space
            char response = userInput[0];

            //conditions
            if ((response == 'y') || (response == 'Y'))
            {
                isFemale = true;
                Console.WriteLine(); //blankline
                Console.WriteLine(); //blankline
                Console.WriteLine("Your pet's details:"); //print pet's info
                Console.WriteLine("Pet's name: " + petName);
                Console.WriteLine("Pet's age: " + petAge);
                Console.WriteLine("Pet's gender: Female");
                Console.WriteLine(petName + ", you're such an adorable girl!");
                Console.WriteLine(); //blankline
                Console.WriteLine("THANK YOU, " + ownerName + ". " + petName + " is now registered!");
                Console.WriteLine(); //blankline
                Console.WriteLine();
            }
            else if ((response == 'n') || (response == 'N'))
            {
                isFemale = false;
                Console.WriteLine(); //blankline
                Console.WriteLine(); //blankline
                Console.WriteLine("Your pet's details:"); //print pet's info
                Console.WriteLine("Pet's name: " + petName);
                Console.WriteLine("Pet's age: " + petAge);
                Console.WriteLine("Pet's gender: Male");
                Console.WriteLine(petName + ", you're such a handsome boy!");
                Console.WriteLine(); //blankline
                Console.WriteLine("THANK YOU, " + ownerName + ". " + petName + " is now registered!");
                Console.WriteLine(); //blankline
                Console.WriteLine();
            }
            else
            { 
                isFemale = false;
                Console.WriteLine("Invalid entry");
            }

            Console.ReadKey(); //wait before closing
        }
    }
}
