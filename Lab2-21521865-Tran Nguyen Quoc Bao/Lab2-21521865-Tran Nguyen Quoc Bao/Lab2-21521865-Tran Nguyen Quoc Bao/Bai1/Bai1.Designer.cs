namespace Lab2_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Bai1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Content = new RichTextBox();
            ReadFile = new Button();
            WriteFile = new Button();
            SuspendLayout();
            // 
            // Content
            // 
            Content.Location = new Point(259, 57);
            Content.Name = "Content";
            Content.Size = new Size(481, 342);
            Content.TabIndex = 0;
            Content.Text = "";
            // 
            // ReadFile
            // 
            ReadFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReadFile.Location = new Point(49, 126);
            ReadFile.Name = "ReadFile";
            ReadFile.Size = new Size(160, 79);
            ReadFile.TabIndex = 1;
            ReadFile.Text = "ĐỌC FILE";
            ReadFile.UseVisualStyleBackColor = true;
            ReadFile.Click += ReadFile_Click;
            // 
            // WriteFile
            // 
            WriteFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WriteFile.Location = new Point(49, 244);
            WriteFile.Name = "WriteFile";
            WriteFile.Size = new Size(160, 79);
            WriteFile.TabIndex = 2;
            WriteFile.Text = "GHI FILE";
            WriteFile.UseVisualStyleBackColor = true;
            WriteFile.Click += WriteFile_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WriteFile);
            Controls.Add(ReadFile);
            Controls.Add(Content);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox Content;
        private Button ReadFile;
        private Button WriteFile;
    }
}