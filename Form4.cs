using System;
using System.Windows.Forms;

namespace WindowsFormsChatApp
{
    public partial class Form4 : Form
    {
        private readonly ChatbotService chatbot = new ChatbotService();
        private string username;

        public Form4(String userName)
        {
            InitializeComponent();
            username = userName;

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

            string response = chatbot.GetResponse(message);

            rtbChatChats.AppendText(
                $"[{DateTime.Now:HH:mm}] Cyber Hawks: {response}\n\n");

            txbChatUserInput.Clear();
            rtbChatChats.ScrollToCaret();
        }
    }
}
