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
                // https://quillbot.com/tools/text-to-speech?utm_medium=cpc&utm_source=bing&utm_campaign=&utm_term=text%20to%20speech%20voices%20free&utm_content=&campaign_type=search-606348085&click_id=&campaign_id=606348085&adgroup_id=1338108226846935&ad_id=&keyword=text%20to%20speech%20voices%20free&placement=&target=&network=o&msclkid=0b82a21303dc195f98a7cbcf28a24acd
                // Website used to convert text to speech, downloaded the mp3 and then coverted to wav. 
                // TODO : Change the audio to the correct one
                SoundPlayer greeting = new SoundPlayer("speech.wav");
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
