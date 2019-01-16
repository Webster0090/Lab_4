using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            int squared, cubed;

            Console.WriteLine("Learn your squares and cubes!");

            do
            {
                Console.Write("Please enter an integer: ");
                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("Number   Squarued   Cubed");
                Console.WriteLine("=====    ======     =====");
                for (int i = 1; i <= input; i++)
                {
                    squared = i * i;
                    cubed = i * i * i;
                    Console.WriteLine("  {0}         {1}         {2}   ", i, squared, cubed);

                }
                Console.Write("Would you like to continue, y/n? ");
                response = Console.ReadLine().ToLower();
            }
            while (response == "y");
            if (response == "n")
            {
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
            }
        }
    }
}
