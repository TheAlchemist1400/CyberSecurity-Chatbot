namespace WindowsFormsChatApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bgdPicture = new System.Windows.Forms.PictureBox();
            this.btnChatbot = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnToDoList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bgdPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bgdPicture
            // 
            this.bgdPicture.Image = ((System.Drawing.Image)(resources.GetObject("bgdPicture.Image")));
            this.bgdPicture.Location = new System.Drawing.Point(0, 0);
            this.bgdPicture.Name = "bgdPicture";
            this.bgdPicture.Size = new System.Drawing.Size(759, 451);
            this.bgdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgdPicture.TabIndex = 0;
            this.bgdPicture.TabStop = false;
            // 
            // btnChatbot
            // 
            this.btnChatbot.Location = new System.Drawing.Point(210, 263);
            this.btnChatbot.Name = "btnChatbot";
            this.btnChatbot.Size = new System.Drawing.Size(80, 27);
            this.btnChatbot.TabIndex = 1;
            this.btnChatbot.Text = "Chatbot";
            this.btnChatbot.UseVisualStyleBackColor = true;
            this.btnChatbot.Click += new System.EventHandler(this.btnChatbot_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.Location = new System.Drawing.Point(464, 247);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(80, 27);
            this.btnQuiz.TabIndex = 2;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = true;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(553, 171);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(80, 27);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(340, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(54, 232);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(80, 27);
            this.btnResults.TabIndex = 5;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnToDoList
            // 
            this.btnToDoList.Location = new System.Drawing.Point(153, 171);
            this.btnToDoList.Name = "btnToDoList";
            this.btnToDoList.Size = new System.Drawing.Size(80, 27);
            this.btnToDoList.TabIndex = 6;
            this.btnToDoList.Text = "ToDoList";
            this.btnToDoList.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.btnToDoList);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.btnChatbot);
            this.Controls.Add(this.bgdPicture);
            this.Name = "Form2";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.bgdPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bgdPicture;
        private System.Windows.Forms.Button btnChatbot;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnToDoList;
    }
}