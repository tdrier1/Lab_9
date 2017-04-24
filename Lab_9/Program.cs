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
            bool run = true;

            List<Circle> CircList = new List<Circle>();//create list to store circle data

            do
            {
                Console.WriteLine("Welcome to the Circle Tester");
                Console.WriteLine("++++++++++++++++++++++++++++");
                Console.Write("\nEnter Radius: ");
                double radius = GetDbl();//validates data being entered

                getCalculations(radius, CircList);//method used to call Circle class

                run=Continue(CircList);//method used to prompt user to continue

            } while (run == true);
        }

        public static double GetDbl()
        {
            double value;

            while (!double.TryParse(Console.ReadLine(), out value))
            {
                {
                    Console.Write("Try again! Please enter a number(can be decimals): ");
                }
            }
            return value;
        }//validation for input

        public static void getCalculations(double radius, List<Circle> CircList)
        {

            Circle cirCalc = new Circle(radius);//creates a new circle object

            CircList.Add(cirCalc);//adds circle obj to list

            Console.WriteLine("\nCircumference: " + CircList.Last().getFormattedCircumference());//prints cicle data to the console by calling methods in other class
            Console.WriteLine("\nArea: " + CircList.Last().getFormattedArea());
        }

        public static bool Continue(List<Circle> CircList)//standard loop to prompt user to continue with validation
        {
            string conf;
            bool check = true;
            bool run = true;

            Console.WriteLine("\n=============================");
            Console.WriteLine("\nWould you like to play again?");
            Console.Write("\nPlease Enter (y/n): ");

            do
            {
                conf = Console.ReadLine();
                var t = conf.ToLower();

                if (t != "y" || t != "n")
                {
                    Console.Write("\nPlease Enter (y/n): ");
                }
                if (t == "y")
                {
                    Console.Clear();
                    check = false;
                }
                if (t == "n")
                {
                    Console.Clear();
                    Console.WriteLine("You built {0} circles!", CircList.Count);
                    Console.WriteLine("\nThank you and goodbye.\n");

                    run = false;
                    check = false;
                }
            } while (check == true);

            return run;
        }
    }
}
