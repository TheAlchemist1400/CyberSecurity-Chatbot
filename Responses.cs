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
                case string s when s.Contains("how are you"):
                    return $"I'm doing well, {name}! Hope you are better, what can I do for you today, if you not sure type \"help\".";

                case string s when s.Contains("help"):
                    return $"Sure, {name}! Type any of the following commands:\n" +
                        "password: Learn about password safety.\n" +
                        "phishing: Learn about phishing scams.\n" +
                        "malware:  Learn about malware.\n" +
                        "browsing: Safe browsing tips.\n" +
                        "purpose:  What is the purpose of this chatbot.\n" +
                        "goal:     What is our goal.\n" +                       
                        "Cyber hawks: Who are we. \n";


                case string s when s.Contains("password"):
                    return $"Password safety is crucial in protecting your online accounts. Here are some tips to create strong passwords: \n" +
                        "1. Use a combination of uppercase and lowercase letters, numbers, and special characters.\n" +
                        "2. Avoid using easily guessable information such as your name, birthdate, or common words.\n" +
                        "3. Use a passphrase or a combination of random words to create a longer password.\n" +
                        "4. Consider using a password manager to securely store and generate unique passwords for each of your accounts.\n";

                case string s when s.Contains("phishing") || s.Contains("emails"):
                    return $"Phishing scams are fraudulent attempts to obtain sensitive information by pretending to be a trustworthy entity. Here are some tips to avoid falling victim to phishing scams: \n" +
                        "1. Be cautious of unsolicited emails, messages, or phone calls asking for personal information.\n" +
                        "2. Verify the sender's email address or phone number before responding.\n" +
                        "3. Avoid clicking on suspicious links or downloading attachments from unknown sources.\n" +
                        "4. Keep your software and antivirus programs up to date to protect against known vulnerabilities.\n";

                case string s when s.Contains("malware"):
                    return $"Malware is malicious software designed to harm or exploit computer systems. Here are some tips to protect yourself from malware: \n" +
                        "1. Install and regularly update antivirus software.\n" +
                        "2. Be cautious when downloading files or software from the internet.\n" +
                        "3. Avoid clicking on suspicious links or pop-up ads.\n" +
                        "4. Keep your operating system and software up to date with the latest security patches.\n";
            
                case string s when s.Contains("browsing") || s.Contains("internet") || s.Contains("website"):
                    return $"Safe browsing is essential to protect your personal information and avoid online threats. Here are some tips for safe browsing: \n" +
                        "1. Use a secure and reputable web browser.\n" +
                        "2. Enable pop-up blockers and avoid clicking on suspicious pop-ups.\n" +
                        "3. Be cautious when entering personal information on websites, especially if they are not secure (look for 'https' in the URL).\n" +
                        "4. Avoid visiting untrusted or suspicious websites.\n";

                case string s when s.Contains("purpose"):
                    return $"The purpose of this chatbot is to raise awareness about cybersecurity and provide information and tips to help South African citizens protect themselves online. We aim to educate users about common cyber threats and best practices for staying safe in the digital world.";

                case string s when s.Contains("cyber hawk") || s.Contains("Who are you"):
                    return $"Cyber Hawks is a team dedicated to promoting cybersecurity awareness and education. aiding in SA's cyberdemic, by providing valuable information and resources against it.";

                case string s when s.Contains("goal"):
                    return $"Our goal is to educate and empower south africans to protect themselves from cyber threats and stay safe online. We aim to raise awareness about cybersecurity best practices and provide resources to help individuals and communities stay secure in the digital world.";

                default:
                    return $"I'm sorry, {name}, I don't have an answer to that question. Please try asking something else or type \"help\" for a list of commands.";
            }
        }
    }
}
