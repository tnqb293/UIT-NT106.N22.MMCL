namespace Lab2_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Lab2
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
            Bai2 = new Button();
            Bai3 = new Button();
            Bai4 = new Button();
            Bai5 = new Button();
            Bai6 = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // Bai1
            // 
            Bai1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Bai1.Location = new Point(174, 72);
            Bai1.Name = "Bai1";
            Bai1.Size = new Size(145, 65);
            Bai1.TabIndex = 0;
            Bai1.Text = "BÀI 1";
            Bai1.UseVisualStyleBackColor = true;
            Bai1.Click += Bai1_Click;
            // 
            // Bai2
            // 
            Bai2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Bai2.Location = new Point(174, 167);
            Bai2.Name = "Bai2";
            Bai2.Size = new Size(145, 65);
            Bai2.TabIndex = 1;
            Bai2.Text = "BÀI 2";
            Bai2.UseVisualStyleBackColor = true;
            Bai2.Click += Bai2_Click;
            // 
            // Bai3
            // 
            Bai3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Bai3.Location = new Point(174, 255);
            Bai3.Name = "Bai3";
            Bai3.Size = new Size(145, 65);
            Bai3.TabIndex = 2;
            Bai3.Text = "BÀI 3";
            Bai3.UseVisualStyleBackColor = true;
            Bai3.Click += Bai3_Click;
            // 
            // Bai4
            // 
            Bai4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Bai4.Location = new Point(477, 72);
            Bai4.Name = "Bai4";
            Bai4.Size = new Size(145, 65);
            Bai4.TabIndex = 3;
            Bai4.Text = "BÀI 4";
            Bai4.UseVisualStyleBackColor = true;
            Bai4.Click += Bai4_Click;
            // 
            // Bai5
            // 
            Bai5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Bai5.Location = new Point(477, 167);
            Bai5.Name = "Bai5";
            Bai5.Size = new Size(145, 65);
            Bai5.TabIndex = 4;
            Bai5.Text = "BÀI 5";
            Bai5.UseVisualStyleBackColor = true;
            Bai5.Click += Bai5_Click;
            // 
            // Bai6
            // 
            Bai6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Bai6.Location = new Point(477, 255);
            Bai6.Name = "Bai6";
            Bai6.Size = new Size(145, 65);
            Bai6.TabIndex = 5;
            Bai6.Text = "BÀI 6";
            Bai6.UseVisualStyleBackColor = true;
            Bai6.Click += Bai6_Click;
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.ActiveCaption;
            Exit.Location = new Point(353, 340);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 6;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Lab2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 391);
            Controls.Add(Exit);
            Controls.Add(Bai6);
            Controls.Add(Bai5);
            Controls.Add(Bai4);
            Controls.Add(Bai3);
            Controls.Add(Bai2);
            Controls.Add(Bai1);
            Name = "Lab2";
            Text = "Lab2";
            ResumeLayout(false);
        }

        #endregion

        private Button Bai1;
        private Button Bai2;
        private Button Bai3;
        private Button Bai4;
        private Button Bai5;
        private Button Bai6;
        private Button Exit;
    }
}