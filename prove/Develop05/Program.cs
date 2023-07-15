using System;

class Program
{
    static void Main(string[] args)
    {
        EternalQuestProgram program = new EternalQuestProgram();

        program.CreateGoal("simple", "Run a marathon", 1000);
        program.CreateGoal("eternal", "Read scriptures", 100);
        program.CreateGoal("checklist", "Attend the temple", 50, 10);

        program.RecordEvent(0);
        program.RecordEvent(1);
        program.RecordEvent(1);
        program.RecordEvent(2);
        program.RecordEvent(2);
        program.RecordEvent(2);
        program.RecordEvent(2);
        program.RecordEvent(2);
        program.RecordEvent(2);
        program.RecordEvent(2);

        program.DisplayGoals();
        program.DisplayScore();

        Console.ReadLine();
    }
}