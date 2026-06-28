namespace WindowsFormsChatApp
{
    partial class Form6
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
            this.lblResultsHeader = new System.Windows.Forms.Label();
            this.lblResultsScore = new System.Windows.Forms.Label();
            this.lblResultsPercentage = new System.Windows.Forms.Label();
            this.lblResultsFeedback = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultsHeader
            // 
            this.lblResultsHeader.AutoSize = true;
            this.lblResultsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsHeader.Location = new System.Drawing.Point(283, 9);
            this.lblResultsHeader.Name = "lblResultsHeader";
            this.lblResultsHeader.Size = new System.Drawing.Size(160, 46);
            this.lblResultsHeader.TabIndex = 0;
            this.lblResultsHeader.Text = "Results";
            // 
            // lblResultsScore
            // 
            this.lblResultsScore.AutoSize = true;
            this.lblResultsScore.Location = new System.Drawing.Point(337, 118);
            this.lblResultsScore.Name = "lblResultsScore";
            this.lblResultsScore.Size = new System.Drawing.Size(45, 17);
            this.lblResultsScore.TabIndex = 1;
            this.lblResultsScore.Text = "Score";
            // 
            // lblResultsPercentage
            // 
            this.lblResultsPercentage.AutoSize = true;
            this.lblResultsPercentage.Location = new System.Drawing.Point(326, 176);
            this.lblResultsPercentage.Name = "lblResultsPercentage";
            this.lblResultsPercentage.Size = new System.Drawing.Size(81, 17);
            this.lblResultsPercentage.TabIndex = 2;
            this.lblResultsPercentage.Text = "Percentage";
            // 
            // lblResultsFeedback
            // 
            this.lblResultsFeedback.AutoSize = true;
            this.lblResultsFeedback.Location = new System.Drawing.Point(337, 278);
            this.lblResultsFeedback.Name = "lblResultsFeedback";
            this.lblResultsFeedback.Size = new System.Drawing.Size(70, 17);
            this.lblResultsFeedback.TabIndex = 3;
            this.lblResultsFeedback.Text = "Feedback";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(283, 379);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(143, 59);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblResultsFeedback);
            this.Controls.Add(this.lblResultsPercentage);
            this.Controls.Add(this.lblResultsScore);
            this.Controls.Add(this.lblResultsHeader);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultsHeader;
        private System.Windows.Forms.Label lblResultsScore;
        private System.Windows.Forms.Label lblResultsPercentage;
        private System.Windows.Forms.Label lblResultsFeedback;
        private System.Windows.Forms.Button btnMenu;
    }
}