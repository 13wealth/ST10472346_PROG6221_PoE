using System;


namespace Cybersecurity_Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logo.AnimatedLogo();                                                                                        //Display the logo of the chatbot 
            UI.GetUserData();                                                                                           //Get user data (name, etc.) for a personalized experience    
            UI.WelcomeMessage();                                                                                        //Start the chatbot by displaying a welcome message

            while (true)
            {
                UI.TopicMenu();
                Console.Write("You: ");
                string userInput = Console.ReadLine();

                string topic = InputValidation.InputHandler(userInput);

                if (topic == "exit")
                {
                    UI.ExitMessage();
                    break;
                }

                bool wasHandled = BotOperations.TryHandleTopic(topic);

                if (!wasHandled)
                {
                    UI.InvalidOption();
                }

                if (!UI.AskToContinue())
                {
                    UI.GoodbyeMessage();
                    break;
                }
            }
        }
    }
}
        

