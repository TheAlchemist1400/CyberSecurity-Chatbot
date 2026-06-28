using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsChatApp
{
    internal class ChatbotService
    {
        List<ChatResponse> responses;

        public ChatbotService()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "responses.json");
            responses = JsonStorage.Load<ChatResponse>(path);
        }

        public string GetResponse(string message)
        {
            message = message.ToLower();

            foreach (var response in responses)
            {
                if (message.Contains(response.Keyword.ToLower()))
                    return response.Response;
            }

            return "Sorry, I don't understand. Type 'help'.";
        }
    }
}
