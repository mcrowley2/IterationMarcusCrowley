using System;

namespace IterationMarcusCrowley
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Integer between 2 and 10: ");
            int number;
            int i = 1;

            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Clear();
                Console.WriteLine("You must enter only a number");
            }

            if (number%2 == 1)
            {
                while(i <= number-1)
                {
                    Console.WriteLine("You entered an odd number");
                    i++;
                }
            }
            else
            {
                while(i <= number+1)
                {
                    Console.WriteLine("You entered an even number");
                    i++;
                }
            }
        }
    }
}
