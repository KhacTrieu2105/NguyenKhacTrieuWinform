using System;
using System.Windows.Forms;
using BT_WinForm.GUI;

namespace BT_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Caculator().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Caculator_2().Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new Simple_Caculator().Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            new Khoa().Show();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            new Article14().Show();
        }

        private void btListBox_Click(object sender, EventArgs e)
        {
            new ListBoxForm().Show();
        }

        // Nút 1: Mở form Quản lý nhân sự (cũ - có ảnh 3x4)
        private void btnArticle19_Click(object sender, EventArgs e)
        {
            new article19().Show();
        }

        // Nút 2: Mở form Quản lý nhân sự (mới - có DataGridView, Thêm/Sửa/Xóa)
        private void btnQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            new frmQuanLyNhanSu().Show();
        }
        private void btnArticle20_Click(object sender, EventArgs e)
        {
            new frmArticle20().Show();
        }
        private void btnArticle21_Click(object sender, EventArgs e)
        {
            new frmArticle21().Show();
        }
        private void btnArticle22_Click(object sender, EventArgs e)
        {
            new frmArticle22().Show();
        }
        private void btnArticle23_Click(object sender, EventArgs e)
        {
            new frmArticle23().Show();
        }
        private void btnArticle24_Click(object sender, EventArgs e)
        {
            new frmArticle24().Show();
        }
        private void btnArticle25_Click(object sender, EventArgs e)
        {
            new frmArticle25().Show();
        }
    }
}