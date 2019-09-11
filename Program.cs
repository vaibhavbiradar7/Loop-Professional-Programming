using System;

namespace Loop_Professional_Programming
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many years of experience do you have in professional programming?");

            try
            {
                int years = int.Parse(Console.ReadLine());
                for (int i = 0; i < years; i++)
                {
                    Console.WriteLine("You have " + i + " years of exprience");
                }
                Console.WriteLine("Press any key to exit the program ...");

                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
        }
    }
}    