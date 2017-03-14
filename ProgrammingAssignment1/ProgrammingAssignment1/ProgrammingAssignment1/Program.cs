using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            double point1X, point1Y, point2X, point2Y, changeX, changeY, distance, angle;
            Console.WriteLine("Welcome to this program. You will input two points, each with 1 X value and 1 Y value, on a cartesian plane.");

            //read in all the values from the user
            Console.WriteLine("Enter an X value for point 1.");
            point1X = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an Y value for point 1.");
            point1Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an X value for point 2.");
            point2X = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an Y value for point 2.");
            point2Y = double.Parse(Console.ReadLine());

            //take the absolute value of the difference, to be used to calculating distance and angle
            changeX = Math.Abs(point2X - point1X);
            changeY= Math.Abs(point2Y - point1Y);

            //distance calculation
            distance = Math.Sqrt(Math.Pow(changeX, 2) + Math.Pow(changeY, 2));
            Console.WriteLine("{0:F3}", distance);

            //angle calculation
            angle = Math.Atan2(changeY, changeX) * 180 / Math.PI;
            Console.WriteLine("{0:F3}", angle);

            Console.ReadKey();
            
        }
    }
}
