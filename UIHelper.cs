// UIHelper.cs
// Responsible for displaying ASCII art and formatting console UIusing System;

public static class UIHelper
{
    // Displays the chatbot ASCII header and visual branding
    public static void DisplayHeader()
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("=================================================");
        Console.WriteLine("     CYBERSECURITY AWARENESS BOT");
        Console.WriteLine("=================================================");

        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine(@"
   ____      _                 ____                      
  / ___| ___| |_ _   _ _ __  / ___|  ___ __ _ _ __  ___ 
 | |  _ / _ \ __| | | | '__| \___ \ / __/ _` | '_ \/ __|
 | |_| |  __/ |_| |_| | |     ___) | (_| (_| | | | \__ \
  \____|\___|\__|\__,_|_|    |____/ \___\__,_|_| |_|___/
        🔐 STAY SAFE ONLINE 🔐
");

        Console.ResetColor();
        Console.WriteLine("\n-------------------------------------------------");
    }
}