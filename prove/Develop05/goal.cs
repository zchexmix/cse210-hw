using System;

class Goal
{
    protected string name;
    protected int value;
    protected bool completed;

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
        completed = false;
    }

    public virtual int RecordEvent()
    {
        if (!completed)
        {
            completed = true;
            return value;
        }
        return 0;
    }

    public bool IsCompleted()
    {
        return completed;
    }

    public virtual string DisplayProgress()
    {
        return completed ? $"[X] {name}" : $"[ ] {name}";
    }
}