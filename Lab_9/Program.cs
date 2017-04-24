using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__9
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Circle Tester");
            Console.Write("Enter Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double diameter = 2 * (radius);

            Circle cirCalc = new Circle(radius);

            Console.WriteLine("Circumference: " + Circle.getFormattedCircumference(Circle.getCircumference(diameter)));
            Console.WriteLine("Area: " + Circle.getFormattedArea(Circle.getArea(radius)));

            Console.WriteLine("Continue? (y/n)");



        }
    }
}
