namespace cbot_trial
{
    partial class ChatbotForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbChat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            
            
            this.txtUserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserInput.Location = new System.Drawing.Point(12, 329);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(576, 23);
            this.txtUserInput.TabIndex = 0;
            
            
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(594, 329);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
       
            this.rtbChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbChat.Location = new System.Drawing.Point(12, 12);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbChat.Size = new System.Drawing.Size(657, 304);
            this.rtbChat.TabIndex = 2;
            this.rtbChat.Text = "";
            
         
            this.ClientSize = new System.Drawing.Size(681, 364);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserInput);
            this.Name = "ChatbotForm";
            this.Text = "PromptPal";
            this.MaximumSize = new System.Drawing.Size(700, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 600); 
            this.ResumeLayout(false);
            this.PerformLayout();

        
            this.BackgroundImage = System.Drawing.Image.FromFile("images/chatbotimg.jpg");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
