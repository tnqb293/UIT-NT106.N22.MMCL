namespace Lab2_21521865_Tran_Nguyen_Quoc_Bao
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Bai1 frm1 = new Bai1();
            frm1.ShowDialog();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Bai2 frm2 = new Bai2();
            frm2.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Bai3 frm3 = new Bai3();
            frm3.ShowDialog();
        }
        private void Bai5_Click(object sender, EventArgs e)
        {
            Bai5 frm5 = new Bai5();
            frm5.ShowDialog();
        }

        private void Bai6_Click(object sender, EventArgs e)
        {
            Bai6 frm6 = new Bai6();
            frm6.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}