using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot_Part1
{
    internal class Chatbot
    {
        // Start method to start the chatbot and prompt the user for their name
        public void run()
        {
            // Prompt the user to enter their name and store it in a variable
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            // Ensure the user has entered a name, if not prompt them again until they do
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You sure want to trick the CYBER HAWKS?");
                Console.WriteLine("Enter a valid name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Welcome to CYBER HAWKS, {name}");
            Console.WriteLine("A Cybersecurity Awareness Chatbot for South African Citizens");
            Console.WriteLine();

            runChat(name);
        }

        // Chat method to run the chatbot and prompt the user for their questions
        private void runChat(string name)
        {
            while (true)
            {
                Console.WriteLine("Ask me a question about cybersecurity or type 'exit' to quit. ");

                // Set the console color to yellow
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                // Initialise the question variable to store the user's question 
                String question = Console.ReadLine().ToLower();

                // Ensure user can exit program when they type "exit"
                if (question.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                // Ensure user has entered a question, if not prompt them again until they do
                if (string.IsNullOrEmpty(question))
                {
                    Console.WriteLine("Question cannot be empty, please ask a valid question.");
                    continue;
                }

                // Set the console color to green for the chatbot's response 
                Console.ForegroundColor = ConsoleColor.Green;

                // Get the chatbot's response to the users question and display it in the console using the GetResponse method from the Responses class
                Console.WriteLine("Bot: " + Responses.GetResponse(question, name));
                Console.ResetColor();
            }
        }
    }
}
