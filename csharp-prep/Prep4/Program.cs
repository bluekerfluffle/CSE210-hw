using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number:");
            number = int.Parse (Console.ReadLine());

            if (number != 0 )
            {
            numbers.Add(number);
            }
        }
        int sum = 0;
        foreach (int usernumber in numbers)
        {
            sum += number; 
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int usernumber in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}");
    }
}