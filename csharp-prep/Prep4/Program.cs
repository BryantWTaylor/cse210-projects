using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int convNumber = -1;
        int sum = 0;
        int largest = 0;
        do
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            convNumber = int.Parse(userNumber);
            if (convNumber != 0)
            {
                numbers.Add(convNumber);
            }
        } while (convNumber != 0);
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }
        }
        int count = numbers.Count;
        Console.WriteLine($"The sum is {sum}");
        float average = ((float)sum) / count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        
    }
}