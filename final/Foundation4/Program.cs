using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 7, 17), 30, 3.0),
            new Cycling(new DateTime(2023, 7, 18), 45, 15.0),
            new Swimming(new DateTime(2023, 7, 19), 60, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}