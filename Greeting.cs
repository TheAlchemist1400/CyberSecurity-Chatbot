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
        try
        {
            SoundPlayer greeting = new SoundPlayer(@"C:\Users\Armando Moabi\Documents\Rosebank\3rd semester 2026\PROG6221\Class acts\Chatbot Part1\05 - Party On Venus (Prod by by OmArr Josiah of Stoopid Robots");
            greeting.PlaySync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occured: " + ex.Message);
        }
    }
}
