using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Load scriptures from file and pick a random one
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");
        Scripture randomScripture = scriptures[new Random().Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(randomScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            randomScripture.HideRandomWords();

            if (randomScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(randomScripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }
        }
    }

    // Helper method to load scriptures from a file
    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        var scriptures = new List<Scripture>();
        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length != 2) continue; // Skip invalid lines

            string referenceText = parts[0].Trim();
            string scriptureText = parts[1].Trim();

            // Parse the reference (e.g., "John 3:16" or "Proverbs 3:5-6")
            Reference reference = ParseReference(referenceText);
            scriptures.Add(new Scripture(reference, scriptureText));
        }

        return scriptures;
    }

    // Helper method to parse reference strings (e.g., "John 3:16" or "Proverbs 3:5-6")
    static Reference ParseReference(string referenceText)
    {
        string[] parts = referenceText.Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        string book = parts[0];
        int chapter = int.Parse(parts[1]);

        if (parts[2].Contains("-")) // Multi-verse (e.g., "3:5-6")
        {
            string[] verseParts = parts[2].Split('-');
            int startVerse = int.Parse(verseParts[0]);
            int endVerse = int.Parse(verseParts[1]);
            return new Reference(book, chapter, startVerse, endVerse);
        }
        else // Single verse (e.g., "3:16")
        {
            int verse = int.Parse(parts[2]);
            return new Reference(book, chapter, verse);
        }
    }
}