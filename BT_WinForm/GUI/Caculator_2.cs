using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class Caculator_2 : Form
    {

        public Caculator_2()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + "+ " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + "+ " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Caculator_2.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close();
        }
        
    }
}
