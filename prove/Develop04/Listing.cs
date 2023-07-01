class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void Start()
    {
        StartActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random random = new Random();
        int promptIndex = random.Next(prompts.Length);

        Console.WriteLine(prompts[promptIndex]);
        Console.WriteLine("Begin thinking about the prompt...");
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
