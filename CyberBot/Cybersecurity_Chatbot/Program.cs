using System;


namespace Cybersecurity_Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logo.AnimatedLogo();                                                                                //Display the logo of the chatbot 
            UI.GetUserData();                                                                                   //Get user data (name, etc.) for a personalized experience    
            UI.WelcomeMessage();                                                                                //Start the chatbot by displaying a welcome message
                                                                                  
            while (true)
            {
                UI.Menu();
                Console.Write("You: ");                                                                         //Prompt the user for input
                string input = Console.ReadLine();

                string choice = InputValidation.InputHandler(input);                                             //Validate and process the user input to determine the topic

                if (choice == "exit")
                {
                    UI.ExitMessage();
                    break;
                }

                bool valid = ResponseSystem.HandleTopic(choice);                                                //Handles the validated input by providing an appropriate response.

                if (!valid)                                                                                      //If the input was not a general conversational input, try to handle it as a topic
                {
                    valid = ResponseSystem.HandleGeneral(choice);                                                                         //Then return an invalid option message
                }
                
                if (!valid)                                                                                     //If input was not treated as a topic or general conversation, show invalid option message
                {
                    UI.InvalidOption();
                }
            }
        }
    }
}
        

