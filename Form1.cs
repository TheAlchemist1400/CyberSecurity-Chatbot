using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Media;
using System.IO;
using System;

namespace WindowsFormsChatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string name = txbName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name)) 
            {
                MessageBox.Show("Please enter a valid name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form2 menu = new Form2(name);

            // Hide the current form(1) and show the new form(2)
            this.Hide();     
            menu.Show();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            try
            {
                string path = Path.Combine(System.Windows.Forms.Application.StartupPath, "Sound", "speech.wav");

                SoundPlayer player = new SoundPlayer(path);
                // Since its agreeting ensure it greets user before they can use anything
                player.PlaySync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sound error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
