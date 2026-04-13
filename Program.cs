using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Wave;
using System.Threading.Tasks;

namespace Chatbot_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CYBER HAWKS - A Cybersecurity Awareness Chatbot for South African Citizens";

            Logo.DisplayLogo();

            AudioPlayer.PlayGreeting();

            Chatbot bot = new Chatbot();
            bot.run();

            Console.Read();
        }
    }
}

//welcome to Cyber hawks , SA's very own Cybersecurity chatbot.
