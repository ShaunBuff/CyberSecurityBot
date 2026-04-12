// Program.cs
// Entry point of the Cybersecurity Awareness Chatbot application
// Initializes UI, audio greeting, and starts chatbot interaction
using System;

class Program
{
    static void Main(string[] args)
    {
        // Display ASCII header
        UIHelper.DisplayHeader();

        // Play voice greeting safely
        try
        {
            AudioPlayer.PlayGreeting();
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("⚠️ Audio could not be played. Continuing without sound.");
            Console.ResetColor();
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\nEnter your name: ");
        string name = Console.ReadLine();

        // Input validation
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Name cannot be empty. Enter again: ");
            Console.ResetColor();
            name = Console.ReadLine();
        }

        Console.ResetColor();

        // Start chatbot with personalized user name
        Chatbot bot = new Chatbot(name);
        bot.StartChat();
    }
}