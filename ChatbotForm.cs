namespace cbot_trial
{
    public partial class ChatbotForm : Form
    {
        private readonly Chatbot _chatbot;

        public ChatbotForm()
        {
            InitializeComponent();
            _chatbot = new Chatbot();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text;
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                rtbChat.AppendText("You: " + userInput + Environment.NewLine);
                txtUserInput.Clear();

                try
                {
                    string response = await _chatbot.GetResponseAsync(userInput);
                    rtbChat.AppendText("Bot: " + response + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    rtbChat.AppendText("Bot: Sorry, something went wrong , you are not connected  " + Environment.NewLine);
                }
                finally
                {
                    rtbChat.ScrollToCaret();
                }
            }
        }
    }
}
