using System;
using System.Windows.Forms;

namespace WindowsFormsChatApp
{
    public partial class Form2 : Form
    {
        // Constructor 
        private string userName;
        private int score;
        private int total;

        public Form2(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void btnChatbot_Click(object sender, System.EventArgs e)
        {
            Form4 chat = new Form4(userName);

            // Hide the current form(2) and show the new form(4)
            this.Hide();
            chat.Show();
        }

        private void btnProfile_Click(object sender, System.EventArgs e)
        {
            Form3 profile = new Form3(userName);

            // Hide the current form(2) and show the new form(3)
            this.Hide();
            profile.Show();
        }

        private void btnQuiz_Click(object sender, System.EventArgs e)
        {
            Form5 quiz = new Form5(userName);

            // Hide the current form(2) and show the new form(5)
            this.Hide();
            quiz.Show();
        }

        private void btnResults_Click(object sender, System.EventArgs e)
        {
            Form6 results = new Form6(userName,score, total);

            // Hide the current form(2) and show the new form(6)
            this.Hide();
            results.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
