using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class GroceryShoppingExample
    {
        public static void Run()
        {
            // Example of printing grocery shopping and shopping receipt on screen
            double applePrice = 3.50;
            double bananaPrice = 5.25;
            double orangePrice = 4.75;
            double grapePrice = 6.00;
            int appleCount = 4;
            int bananaCount = 3;
            int orangeCount = 5;
            int grapeCount = 1;
            double totalApplePrice = applePrice * appleCount;
            double totalBananaPrice = bananaPrice * bananaCount;
            double totalOrangePrice = orangePrice * orangeCount;
            double totalGrapePrice = grapePrice * grapeCount;
            double totalPrice = totalApplePrice + totalBananaPrice + totalOrangePrice + totalGrapePrice;

            Console.Write("<<< Grocery Shopping Summary >>>\n");
            Console.WriteLine("================================\n");
            Console.WriteLine("Price per apple : " + applePrice + " TRY");
            Console.WriteLine("Price per banana : " + bananaPrice + " TRY");
            Console.WriteLine("Price per orange : " + orangePrice + " TRY");
            Console.WriteLine("Price per grape : " + grapePrice + " TRY");

            Console.WriteLine("\nQuantity of apples : " + appleCount + " pcs --- Total: " + totalApplePrice + " TRY");
            Console.WriteLine("Quantity of bananas : " + bananaCount + " pcs --- Total: " + totalBananaPrice + " TRY");
            Console.WriteLine("Quantity of oranges : " + orangeCount + " pcs --- Total: " + totalOrangePrice + " TRY");
            Console.WriteLine("Quantity of grapes : " + grapeCount + " pcs --- Total: " + totalGrapePrice + " TRY");

            Console.WriteLine("\n-------------------------------------------------");
            Console.WriteLine("Total price of the shopping : " + totalPrice + " TRY");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\nHave a good day :)");
        }
    }
}
