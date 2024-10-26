//  I exceeded requirement by adding additional kinds of goals, "negative goals" where they lose points for bad habits.
 class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();

            // Sample Goals (would normally be user-driven)
            manager.AddGoal(new SimpleGoal("Run a marathon", 1000));
            manager.AddGoal(new EternalGoal("Read scriptures daily", 100));
            manager.AddGoal(new ChecklistGoal("Attend temple 10 times", 50, 10, 500));
            manager.AddGoal(new NegativeGoal("Missed gym session", 50)); // Negative goal example

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1. Display Goals\n2. Record Goal Event\n3. Save Goals\n4. Load Goals\n5. Exit");
                Console.Write("Select an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        manager.DisplayGoals();
                        break;
                    case "2":
                        Console.Write("Enter goal number to record event: ");
                        int goalIndex = int.Parse(Console.ReadLine() ?? "0") - 1;
                        manager.RecordGoalEvent(goalIndex);
                        break;
                    case "3":
                        manager.SaveGoals("goals.txt");
                        break;
                    case "4":
                        manager.LoadGoals("goals.txt");
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
