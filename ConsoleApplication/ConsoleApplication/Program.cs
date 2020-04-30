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
            string name;
            string location;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your location: ");
            location = Console.ReadLine();

            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"Your location is: {location}");

            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: {currentDate.ToShortDateString()}");

            //Christmas
            var christmas = new DateTime(currentDate.Year, 12, 25);
            Console.WriteLine($"Christmas is on: {christmas}");

            var timeSpan = christmas - currentDate;
            var daysUntilChristmas = timeSpan.Days;
            Console.WriteLine($"Days until Christmas: {daysUntilChristmas}");

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