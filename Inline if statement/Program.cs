using System;

namespace Inline_if_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // This writes the string on the console and jumps to the next line
            Console.WriteLine("Guess the right number and win a prize!!");
            // This writes the string on the console but doesn't jump to the next line
            Console.Write("Type a number from 1 to 10.  ");

            // This declares the variable userValue as a string, then
            // pauses the program to wait for user input
            string userValue = Console.ReadLine();
            // This line does 3 things
            // First it declares the variable message as a string
            // second it evaluates if the user typed an 8 is true or false
            // Lastly, the program assigns a string to the variable message based on whether 
            //  the previous expression is true or false
            string message = (userValue == "8") ? "YOU WON A BRAND NEW CAR!!" : "You lose.";

            // This writes the corresponding message in the console
            Console.WriteLine(message);
            // This pauses the program so the user can see the result
            Console.ReadLine();
        }
    }
}
