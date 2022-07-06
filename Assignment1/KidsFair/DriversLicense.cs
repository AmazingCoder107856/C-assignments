using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class DriversLicense
    {
        //base variables and datatype declaration
        private string fullName;
        private int age;
        private bool isQualified;
        private bool isMale;



        public void Testdrive()
        {
            Console.WriteLine(); //Blank line
            Console.WriteLine("Welcome to Palm's Driving Company!"); //Greetings
            Console.WriteLine(); // blankline

            Console.WriteLine("Please enter your complete name: ");
            string fullName = Console.ReadLine();
            var names = fullName.Split(' ');
            string firstname = names[0];
            string lastname = names[1];

            Console.WriteLine("Please eneter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            // conditions
            if (age >= 18)
            {
                isQualified = true;
            }
            else
            {
                isQualified = false;
            }

            Console.WriteLine("Please enter your gender (M/F): ");
            string input = Console.ReadLine();
            input = input.Trim(); //delete leading space
            char response = char.Parse(input);

            //conditions
            if ((response == 'm') || (response == 'M'))
            {
                isMale = true;
            }

            else
            {
                isMale = false;
            }

            PrintDriversLicenseInfo();
        }

        public void PrintDriversLicenseInfo()
        {
            //Display student's info
            Console.WriteLine(); //blankline
            Console.WriteLine(); //blankline
            Console.WriteLine("Student's Information:");
            Console.WriteLine("Student's name: " + fullName);
            Console.WriteLine("Student's age: " + age);
            
            //conditions
            if (isMale)
            {
                Console.WriteLine("Student's gender: Male");
            }
            else
            {
                Console.WriteLine("Pet's gender: Female");
            }

            if (isQualified)
            {
                Console.WriteLine("You are qualified to take the Driver's License exam.");
                Console.WriteLine(); //blankline
                Console.WriteLine("GOODLUCK!");
            }
            else
            {
                Console.WriteLine("Sorry, you don't qualify to take the Driver's License exam.");
            }

            Console.ReadKey(); //wait before closing
        }
    }
}
