using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_Activity_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Favorite Color");
            Console.WriteLine("Enter Favorite Food");
            Console.WriteLine("Enter Favorite number");

            string color = Console.ReadLine();
            string food = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDetailsEntered:");
            Console.WriteLine("Favorite Color :" + color);
            Console.WriteLine("Favorite Food :" + food);
            Console.WriteLine("Favorite Number :" + number);
        }
    }
}
