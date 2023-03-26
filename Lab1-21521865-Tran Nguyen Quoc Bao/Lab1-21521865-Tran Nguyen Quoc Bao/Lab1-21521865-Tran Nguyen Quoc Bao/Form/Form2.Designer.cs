namespace Lab1_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Form2
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
            EnterNum1 = new TextBox();
            EnterNum2 = new TextBox();
            Result = new TextBox();
            label3 = new Label();
            Calculator = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 94);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 143);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập số thứ hai";
            // 
            // EnterNum1
            // 
            EnterNum1.Location = new Point(358, 91);
            EnterNum1.Name = "EnterNum1";
            EnterNum1.Size = new Size(192, 27);
            EnterNum1.TabIndex = 2;
            // 
            // EnterNum2
            // 
            EnterNum2.Location = new Point(358, 140);
            EnterNum2.Name = "EnterNum2";
            EnterNum2.Size = new Size(192, 27);
            EnterNum2.TabIndex = 3;
            // 
            // Result
            // 
            Result.Location = new Point(358, 193);
            Result.Name = "Result";
            Result.Size = new Size(192, 27);
            Result.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 200);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Kết quả";
            // 
            // Calculator
            // 
            Calculator.Location = new Point(408, 256);
            Calculator.Name = "Calculator";
            Calculator.Size = new Size(94, 29);
            Calculator.TabIndex = 6;
            Calculator.Text = "Tính";
            Calculator.UseVisualStyleBackColor = true;
            Calculator.Click += Calculator_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Calculator);
            Controls.Add(label3);
            Controls.Add(Result);
            Controls.Add(EnterNum2);
            Controls.Add(EnterNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox EnterNum1;
        private TextBox EnterNum2;
        private TextBox Result;
        private Label label3;
        private Button Calculator;
    }
}