using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Repeats until the user wants to exit
            {
                Console.Clear();
                Console.WriteLine("=== EXAMPLES MENU ===\n");
                Console.WriteLine("1 - Variable Definition");
                Console.WriteLine("2 - Personal Info Example");
                Console.WriteLine("3 - Reservation Card Example");
                Console.WriteLine("4 - Order Summary Example");
                Console.WriteLine("5 - Grocery Shopping Example");
                Console.WriteLine("6 - Area Calculation Example");
                Console.WriteLine("0 - Exit");
                Console.Write("\nSelect an option (0-6): ");

                string choice = Console.ReadLine(); // Reads a line of text input from the user and stores it in the variable 'choice'
                Console.Clear(); // Clears the console screen to remove all previous output

                switch (choice)
                {
                    case "1":
                        VariableDefinitionExample.Run();
                        break;
                    case "2":
                        PersonalInfoExample.Run();
                        break;
                    case "3":
                        ReservationCardExample.Run();
                        break;
                    case "4":
                        OrderSummaryExample.Run();
                        break;
                    case "5":
                        GroceryShoppingExample.Run();
                        break;
                    case "6":
                        AreaCalculationExample.Run();
                        break;
                    case "0":
                        Console.WriteLine("Exiting program...\n\n");
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Please choose between 0-6.");
                        break;
                }

                Console.WriteLine("\n\n\n\nPress any key to return to menu...");
                Console.ReadKey(); //Prevents the program from ending immediately.
            }
        }
    }
}