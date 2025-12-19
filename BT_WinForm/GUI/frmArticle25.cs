using System;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class frmArticle25 : Form
    {
        public frmArticle25()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0; // Reset ProgressBar
            lblPercent.Text = "0%";
            timer1.Start(); // Bắt đầu Timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1; // Tăng 1%
                lblPercent.Text = $"{progressBar1.Value}%";
            }
            else
            {
                timer1.Stop(); // Dừng Timer khi đạt 100%
                MessageBox.Show("Hoàn thành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}