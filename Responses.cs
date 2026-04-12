using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot_Part1
{
    internal class Responses
    {
        public static string GetResponse(string question, string name)
        {
            question = question.ToLower();

            switch(question)
            {
                case string s when s.Contains("how are you?"):
                    return $"I'm doing well, {name}! Hope you are better, what can I do for you today, if you not sure type \"help\".";

                case string s when s.Contains("help"):
                    return $"Sure, {name}! Type any of the following commands:" +
                        "password  → Learn about password safety" +
                        "phishing  → Learn about phishing scams" +
                        "malware   → Learn about malware" +
                        "browsing  → Safe browsing tips" +
                        "Cyber hawks → Who are we " +
                        "Goal → What is our goal" +
                        "purpose → What is the purpose of this chatbot";
                
                case string s when s.Contains("password"):
                    return $"Password safety is crucial in protecting your online accounts. Here are some tips to create strong passwords: " +
                        "1. Use a combination of uppercase and lowercase letters, numbers, and special characters." +
                        "2. Avoid using easily guessable information such as your name, birthdate, or common words." +
                        "3. Use a passphrase or a combination of random words to create a longer password." +
                        "4. Consider using a password manager to securely store and generate unique passwords for each of your accounts.";

                case string s when s.Contains("phishing"):
                    return $"Phishing scams are fraudulent attempts to obtain sensitive information by pretending to be a trustworthy entity. Here are some tips to avoid falling victim to phishing scams: " +
                        "1. Be cautious of unsolicited emails, messages, or phone calls asking for personal information." +
                        "2. Verify the sender's email address or phone number before responding." +
                        "3. Avoid clicking on suspicious links or downloading attachments from unknown sources." +
                        "4. Keep your software and antivirus programs up to date to protect against known vulnerabilities.";

                case string s when s.Contains("malware"):
                    return $"Malware is malicious software designed to harm or exploit computer systems. Here are some tips to protect yourself from malware: " +
                        "1. Install and regularly update antivirus software." +
                        "2. Be cautious when downloading files or software from the internet." +
                        "3. Avoid clicking on suspicious links or pop-up ads." +
                        "4. Keep your operating system and software up to date with the latest security patches.";
            
                case string s when s.Contains("browsing"):
                    return $"Safe browsing is essential to protect your personal information and avoid online threats. Here are some tips for safe browsing: " +
                        "1. Use a secure and reputable web browser." +
                        "2. Enable pop-up blockers and avoid clicking on suspicious pop-ups." +
                        "3. Be cautious when entering personal information on websites, especially if they are not secure (look for 'https' in the URL)." +
                        "4. Avoid visiting untrusted or suspicious websites.";

                case string s when s.Contains("cyber hawks"):
                    return $"Cyber Hawks is a team dedicated to promoting cybersecurity awareness and education. Our goal is to help south africans to stay safe online by providing valuable information and resources.";

                case string s when s.Contains("goal"):
                    return $"Our goal is to educate and empower south africans to protect themselves from cyber threats and stay safe online. We aim to raise awareness about cybersecurity best practices and provide resources to help individuals and communities stay secure in the digital world.";

                default:
                    return $"I'm sorry, {name}, I don't have an answer to that question. Please try asking something else or type \"help\" for a list of commands.";
            }
        }
    }
}
