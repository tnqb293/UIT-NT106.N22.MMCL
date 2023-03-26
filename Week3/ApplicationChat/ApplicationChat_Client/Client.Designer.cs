namespace ApplicationChat_Client
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListMessage = new ListBox();
            EnterMessage = new TextBox();
            SendMessage = new Button();
            SuspendLayout();
            // 
            // ListMessage
            // 
            ListMessage.FormattingEnabled = true;
            ListMessage.ItemHeight = 20;
            ListMessage.Location = new Point(12, 27);
            ListMessage.Name = "ListMessage";
            ListMessage.Size = new Size(510, 224);
            ListMessage.TabIndex = 1;
            // 
            // EnterMessage
            // 
            EnterMessage.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EnterMessage.Location = new Point(12, 273);
            EnterMessage.Multiline = true;
            EnterMessage.Name = "EnterMessage";
            EnterMessage.Size = new Size(338, 126);
            EnterMessage.TabIndex = 2;
            // 
            // SendMessage
            // 
            SendMessage.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SendMessage.Location = new Point(368, 273);
            SendMessage.Name = "SendMessage";
            SendMessage.Size = new Size(154, 126);
            SendMessage.TabIndex = 3;
            SendMessage.Text = "SEND";
            SendMessage.UseVisualStyleBackColor = true;
            SendMessage.Click += SendMessage_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 425);
            Controls.Add(SendMessage);
            Controls.Add(EnterMessage);
            Controls.Add(ListMessage);
            Name = "Client";
            Text = "Client";
            
            Load += Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        
        private ListBox ListMessage;
        private TextBox EnterMessage;
        private Button SendMessage;
    }
}