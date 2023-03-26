namespace Lab1_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Form6
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            EnterNumA = new TextBox();
            EnterNumB = new TextBox();
            Calculator = new Button();
            Delete = new Button();
            Exit = new Button();
            ResultAFactorial = new TextBox();
            ResultBFactorial = new TextBox();
            ResultS1 = new TextBox();
            ResultS2 = new TextBox();
            ResultS3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 58);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(437, 58);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 1;
            label2.Text = "Nhập B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(108, 159);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 2;
            label3.Text = "KẾT QUẢ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(102, 197);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 3;
            label4.Text = "A! =";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(102, 236);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 4;
            label5.Text = "B! = ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(102, 269);
            label6.Name = "label6";
            label6.Size = new Size(216, 28);
            label6.TabIndex = 5;
            label6.Text = "S1 = 1+2+3+4+...+A =";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(102, 319);
            label7.Name = "label7";
            label7.Size = new Size(209, 28);
            label7.TabIndex = 6;
            label7.Text = "S2= 1+2+3+4+...+B =";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(102, 347);
            label8.Name = "label8";
            label8.Size = new Size(394, 28);
            label8.TabIndex = 7;
            label8.Text = "S3= A^1 + A^2 + A^3 + A^4 + ... + A^B =";
            // 
            // EnterNumA
            // 
            EnterNumA.Location = new Point(159, 59);
            EnterNumA.Name = "EnterNumA";
            EnterNumA.Size = new Size(125, 27);
            EnterNumA.TabIndex = 8;
            // 
            // EnterNumB
            // 
            EnterNumB.Location = new Point(519, 59);
            EnterNumB.Name = "EnterNumB";
            EnterNumB.Size = new Size(125, 27);
            EnterNumB.TabIndex = 9;
            // 
            // Calculator
            // 
            Calculator.Location = new Point(159, 116);
            Calculator.Name = "Calculator";
            Calculator.Size = new Size(94, 29);
            Calculator.TabIndex = 10;
            Calculator.Text = "Tính";
            Calculator.UseVisualStyleBackColor = true;
            Calculator.Click += Calculator_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(356, 116);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 11;
            Delete.Text = "Xóa";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(550, 116);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 12;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // ResultAFactorial
            // 
            ResultAFactorial.Location = new Point(155, 198);
            ResultAFactorial.Name = "ResultAFactorial";
            ResultAFactorial.Size = new Size(125, 27);
            ResultAFactorial.TabIndex = 13;
            // 
            // ResultBFactorial
            // 
            ResultBFactorial.Location = new Point(155, 236);
            ResultBFactorial.Name = "ResultBFactorial";
            ResultBFactorial.Size = new Size(125, 27);
            ResultBFactorial.TabIndex = 14;
            // 
            // ResultS1
            // 
            ResultS1.Location = new Point(325, 270);
            ResultS1.Name = "ResultS1";
            ResultS1.Size = new Size(125, 27);
            ResultS1.TabIndex = 15;
            // 
            // ResultS2
            // 
            ResultS2.Location = new Point(325, 310);
            ResultS2.Name = "ResultS2";
            ResultS2.Size = new Size(125, 27);
            ResultS2.TabIndex = 16;
            // 
            // ResultS3
            // 
            ResultS3.Location = new Point(493, 348);
            ResultS3.Name = "ResultS3";
            ResultS3.Size = new Size(125, 27);
            ResultS3.TabIndex = 17;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultS3);
            Controls.Add(ResultS2);
            Controls.Add(ResultS1);
            Controls.Add(ResultBFactorial);
            Controls.Add(ResultAFactorial);
            Controls.Add(Exit);
            Controls.Add(Delete);
            Controls.Add(Calculator);
            Controls.Add(EnterNumB);
            Controls.Add(EnterNumA);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox EnterNumA;
        private TextBox EnterNumB;
        private Button Calculator;
        private Button Delete;
        private Button Exit;
        private TextBox ResultAFactorial;
        private TextBox ResultBFactorial;
        private TextBox ResultS1;
        private TextBox ResultS2;
        private TextBox ResultS3;
    }
}