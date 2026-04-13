# Cybersecurity Awareness Bot

A C# console chatbot that helps users learn basic cybersecurity topics.

## Features
- Animated ASCII logo display
- Welcome sound on startup (`welcome.wav`)
- Topic menu with guided responses
- Input normalization for flexible user input
- Continue/exit prompt flow

## Topics Covered
1. Phishing emails
2. Password safety
3. Suspicious links

## Tech Stack
- .NET Framework `4.7.2`
- C# `7.3`
- Console application

## Project Structure
- `Cybersecurity_Chatbot/Program.cs` – main app flow
- `Cybersecurity_Chatbot/UI.cs` – user messaging and prompts
- `Cybersecurity_Chatbot/BotOperations.cs` – topic response handling
- `Cybersecurity_Chatbot/InputValidation.cs` – input standardization
- `Cybersecurity_Chatbot/Logo.cs` – animated ASCII logo

## How to Run
1. Open `Cybersecurity_Chatbot.slnx` in Visual Studio.
2. Build the solution.
3. Run the project.

## Notes
- Keep `welcome.wav` in the project output path if sound playback is required.
- This project is intended for educational use.

## References
- OpenAI. (2026). ChatGPT (GPT-5.3-mini) assistance for C# chatbot development, ASCII art animation, and Git workflow guidance. https://chat.openai.com/
- Patorjk.com. (n.d.). Text to ASCII Art Generator (TAAG). https://patorjk.com/software/taag/
