namespace Lab1_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            EnterNumber = new TextBox();
            Result = new TextBox();
            Read = new Button();
            Delete = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 130);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số từ 0 đến 9:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 184);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Kết quả:";
            // 
            // EnterNumber
            // 
            EnterNumber.Location = new Point(309, 123);
            EnterNumber.Name = "EnterNumber";
            EnterNumber.Size = new Size(234, 27);
            EnterNumber.TabIndex = 2;
            // 
            // Result
            // 
            Result.Location = new Point(309, 177);
            Result.Name = "Result";
            Result.Size = new Size(234, 27);
            Result.TabIndex = 3;
            // 
            // Read
            // 
            Read.Location = new Point(174, 259);
            Read.Name = "Read";
            Read.Size = new Size(94, 29);
            Read.TabIndex = 4;
            Read.Text = "Đọc";
            Read.UseVisualStyleBackColor = true;
            Read.Click += Read_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(344, 259);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 5;
            Delete.Text = "Xóa";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(504, 259);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 6;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(Delete);
            Controls.Add(Read);
            Controls.Add(Result);
            Controls.Add(EnterNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox EnterNumber;
        private TextBox Result;
        private Button Read;
        private Button Delete;
        private Button Exit;
    }
}