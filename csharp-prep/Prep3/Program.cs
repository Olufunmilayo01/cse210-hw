using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string input = Console.ReadLine();
        // int number =int.Parse(input);


        // Console.Write("What is your guess? ");
        // string userInput = Console.ReadLine();
        // int guess =int.Parse(userInput);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        
             if (number < guess)
             {
                Console.WriteLine("lower");
             }

             else if (number > guess)
             {
                Console.WriteLine("higher");
             }
              else
             {
            Console.WriteLine("You guessed it!");
             }
        }
       

        
       
    }
}