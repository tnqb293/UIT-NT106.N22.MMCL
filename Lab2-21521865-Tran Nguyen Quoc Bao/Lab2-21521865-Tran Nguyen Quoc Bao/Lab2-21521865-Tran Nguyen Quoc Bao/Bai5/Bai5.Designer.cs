namespace Lab2_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Bai5
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
            Compress = new Button();
            Decompress = new Button();
            SuspendLayout();
            // 
            // Compress
            // 
            Compress.BackColor = SystemColors.Info;
            Compress.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Compress.Location = new Point(114, 164);
            Compress.Name = "Compress";
            Compress.Size = new Size(220, 79);
            Compress.TabIndex = 0;
            Compress.Text = "COMPRESS";
            Compress.UseVisualStyleBackColor = false;
            Compress.Click += Compress_Click;
            // 
            // Decompress
            // 
            Decompress.BackColor = SystemColors.InactiveCaption;
            Decompress.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Decompress.Location = new Point(430, 164);
            Decompress.Name = "Decompress";
            Decompress.Size = new Size(220, 79);
            Decompress.TabIndex = 1;
            Decompress.Text = "DECOMPRESS";
            Decompress.UseVisualStyleBackColor = false;
            Decompress.Click += Decompress_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Decompress);
            Controls.Add(Compress);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
        }

        #endregion

        private Button Compress;
        private Button Decompress;
    }
}