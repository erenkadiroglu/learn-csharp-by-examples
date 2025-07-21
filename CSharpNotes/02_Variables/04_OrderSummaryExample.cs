using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class OrderSummaryExample
    {
        public static void Run()
        {
            // Prints order summary on the screen.            
            int hamburgerPrice = 300;
            int pizzaPrice = 400;
            int friesPrice = 100;
            int drinkPrice = 50;
            int saladPrice = 75;

            int hamburgerCount = 2;
            int pizzaCount = 1;
            int friesCount = 3;
            int drinkCount = 2;
            int saladCount = 1;

            int totalAmount = (hamburgerPrice * hamburgerCount) + (pizzaPrice * pizzaCount) + (friesPrice * friesCount) + (drinkPrice * drinkCount) + (saladPrice * saladCount);

            Console.WriteLine("***** MENU *****");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1- Hamburger: " + hamburgerPrice + " TRY");
            Console.WriteLine("2- Pizza: " + pizzaPrice + " TRY");
            Console.WriteLine("3- Fries: " + friesPrice + " TRY");
            Console.WriteLine("4- Drink: " + drinkPrice + " TRY");
            Console.WriteLine("5- Salad: " + saladPrice + " TRY");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("***** Orders *****");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Hamburger : " + hamburgerCount + " pcs --- Amount: " + (hamburgerPrice * hamburgerCount) + " TRY");
            Console.WriteLine("Pizza : " + pizzaCount + " pcs --- Amount: " + (pizzaPrice * pizzaCount) + " TRY");
            Console.WriteLine("Fries : " + friesCount + " pcs --- Amount: " + (friesPrice * friesCount) + " TRY");
            Console.WriteLine("Drink : " + drinkCount + " pcs --- Amount: " + (drinkPrice * drinkCount) + " TRY");
            Console.WriteLine("Salad : " + saladCount + " pcs --- Amount: " + (saladPrice * saladCount) + " TRY");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Total Amount: " + totalAmount + " TRY");
            Console.WriteLine("Enjoy your meal!");
            Console.ReadKey();
        }
    }
}
