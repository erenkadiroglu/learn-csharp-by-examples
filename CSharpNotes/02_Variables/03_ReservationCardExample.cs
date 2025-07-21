using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class ReservationCardExample
    {
        public static void Run()
        {
            // Prints the reservation card on the screen.
            string customerName = "Eren";
            string customerSurname = "KADIROGLU";
            int customerAge = 22;
            string customerCity = "Eskisehir";
            string customerEmail = "erenkdroglu@gmail.com";
            string customerPhone = "+90 545 844 8676";

            Console.WriteLine("**** Reservation Card ****");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Customer : " + customerName + " " + customerSurname);
            Console.WriteLine("Age : " + customerAge);
            Console.WriteLine("City : " + customerCity);
            Console.WriteLine("E-mail : " + customerEmail);
            Console.WriteLine("Phone : " + customerPhone);
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
