namespace StudentManagement
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
            txtID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            buttonAdd = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            txtSearch = new TextBox();
            txtBirth = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(149, 25);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(270, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "MÃ SỐ SINH VIÊN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 78);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "HỌ VÀ TÊN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 126);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "NGÀY SINH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 173);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 5;
            label4.Text = "ĐỊA CHỈ";
            // 
            // txtName
            // 
            txtName.Location = new Point(149, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 27);
            txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(149, 167);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(270, 27);
            txtAddress.TabIndex = 8;
            txtAddress.TextChanged += textBox4_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(536, 69);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "THÊM";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(536, 109);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "XÓA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(536, 150);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "SỬA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(681, 198);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 12;
            button4.Text = "TÌM KIẾM";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(761, 276);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 201);
            label5.Name = "label5";
            label5.Size = new Size(184, 20);
            label5.TabIndex = 16;
            label5.Text = "Nhập tên sinh viên cần tìm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(482, 198);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 27);
            txtSearch.TabIndex = 17;
            txtSearch.TextChanged += Search_TextChanged;
            // 
            // txtBirth
            // 
            txtBirth.Location = new Point(149, 123);
            txtBirth.Name = "txtBirth";
            txtBirth.Size = new Size(270, 27);
            txtBirth.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(536, 29);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 19;
            button1.Text = "KẾT NỐI SQL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(button1);
            Controls.Add(txtBirth);
            Controls.Add(txtSearch);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtID);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtAddress;
        private Button buttonAdd;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox txtSearch;
        private TextBox txtBirth;
        private Button button1;
    }
}