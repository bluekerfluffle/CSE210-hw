using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next (1,101);

        int guessnumber = -1;

        while (guessnumber != magicnumber)
        {
        Console.Write("What is your guess?");
        guessnumber = int.Parse(Console.ReadLine());

        if (magicnumber > guessnumber)
        {
            Console.WriteLine("Higher")
        }
        
        else if (magicnumber < guessnumber)
        {
            Console.WriteLine("Lower");
        }

        else 
        {
            Console.WriteLine("You guessed it!!");
        }
        }
    }
} 