namespace WindowsFormsChatApp
{
    partial class Form4
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
            this.lblChatHeader = new System.Windows.Forms.Label();
            this.rtbChatChats = new System.Windows.Forms.RichTextBox();
            this.txbChatUserInput = new System.Windows.Forms.TextBox();
            this.btnChatSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChatHeader
            // 
            this.lblChatHeader.AutoSize = true;
            this.lblChatHeader.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatHeader.Location = new System.Drawing.Point(193, 9);
            this.lblChatHeader.Name = "lblChatHeader";
            this.lblChatHeader.Size = new System.Drawing.Size(382, 67);
            this.lblChatHeader.TabIndex = 0;
            this.lblChatHeader.Text = "CYBER HAWKS CHATBOT";
            // 
            // rtbChatChats
            // 
            this.rtbChatChats.Location = new System.Drawing.Point(23, 77);
            this.rtbChatChats.Name = "rtbChatChats";
            this.rtbChatChats.Size = new System.Drawing.Size(765, 339);
            this.rtbChatChats.TabIndex = 1;
            this.rtbChatChats.Text = "";
            // 
            // txbChatUserInput
            // 
            this.txbChatUserInput.Location = new System.Drawing.Point(23, 422);
            this.txbChatUserInput.Name = "txbChatUserInput";
            this.txbChatUserInput.Size = new System.Drawing.Size(691, 22);
            this.txbChatUserInput.TabIndex = 2;
            // 
            // btnChatSend
            // 
            this.btnChatSend.BackColor = System.Drawing.Color.Lime;
            this.btnChatSend.Location = new System.Drawing.Point(721, 422);
            this.btnChatSend.Name = "btnChatSend";
            this.btnChatSend.Size = new System.Drawing.Size(67, 22);
            this.btnChatSend.TabIndex = 3;
            this.btnChatSend.Text = "SEND";
            this.btnChatSend.UseVisualStyleBackColor = false;
            this.btnChatSend.Click += new System.EventHandler(this.btnChatSend_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChatSend);
            this.Controls.Add(this.txbChatUserInput);
            this.Controls.Add(this.rtbChatChats);
            this.Controls.Add(this.lblChatHeader);
            this.Name = "Form4";
            this.Text = "CHatbot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChatHeader;
        private System.Windows.Forms.RichTextBox rtbChatChats;
        private System.Windows.Forms.TextBox txbChatUserInput;
        private System.Windows.Forms.Button btnChatSend;
    }
}