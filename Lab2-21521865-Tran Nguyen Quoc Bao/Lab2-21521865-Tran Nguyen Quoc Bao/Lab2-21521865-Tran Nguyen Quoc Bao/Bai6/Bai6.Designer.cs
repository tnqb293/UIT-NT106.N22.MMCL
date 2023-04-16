namespace Lab2_21521865_Tran_Nguyen_Quoc_Bao
{
    partial class Bai6
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
            components = new System.ComponentModel.Container();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            richTextBox1 = new RichTextBox();
            Up = new Button();
            SWITCH = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(21, 14);
            listView1.Name = "listView1";
            listView1.Size = new Size(260, 416);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(302, 14);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(469, 359);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Up
            // 
            Up.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Up.Location = new Point(392, 390);
            Up.Name = "Up";
            Up.Size = new Size(119, 40);
            Up.TabIndex = 2;
            Up.Text = "BACK";
            Up.UseVisualStyleBackColor = true;
            Up.Click += Up_Click;
            // 
            // SWITCH
            // 
            SWITCH.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SWITCH.Location = new Point(559, 390);
            SWITCH.Name = "SWITCH";
            SWITCH.Size = new Size(119, 40);
            SWITCH.TabIndex = 4;
            SWITCH.Text = "SWITCH DRIVE";
            SWITCH.UseVisualStyleBackColor = true;
            SWITCH.Click += SWITCH_Click;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SWITCH);
            Controls.Add(Up);
            Controls.Add(richTextBox1);
            Controls.Add(listView1);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ImageList imageList1;
        private RichTextBox richTextBox1;
        private Button Up;
        private Button SWITCH;
    }
}