using System;
using System.Threading;


abstract class Activity
{
    protected int duration; 

        protected void StartActivity(string name, string description)
    {
        Console.WriteLine($"----- {name} -----");
        Console.WriteLine(description);
        Console.Write("Enter the duration in seconds: ");
        duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);
    }

    
    protected void EndActivity(string name)
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed {name} for {duration} seconds.");
        Thread.Sleep(2000);
    }

    
    protected void ShowSpinner()
    {
        Console.Write("Processing ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(".");
            Thread.Sleep(300);
        }
        Console.WriteLine();
    }

    
    public abstract void Start();
}