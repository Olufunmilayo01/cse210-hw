using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _itemCount;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many items as you can.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt peace or joy recently?",
            "Who are some of your personal heroes?"
        };
    }

    // Method to run the listing activity
    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        Console.WriteLine("Start listing as many items as you can...");
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        _itemCount = items.Count;
        Console.WriteLine($"You listed {_itemCount} items.");

        DisplayEndingMessage();
    }
}
