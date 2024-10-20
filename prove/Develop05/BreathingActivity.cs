using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Method to run the breathing activity
    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3); // Pause for 3 seconds
            Console.WriteLine("Breathe out...");
            ShowCountDown(3); // Pause for 3 seconds
        }

        DisplayEndingMessage();
    }
}
