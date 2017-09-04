using System;

namespace Comp5202_problem2_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           //Start the program with Clear();
           Console.Clear();
           
                   

            Console.WriteLine("================================================================================================");
            Console.WriteLine("This program will display the division tables of numbers less than a 100 based on a number input");
            Console.WriteLine("================================================================================================");
            Console.WriteLine("Please type in a number less than 100");
            int input = int.Parse(Console.ReadLine());

            
            {
             
             Console.WriteLine($"{input} / 12 = {input/12}");
             
            }
            while(input < 100)
            


           //End the program with blank line and instructions
           Console.ResetColor();
           Console.WriteLine();
           Console.WriteLine("Press <Enter> to quit the program");
           Console.ReadKey();
           
        }
    }
}
