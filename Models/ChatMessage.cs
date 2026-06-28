using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsChatApp.Models
{
    internal class ChatMessage
    {
        public string Username { get; set; }

        public string Sender { get; set; }

        public string Message { get; set; }

        public DateTime Time { get; set; }

        public ChatMessage()
        {
            Time = DateTime.Now;
        }

        // Clean display format for UI
        public string Format()
        {
            return $"[{Time:HH:mm}] {Sender}: {Message}";
        }
    }
}
