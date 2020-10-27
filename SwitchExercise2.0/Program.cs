using System;

namespace SwitchExercise2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 8;

            Console.WriteLine("Guess the favorite number. Hint: It is under 10");
            var userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
            {
                Console.WriteLine($"That number is too low!");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine($"That number is too high!");
            }
            else if (userGuess == favNumber)
            {
                Console.WriteLine($"Correct!!!");
            }
            else
            {
                Console.WriteLine($"Nevermind!");
            }
            

            

        

        }
    }
}
