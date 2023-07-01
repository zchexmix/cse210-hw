class BreathingActivity : Activity
{
    public override void Start()
    {
        StartActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            ShowSpinner();

            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
            ShowSpinner();
        }

        EndActivity("Breathing Activity");
    }
}