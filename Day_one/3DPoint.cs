using System;

namespace Day_one
{
    internal class _3DPoint
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public void Display()
        {
            Console.WriteLine($"x={x}, y={y}, z={z}");
        }

        public int CalcDistance(_3DPoint p1)
        {
            double partX = Math.Pow((x - p1.x), 2);
            double partY = Math.Pow((y - p1.y), 2);
            double partZ = Math.Pow((z - p1.z), 2);
            double distance = Math.Sqrt(partX + partY + partZ);
            return (int)distance;
        }

        public static _3DPoint GetPointFromUser(string pointName)
        {
            int x, y, z;
            Console.WriteLine($"Enter the coordinates for {pointName}:");

            x = GetValidatedCoordinate("x");
            y = GetValidatedCoordinate("y");
            z = GetValidatedCoordinate("z");

            return new _3DPoint { x = x, y = y, z = z };
        }

        private static int GetValidatedCoordinate(string coordinateName)
        {
            int value;
            bool isValid;

            do
            {
                Console.Write($"Enter {coordinateName} (between -1000 and 1000): ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out value) && value >= -1000 && value <= 1000;

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number between -1000 and 1000.");
                }
            } while (!isValid);

            return value;
        }
    }

}