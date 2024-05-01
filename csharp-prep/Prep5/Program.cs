using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = squareNumber(userNumber);

        DisplayResult(userName, squaredNumber);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write ("Please enter your name:");
            string Name = Console.ReadLine();

            return Name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number:");
            int Number = int.Parse(Console.ReadLine());
            
            return Number;
        }
        static int SquaredNumber(int number)
        {
            int square = number*number;
            return square;
        }
        static void DisplayResult (String name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");

        }

    }
}