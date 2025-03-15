using System;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirements

        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }

        // Print the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        // Stretch Challenge

        // Determine the sign (+ or -)
        string sign = "";
        int lastDigit = gradePercentage % 10;

        if (letter != "F") // No signs for F grades
        {
            if (lastDigit >= 7 && letter != "A") // No A+ grade
            {
                sign = "+";
            }
            else if (lastDigit < 3 && letter != "F") // No F- grade
            {
                sign = "-";
            }
        }

        // Handle exceptional cases
        if (letter == "A" && lastDigit >= 7)
        {
            sign = ""; // No A+ grade
        }
        else if (letter == "F")
        {
            sign = ""; // No F+ or F- grades
        }

        // Print the final grade with sign
        Console.WriteLine($"Your final grade is: {letter}{sign}");
    }
}