namespace WindowsFormsChatApp
{
    partial class Form3
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
            this.btnUploadProfile = new System.Windows.Forms.Button();
            this.txbProfileName = new System.Windows.Forms.TextBox();
            this.RbtnUploadProfileTrue = new System.Windows.Forms.RadioButton();
            this.RbtnUploadProfileFalse = new System.Windows.Forms.RadioButton();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileHeader = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txbProfileEmail = new System.Windows.Forms.TextBox();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblFavouriteTopic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadProfile
            // 
            this.btnUploadProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUploadProfile.Location = new System.Drawing.Point(611, 393);
            this.btnUploadProfile.Name = "btnUploadProfile";
            this.btnUploadProfile.Size = new System.Drawing.Size(163, 45);
            this.btnUploadProfile.TabIndex = 0;
            this.btnUploadProfile.Text = "UPLOAD";
            this.btnUploadProfile.UseVisualStyleBackColor = false;
            // 
            // txbProfileName
            // 
            this.txbProfileName.Location = new System.Drawing.Point(114, 165);
            this.txbProfileName.Name = "txbProfileName";
            this.txbProfileName.Size = new System.Drawing.Size(242, 22);
            this.txbProfileName.TabIndex = 1;
            // 
            // RbtnUploadProfileTrue
            // 
            this.RbtnUploadProfileTrue.AutoSize = true;
            this.RbtnUploadProfileTrue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RbtnUploadProfileTrue.Location = new System.Drawing.Point(17, 418);
            this.RbtnUploadProfileTrue.Name = "RbtnUploadProfileTrue";
            this.RbtnUploadProfileTrue.Size = new System.Drawing.Size(67, 21);
            this.RbtnUploadProfileTrue.TabIndex = 2;
            this.RbtnUploadProfileTrue.TabStop = true;
            this.RbtnUploadProfileTrue.Text = "TRUE";
            this.RbtnUploadProfileTrue.UseVisualStyleBackColor = false;
            // 
            // RbtnUploadProfileFalse
            // 
            this.RbtnUploadProfileFalse.AutoSize = true;
            this.RbtnUploadProfileFalse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RbtnUploadProfileFalse.Location = new System.Drawing.Point(134, 418);
            this.RbtnUploadProfileFalse.Name = "RbtnUploadProfileFalse";
            this.RbtnUploadProfileFalse.Size = new System.Drawing.Size(72, 21);
            this.RbtnUploadProfileFalse.TabIndex = 3;
            this.RbtnUploadProfileFalse.TabStop = true;
            this.RbtnUploadProfileFalse.Text = "FALSE";
            this.RbtnUploadProfileFalse.UseVisualStyleBackColor = false;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.Location = new System.Drawing.Point(12, 158);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(96, 29);
            this.lblProfileName.TabIndex = 4;
            this.lblProfileName.Text = "Name :";
            // 
            // lblProfileHeader
            // 
            this.lblProfileHeader.AutoSize = true;
            this.lblProfileHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProfileHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProfileHeader.Location = new System.Drawing.Point(260, 38);
            this.lblProfileHeader.Name = "lblProfileHeader";
            this.lblProfileHeader.Size = new System.Drawing.Size(292, 51);
            this.lblProfileHeader.TabIndex = 5;
            this.lblProfileHeader.Text = "MY PROFILE";
            this.lblProfileHeader.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(12, 208);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(123, 29);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "Average :";
            // 
            // txbProfileEmail
            // 
            this.txbProfileEmail.Location = new System.Drawing.Point(141, 215);
            this.txbProfileEmail.Name = "txbProfileEmail";
            this.txbProfileEmail.Size = new System.Drawing.Size(242, 22);
            this.txbProfileEmail.TabIndex = 6;
            this.txbProfileEmail.TextChanged += new System.EventHandler(this.txbProfileEmail_TextChanged);
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.AutoSize = true;
            this.lblHighestScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHighestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestScore.Location = new System.Drawing.Point(14, 256);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(192, 29);
            this.lblHighestScore.TabIndex = 8;
            this.lblHighestScore.Text = "Highest Score :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(-1, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(802, 51);
            this.label2.TabIndex = 9;
            this.label2.Text = "==============================";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(8, -5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(802, 51);
            this.label3.TabIndex = 10;
            this.label3.Text = "==============================";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::WindowsFormsChatApp.Properties.Resources.cyberSecurity;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempts.Location = new System.Drawing.Point(14, 306);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(128, 29);
            this.lblAttempts.TabIndex = 12;
            this.lblAttempts.Text = "Attempts :";
            // 
            // lblFavouriteTopic
            // 
            this.lblFavouriteTopic.AutoSize = true;
            this.lblFavouriteTopic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFavouriteTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavouriteTopic.Location = new System.Drawing.Point(12, 355);
            this.lblFavouriteTopic.Name = "lblFavouriteTopic";
            this.lblFavouriteTopic.Size = new System.Drawing.Size(210, 29);
            this.lblFavouriteTopic.TabIndex = 13;
            this.lblFavouriteTopic.Text = "Favourite Topic :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFavouriteTopic);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHighestScore);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.txbProfileEmail);
            this.Controls.Add(this.lblProfileHeader);
            this.Controls.Add(this.lblProfileName);
            this.Controls.Add(this.RbtnUploadProfileFalse);
            this.Controls.Add(this.RbtnUploadProfileTrue);
            this.Controls.Add(this.txbProfileName);
            this.Controls.Add(this.btnUploadProfile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadProfile;
        private System.Windows.Forms.TextBox txbProfileName;
        private System.Windows.Forms.RadioButton RbtnUploadProfileTrue;
        private System.Windows.Forms.RadioButton RbtnUploadProfileFalse;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileHeader;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txbProfileEmail;
        private System.Windows.Forms.Label lblHighestScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label lblFavouriteTopic;
    }
}