using System;

namespace IterationMarcusCrowley
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instruct user to enter integer between 2 and 10
            Console.Write("Enter Integer between 2 and 10: ");

            // Declare variables
            int number; // Variable declared for a number entered by user
            int i = 1; // Value set to start with

            // Create a loop to determine what will happen if user enters a non-numeric character
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Clear(); // Console clears after user enters non-numeric character
                Console.WriteLine("You must enter only a number"); // Remind the user that only a number can be entered
            }

            // Create if-else statement to determine whether the user entered an odd or even number
            if (number%2 == 1)
            {
                // Create loop for when an odd number is entered
                while(i <= number-1) // The number entered minus 1 will be how many times statement below displays
                {
                    Console.WriteLine("You entered an odd number"); // Statement for when user enters odd number
                    i++; // Keeps console from displaying statement infinite times
                }
            }
            else // if user enters an even number
            {
                while(i <= number+1) // The number entered plus 1 will be how many times statement below displays
                {
                    Console.WriteLine("You entered an even number"); // Statement for when user enters even number
                    i++; // Keeps console from displaying statement infinite times
                }
            }
        }
    }
}
