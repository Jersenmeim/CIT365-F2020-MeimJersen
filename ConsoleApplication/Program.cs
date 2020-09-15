using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jersen Meim";
            string location = "Philippines";
            DateTime dateTime = DateTime.Today;


            // Name and location
            Console.WriteLine("My name is " + name + ", and I am from " + location);

            // Date without the current time
            Console.WriteLine("Date Today: " + dateTime.ToString("dd/MM/yyyy"));

            // Number of days until Christmas this year
            DateTime date2 = new DateTime(2020, 12, 25);
            TimeSpan interval = date2 - dateTime;
            Console.WriteLine("Days until christmas in this year: " + interval.ToString("dd"));

            //Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet"); 
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}