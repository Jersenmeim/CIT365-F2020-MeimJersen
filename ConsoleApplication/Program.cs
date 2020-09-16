using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            string name, location, next = "Press any key to continue";
            DateTime dateTime = DateTime.Today;

            //prompt to enter name and location
            Console.WriteLine("Hi what is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Where are you from: ");
            location = Console.ReadLine();

            // Name and location
            Console.WriteLine($"\nWelcome {name}, I heard that {location} is a great place, " +
                $"hope to visit your place someday.");
            Console.WriteLine($"{next}");
            Console.ReadKey();

            // Date without the current time
            Console.WriteLine($"\nThe Date Today: " + dateTime.ToString("dd/MM/yyyy"));
            Console.WriteLine($"{next}");
            Console.ReadKey();

            // Number of days until Christmas this year
            DateTime date2 = new DateTime(2020, 12, 25);
    
            TimeSpan interval = date2 - dateTime;
            Console.WriteLine($"\nHey! there are " + interval.ToString("dd") + " days until Christmas.");
            Console.WriteLine($"{next}");
            Console.ReadKey();


            //Add the program example from section 2.1 in the C# Programming Yellow Book by Rob Miles.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine($"\nWelcome to Glazer Calculator");
            Console.WriteLine($"\nEnter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine($"\nThe length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");
            Console.WriteLine($"\nPress enter to exit");
            Console.ReadKey();
        }
    }
}