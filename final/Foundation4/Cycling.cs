using System;

class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int length, double speed)
        : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (length / 60.0);
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Speed {speed} mph, Distance {GetDistance()} miles, Pace: {GetPace()} min per mile";
    }
}