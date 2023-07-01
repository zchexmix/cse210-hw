class ListingActivity : Activity
{
    private string[] prompts = {
        "What are some of your new years resolutions that you can re-focus on?",
        "What is something you are feeling grateful for today and why?",
        "What is your greatest achievement in life so far? What else do you want to achieve?",
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void Start()
    {
        StartActivity("Listing Activity", "This will help you reflect on the good things in your life.");

        Random random = new Random();
        int promptIndex = random.Next(prompts.Length);

        Console.WriteLine(prompts[promptIndex]);
        Console.WriteLine("Thinking about the prompt...");
        Thread.Sleep(5000);

        Console.WriteLine("Start listing items. Press Enter after each item.");
        int itemCount = 0;
        string item;
        do
        {
            item = Console.ReadLine();
            itemCount++;
        } while (!string.IsNullOrEmpty(item) && itemCount < duration);

        Console.WriteLine($"You listed {itemCount - 1} items.");
        Thread.Sleep(2000);

        EndActivity("Listing Activity");
    }
}
