using System;
using System.Media;

namespace Cybersecurity_Chatbot
{
    /**
     * UI class handles all user interactions, including displaying messages, menus, and prompts. 
     * It also manages the welcome sound and validates user input for continuing the conversation.
     */
    internal class UI
    {
        public static string GetUserData()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("                   W   E   L   C   O   M   E                    ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();
            Console.ResetColor();

            TypeText("Bot: Hello human... I need a name to continue our mission.\n");
            TypeText("Bot: What should I call you? ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))                                                                //If user doesn't enter a name, assign a default name
            {
                name = "User";                                                                                  //Default name if user doesn't provide one
            }

            Console.WriteLine();
            TypeText($"Bot: Nice to meet you, {name}! \n");
            Console.WriteLine();

            return name;
        }

        public static void WelcomeMessage()
        {
            try 
            {
                SoundPlayer welcome = new SoundPlayer("welcome.wav");                                           //Attempts to play a welcome sound when the chatbot starts
                welcome.Play();                                                                                 //Plays the welcome sound
            }
            catch (Exception e)                                                                                 //If sound cannot be played, it'll catch it here and display error message
            {
                Console.WriteLine("Bot: Unable to play welcome sound. " + e.Message);
            }
        }

        public static void Menu()
        {
            TypeText("Choose a topic:");
            TypeText("1) Phishing emails");
            TypeText("2) Passwords");
            TypeText("3) Suspicious links");
            TypeText("4) Exit");
        }

        public static void ExitMessage()
        {
            Console.WriteLine();
            TypeText("Bot: Thanks for chatting. Stay alert online and keep your accounts secure.");
        }

        public static void GoodbyeMessage()
        {
            Console.WriteLine();
            TypeText("Bot: Great job learning about online safety. Goodbye.");
        }

        public static void InvalidOption()
        {
            Console.WriteLine();
            TypeText("Bot: I can help with phishing, passwords, or suspicious links.");
            TypeText("Bot: Please type a topic name, number (1-4), or 'exit'.");
        }

        /*
         * Reusable method to display text with a typing effect.
         * Making the chatbot's responses feel more dynamic and engaging.
         * @param text The text to display.
         * @param delay The delay in milliseconds between each character (default is 40ms).
         * Threading logic assisted by ChatGPT to create a typing effect for the chatbot's responses.
         */
        public static void TypeText(string text, int delay = 40)
        {
            foreach (char a in text)
            {
                Console.Write(a); 
                System.Threading.Thread.Sleep(delay);                                                           //Delay between each character to create typing effect
            }
        }
    }
}