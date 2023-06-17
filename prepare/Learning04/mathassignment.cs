using System;

public class Math : Assignment
{
    private string _textsect;
    private string _problems;

    public Math(string name, string topic, string text, string problems) : base(name, topic)
    {
        _textsect = text;
        _problems = problems;
    }
    public string GetText()
    {
        return _textsect;
    }
    public void SetText(string textsect)
    {
        _textsect = textsect;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_textsect}, {_problems}";
    }
}