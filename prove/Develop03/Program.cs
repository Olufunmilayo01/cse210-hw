using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Option to load progress from file or start new
        Scripture selectedScripture = LoadScriptureState("progress.txt");

        if (selectedScripture == null)
        {
            // If no saved progress, create a new scripture
            selectedScripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        }

        bool quit = false;
        while (!quit)
        {
            // Display the scripture with hidden words
            selectedScripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to save and exit.");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
            {
                SaveScriptureState("progress.txt", selectedScripture);
                quit = true;
            }
            else
            {
                selectedScripture.HideRandomWords();
            }
        }

        Console.WriteLine("Progress saved. Thank you for using the Scripture Memorization Program!");
    }

    // Method to save the scripture state
    static void SaveScriptureState(string fileName, Scripture scripture)
    {
        File.WriteAllText(fileName, scripture.GetScriptureState());
    }

    // Method to load the saved scripture state
    static Scripture LoadScriptureState(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] data = File.ReadAllLines(fileName);
            if (data.Length > 0)
            {
                string[] parts = data[0].Split(';');
                string reference = parts[0];
                string text = parts[1];
                return new Scripture(reference, text, data[1]); // Pass the hidden word state as well
            }
        }

        return null;
    }
}
