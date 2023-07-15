using System;

class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        this.targetCount = targetCount;
        currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (!completed)
        {
            currentCount++;
            if (currentCount == targetCount)
            {
                completed = true;
                return value + 500; // Bonus points for completing the checklist
            }
            return value;
        }
        return 0;
    }

    public override string DisplayProgress()
    {
        if (completed)
        {
            return $"[X] {name} (Completed {targetCount}/{targetCount} times)";
        }
        return $"[ ] {name} (Completed {currentCount}/{targetCount} times)";
    }
}