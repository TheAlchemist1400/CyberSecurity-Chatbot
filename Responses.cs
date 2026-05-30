using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot_Part2
{
    internal class Responses
    {
        // Variables 
        private static String topic;
        private static String favoriteTopic;
        private static Random random = new Random();

        // ============================================================== RESPONSE METHODS ==========================================
        public static string GetResponse(string question, string name)
        {
            // If statement to save the topic password as the users favourite topic
            if (question.Contains("interest in passwaord") || question.Contains("like password") || question.Contains("favourite topic is password"))
            {
                favoriteTopic = "password";
                return $"{name}, I'll remember that you're interested in password security, remember to use unique passwords for every account.";
            }
            // If statement to save the topic phishing as the users favourite topic
            if (question.Contains("interest in phishing") || question.Contains("like phishing") || question.Contains("favourite topic is phishing"))
            {
                favoriteTopic = "phishing";
                return $"{name}, I'll remember that you're interested in phishing awareness, always be cautious of suspicious emails and links.";
            }
            // If statement to save the topic malware as the users favourite topic
            if (question.Contains("interested in malware") || question.Contains("like malware") || question.Contains("favourite topic is malware"))
            {
                favoriteTopic = "malware";

                return $"{name}, I'll remember that you're interested in malware protection, always keep your antivirus software up to date.";
            }
            // If statement to save the topic browsing as the users favourite topic
            if (question.Contains("interested in browsing") || question.Contains("like browsing") || question.Contains("favourite topic is browsing"))
            {
                favoriteTopic = "browsing";

                return $"{name}, I'll remember that you're interested in browsing safety, always use a reliable browser and keep it updated.";
            }


            switch (question.ToLower())
            {
                // Introductory questions 
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

                // Cybersecurity topics
                case string s when s.Contains("password"):
                    topic = "password";
                    Console.WriteLine($"Password safety is crucial in protecting your online accounts, as it is password is a string of letters, numbers, and symbols that acts like a key to access a computer system, online account, or other secured resources. It verifies the identity of the user and ensures that only authorized individuals can access sensitive data or perform actions within a system");
                    
                    return CurrentTopic(topic, name);

                case string s when s.Contains("phishing") || s.Contains("emails"):
                    topic = "phishing";
                    Console.WriteLine($"Phishing scams are fraudulent attempts to obtain sensitive information by pretending to be a trustworthy entity.");
                    
                    return CurrentTopic(topic, name);
                   
                case string s when s.Contains("malware"):
                    topic = "malware";
                    Console.WriteLine($"Malware is malicious software designed to harm or exploit computer systems.");
                    
                    return CurrentTopic(topic, name);

                case string s when s.Contains("browsing") || s.Contains("internet") || s.Contains("website"):
                    topic = "browsing";
                    Console.WriteLine($"Safe browsing is essential to protect your personal information and avoid online threats.");
                    
                    return CurrentTopic(topic, name);

                // General questions
                case string s when s.Contains("purpose"):
                    return $"The purpose of this chatbot is to raise awareness about cybersecurity and provide information and tips to help South African citizens protect themselves online. We aim to educate users about common cyber threats and best practices for staying safe in the digital world.";

                case string s when s.Contains("cyber hawk") || s.Contains("who are you"):
                    return $"Cyber Hawks is a team dedicated to promoting cybersecurity awareness and education. aiding in SA's cyberdemic, by providing valuable information and resources against it.";

                case string s when s.Contains("goal"):
                    return $"Our goal is to educate and empower south africans to protect themselves from cyber threats and stay safe online. We aim to raise awareness about cybersecurity best practices and provide resources to help individuals and communities stay secure in the digital world.";

                default:
                    return $"I'm sorry, {name}, I don't have an answer to that question. Please try asking something else or type \"help\" for a list of commands.";
            }
        }

        // ============================================================== CURRENT METHODS ==========================================
        public static string CurrentTopic(string topic, string name)
        {
            Console.WriteLine($"Would you like me to give you tips on protecting against {topic}? Type yes or tips.");

            switch (topic.ToLower())
            {
                // If the topic is password, ask if they want password tips
                case "password":
                    string ans = Console.ReadLine().ToLower();

                    if (ans == "yes" || ans == "tips")
                    {
                        return getPasswordTips();
                    }
                    break;

                // If the topic is phishing, ask if they want phishing tips
                case "phishing":
                    string ans2 = Console.ReadLine().ToLower();

                    if (ans2 == "yes" || ans2 == "tips")
                    {
                        return getPhishingTips();
                    }
                    break;
                // If the topic is malware, ask if they want malware tips
                case "malware":
                    string ans3 = Console.ReadLine().ToLower();

                    if (ans3 == "yes" || ans3 == "tips")
                    {
                        return getMalwareTips();
                    }
                    break;
                // If the topic is browsing, ask if they want browsing tips
                case "browsing":
                    string ans4 = Console.ReadLine().ToLower();

                    if (ans4 == "yes" || ans4 == "tips")
                    {
                        return getBrowsingTips();
                    }
                    break;

                default:
                    return ($"You are not currently learning about any specific topic, {name}. Type \"help\" for a list of commands.");
                    break;
            }    

            // If user answered something other than "yes"/"tips" we return a friendly message.
            return $"Okay, {name}. If you want tips about {topic}, type the topic name again or type \"help\".";
        }

        // ============================================================== TIPS METHODS ==========================================

        // ============================== PHISHING TIPS METHODS ==============================
        public static string getPhishingTips()
        {

            string[] phishingTips = new string[]
                {
                    "Be cautious of unsolicited emails, messages, or phone calls asking for personal information.",
                    "Verify the sender's email address or phone number before responding.",
                    "Avoid clicking on suspicious links or downloading attachments from unknown sources.",
                    "Keep your software and antivirus programs up to date to protect against known vulnerabilities."
                };

            string answer;

            do
            {
                int index = random.Next(phishingTips.Length);
                Console.WriteLine("\nTip: " + phishingTips[index]);

                Console.WriteLine("\nWould you like another tip? (yes/no)");
                answer = Console.ReadLine().ToLower();
            }
            while (answer == "yes");

            return string.Empty;
        }
        // ============================== PASSWORD TIPS METHODS ==============================
        public static string getPasswordTips()
        {

            string[] passwordTips = new string[]
                {
                    "Use a combination of uppercase and lowercase letters, numbers, and special characters.",
                    "Avoid using easily guessable information such as your name, birthdate, or common words.",
                    "Use a passphrase or a combination of random words to create a longer password.",
                    "Consider using a password manager to securely store and generate unique passwords for each of your accounts."
                };

            string answer;

            do
            {
                int index = random.Next(passwordTips.Length);
                Console.WriteLine("\nTip: " + passwordTips[index]);

                Console.WriteLine("\nWould you like another tip? (yes/no)");
                answer = Console.ReadLine().ToLower();
            }
            while (answer == "yes");

            return string.Empty;
        }
        // ============================== MALWARE TIPS METHODS ==============================

        public static string getMalwareTips()
        {
            string[] malwareTips = new string[]
                {
                    "Keep your operating system and software up to date with the latest security patches.",
                    "Use reputable antivirus and anti-malware software and keep it updated.",
                    "Be cautious when downloading files or clicking on links from unknown sources.",
                    "Regularly back up your important data to an external drive or cloud storage."
                };

            string answer;

            do
            {
                int index = random.Next(malwareTips.Length);
                Console.WriteLine("\nTip: " + malwareTips[index]);

                Console.WriteLine("\nWould you like another tip? (yes/no)");
                answer = Console.ReadLine().ToLower();
            }
            while (answer == "yes");

            return string.Empty;
        }
        // ============================== BROWSING TIPS METHODS ==============================
        public static string getBrowsingTips()
        {
            string[] browsingTips = new string[]
                {
                    "Use a secure and reputable web browser.",
                    "Enable pop-up blockers and avoid clicking on suspicious pop-ups.",
                    "Be cautious when entering personal information on websites, especially if they are not secure (look for 'https' in the URL).",
                    "Avoid visiting untrusted or suspicious websites."
                };

            string answer;

            do
            {
                int index = random.Next(browsingTips.Length);
                Console.WriteLine("\nTip: " + browsingTips[index]);

                Console.WriteLine("\nWould you like another tip? (yes/no)");
                answer = Console.ReadLine().ToLower();
            }
            while (answer == "yes");

            return string.Empty;
        }
    }
}
