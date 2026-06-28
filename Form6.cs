using System;
using System.Windows.Forms;

namespace WindowsFormsChatApp
{
    public partial class Form6 : Form
    {
        private string username;
        private int score;
        private int total;

        public Form6(String userName, int score, int total)
        {
            InitializeComponent();
            this.username = userName;
            this.score = score;
            this.total = total;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            double percentage = ((double)score / total) * 100;

            lblResultsScore.Text = $"Score: {score}/{total}";
            lblResultsPercentage.Text = $"Percentage: {percentage:F2}%";

            if (percentage >= 80)
            {
                lblResultsFeedback.Text =
                    "Excellent! You have strong cybersecurity knowledge.";
            }
            else if (percentage >= 60)
            {
                lblResultsFeedback.Text =
                    "Good job! Keep learning to improve your cybersecurity awareness.";
            }
            else
            {
                lblResultsFeedback.Text =
                    "You should review the chatbot lessons and try the quiz again.";
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2(username);

            menu.Show();
            this.Hide();
        }
    }
}
