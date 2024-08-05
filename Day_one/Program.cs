using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1: Calculate distance between two points");
                Console.WriteLine("2: Perform fraction addition");
                Console.WriteLine("0: Exit");

                string choice = Console.ReadLine();

                if (choice == "0") break;

                switch (choice)
                {
                    case "1":
                        // Calculate distance between two points
                        _3DPoint point1 = _3DPoint.GetPointFromUser("Point 1");
                        _3DPoint point2 = _3DPoint.GetPointFromUser("Point 2");

                        point1.Display();
                        point2.Display();

                        double distance = point2.CalcDistance(point1);
                        Console.WriteLine($"The distance between the two points is {distance} units.");
                        break;

                    case "2":
                        // Perform fraction addition
                        Fraction fraction1 = new Fraction();
                        Fraction fraction2 = new Fraction();

                        Console.WriteLine("Enter the numerator for the first fraction:");
                        double nominator1 = double.Parse(Console.ReadLine());
                        if (nominator1 == 0) break;
                        Console.WriteLine("Enter the denominator for the first fraction:");
                        double denominator1 = double.Parse(Console.ReadLine());
                        fraction1.Nominator = nominator1;
                        fraction1.denominator = denominator1;

                        Console.WriteLine("Enter the numerator for the second fraction:");
                        double nominator2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the denominator for the second fraction:");
                        double denominator2 = double.Parse(Console.ReadLine());
                        fraction2.Nominator = nominator2;
                        fraction2.denominator = denominator2;

                        fraction1.Display();
                        fraction2.Display();

                        double result = fraction1.Add(fraction1, fraction2);
                        Console.WriteLine($"Result of adding the two fractions: {result}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 0.");
                        break;
                }
            }
        }
    }
}