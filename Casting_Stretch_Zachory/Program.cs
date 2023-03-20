using System;

namespace Casting_Stretch_Zachory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to enter their favorite whole number and assigns input to integer.
            Console.WriteLine("Please your favorite number. (whole numbers only)");
            int myFavNum = Convert.ToInt32(Console.ReadLine());

            // Prints favorite number to console.
            Console.WriteLine("Your favorite number is " + myFavNum);

            // Asks user a true/false question and assigns response to a boolean.
            Console.WriteLine("Do you like Halo? (Please enter 'true' or 'false')");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            // Prints the result of question asked.
            Console.WriteLine($"It is {isTrue} that you like Halo.");
        }
    }
}
