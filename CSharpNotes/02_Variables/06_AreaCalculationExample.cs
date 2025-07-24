using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class AreaCalculationExample
    {
        public static void Run()
        {
            double edge1, edge2, radius, baseLength, height;
            double pi = 3.14;
            double areaOfRectangle;
            double areaOfCircle;
            double areaOfTriangle;
            double areaOfSquare;
            double areaOfParallelogram;

            Console.WriteLine("Select the geometric shape you want to calculate.");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1) Circle");
            Console.WriteLine("2) Triangle");
            Console.WriteLine("3) Rectangle");
            Console.WriteLine("4) Square");
            Console.WriteLine("5) Parallelogram");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Enter the number of the shape: ");
            int choice = int.Parse(Console.ReadLine()); //The string input is converted to a number using int.Parse()
            Console.WriteLine("\n\n");

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the radius of the circle: ");
                    radius = double.Parse(Console.ReadLine()); //The string input is converted to a decimal number using double.Parse().
                    areaOfCircle = pi * radius * radius;
                    Console.WriteLine("\n===================================================");
                    Console.WriteLine($"The area of the circle is: {areaOfCircle}");
                    Console.WriteLine("===================================================");
                    break;
                case 2:
                    Console.Write("Enter the base length of the triangle: ");
                    baseLength = double.Parse(Console.ReadLine());  
                    Console.Write("Enter the height of the triangle: ");
                    height = double.Parse(Console.ReadLine());
                    areaOfTriangle = baseLength * height / 2;
                    Console.WriteLine("\n===================================================");
                    Console.WriteLine($"The area of the triangle is: {areaOfTriangle}");
                    Console.WriteLine("===================================================");
                    break;
                case 3:
                    Console.Write("Enter the length of edge 1: ");
                    edge1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the length of edge 2: ");
                    edge2 = double.Parse(Console.ReadLine());
                    areaOfRectangle = edge1 * edge2;
                    Console.WriteLine("\n===================================================");
                    Console.WriteLine($"The area of the rectangle is: {areaOfRectangle}");
                    Console.WriteLine("===================================================");
                    break;
                case 4:
                    Console.Write("Enter the length of the edge of the square: ");
                    edge1 = double.Parse(Console.ReadLine());
                    areaOfSquare = edge1 * edge1;
                    Console.WriteLine("\n===================================================");
                    Console.WriteLine($"The area of the square is: {areaOfSquare}");
                    Console.WriteLine("===================================================");
                    break;
                case 5:
                    Console.Write("Enter the base length of the parallelogram: ");
                    baseLength = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height of the parallelogram: ");
                    height = double.Parse(Console.ReadLine());
                    areaOfParallelogram = baseLength * height;
                    Console.WriteLine("\n===================================================");
                    Console.WriteLine($"The area of the parallelogram is: {areaOfParallelogram}");
                    Console.WriteLine("===================================================");
                    break;
                case 0:
                    Console.WriteLine("Exiting program...\n\n");
                    return;
                default:
                    Console.WriteLine("Invalid selection. Please choose between 1-5.");
                    break;
            }
        }
    }
}
