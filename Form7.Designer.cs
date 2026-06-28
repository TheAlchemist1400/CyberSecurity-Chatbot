namespace WindowsFormsChatApp
{
    partial class Form7
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
            this.lblToDoListHeader = new System.Windows.Forms.Label();
            this.txbTask = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnToDoListAdd = new System.Windows.Forms.Button();
            this.txbTaskList = new System.Windows.Forms.ListBox();
            this.btnToDoListMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblToDoListHeader
            // 
            this.lblToDoListHeader.AutoSize = true;
            this.lblToDoListHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDoListHeader.Location = new System.Drawing.Point(253, 9);
            this.lblToDoListHeader.Name = "lblToDoListHeader";
            this.lblToDoListHeader.Size = new System.Drawing.Size(239, 39);
            this.lblToDoListHeader.TabIndex = 0;
            this.lblToDoListHeader.Text = "My To Do List";
            // 
            // txbTask
            // 
            this.txbTask.Location = new System.Drawing.Point(42, 87);
            this.txbTask.Name = "txbTask";
            this.txbTask.Size = new System.Drawing.Size(618, 22);
            this.txbTask.TabIndex = 1;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Lime;
            this.btnComplete.Location = new System.Drawing.Point(42, 383);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(176, 38);
            this.btnComplete.TabIndex = 3;
            this.btnComplete.Text = "COMPLETE";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(253, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnToDoListAdd
            // 
            this.btnToDoListAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToDoListAdd.Location = new System.Drawing.Point(666, 87);
            this.btnToDoListAdd.Name = "btnToDoListAdd";
            this.btnToDoListAdd.Size = new System.Drawing.Size(63, 28);
            this.btnToDoListAdd.TabIndex = 5;
            this.btnToDoListAdd.Text = "+ ADD";
            this.btnToDoListAdd.UseVisualStyleBackColor = false;
            this.btnToDoListAdd.Click += new System.EventHandler(this.btnToDoListAdd_Click);
            // 
            // txbTaskList
            // 
            this.txbTaskList.FormattingEnabled = true;
            this.txbTaskList.ItemHeight = 16;
            this.txbTaskList.Location = new System.Drawing.Point(44, 127);
            this.txbTaskList.Name = "txbTaskList";
            this.txbTaskList.Size = new System.Drawing.Size(613, 228);
            this.txbTaskList.TabIndex = 6;
            // 
            // btnToDoListMenu
            // 
            this.btnToDoListMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToDoListMenu.Location = new System.Drawing.Point(570, 383);
            this.btnToDoListMenu.Name = "btnToDoListMenu";
            this.btnToDoListMenu.Size = new System.Drawing.Size(90, 38);
            this.btnToDoListMenu.TabIndex = 7;
            this.btnToDoListMenu.Text = "MENU";
            this.btnToDoListMenu.UseVisualStyleBackColor = false;
            this.btnToDoListMenu.Click += new System.EventHandler(this.btnToDoListMenu_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToDoListMenu);
            this.Controls.Add(this.txbTaskList);
            this.Controls.Add(this.btnToDoListAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txbTask);
            this.Controls.Add(this.lblToDoListHeader);
            this.Name = "Form7";
            this.Text = "ToDoList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToDoListHeader;
        private System.Windows.Forms.TextBox txbTask;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnToDoListAdd;
        private System.Windows.Forms.ListBox txbTaskList;
        private System.Windows.Forms.Button btnToDoListMenu;
    }
}