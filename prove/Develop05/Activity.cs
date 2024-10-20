using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Method to start the activity
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); // Pause for 3 seconds
    }

    // Method to end the activity
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed {_name} Activity for {_duration} seconds.");
        ShowSpinner(3); // Pause for 3 seconds
    }

    // Method to show a spinner animation
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    // Method to show a countdown
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); // Pause for 1 second
        }
    }
}
