using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    public class PersonalInfoExample
    {
        public static void Run()
        {
            // Prints person's information and a sample order summary to the screen.
            int age = 22;
            string firstName = "Eren";
            string lastName = "KADIROGLU";
            string department = "Computer Engineering";
            int grade = 2;
            double gpa = 2.76;

            Console.WriteLine("Hello, I am " + firstName + " " + lastName + ".");
            Console.WriteLine("I am " + age + " years old.");
            Console.WriteLine("I am a " + grade + ". year student of " + department + ".");
            Console.WriteLine("Currently, I have a GPA of " + gpa + ".");
            Console.ReadKey();
        }
    }
}
