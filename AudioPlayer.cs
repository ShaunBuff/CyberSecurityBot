
// AudioPlayer.cs
// Handles playback of voice greeting using WAV audio fileusing System;
using System.Media;

public static class AudioPlayer
{
    // Plays greeting audio when application starts
    // Enhances user engagement and experience
    public static void PlayGreeting()
    {
        try
        {
            string path = "assets/greeting.wav";

            SoundPlayer player = new SoundPlayer(path);
            player.Load();      // make sure file is ready
            player.PlaySync();  // plays audio and waits until finished
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("⚠️ Audio error: " + ex.Message);
            Console.ResetColor();
        }
    }
}