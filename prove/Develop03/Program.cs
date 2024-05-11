using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Console.Write("Enter the book: ");
        string userBook = Console.ReadLine();
        Console.Write("Enter the chapter of the book: ");
        string userChapter = Console.ReadLine();
        Console.Write("Enter the first verse of the chapter: ");
        string userVerseF = Console.ReadLine();
        Console.Write("Enter the last verse of the chapter: (Press 'N' if there isn't) ");
        string userVerseL = Console.ReadLine().ToLower();
        Console.Write("Enter your scripture: ");
        string userPhase = Console.ReadLine();

        Reference referenceStructure = new(userBook, userChapter, userVerseF, userVerseL);
        string reference = referenceStructure.GetCompleteReference();
        Scripture scritureStructure = new Scripture(userPhase);
        string scripture = scritureStructure.GetCompleteScripture();
        Domain domain = new Domain(reference, scripture);
        string completePhase = domain.CompletePhase();

        Word word = new(true);

        List<string> list = new();
        list = scripture.Split(" ").ToList();

        List<string> listWithSlashs = new();
        bool condition = true;

        Console.Clear();
        word.GetCompletePhase(completePhase, list, condition, reference);

        listWithSlashs.Add(reference + " ");

        for (int i = 0; i < list.Count; i++)
        {
            listWithSlashs.Add((string)list[i] + " ");
            Console.Clear();
        }

        Console.WriteLine("You have finished the program. ");
        word.GetCompletePhase(completePhase, list, condition, reference);
        Console.Write("The phrase reached was like this: "); 
        Console.WriteLine();

        foreach (var item in listWithSlashs)
        {
            Console.Write($"{item}");
        }

    }
}