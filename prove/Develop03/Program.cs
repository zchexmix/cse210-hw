using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine();
            Console.WriteLine("Hide words by pressing Enter, or type quit to end the program.");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture.HideRandomWord();
        }
    }
}

