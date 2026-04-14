using System;


namespace Cybersecurity_Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Logo.AnimatedLogo();                                                                              //-Display the logo of the chatbot 
            UI.GetUserData();                                                                                   //-Get user data (name, etc.) for a personalized experience    
            UI.WelcomeMessage();*/                                                                              //-Start the chatbot by displaying a welcome message

            while (true)
            {
                UI.Menu();
                Console.Write("You: ");                                                                         //-Prompt the user for input
                string input = Console.ReadLine();

                string choice = InputValidation.InputHandler(input);                                            //-Validate and process the user input to determine the topic

                /*
                 * The conditions below treats the variable "choice" as the final processed input.
                 * If the user types "exit" or "4", it will trigger the exit condition
                 */
                if (choice == "exit")                                                                           //-Early exit condition
                {
                    UI.ExitMessage();
                    break;
                }

                bool valid = ResponseSystem.HandleTopic(choice);                                                //-Try to handle the input as a topic. If it matches a topic, it will provide the relevant information.

                if (!valid)
                    valid = ResponseSystem.HandleGeneral(choice);                                               //-If the input doesn't match a topic, try handling it as a general conversational input  
                if (!valid)
                    
                    UI.InvalidOption();                                                                         //-Else handle it as an invalid option
                
            }
        }
    }
}



