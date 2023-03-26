namespace Lab1_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Form1
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
            Bai1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // Bai1
            // 
            Bai1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Bai1.Location = new Point(162, 113);
            Bai1.Name = "Bai1";
            Bai1.Size = new Size(154, 55);
            Bai1.TabIndex = 0;
            Bai1.Text = "Bài 1";
            Bai1.UseVisualStyleBackColor = true;
            Bai1.Click += Bai1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(162, 203);
            button2.Name = "button2";
            button2.Size = new Size(154, 55);
            button2.TabIndex = 1;
            button2.Text = "Bài 2";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Bai2;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(437, 113);
            button3.Name = "button3";
            button3.Size = new Size(154, 55);
            button3.TabIndex = 2;
            button3.Text = "Bài 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Bai3;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(437, 203);
            button4.Name = "button4";
            button4.Size = new Size(154, 55);
            button4.TabIndex = 3;
            button4.Text = "Bài 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Bai4;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(300, 295);
            button5.Name = "button5";
            button5.Size = new Size(154, 55);
            button5.TabIndex = 4;
            button5.Text = "Bài 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Bai5;
            // 
            // Exit
            // 
            Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.Location = new Point(330, 382);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 5;
            Exit.Text = "THOÁT";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Bai1);
            Name = "Form1";
            Text = "Lab1";
            ResumeLayout(false);
        }

        #endregion

        private Button Bai1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button Exit;
    }
}