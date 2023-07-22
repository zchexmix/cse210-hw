using System;

class Event
{
    private string eventType;
    protected string title;
    protected string description;
    protected DateTime date;
    protected string time;
    protected Address address;

    public Event(string eventType, string title, string description, DateTime date, string time, Address address)
    {
        this.eventType = eventType;
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event Type: {eventType}\nTitle: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: {eventType}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}