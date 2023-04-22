using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass, but you'll get it next time!");
        }
    }
}