using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDeliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concept 1 - Declaring Variables
            int cost;
            int discount;
            cost = 50;
            discount = 2;
            Console.WriteLine("The Cost After the Discount Has Been Applied is: " + (cost - discount));
            Console.WriteLine("Press Enter to Continue . . .");
            Console.ReadLine();

            // Concept 2 - Creating Arrays
            // Concept 3 - For Loops
            int[] prices = new int[10];
            Console.WriteLine("The prices of all of the items are as follows: ");
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = i * 2;
                Console.WriteLine(prices[i].ToString());
            }
            Console.WriteLine("Press Enter to Continue . . .");
            Console.ReadLine();

            // Concept 4 - Working with DateTime
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is:  " + today.ToLongDateString());
            Console.WriteLine("7 Days from Now is:  " + today.AddDays(7).ToLongDateString());
            Console.WriteLine("Press Enter to Continue . . .");
            Console.ReadLine();

            // Concept 5 - If Statements
            Console.WriteLine("Please enter either 1 or 2 to continue . . .");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("You have selected option 1.");
            }
            else if (input == "2")
            {
                Console.WriteLine("You have selected option 2.");
            }

            // Concept 6 - Gracefully Handling Exceptions
            int doubleInput;
            try
            {
                doubleInput = Int32.Parse(input) * 2;
            }
            catch (FormatException e)
            {
                Console.WriteLine("ERROR:  " + e.Message);
                Console.WriteLine("How rude of you to try and break my simple minded program.");
                doubleInput = 0;
            }
            Console.WriteLine("Your result is: " + doubleInput.ToString());
            Console.WriteLine("Press Enter to Continue . . .");
            Console.ReadLine();

            // Concept 7 - Enumerations and the Switch Statement
            Console.WriteLine("Try to guess my favorite food.");
            string inputFood = Console.ReadLine();
            switch(inputFood.ToUpper())
            {
                case "PIZZA":
                    Console.WriteLine("Definitely one of my favorite foods!");
                    break;
                case "PASTA":
                    Console.WriteLine("Definitely one of my favorite foods!");
                    break;
                case "CHOCOLATE":
                    Console.WriteLine("Don't even joke about it.");
                    break;
                default:
                    Console.WriteLine("Better luck next time.");
                    break;
            }
            Console.WriteLine("Thanks for trying out my first C# program!  Press enter to exit.  Goodbye!");
            Console.ReadLine();
        }
    }
}
