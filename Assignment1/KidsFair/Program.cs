// See https://aka.ms/new-console-template for more information
namespace Assignment1 
{
    class Program 
    {
        static void Main (string [] args)
        {
            //creating new classes
            PrepareConsolesLook();
            Pet petobj = new Pet(); //creat object of class type Pet
            petobj.Start(); //Start object
            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            TicketSeller ticket = new TicketSeller();  //create object of class type TicketSeller
            ticket.Greeting(); //Greeting object
            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            Album album = new Album(); //create object of class type Album
            album.Favorites(); //Favorites object
            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            DriversLicense license = new DriversLicense(); //create object of class type DriversLicense
            license.Testdrive(); //Testdrive object
            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            WhoAmI aboutme = new WhoAmI(); //create object of class type WhoAmI
            aboutme.WhoMe(); //WhoMe object
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();

            Console.ReadKey();
        }

        static void PrepareConsolesLook()
        {
            //change the appearance of the window
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "KIDS FAIR";

        }
    }
}

