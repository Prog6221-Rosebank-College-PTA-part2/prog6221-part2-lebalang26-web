using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CyberSecurity
{
    public partial class Form1 : Form
    {
        // ================= DATABASE =================
        private readonly string connectionString =
            @"Server=(localdb)\MSSQLLocalDB;
              Initial Catalog=CyberTasks;
              Integrated Security=True";

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTasks.CurrentRow != null)
            {
                txtTitle.Text = dgvTasks.CurrentRow.Cells["Title"].Value?.ToString();
                txtDescription.Text = dgvTasks.CurrentRow.Cells["Description"].Value?.ToString();
            }
        }

        // ================= CHATBOT =================
        private readonly Dictionary<string, string> botResponses = new Dictionary<string, string>
        {
            { "phishing", "Never click suspicious links. Always verify sender identity." },
            { "password", "Use strong passwords with letters, numbers, and symbols." },
            { "2fa", "Enable two-factor authentication for extra security." },
            { "malware", "Install updated antivirus software." },
            { "update", "Keep your system and apps updated regularly." }
        };

        // ================= QUIZ =================
        private readonly List<string> questions = new List<string>
        {
            "What is phishing?",
            "What is 2FA?",
            "What is malware?"
        };

        private readonly List<string[]> options = new List<string[]>
        {
             new[] { "Fake email attack", "Firewall", "Browser", "VPN" },
             new[] { "Two passwords", "Two-factor authentication", "Backup", "Antivirus" },
             new[] { "Software update", "Malicious software", "Cloud storage", "Encryption" }
        };

        private readonly List<int> answers = new List<int> { 0, 1, 1 };

        private int currentQuestion = 0;
        private int score = 0;

        // ================= FORM =================
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("System started");
            LoadTasks();
            LoadQuestion();

            label7.Text = "";
            label8.Text = "Score: 0/" + questions.Count;
        }

        // =====================================================
        // ================= CHATBOT ============================
        // =====================================================

        

        // =====================================================
        // ================= TASKS (SQL) ========================
        // =====================================================

        private void LoadTasks()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Bot";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvTasks.DataSource = dt;
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtMessageInput.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(input))
                return;

            richTextBox1.AppendText($"You: {input}\n");

            if (botResponses.ContainsKey(input))
            {
                richTextBox1.AppendText($"Bot: {botResponses[input]}\n\n");
            }
            else
            {
                richTextBox1.AppendText("Bot: I am not sure, stay safe online.\n\n");
            }

            txtMessageInput.Clear(); // IMPORTANT FIX
        }

        private void AddTask()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            INSERT INTO Bot (Title, Description, ReminderDate)
            VALUES (@t, @d, @r)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@t", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@d", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@r", dtpReminder.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            LoadTasks();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTask();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvTasks.CurrentRow.Cells["ID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Bot WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Task deleted successfully.");

            LoadTasks();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mark Complete clicked");
        }

        // =====================================================
        // ================= QUIZ ===============================
        // =====================================================

        private void LoadQuestion()
        {
            if (currentQuestion >= questions.Count)
                return;

            label6.Text = questions[currentQuestion];

            rbOptionA.Text = options[currentQuestion][0];
            rbOptionB.Text = options[currentQuestion][1];
            rbOptionC.Text = options[currentQuestion][2];
            rbOptionD.Text = options[currentQuestion][3];

            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;

            label8.Text = $"Score: {score}/{questions.Count}";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            // Check if quiz has already finished
            if (currentQuestion >= questions.Count)
            {
                MessageBox.Show("The quiz has already finished.");
                return;
            }

            // Determine selected answer
            int selected = -1;

            if (rbOptionA.Checked)
                selected = 0;
            else if (rbOptionB.Checked)
                selected = 1;
            else if (rbOptionC.Checked)
                selected = 2;
            else if (rbOptionD.Checked)
                selected = 3;

            // No answer selected
            if (answers == null || currentQuestion < 0 || currentQuestion >= answers.Count)
            {
                MessageBox.Show("Answer data is missing or out of range.");
                return;
            }

            // Check answer
            if (selected == answers[currentQuestion])
            {
                score++;
                label7.Text = "✅ Correct!";
            }
            else
            {
                label7.Text = "❌ Incorrect!";
            }

            // Update score
            label8.Text = $"Score: {score}/{questions.Count}";

            // Move to next question
            currentQuestion++;

            // Check if quiz is finished
            if (currentQuestion >= questions.Count)
            {
                label6.Text = "🎉 Quiz Completed!";
                label7.Text = $"Final Result: {score} out of {questions.Count}";
                label8.Text = $"Final Score: {score}/{questions.Count}";

                // Disable quiz controls
                rbOptionA.Enabled = false;
                rbOptionB.Enabled = false;
                rbOptionC.Enabled = false;
                rbOptionD.Enabled = false;
                button10.Enabled = false;

                return;
            }

            // Load next question
            LoadQuestion();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        // =====================================================
        // ================= NAV BUTTONS ========================
        // =====================================================

        private void btnChat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Chat opened");
        }

        private void btnBotAssistant_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bot Assistant opened");
        }

        private void btnMiniGame_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Quiz opened");
        }

        private void btnActivityLog_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Activity Log opened");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("About opened");
        }
        private void btnTaskAssistant_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Task Assistant opened");
        }

        // =====================================================
        // ================= EMPTY EVENTS =======================
        // =====================================================

        private void dgvBots_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtMessageInput_TextChanged(object sender, EventArgs e) { }
        private void txtTitle_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void dtpReminder_ValueChanged(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void rbOptionA_CheckedChanged(object sender, EventArgs e) { }
        private void rbOptionB_CheckedChanged(object sender, EventArgs e) { }
        private void rbOptionC_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void lblQuestion_Click(object sender, EventArgs e) { }
        private void lblFeedback_Click(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void dtpReminder_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvTasks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}