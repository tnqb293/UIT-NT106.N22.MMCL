namespace Lab2_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Bai2
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
            ReadFile = new Button();
            Content = new RichTextBox();
            FileName = new TextBox();
            Size = new TextBox();
            URL = new TextBox();
            LineCount = new TextBox();
            WordsCount = new TextBox();
            CharacterCount = new TextBox();
            Exit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // ReadFile
            // 
            ReadFile.BackColor = SystemColors.Info;
            ReadFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReadFile.Location = new Point(106, 30);
            ReadFile.Name = "ReadFile";
            ReadFile.Size = new Size(176, 39);
            ReadFile.TabIndex = 0;
            ReadFile.Text = "READ FROM FILE";
            ReadFile.UseVisualStyleBackColor = false;
            ReadFile.Click += ReadFile_Click;
            // 
            // Content
            // 
            Content.Location = new Point(441, 21);
            Content.Name = "Content";
            Content.Size = new Size(325, 408);
            Content.TabIndex = 1;
            Content.Text = "";
            // 
            // FileName
            // 
            FileName.Location = new Point(205, 84);
            FileName.Name = "FileName";
            FileName.Size = new Size(209, 27);
            FileName.TabIndex = 2;
            // 
            // Size
            // 
            Size.Location = new Point(205, 140);
            Size.Name = "Size";
            Size.Size = new Size(209, 27);
            Size.TabIndex = 3;
            // 
            // URL
            // 
            URL.Location = new Point(205, 193);
            URL.Name = "URL";
            URL.Size = new Size(209, 27);
            URL.TabIndex = 4;
            // 
            // LineCount
            // 
            LineCount.Location = new Point(205, 248);
            LineCount.Name = "LineCount";
            LineCount.Size = new Size(209, 27);
            LineCount.TabIndex = 5;
            // 
            // WordsCount
            // 
            WordsCount.Location = new Point(205, 302);
            WordsCount.Name = "WordsCount";
            WordsCount.Size = new Size(209, 27);
            WordsCount.TabIndex = 6;
            // 
            // CharacterCount
            // 
            CharacterCount.Location = new Point(205, 354);
            CharacterCount.Name = "CharacterCount";
            CharacterCount.Size = new Size(209, 27);
            CharacterCount.TabIndex = 7;
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.ActiveCaption;
            Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.ForeColor = SystemColors.ActiveCaptionText;
            Exit.Location = new Point(106, 399);
            Exit.Name = "Exit";
            Exit.Size = new Size(176, 39);
            Exit.TabIndex = 8;
            Exit.Text = "EXIT";
            Exit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 91);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 9;
            label1.Text = "FILE NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 144);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 10;
            label2.Text = "SIZE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 196);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 11;
            label3.Text = "URL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 255);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 12;
            label4.Text = "LINE COUNT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 309);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 13;
            label5.Text = "WORDS COUNT:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 356);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 14;
            label6.Text = "CHARACTER COUNT";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(CharacterCount);
            Controls.Add(WordsCount);
            Controls.Add(LineCount);
            Controls.Add(URL);
            Controls.Add(Size);
            Controls.Add(FileName);
            Controls.Add(Content);
            Controls.Add(ReadFile);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReadFile;
        private RichTextBox Content;
        private TextBox FileName;
        private TextBox Size;
        private TextBox URL;
        private TextBox LineCount;
        private TextBox WordsCount;
        private TextBox CharacterCount;
        private Button Exit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}