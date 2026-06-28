namespace WindowsFormsChatApp
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lblQuizHeader = new System.Windows.Forms.Label();
            this.lblQuizQuestion = new System.Windows.Forms.Label();
            this.rbtnQuizTrue = new System.Windows.Forms.RadioButton();
            this.rbtnQuizFalse = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnQuizNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuizHeader
            // 
            this.lblQuizHeader.AutoSize = true;
            this.lblQuizHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizHeader.Location = new System.Drawing.Point(299, 9);
            this.lblQuizHeader.Name = "lblQuizHeader";
            this.lblQuizHeader.Size = new System.Drawing.Size(128, 51);
            this.lblQuizHeader.TabIndex = 0;
            this.lblQuizHeader.Text = "QUIZ";
            // 
            // lblQuizQuestion
            // 
            this.lblQuizQuestion.AutoSize = true;
            this.lblQuizQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizQuestion.Location = new System.Drawing.Point(53, 114);
            this.lblQuizQuestion.Name = "lblQuizQuestion";
            this.lblQuizQuestion.Size = new System.Drawing.Size(118, 29);
            this.lblQuizQuestion.TabIndex = 1;
            this.lblQuizQuestion.Text = "Question";
            this.lblQuizQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtnQuizTrue
            // 
            this.rbtnQuizTrue.AutoSize = true;
            this.rbtnQuizTrue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnQuizTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnQuizTrue.ForeColor = System.Drawing.Color.Blue;
            this.rbtnQuizTrue.Location = new System.Drawing.Point(603, 231);
            this.rbtnQuizTrue.Name = "rbtnQuizTrue";
            this.rbtnQuizTrue.Size = new System.Drawing.Size(112, 36);
            this.rbtnQuizTrue.TabIndex = 2;
            this.rbtnQuizTrue.TabStop = true;
            this.rbtnQuizTrue.Text = "TRUE";
            this.rbtnQuizTrue.UseVisualStyleBackColor = false;
            // 
            // rbtnQuizFalse
            // 
            this.rbtnQuizFalse.AutoSize = true;
            this.rbtnQuizFalse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnQuizFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnQuizFalse.ForeColor = System.Drawing.Color.Blue;
            this.rbtnQuizFalse.Location = new System.Drawing.Point(603, 147);
            this.rbtnQuizFalse.Name = "rbtnQuizFalse";
            this.rbtnQuizFalse.Size = new System.Drawing.Size(126, 36);
            this.rbtnQuizFalse.TabIndex = 3;
            this.rbtnQuizFalse.TabStop = true;
            this.rbtnQuizFalse.Text = "FALSE";
            this.rbtnQuizFalse.UseVisualStyleBackColor = false;
            // 
            // btnQuizNext
            // 
            this.btnQuizNext.Location = new System.Drawing.Point(309, 387);
            this.btnQuizNext.Name = "btnQuizNext";
            this.btnQuizNext.Size = new System.Drawing.Size(118, 34);
            this.btnQuizNext.TabIndex = 4;
            this.btnQuizNext.Text = "NEXT";
            this.btnQuizNext.UseVisualStyleBackColor = true;
            this.btnQuizNext.Click += new System.EventHandler(this.btnQuizNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(457, 387);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(117, 34);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnQuizNext);
            this.Controls.Add(this.rbtnQuizFalse);
            this.Controls.Add(this.rbtnQuizTrue);
            this.Controls.Add(this.lblQuizQuestion);
            this.Controls.Add(this.lblQuizHeader);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuizHeader;
        private System.Windows.Forms.Label lblQuizQuestion;
        private System.Windows.Forms.RadioButton rbtnQuizTrue;
        private System.Windows.Forms.RadioButton rbtnQuizFalse;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnQuizNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
    }
}