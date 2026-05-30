
namespace ChatBot_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            rtbAscii = new RichTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            Background = new Panel();
            button2 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(rtbAscii);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(Background);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 700);
            panel1.TabIndex = 0;
            // 
            // rtbAscii
            // 
            rtbAscii.BackColor = Color.Black;
            rtbAscii.Font = new Font("Consolas", 8F, FontStyle.Bold);
            rtbAscii.ForeColor = Color.Lime;
            rtbAscii.Location = new Point(20, 112);
            rtbAscii.Name = "rtbAscii";
            rtbAscii.ReadOnly = true;
            rtbAscii.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbAscii.Size = new Size(750, 127);
            rtbAscii.TabIndex = 0;
            rtbAscii.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 240);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(750, 300);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 580);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(620, 105);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(660, 580);
            button1.Name = "button1";
            button1.Size = new Size(110, 60);
            button1.TabIndex = 3;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.ForeColor = Color.White;
            button3.Location = new Point(660, 650);
            button3.Name = "button3";
            button3.Size = new Size(110, 35);
            button3.TabIndex = 4;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Background
            // 
            Background.BackColor = Color.RoyalBlue;
            Background.Controls.Add(button2);
            Background.Controls.Add(label1);
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Size = new Size(800, 106);
            Background.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(12, 3);
            button2.Name = "button2";
            button2.Size = new Size(121, 97);
            button2.TabIndex = 0;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 35);
            label1.Name = "label1";
            label1.Size = new Size(332, 41);
            label1.TabIndex = 1;
            label1.Text = "Cybersecurity Chatbot";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 700);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Cybersecurity Awareness Chatbot";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Background.ResumeLayout(false);
            Background.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Background;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox rtbAscii;
    }
}



