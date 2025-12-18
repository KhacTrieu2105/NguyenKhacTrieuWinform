using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }
        public ArrayList GetData ()
        {
            ArrayList lst = new ArrayList();
            Faculty f = new Faculty();
            f.Id = "K1";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K2";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K3";
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);
            return lst;

        }
        private void Khoa_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name";
            cb_Faculty.ValueMember = "Id";  
            cb_Faculty.SelectedIndex = 0;   
        }

        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Faculty.SelectedValue != null)
            {
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã : " + id;
            }
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            Faculty? f = cb_Faculty.SelectedItem as Faculty;
            if (f != null)
            {
                tbDisplay.Text = "Bạn đã chọn khoa có tên: " + f.Name;
            }
        }
    }
}
