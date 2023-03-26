namespace Lab1_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Form3
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
            Num1 = new TextBox();
            Num2 = new TextBox();
            Num3 = new TextBox();
            Min = new TextBox();
            Max = new TextBox();
            Find = new Button();
            Delete = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 66);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 110);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 159);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Số thứ ba:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 331);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Số nhỏ nhất là:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 378);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Số lớn nhất là:";
            // 
            // Num1
            // 
            Num1.Location = new Point(152, 59);
            Num1.Name = "Num1";
            Num1.Size = new Size(205, 27);
            Num1.TabIndex = 5;
            // 
            // Num2
            // 
            Num2.Location = new Point(152, 110);
            Num2.Name = "Num2";
            Num2.Size = new Size(205, 27);
            Num2.TabIndex = 6;
            // 
            // Num3
            // 
            Num3.Location = new Point(152, 159);
            Num3.Name = "Num3";
            Num3.Size = new Size(205, 27);
            Num3.TabIndex = 7;
            // 
            // Min
            // 
            Min.Location = new Point(152, 324);
            Min.Name = "Min";
            Min.Size = new Size(205, 27);
            Min.TabIndex = 8;
            // 
            // Max
            // 
            Max.Location = new Point(152, 375);
            Max.Name = "Max";
            Max.Size = new Size(205, 27);
            Max.TabIndex = 9;
            // 
            // Find
            // 
            Find.Location = new Point(492, 94);
            Find.Name = "Find";
            Find.Size = new Size(136, 59);
            Find.TabIndex = 10;
            Find.Text = "Tìm";
            Find.UseVisualStyleBackColor = true;
            Find.Click += Find_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(492, 206);
            Delete.Name = "Delete";
            Delete.Size = new Size(136, 59);
            Delete.TabIndex = 11;
            Delete.Text = "Xóa";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(492, 308);
            Exit.Name = "Exit";
            Exit.Size = new Size(136, 59);
            Exit.TabIndex = 12;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(Delete);
            Controls.Add(Find);
            Controls.Add(Max);
            Controls.Add(Min);
            Controls.Add(Num3);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Num1;
        private TextBox Num2;
        private TextBox Num3;
        private TextBox Min;
        private TextBox Max;
        private Button Find;
        private Button Delete;
        private Button Exit;
    }
}