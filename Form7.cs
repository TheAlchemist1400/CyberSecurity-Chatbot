using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsChatApp
{
    public partial class Form7 : Form
    {
        private string userName;
        private List<TaskItem> tasks = new List<TaskItem>();
        public Form7(String userName)
        {
            InitializeComponent();
            this.userName = userName;
            tasks = JsonStorage.Load<TaskItem>("Data/tasks.json");

            foreach (TaskItem task in tasks)
            {
                txbTaskList.Items.Add(
                    task.Completed
                    ? task.Task + " ✓"
                    : task.Task);
            }
        }

        private void btnToDoListAdd_Click(object sender, EventArgs e)
        {
            String task = txbTask.Text.Trim();

            if(!string.IsNullOrEmpty(task)) 
            {
                // Save the task to the list and JSON file
                tasks.Add(new TaskItem { Task = task, Completed = false });
                JsonStorage.Save("Data/tasks.json", tasks);

                txbTaskList.Items.Add(task);
                // clear the txbTask
                txbTask.Clear();
                txbTask.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a task.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbTaskList.SelectedItem != null)
            {
                txbTaskList.Items.Remove(txbTaskList.SelectedItem);

                // Remove the task from the list and JSON file
                tasks.RemoveAt(txbTaskList.SelectedIndex);
                JsonStorage.Save("Data/tasks.json", tasks);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (txbTaskList.SelectedItem != null)
            {
                int index = txbTaskList.SelectedIndex;
                string task = txbTaskList.SelectedItem.ToString();
                txbTaskList.Items[index] = task + " ✓ ";

                // Mark the task as completed in the list and JSON file
                tasks[index].Completed = true;
                JsonStorage.Save("Data/tasks.json", tasks);
            }
            else
            {
                MessageBox.Show("Please select a task to mark as complete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnToDoListMenu_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2(userName);
            this.Hide();
            menu.Show();
        }
    }
}
