using System;
using System.Windows.Forms;
using WindowsFormsChatApp.Models;
using System.Collections.Generic;

namespace WindowsFormsChatApp
{
    public partial class Form4 : Form
    {
        private readonly ChatbotService chatbot = new ChatbotService();
        private string username;
        private List<ChatMessage> chatHistory;

        public Form4(String userName)
        {
            InitializeComponent();
            username = userName;

            chatHistory = JsonStorage.Load<ChatMessage>("Data/chatHistory.json");

            // Greet user at load form
            rtbChatChats.AppendText($"Cyber Hawks: Welcome {username}!\n");
        }

        private void btnChatSend_Click(object sender, EventArgs e)
        {
            string message = txbChatUserInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(message))
                return;

            rtbChatChats.AppendText(
                $"[{DateTime.Now:HH:mm}] {username}: {message}\n");

            // Save the users message to chat history
            chatHistory.Add(new ChatMessage
            {
                Username = username,
                Sender = "User",
                Message = message,
                Time = DateTime.Now
            });

            string response = chatbot.GetResponse(message);

            // Save the bots message to chat history
            chatHistory.Add(new ChatMessage
            {
                Username = username,
                Sender = "Cyber Hawks",
                Message = response,
                Time = DateTime.Now
            });

            rtbChatChats.AppendText(
                $"[{DateTime.Now:HH:mm}] Cyber Hawks: {response}\n\n");
            
            // Save the json file
            JsonStorage.Save("Data/chatHistory.json", chatHistory);

            txbChatUserInput.Clear();
            rtbChatChats.ScrollToCaret();
        }
    }
}
