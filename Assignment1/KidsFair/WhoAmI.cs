using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class WhoAmI
    {
        //base variables and datatype declaration
        private string fullName; //name of the user
        private int age; //age of the user
        private int birthyear; //year of birth of the user
        private string gender; //gender of the user
        private string nationality; //nationality of the user
        private string hobby; //hobby of the user

        public void WhoMe() //method object WhoMe
        {
            Console.Write("What is your fullname? "); //ask the user to input his name
            string fullName = Console.ReadLine();
            var names = fullName.Split(' ');
            string firstname = names[0];
            string lastname = names[1];

            Console.Write("How old are you? "); //ask the user to input his age
            string input = Console.ReadLine();
            int age = int.Parse(input);

            int birthyear = 2022 - age; //calculate to get the year of birth

            Console.Write("Please input your gender (Male/Female): "); //ask the user to input his gender
            gender = Console.ReadLine();

            Console.Write("What is your nationality? "); //ask the user to input his nationality
            nationality = Console.ReadLine();

            Console.Write("Please input your favorite hobby: "); //ask the user to input his hobby
            hobby = Console.ReadLine();

            //display user's info
            Console.WriteLine(); //blankline
            Console.WriteLine("Hello! Your firstname is " + firstname + " and your lastname is " + lastname + ". You are " + age + " years old and you were born in the year " + birthyear + ", " + gender + ", and a/an " + nationality + " citizen.");
            Console.WriteLine("You like to go " + hobby + " during your spare time.");
            Console.ReadLine(); //blankline

            Console.ReadKey();
        }
    }
}
