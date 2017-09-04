using System;

namespace Comp5202_problem2_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           //Start the program with Clear();
           Console.Clear();
           
            var counter = 100;
            var number = 0;
            int i= 0;

            Console.WriteLine("================================================================================");
            Console.WriteLine("This program will display the division tables of 1 to 12 based on a number input");
            Console.WriteLine("================================================================================");
            Console.WriteLine("Please type in a number less than 100");
            int input = int.Parse(Console.ReadLine());

            for(i = 0; i < counter; i++);
            {
             int a = i + 1;
             Console.WriteLine($"{a} / {12} = {a/12}");

            }
                Console.ReadLine();
           


           //End the program with blank line and instructions
           Console.ResetColor();
           Console.WriteLine();
           Console.WriteLine("Press <Enter> to quit the program");
           Console.ReadKey();
           
        }
    }
}
