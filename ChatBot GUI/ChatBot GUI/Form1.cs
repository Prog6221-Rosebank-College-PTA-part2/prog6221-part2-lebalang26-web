
using System;
using System.Speech.Synthesis;

namespace ChatBot_GUI
{
    public partial class Form1 : Form
    {
        private ChatbotEngine bot;

        private SpeechSynthesizer speaker;

        public Form1()
        {
            InitializeComponent();

            bot = new ChatbotEngine();

            speaker = new SpeechSynthesizer();

            rtbAscii.Text = Assets.GetAsciiArt();

            Assets.PlayGreeting();

            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string userInput = textBox1.Text.Trim();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    return;
                }

                // Show user message
                textBox2.AppendText("You: " + userInput + Environment.NewLine);

                // Delegate usage
                ChatbotEngine.ResponseHandler handler = bot.GetResponse;

                string response = handler(userInput);

                // Show bot response
                textBox2.AppendText("Bot: " + response + Environment.NewLine + Environment.NewLine);

                // Voice output
                speaker.SpeakAsync(response);

                // Clear input
                textBox1.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cybersecurity Awareness Chatbot");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
