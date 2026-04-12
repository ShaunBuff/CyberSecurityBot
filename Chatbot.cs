// This is Chatbot.cs
// Handles all chatbot logic including conversation, scenario mode,
// cybersecurity education, and user interaction
using System;

// Main chatbot class responsible for handling user interaction and responses
public class Chatbot
{
    private string userName;

    public Chatbot(string name)
    {
        userName = name;
    }
    // Starts continuous chatbot loop for user interaction
    // Reads input and routes it to response handler
    public void StartChat()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nWelcome {userName}! 👋");
        Console.WriteLine("I am your Cybersecurity Awareness Assistant.");
        Console.WriteLine("Type 'help' to see options or 'exit' to quit.\n");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You: ");
            string input = Console.ReadLine()?.ToLower();
            Console.ResetColor();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bot: Please enter a valid message.");
                Console.ResetColor();
                continue;
            }

            if (input == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: Stay safe online, {userName}! 🔐");
                Console.ResetColor();
                break;
            }

            HandleInput(input);
        }
    }
    // Processes user input and determines appropriate cybersecurity response
    // Handles phishing, passwords, links, and general queries
    private void HandleInput(string input)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Bot: ");

        if (input.Contains("hello") || input.Contains("hi"))
        {
            Console.WriteLine($"Hello {userName}! 😊 How can I help you stay safe online?");
        }
        else if (input.Contains("how are you"))
        {
            Console.WriteLine("I'm running securely and ready to protect you 🔐");
        }
        else if (input.Contains("purpose"))
        {
            Console.WriteLine("My purpose is to teach you cybersecurity safety.");
        }
        else if (input.Contains("password tips"))
        {
            Console.WriteLine("Use strong passwords: 8+ characters, symbols, numbers, and avoid personal info.");
        }
        else if (input.Contains("phishing") || input.Contains("email"))
        {
            Console.WriteLine("Phishing is when attackers trick you into personal information through fake emails or websites.");
        }
        else if (input.Contains("link"))
        {
            Console.WriteLine("Always check links for HTTPS and suspicious spelling before clicking.");
        }
        else if (input.Contains("scenario") || input.Contains("test"))
        {
            RunScenario();
        }
        else if (input.Contains("help"))
        {
            ShowHelp();
        }
        else
        {
            Console.WriteLine("I’m not sure about that. Try asking about passwords, phishing, or type 'scenario'.");
        }

        Console.ResetColor();
    }

    private void ShowHelp()
    {
        Console.WriteLine("\nYou can ask me about:");
        Console.WriteLine("- Password safety");
        Console.WriteLine("- Phishing emails");
        Console.WriteLine("- Suspicious links");
        Console.WriteLine("- Type 'scenario' for a test\n");
    }

    // 🎭 SCENARIO MODE (MAIN FEATURE)
    private void RunScenario()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine("\n=======================================");
        Console.WriteLine("      CYBERSECURITY SCENARIO TEST");
        Console.WriteLine("=======================================\n");

        Console.WriteLine($"{userName}, imagine this situation:\n");

        Console.WriteLine("📧 You receive an email:");
        Console.WriteLine("'URGENT: Your bank account will be locked immediately. Click here to verify!'\n");

        Console.WriteLine("What do you do?");
        Console.WriteLine("1️⃣ Click the link immediately");
        Console.WriteLine("2️⃣ Ignore the email");
        Console.WriteLine("3️⃣ Verify the sender and contact the bank\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter your answer (1/2/3): ");
        string answer = Console.ReadLine();
        Console.ResetColor();

        Console.WriteLine();

        if (string.IsNullOrWhiteSpace(answer))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("⚠️ No answer entered.");
        }
        else if (answer == "3")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✅ Correct!");
            Console.WriteLine("This is a phishing attempt. Always verify before clicking.");
        }
        else if (answer == "2")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("👍 Good choice!");
            Console.WriteLine("Ignoring suspicious emails is a safe action.");
        }
        else if (answer == "1")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Incorrect!");
            Console.WriteLine("This is a phishing scam designed to steal your data.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("⚠️ Invalid option. Please choose 1, 2, or 3.");
        }

        Console.ResetColor();

        Console.WriteLine("\nType 'scenario' again to retry or continue chatting.\n");
    }
}