// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MainProgram 
    {
        static void Main(string[] args)
        {
            Console.Title = "Selection and iteration in C#";
            SelectionAndIteration selection = new SelectionAndIteration();
            selection.Start();

            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();

            Console.Title = "Fahrenheit and Celsius Converter";
            TemperatureConverter converter = new TemperatureConverter();
            converter.Start();

            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();

            Console.Title = "Working Schedule";
            WorkingSchedule schedule = new WorkingSchedule();
            schedule.Start();

            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();

        }
    }
}

