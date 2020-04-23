using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication {
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Gunther";
            string location = "Rexburg, ID";

            Console.WriteLine($"My name is: {name}");
            Console.WriteLine($"My location is: {location}");

            double width, height, woodLength, glassArea;
            Console.Write("Please enter a width in meters: ");
            string widthString, heightString;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter a height in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}