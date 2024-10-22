public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void ShowBreathingAnimation(int seconds)
    {
        Console.Clear();
        // Animation for breathing in
        Console.Write("Breathe in: ");
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(">");
            Thread.Sleep(1000); // 1 second pause per step
        }
        Console.ResetColor();
        Console.WriteLine();

        // Animation for breathing out
        Console.Write("Breathe out: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("<");
            Thread.Sleep(1000); // 1 second pause per step
        }
        Console.ResetColor();
        Console.WriteLine();
    }

    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 2; i++)
        {
            
            ShowBreathingAnimation(3); // Use 3 seconds for each breathe in and out
        }

        DisplayEndingMessage();
    }
}
