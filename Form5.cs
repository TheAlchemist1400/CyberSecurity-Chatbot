using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using WindowsFormsChatApp.Models;

namespace WindowsFormsChatApp
{
    public partial class Form5 : Form
    {
        private string username;
        private List< quizQuestions > questions;
        private int currentIndex = 0;
        private int score = 0;

        public Form5(String userName)
        {
            InitializeComponent();
            username = userName;

            LoadQuestions();
            ShowQuestion();


        }
        private void LoadQuestions()
        {
            string path = Path.Combine(
                System.Windows.Forms.Application.StartupPath,
                "Data",
                "quiz.json"
            );

            if (!File.Exists(path))
            {
                MessageBox.Show("Quiz file not found!");
                return;
            }

            string json = File.ReadAllText(path);
            questions = JsonSerializer.Deserialize<List<quizQuestions>>(json);

            if (questions == null)
            {
                MessageBox.Show("Failed to load quiz data.");
                questions = new List<quizQuestions>();
            }
        }

        private void ShowQuestion()
        {
            if (questions == null || questions.Count == 0)
            {
                MessageBox.Show("No quiz questions loaded.");
                return;
            }

            if (currentIndex < questions.Count)
            {
                lblQuizQuestion.Text = questions[currentIndex].Question;
                rbtnQuizTrue.Checked = false;
                rbtnQuizFalse.Checked = false;
            }
            else
            {
                ShowResult();
            }
        }

        private void btnQuizNext_Click(object sender, EventArgs e)
        {
            if (!rbtnQuizTrue.Checked && !rbtnQuizFalse.Checked)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            bool selectedAnswer = rbtnQuizTrue.Checked;
            bool correctAnswer = questions[currentIndex].Answer;

            if (selectedAnswer == correctAnswer)
                score++;

            currentIndex++;
            ShowQuestion();
        }

        private void ShowResult()
        {
            int total = questions.Count;
            double percentage = ((double)score / total) * 100;

            MessageBox.Show(
                $"Quiz completed!\n\n" +
                $"Score: {score}/{total}\n" +
                $"Percentage: {percentage:F2}%");
        }
    }

}
