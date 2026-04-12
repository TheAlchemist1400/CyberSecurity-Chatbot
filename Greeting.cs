using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace Chatbot_Part1
{
    internal class AudioPlayer
    {
        public static void PlayGreeting()
        {
            // Use the SoundPlayer class to "TRY" and play the audio file, Use try incase an error occurs it doesnt crash the program
            try
            {
                // TODO : Change the audio to the correct one
                SoundPlayer greeting = new SoundPlayer(@"C:\Users\Armando Moabi\Documents\Rosebank\3rd semester 2026\PROG6221\Class acts\Chatbot Part1\05 - Party On Venus (Prod by by OmArr Josiah of Stoopid Robots");
                greeting.PlaySync();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur while trying to play the audio and return an error message to the user
                Console.WriteLine($"An error occured: {ex.Message}");
            }
        }
    }
}
