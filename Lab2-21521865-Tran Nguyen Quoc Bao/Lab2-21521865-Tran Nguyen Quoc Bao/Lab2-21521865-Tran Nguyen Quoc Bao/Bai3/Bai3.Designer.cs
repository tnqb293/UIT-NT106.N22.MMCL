namespace Lab2_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Bai3
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
            ReadAndCalculator = new Button();
            SuspendLayout();
            // 
            // ReadAndCalculator
            // 
            ReadAndCalculator.BackColor = SystemColors.Info;
            ReadAndCalculator.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ReadAndCalculator.Location = new Point(256, 146);
            ReadAndCalculator.Name = "ReadAndCalculator";
            ReadAndCalculator.Size = new Size(281, 147);
            ReadAndCalculator.TabIndex = 0;
            ReadAndCalculator.Text = "ĐỌC FILE VÀ TÍNH TOÁN";
            ReadAndCalculator.UseVisualStyleBackColor = false;
            ReadAndCalculator.Click += ReadAndCalculator_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReadAndCalculator);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button ReadAndCalculator;
    }
}