namespace ApplicationChat
{
    partial class Server
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
            button1 = new Button();
            SuspendLayout();
            // 
            // ListMessage
            // 
            ListMessage.FormattingEnabled = true;
            ListMessage.ItemHeight = 20;
            ListMessage.Location = new Point(12, 27);
            ListMessage.Name = "ListMessage";
            ListMessage.Size = new Size(510, 224);
            ListMessage.TabIndex = 0;
            // 
            // EnterMessage
            // 
            EnterMessage.Location = new Point(12, 273);
            EnterMessage.Multiline = true;
            EnterMessage.Name = "EnterMessage";
            EnterMessage.Size = new Size(338, 126);
            EnterMessage.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(368, 273);
            button1.Name = "button1";
            button1.Size = new Size(154, 126);
            button1.TabIndex = 2;
            button1.Text = "SEND";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 425);
            Controls.Add(button1);
            Controls.Add(EnterMessage);
            Controls.Add(ListMessage);
            Name = "Server";
            Text = "Server";
            FormClosing += Server_FormClosing;
            Load += Server_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListMessage;
        private TextBox EnterMessage;
        private Button button1;
    }
}