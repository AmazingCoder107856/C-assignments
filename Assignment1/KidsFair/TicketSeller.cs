using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 
{
    class TicketSeller
    {
        //base variables and datatype declaration
        private string name;   // name of the ticket buyer
        private double price = 100;  // price of the ticket
        private int numOfAdults;  // number of adults
        private int numOfChildren; // number of children
        private double amountToPay; // total cost of the ticket
           

        public void Greeting() 
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to KIDS' FAIR 2022!"); // Greeting phrase
            Console.WriteLine("Ticket prices:"); //ticket prices (adult & child)
            Console.WriteLine("Adult - 100.00 $");
            Console.WriteLine("Child - 80.00 $");
            Console.WriteLine();
            Console.ReadLine();

            PrintTicketSellerInfo(); // method to print ticket info

        }

        public void PrintTicketSellerInfo()
        {
            //read a line of text
            Console.WriteLine("Please enter your name: "); 
            name = Console.ReadLine();

            //read a whole number...convert string to integers
            Console.WriteLine("Number of adults: ");
            numOfAdults = Convert.ToInt32(Console.ReadLine());

            //read a whole number...convert string to integers
            Console.WriteLine("Number of children: ");
            numOfChildren = Convert.ToInt32(Console.ReadLine());

            double price = 100.00; //ticket price for an adult
            double price1 = 80.00; //ticket price for a child

            Console.WriteLine(); //blankline
            Console.WriteLine("Your receipt for: "); //display no. of tickets and prices
            Console.WriteLine(); //blankline
            Console.WriteLine(numOfAdults + " adults @ " + price + " $ each");
            Console.WriteLine(numOfChildren + " children @ " + price1 + " $ each");
            Console.WriteLine("_______________________________");

            //claculate total amount to pay
            double amountToPay = (numOfAdults * price) + (numOfChildren * price1);
            Console.WriteLine("Total amount to pay: " + amountToPay + " $");
            Console.WriteLine("===============================");
           

            //thanking the buyer for purchasing
            Console.WriteLine(); //blankline
            Console.WriteLine("Thank you " + name + " for the purchase. Hope to see you again.");
            Console.WriteLine("If you have problems or questions concerning your purchase, please don't hesitate to contact us.");
            Console.WriteLine(); //blankline

            Console.ReadKey(); //wait before closing
        }

    }
}
