using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__9
{
    class Circle
    {
        public double radius;
        public double diameter;
        public double circumference;
        public double area;


        public Circle(double radius)
        {
            diameter = 0;
            circumference = 0;
            area = 0;
        }

        public static double getCircumference(double diameter)
        {
            double circumference = Math.PI * (diameter);

            return circumference;
        }

        public static string getFormattedCircumference(double circumference)
        {

            string CircForm = circumference.ToString("0.##");

            return CircForm;
        }

        public static double getArea(double radius)
        {
            double area = Math.PI * (Math.Pow(radius, 2));

            return area;
        }

        public static string getFormattedArea(double area)
        {

            string areaForm = area.ToString("0.##");

            return areaForm;
        }
    }
}