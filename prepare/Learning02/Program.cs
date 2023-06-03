using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        Console.WriteLine(job1._company);
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2022;


        Resume newResume = new Resume();
        newResume._name = "Zach Checketts";
        newResume._job.Add(job1);
        newResume._job.Add(job2);

        newResume.Display();

    }
}