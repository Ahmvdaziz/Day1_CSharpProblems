using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_one
{
    internal class Fraction
    {
        public double Nominator { get; set; }
        private double Denominator;
        public double denominator
        {
            set
            {
                if (value <= 0)
                {
                    Denominator = 1;
                    Console.WriteLine("Invalid number. Denominator must be one or more.");
                }
                else
                {
                    Denominator = value;
                }
            }
            get
            {
                return Denominator;
            }
        }
        public void Display()
        {
            Console.WriteLine($"Denominator={Denominator}, Nominator={Nominator}");
        }
        public double Add(Fraction f1, Fraction f2)
        {
            double res = 0, re1;
            res = f1.Nominator * f2.Denominator + f2.Nominator * f1.Denominator;
            re1 = f1.Denominator * f2.Denominator;
            return res / re1;
        }
    }
}
