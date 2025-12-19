using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class frmArticle20 : Form
    {
        private List<SinhVien> dsSinhVien = new List<SinhVien>();

        public frmArticle20()
        {
            InitializeComponent();
            CaiDatDataGridView();
        }

        private void CaiDatDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            // Cột Mã SV
            DataGridViewTextBoxColumn colMaSV = new DataGridViewTextBoxColumn();
            colMaSV.HeaderText = "Mã SV";
            colMaSV.DataPropertyName = "MaSV";
            colMaSV.Width = 100;
            dataGridView1.Columns.Add(colMaSV);

            // Cột Tên SV
            DataGridViewTextBoxColumn colTenSV = new DataGridViewTextBoxColumn();
            colTenSV.HeaderText = "Tên SV";
            colTenSV.DataPropertyName = "TenSV";
            colTenSV.Width = 200;
            dataGridView1.Columns.Add(colTenSV);

            // Cột Lớp
            DataGridViewTextBoxColumn colLop = new DataGridViewTextBoxColumn();
            colLop.HeaderText = "Lớp";
            colLop.DataPropertyName = "Lop";
            colLop.Width = 100;
            dataGridView1.Columns.Add(colLop);

            // Cột Điểm
            DataGridViewTextBoxColumn colDiem = new DataGridViewTextBoxColumn();
            colDiem.HeaderText = "Điểm";
            colDiem.DataPropertyName = "Diem";
            colDiem.Width = 80;
            dataGridView1.Columns.Add(colDiem);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SinhVien sv = new SinhVien
            {
                MaSV = txtMaSV.Text,
                TenSV = txtTenSV.Text,
                Lop = txtLop.Text,
                Diem = txtDiem.Text
            };

            dsSinhVien.Add(sv);
            CapNhatDataGridView();
            XoaTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridView1.CurrentRow.Index;
            dsSinhVien[index].MaSV = txtMaSV.Text;
            dsSinhVien[index].TenSV = txtTenSV.Text;
            dsSinhVien[index].Lop = txtLop.Text;
            dsSinhVien[index].Diem = txtDiem.Text;

            CapNhatDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentRow.Index;
                dsSinhVien.RemoveAt(index);
                CapNhatDataGridView();
                XoaTextBox();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                txtMaSV.Text = dsSinhVien[index].MaSV;
                txtTenSV.Text = dsSinhVien[index].TenSV;
                txtLop.Text = dsSinhVien[index].Lop;
                txtDiem.Text = dsSinhVien[index].Diem;
            }
        }

        private void CapNhatDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dsSinhVien;
        }

        private void XoaTextBox()
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtLop.Clear();
            txtDiem.Clear();
        }
    }

    // Lớp Sinh viên
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string Lop { get; set; }
        public string Diem { get; set; }
    }
}