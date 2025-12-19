using System;
using System.Drawing;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class frmArticle24 : Form
    {
        private int second = 0;

        public frmArticle24()
        {
            InitializeComponent();
            timer1.Interval = 1000; // 1 giây
            timer1.Tick += Timer1_Tick;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            second++;
            int minutes = second / 60;
            int seconds = second % 60;
            lblTime.Text = $"{minutes:D2}:{seconds:D2}";
        }
    }
}