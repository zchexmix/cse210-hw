using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("6 Killyon Road", "London", "Greater London", "England");

        Lecture lecture = new Lecture("BYU Lecture", "An interesting lecture on Faith", new DateTime(2023, 7, 17), "10:00 AM", address1, "John Doe", 50);
        Reception reception = new Reception("Reception", "Wedding Reception", new DateTime(2023, 7, 18), "7:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Gathering Title", "A gathering in the park", new DateTime(2023, 7, 19), "2:00 PM", address1, "Sunny");

        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}