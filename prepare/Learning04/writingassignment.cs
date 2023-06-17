using System;

public class Writing : Assignment
{
    private string _title;

    public Writing(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetWritingInfo()
    {
        return $"Title: {_title}";
    }
}