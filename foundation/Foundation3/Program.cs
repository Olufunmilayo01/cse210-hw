using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Set the date in a consistent format
        string date = DateTime.Now.ToString("dd MMM yyyy");

        // Create instances of each activity
        Activity runningActivity = new Running(date, 30, 3.0);
        Activity cyclingActivity = new Cycling(date, 30, 15.0);
        Activity swimmingActivity = new Swimming(date, 30, 20);

        // Store activities in a list
        List<Activity> activities = new List<Activity>
        {
            runningActivity,
            cyclingActivity,
            swimmingActivity
        };

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}