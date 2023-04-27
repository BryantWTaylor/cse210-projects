using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 101);
        int convGuess = -1;
        Console.WriteLine("Welcome to the Number Guessing Game!");
        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            convGuess = int.Parse(userGuess);
            if (mNumber == convGuess) 
            {
                Console.WriteLine("You guessed it!");
            }
            else if (convGuess > mNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        } while (convGuess != mNumber);    
    }
}