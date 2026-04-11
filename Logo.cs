using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot_Part1
{
    internal class Logo
    {
        public static void DisplayLogo()
        {
            // Ascii art from https://www.asciiart.eu/text-to-ascii-art
            Console.WriteLine(@"
________      ___    ___ ________  _______   ________       
|\   ____\    |\  \  /  /|\   __  \|\  ___ \ |\   __  \      
\ \  \___|    \ \  \/  / | \  \|\ /\ \   __/|\ \  \|\  \     
 \ \  \        \ \    / / \ \   __  \ \  \_|/_\ \   _  _\    
  \ \  \____    \/  /  /   \ \  \|\  \ \  \_|\ \ \  \\  \|   
   \ \_______\__/  / /      \ \_______\ \_______\ \__\\ _\   
    \|_______|\___/ /        \|_______|\|_______|\|__|\|__|  
             \|___|/                                         
                                                             
                                                             
 ___  ___  ________  ___       __   ___  __    ________      
|\  \|\  \|\   __  \|\  \     |\  \|\  \|\  \ |\   ____\     
\ \  \\\  \ \  \|\  \ \  \    \ \  \ \  \/  /|\ \  \___|_    
 \ \   __  \ \   __  \ \  \  __\ \  \ \   ___  \ \_____  \   
  \ \  \ \  \ \  \ \  \ \  \|\__\_\  \ \  \\ \  \|____|\  \  
   \ \__\ \__\ \__\ \__\ \____________\ \__\\ \__\____\_\  \ 
    \|__|\|__|\|__|\|__|\|____________|\|__| \|__|\_________\
                                                 \|_________|
            CYBER HAWKS, a cyber security chatbot.");

            // Restore the original console colors
            Console.ResetColor();
        }
}
