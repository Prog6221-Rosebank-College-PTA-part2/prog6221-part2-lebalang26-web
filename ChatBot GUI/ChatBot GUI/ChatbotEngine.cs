using System;
using System.Collections.Generic;

namespace ChatBot_GUI
{
    public class ChatbotEngine
    {
        // Delegate requirement
        public delegate string ResponseHandler(string input);

        private Dictionary<string, List<string>> responses;

        private List<string> worriedWords;

        private Random random;

        private string userName = "";

        private string favouriteTopic = "";

        private string lastTopic = "";

        public ChatbotEngine()
        {
            random = new Random();

            responses = new Dictionary<string, List<string>>();

            // Password Responses
            responses["password"] = new List<string>()
            {
                "Use strong and unique passwords for each account.",
                "Avoid using personal details in passwords.",
                "Use a password manager to store passwords safely.",
                "Enable multi-factor authentication for better security."
            };

            // Phishing Responses
            responses["phishing"] = new List<string>()
            {
                "Never click suspicious email links.",
                "Scammers often pretend to be trusted organisations.",
                "Check sender email addresses carefully.",
                "Avoid downloading attachments from unknown emails."
            };

            // Privacy Responses
            responses["privacy"] = new List<string>()
            {
                "Review your privacy settings regularly.",
                "Avoid sharing personal information online.",
                "Use two-factor authentication to improve account security.",
                "Limit what you post on social media platforms."
            };

            // Safe Browsing Responses
            responses["safe browsing"] = new List<string>()
            {
                "Always visit websites using HTTPS.",
                "Keep your browser updated.",
                "Avoid downloading files from unknown websites.",
                "Do not save passwords on public computers."
            };

            // Malware Responses
            responses["malware"] = new List<string>()
            {
                "Install trusted antivirus software.",
                "Do not install unknown programs.",
                "Keep your operating system updated.",
                "Scan USB devices before opening files."
            };

            worriedWords = new List<string>()
            {
                "worried",
                "afraid",
                "scared",
                "frustrated",
                "nervous"
            };
        }

        public string GetResponse(string input)
        {
            input = input.ToLower();

            // MEMORY FEATURE
            if (input.Contains("my name is"))
            {
                string[] words = input.Split(' ');

                userName = words[words.Length - 1];

                return $"Nice to meet you {userName}!";
            }

            // MEMORY FEATURE
            if (input.Contains("i like privacy"))
            {
                favouriteTopic = "privacy";

                return "Great! I will remember that you are interested in privacy.";
            }

            // SENTIMENT DETECTION
            foreach (string word in worriedWords)
            {
                if (input.Contains(word))
                {
                    return "It is understandable to feel worried about online scams. Always avoid suspicious links and verify websites before entering personal information.";
                }
            }

            // CONVERSATION FLOW
            if (input.Contains("tell me more") ||
                input.Contains("another tip") ||
                input.Contains("explain more"))
            {
                if (lastTopic != "")
                {
                    return GetRandomResponse(lastTopic);
                }
            }

            // KEYWORD RECOGNITION
            foreach (var keyword in responses.Keys)
            {
                if (input.Contains(keyword))
                {
                    lastTopic = keyword;

                    return GetRandomResponse(keyword);
                }
            }

            // PERSONALIZED RESPONSE
            if (favouriteTopic != "")
            {
                return $"{userName}, since you are interested in {favouriteTopic}, remember to keep your accounts secure.";
            }

            // GREETINGS
            if (input.Contains("hello") || input.Contains("hi"))
            {
                return "Hello! Ask me anything about cybersecurity.";
            }

            // DEFAULT RESPONSE
            return "I am not sure I understand. Can you try rephrasing?";
        }

        private string GetRandomResponse(string keyword)
        {
            List<string> possibleResponses = responses[keyword];

            int index = random.Next(possibleResponses.Count);

            return possibleResponses[index];
        }
    }
}