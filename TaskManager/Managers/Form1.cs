using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Managers
{
    public partial class Form1 : Form
    {
        private string connectionString =
            @"Server=(localdb)\MSSQLLocalDB;
            Initial Catalog=TaskManager;
            Integrated Security=True";

        private List<string> activityLog = new List<string>();

        public Form1()
        {
            InitializeComponent();

            button1.Click += button1_Click; // ensure event wired
        }

        // ================= SEND BUTTON (NLP CHAT) =================
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.ToLower().Trim();

            listBox1.Items.Add("User: " + textBox1.Text);

            if (input.Contains("add task"))
            {
                AddTask(textBox1.Text);
            }
            else if (input.Contains("show tasks"))
            {
                LoadTasks();
            }
            else if (input.Contains("delete"))
            {
                DeleteFirstTask();
            }
            else if (input.Contains("log"))
            {
                ShowLog();
            }
            else
            {
                listBox1.Items.Add("Bot: Try 'add task', 'show tasks', 'log'");
            }

            textBox1.Clear();
        }

        // ================= ADD TASK =================
        private void AddTask(string input)
        {
            string title = input.Replace("add task", "").Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Tasks(Title, Description, Status) VALUES(@t,@d,'Pending')";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@t", title);
                cmd.Parameters.AddWithValue("@d", title);

                cmd.ExecuteNonQuery();
            }

            listBox2.Items.Add("Task: " + title);
            listBox1.Items.Add("Bot: Task added → " + title);

            Log("Task added: " + title);
        }

        // ================= LOAD TASKS =================
        private void LoadTasks()
        {
            listBox2.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Tasks";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listBox2.Items.Add(
                        $"ID:{reader["Id"]} | {reader["Title"]} | {reader["Status"]}"
                    );
                }
            }

            listBox1.Items.Add("Bot: Tasks loaded");
            Log("Tasks loaded");
        }

        // ================= DELETE FIRST TASK (SIMPLE SAFE VERSION) =================
        private void DeleteFirstTask()
        {
            if (listBox2.Items.Count == 0)
            {
                listBox1.Items.Add("Bot: No tasks to delete");
                return;
            }

            string firstItem = listBox2.Items[0].ToString();

            int idStart = firstItem.IndexOf("ID:") + 3;
            int idEnd = firstItem.IndexOf("|");

            string id = firstItem.Substring(idStart, idEnd - idStart).Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Tasks WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            listBox2.Items.RemoveAt(0);

            listBox1.Items.Add("Bot: First task deleted");
            Log("Task deleted ID: " + id);
        }

        // ================= ACTIVITY LOG =================
        private void Log(string action)
        {
            activityLog.Add(DateTime.Now + " - " + action);

            if (activityLog.Count > 50)
                activityLog.RemoveAt(0);
        }

        private void ShowLog()
        {
            listBox1.Items.Add("=== ACTIVITY LOG ===");

            int start = Math.Max(0, activityLog.Count - 10);

            for (int i = start; i < activityLog.Count; i++)
                listBox1.Items.Add(activityLog[i]);
        }
    }
}