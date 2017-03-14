using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            int age = 22;
            Console.WriteLine("My age is {0}.", age);

            //Problem 2
            int MAX_SCORE = 100;
            int score = 48;
            float percent = ((float)score / (float)MAX_SCORE) * 100;
            Console.WriteLine("The percentage of {0} and {1} is {2}%", score, MAX_SCORE, percent);

            Console.ReadKey();

        }
    }
}
