using System;

namespace Cybersecurity_Chatbot
{
    internal class ResponseSystem
    {
        /**
         * Tries to handle general conversational inputs by providing appropriate responses.
         * @param input The user input to handle.
         * @return True if the input was handled; otherwise, false.
         */
        public static bool HandleGeneral(string input)
        {
            switch (input.ToLower())                                                                                    //Convert input to lowercase for case-insensitive comparison
            {
                case "how are you":
                case "how are you?":
                case "how r u":
                case "how's it going?":
                    Console.WriteLine();
                    UI.TypeText("Bot: I am running optimally and ready to protect you from cyber threats.\n");
                    UI.TypeText("Bot: More importantly — how are YOU doing today?\n");
                    return true;

                case "what is your purpose":
                case "what's your purpose":
                case "purpose":
                    Console.WriteLine();
                    UI.TypeText("Bot: My purpose is to educate you about cybersecurity threats and online safety.\n");
                    UI.TypeText("Bot: I help you stay safe from phishing, weak passwords, and unsafe browsing.\n");
                    return true;

                case "what can i ask you":
                case "what can i ask":
                case "help":
                    Console.WriteLine();
                    UI.TypeText("Bot: You can ask me about:\n");
                    UI.TypeText("- Password safety\n");
                    UI.TypeText("- Phishing emails\n");
                    UI.TypeText("- Suspicious links\n");
                    UI.TypeText("- Safe browsing habits\n");
                    UI.TypeText("- General online safety questions\n");
                    return true;

                default:
                    return false;
            }
        }
        /**
         * Tries to handle the given topic by providing an explanation.
         * @param topic The topic to handle.
         * @return True if the topic was handled; otherwise, false.
         */
        public static bool HandleTopic(string topic)
        {
            switch (topic)
            {
                /*
                 * Multiple case labels allow for different variations.
                 * If input is any of these variations, call the method to explain phishing
                 * if no match is found, it will return false and show the invalid option message
                 */
                case "phishing":
                case "phishing email":
                case "phishing emails":
                case "phishing scam":
                case "emails":
                    ExplainPhishing();                                                                                  //Call the method to explain phishing
                    return true;

                case "password":
                case "passwords":
                    ExplainPasswords();                                                                                 //Call the method to explain passwords
                    return true;

                case "suspicious link":
                case "suspicious links":
                case "links":
                case "suspicious":
                    ExplainSuspiciousLinks();                                                                           //Call the method to explain suspicious links
                    return true;

                default:
                    return false;                                                                                       //No matching topic found
            }
        }

        private static void ExplainPhishing()   
        {
            Console.WriteLine();
            UI.TypeText("Bot: Phishing is when attackers pretend to be trusted companies or people to steal your information.");
            UI.TypeText("Bot: Warning signs include urgent language, spelling mistakes, and requests for passwords or banking details.");
            UI.TypeText("Bot: Safety tip: Do not click links in unexpected messages. Contact the company using an official website.");
        }

        private static void ExplainPasswords()
        {
            Console.WriteLine();
            UI.TypeText("Bot: Strong passwords protect your accounts from being guessed or cracked.");
            UI.TypeText("Bot: Use long passphrases, avoid personal information, and never reuse the same password on multiple sites.");
            UI.TypeText("Bot: Safety tip: Use a password manager and enable multi-factor authentication where possible.");
        }

        private static void ExplainSuspiciousLinks()
        {
            Console.WriteLine();
            UI.TypeText("Bot: Suspicious links can lead to fake websites, malware downloads, or scams.");
            UI.TypeText("Bot: Hover over links to preview the real address and watch for misspelled domains.");
            UI.TypeText("Bot: Safety tip: If unsure, do not click. Type the official website address directly into your browser.");
        }
    }
}
