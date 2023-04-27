using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userResponse = Console.ReadLine();
            int userNumber = int.Parse(userResponse);
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int numberSquared = number * number;
            return numberSquared;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));

        // Probably cleaner option:
        // DisplayWelcome();
        // string userName = PromptUserName();
        // int userNumber = PromptUserNumber();

        // int squaredNumber = SquareNumber(userNumber);

        // DisplayResult(userName, squaredNumber);
    }
}