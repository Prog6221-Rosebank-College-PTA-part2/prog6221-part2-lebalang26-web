namespace CyberSecurity
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            btnSend = new Button();
            txtMessageInput = new TextBox();
            btnChat = new Button();
            btnTaskAssistant = new Button();
            btnMiniGame = new Button();
            btnActivityLog = new Button();
            btnAbout = new Button();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            dtpReminder = new DateTimePicker();
            dgvTasks = new DataGridView();
            btnAddTask = new Button();
            btnDeleteTask = new Button();
            btnCompleteTask = new Button();
            lblQuestion = new Label();
            rbOptionA = new RadioButton();
            rbOptionB = new RadioButton();
            rbOptionC = new RadioButton();
            btnSubmitAnswer = new Button();
            button10 = new Button();
            button11 = new Button();
            lblFeedback = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rbOptionD = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 20);
            label1.Name = "label1";
            label1.Size = new Size(205, 20);
            label1.TabIndex = 0;
            label1.Text = "Cybersecurity Chatbot System";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(101, 80);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(400, 200);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.HotTrack;
            btnSend.ForeColor = SystemColors.ButtonHighlight;
            btnSend.Location = new Point(411, 289);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(90, 27);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessageInput
            // 
            txtMessageInput.Location = new Point(101, 286);
            txtMessageInput.Multiline = true;
            txtMessageInput.Name = "txtMessageInput";
            txtMessageInput.Size = new Size(300, 30);
            txtMessageInput.TabIndex = 2;
            // 
            // btnChat
            // 
            btnChat.BackColor = SystemColors.GrayText;
            btnChat.ForeColor = Color.White;
            btnChat.Location = new Point(20, 80);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(75, 34);
            btnChat.TabIndex = 4;
            btnChat.Text = "Chat";
            btnChat.UseVisualStyleBackColor = false;
            btnChat.Click += btnChat_Click;
            // 
            // btnTaskAssistant
            // 
            btnTaskAssistant.BackColor = SystemColors.GrayText;
            btnTaskAssistant.ForeColor = Color.White;
            btnTaskAssistant.Location = new Point(20, 120);
            btnTaskAssistant.Name = "btnTaskAssistant";
            btnTaskAssistant.Size = new Size(75, 34);
            btnTaskAssistant.TabIndex = 5;
            btnTaskAssistant.Text = "Tasks";
            btnTaskAssistant.UseVisualStyleBackColor = false;
            btnTaskAssistant.Click += btnTaskAssistant_Click;
            // 
            // btnMiniGame
            // 
            btnMiniGame.BackColor = SystemColors.GrayText;
            btnMiniGame.ForeColor = Color.White;
            btnMiniGame.Location = new Point(20, 160);
            btnMiniGame.Name = "btnMiniGame";
            btnMiniGame.Size = new Size(75, 34);
            btnMiniGame.TabIndex = 6;
            btnMiniGame.Text = "Quiz";
            btnMiniGame.UseVisualStyleBackColor = false;
            btnMiniGame.Click += btnMiniGame_Click;
            // 
            // btnActivityLog
            // 
            btnActivityLog.BackColor = SystemColors.GrayText;
            btnActivityLog.ForeColor = Color.White;
            btnActivityLog.Location = new Point(20, 200);
            btnActivityLog.Name = "btnActivityLog";
            btnActivityLog.Size = new Size(75, 34);
            btnActivityLog.TabIndex = 7;
            btnActivityLog.Text = "Log";
            btnActivityLog.UseVisualStyleBackColor = false;
            btnActivityLog.Click += btnActivityLog_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = SystemColors.GrayText;
            btnAbout.ForeColor = Color.White;
            btnAbout.Location = new Point(20, 240);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 40);
            btnAbout.TabIndex = 8;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(20, 337);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 30);
            txtTitle.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 397);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 60);
            txtDescription.TabIndex = 10;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // dtpReminder
            // 
            dtpReminder.Location = new Point(12, 506);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.Size = new Size(200, 27);
            dtpReminder.TabIndex = 11;
            dtpReminder.ValueChanged += dtpReminder_ValueChanged_1;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeight = 29;
            dgvTasks.Location = new Point(237, 337);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new Size(400, 200);
            dgvTasks.TabIndex = 12;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick_1;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.DarkGreen;
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(12, 580);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(93, 34);
            btnAddTask.TabIndex = 13;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.Red;
            btnDeleteTask.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteTask.Location = new Point(149, 580);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(109, 34);
            btnDeleteTask.TabIndex = 14;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += button7_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.BackColor = Color.FromArgb(128, 64, 0);
            btnCompleteTask.ForeColor = Color.White;
            btnCompleteTask.Location = new Point(264, 580);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(124, 34);
            btnCompleteTask.TabIndex = 15;
            btnCompleteTask.Text = "Mark Complete";
            btnCompleteTask.UseVisualStyleBackColor = false;
            btnCompleteTask.Click += button8_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.Location = new Point(150, 520);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(400, 30);
            lblQuestion.TabIndex = 16;
            // 
            // rbOptionA
            // 
            rbOptionA.Location = new Point(533, 120);
            rbOptionA.Name = "rbOptionA";
            rbOptionA.Size = new Size(104, 24);
            rbOptionA.TabIndex = 17;
            // 
            // rbOptionB
            // 
            rbOptionB.Location = new Point(533, 160);
            rbOptionB.Name = "rbOptionB";
            rbOptionB.Size = new Size(104, 24);
            rbOptionB.TabIndex = 18;
            // 
            // rbOptionC
            // 
            rbOptionC.Location = new Point(533, 200);
            rbOptionC.Name = "rbOptionC";
            rbOptionC.Size = new Size(104, 24);
            rbOptionC.TabIndex = 19;
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.BackColor = SystemColors.HotTrack;
            btnSubmitAnswer.ForeColor = Color.White;
            btnSubmitAnswer.Location = new Point(520, 282);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(99, 34);
            btnSubmitAnswer.TabIndex = 20;
            btnSubmitAnswer.Text = "Submit";
            btnSubmitAnswer.UseVisualStyleBackColor = false;
            btnSubmitAnswer.Click += button10_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkGreen;
            button10.ForeColor = Color.White;
            button10.Location = new Point(533, 580);
            button10.Name = "button10";
            button10.Size = new Size(104, 34);
            button10.TabIndex = 21;
            button10.Text = "Next";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click_1;
            // 
            // button11
            // 
            button11.BackColor = Color.DarkRed;
            button11.ForeColor = Color.White;
            button11.Location = new Point(839, 580);
            button11.Name = "button11";
            button11.Size = new Size(107, 34);
            button11.TabIndex = 22;
            button11.Text = "Clear Log";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // lblFeedback
            // 
            lblFeedback.Location = new Point(150, 680);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(300, 30);
            lblFeedback.TabIndex = 23;
            // 
            // listBox1
            // 
            listBox1.Location = new Point(695, 337);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(393, 204);
            listBox1.TabIndex = 24;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 314);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 25;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 374);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 26;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 483);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 27;
            label4.Text = "Reminder Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(758, 52);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 28;
            label5.Text = "Mini Game (Quiz)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(520, 83);
            label6.Name = "label6";
            label6.Size = new Size(506, 20);
            label6.TabIndex = 29;
            label6.Text = "Q.1. What should you do if you receive an email asking for your passwords?";
            // 
            // rbOptionD
            // 
            rbOptionD.AutoSize = true;
            rbOptionD.Location = new Point(533, 240);
            rbOptionD.Name = "rbOptionD";
            rbOptionD.Size = new Size(17, 16);
            rbOptionD.TabIndex = 30;
            rbOptionD.TabStop = true;
            rbOptionD.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.HotTrack;
            label7.ForeColor = Color.White;
            label7.Location = new Point(932, 124);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 31;
            label7.Text = "Results";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Green;
            label8.ForeColor = Color.White;
            label8.Location = new Point(932, 260);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 32;
            label8.Text = "Score";
            // 
            // Form1
            // 
            ClientSize = new Size(1100, 750);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(rbOptionD);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(txtMessageInput);
            Controls.Add(btnSend);
            Controls.Add(btnChat);
            Controls.Add(btnTaskAssistant);
            Controls.Add(btnMiniGame);
            Controls.Add(btnActivityLog);
            Controls.Add(btnAbout);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(dtpReminder);
            Controls.Add(dgvTasks);
            Controls.Add(btnAddTask);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnCompleteTask);
            Controls.Add(lblQuestion);
            Controls.Add(rbOptionA);
            Controls.Add(rbOptionB);
            Controls.Add(rbOptionC);
            Controls.Add(btnSubmitAnswer);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(lblFeedback);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "CyberSecurity System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageInput;

        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnTaskAssistant;
        private System.Windows.Forms.Button btnMiniGame;
        private System.Windows.Forms.Button btnActivityLog;
        private System.Windows.Forms.Button btnAbout;

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpReminder;

        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnCompleteTask;

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionC;

        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;

        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.ListBox listBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton rbOptionD;
        private Label label7;
        private Label label8;
    }
}