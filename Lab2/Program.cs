using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey response;

            do
            {
                Console.WriteLine("Hello! This program will obtain the area, perimeter, and volume of your given dimensions! Press <ENTER> to continue.");
                response = Console.ReadKey(false).Key;
                if (response != ConsoleKey.Enter)
                    Console.WriteLine();

                decimal length;
                Console.WriteLine("Please enter the length of the room.");
                length = Convert.ToDecimal(Console.ReadLine());

                decimal width;
                Console.WriteLine("Please enter the width of the room.");
                width = Convert.ToDecimal(Console.ReadLine());

                decimal height;
                Console.WriteLine("Please enter the height of room.");
                height = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Calculating area, perimeter, and volume... Press <ENTER> to continue.");
                response = Console.ReadKey(false).Key;
                if (response != ConsoleKey.Enter)
                    Console.WriteLine();

                decimal area = (length * width);
                Console.WriteLine($"The area of the room is: {area}");

                decimal perimeter = (2 * (length + width));
                Console.WriteLine($"The perimeter of the room is: {perimeter}");

                decimal volume = (area * height);
                Console.WriteLine($"The volume of the room is: {volume}");

                Console.WriteLine("Would you like to measure another room? (Enter 'y' to continue or 'n' to close)");
                response = Console.ReadKey().Key;
                if (response != ConsoleKey.Y && response == ConsoleKey.N)
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
            } while (response == ConsoleKey.Y && response != ConsoleKey.N);
        }
    }
}
