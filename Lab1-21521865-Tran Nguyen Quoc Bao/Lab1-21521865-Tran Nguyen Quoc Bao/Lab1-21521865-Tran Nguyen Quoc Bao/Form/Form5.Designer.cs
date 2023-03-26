namespace Lab1_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Form5
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
            Number = new TextBox();
            Change = new Button();
            List = new ComboBox();
            label2 = new Label();
            Result = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 123);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 0;
            label1.Text = "Số tiền cần đổi:";
            // 
            // Number
            // 
            Number.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number.Location = new Point(266, 120);
            Number.Name = "Number";
            Number.Size = new Size(186, 38);
            Number.TabIndex = 1;
            // 
            // Change
            // 
            Change.Location = new Point(288, 181);
            Change.Name = "Change";
            Change.Size = new Size(145, 35);
            Change.TabIndex = 2;
            Change.Text = "Chuyển đổi";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // List
            // 
            List.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            List.FormattingEnabled = true;
            List.Location = new Point(458, 120);
            List.Name = "List";
            List.Size = new Size(151, 39);
            List.TabIndex = 3;
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(95, 247);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 4;
            label2.Text = "Số tiền đã đổi:";
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Result.Location = new Point(266, 240);
            Result.Name = "Result";
            Result.Size = new Size(186, 38);
            Result.TabIndex = 5;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Result);
            Controls.Add(label2);
            Controls.Add(List);
            Controls.Add(Change);
            Controls.Add(Number);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Number;
        private Button Change;
        private ComboBox List;
        private Label label2;
        private TextBox Result;
    }
}