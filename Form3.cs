using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsChatApp.Data;
using WindowsFormsChatApp.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsChatApp
{
    public partial class Form3 : Form
    {
        private string userName;
        public Form3(String userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblProfileName.Text = "Name: " + userName;

            List<quizResults> results =
                JsonStorage.Load<quizResults>("Data/results.json");

            var userResults = results
                .Where(r => r.UserName == userName)
                .ToList();

            if (userResults.Count == 0)
            {
                lblHighestScore.Text = "Highest Score: No quizzes yet";
                lblHighestScore.Text = "Latest Score: No quizzes yet";
                lblAverage.Text = "Average: N/A";
                lblAttempts.Text = "Attempts: 0";
                lblFavouriteTopic.Text = "Favourite Topic: Unknown";

                return;
            }

            var highest = userResults
                .OrderByDescending(r => r.Percentage)
                .First();

            var latest = userResults
                .OrderByDescending(r => r.DateTaken)
                .First();

            double average =
                userResults.Average(r => r.Percentage);

            lblHighestScore.Text =
                $"Highest Score: {highest.Score}/{highest.Total} ({highest.Percentage:F1}%)";

            lblHighestScore.Text =
                $"Latest Score: {latest.Score}/{latest.Total} ({latest.Percentage:F1}%)";

            lblAverage.Text =
                $"Average: {average:F1}%";

            lblAttempts.Text =
                $"Attempts: {userResults.Count}";
        }

        private void txbProfileEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
