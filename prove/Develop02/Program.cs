using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
}

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, DateTime date)
    {
        Entry entry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = date
        };
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine("Prompt: " + entry.Prompt);
                writer.WriteLine("Response: " + entry.Response);
                writer.WriteLine("Date: " + entry.Date);
                writer.WriteLine();
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                Entry entry = new Entry();
                entry.Prompt = reader.ReadLine().Substring(8);
                entry.Response = reader.ReadLine().Substring(10);
                entry.Date = DateTime.Parse(reader.ReadLine().Substring(6));
                entries.Add(entry);
                reader.ReadLine();
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    string prompt = prompts[new Random().Next(prompts.Count)];
                    Console.WriteLine("Prompt: " + prompt);
                    Console.WriteLine("Enter your response:");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response, DateTime.Now);
                    Console.WriteLine("Entry saved!");
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("Enter a file name to save the journal:");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved to file!");
                    break;
                case 4:
                    Console.WriteLine("Enter a file name to load the journal:");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from file!");
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    break;
            }
        }
    }
}
