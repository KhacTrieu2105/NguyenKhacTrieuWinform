using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class frmQuanLyNhanSu : Form
    {
        private List<NhanVien> dsNhanVien = new List<NhanVien>();

        public frmQuanLyNhanSu()
        {
            InitializeComponent();
            // Thiết lập cột cho DataGridView
            CaiDatDataGridView();
        }

        private void CaiDatDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            // Cột Mã NV
            DataGridViewTextBoxColumn colMa = new DataGridViewTextBoxColumn();
            colMa.HeaderText = "Mã NV";
            colMa.DataPropertyName = "MaNV";
            colMa.Width = 100;
            dataGridView1.Columns.Add(colMa);

            // Cột Họ tên
            DataGridViewTextBoxColumn colTen = new DataGridViewTextBoxColumn();
            colTen.HeaderText = "Họ tên";
            colTen.DataPropertyName = "HoTen";
            colTen.Width = 180;
            dataGridView1.Columns.Add(colTen);

            // Cột Ngày sinh
            DataGridViewTextBoxColumn colNgaySinh = new DataGridViewTextBoxColumn();
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.Width = 120;
            dataGridView1.Columns.Add(colNgaySinh);

            // Cột Giới tính
            DataGridViewTextBoxColumn colGioiTinh = new DataGridViewTextBoxColumn();
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.Width = 100;
            dataGridView1.Columns.Add(colGioiTinh);

            // Cột Lương
            DataGridViewTextBoxColumn colLuong = new DataGridViewTextBoxColumn();
            colLuong.HeaderText = "Lương";
            colLuong.DataPropertyName = "Luong";
            colLuong.Width = 120;
            dataGridView1.Columns.Add(colLuong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVien nv = new NhanVien
            {
                MaNV = txtMaNV.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy"),
                GioiTinh = rbNam.Checked ? "Nam" : "Nữ",
                Luong = txtLuong.Text
            };

            dsNhanVien.Add(nv);
            CapNhatDataGridView();
            XoaTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridView1.CurrentRow.Index;
            dsNhanVien[index].MaNV = txtMaNV.Text;
            dsNhanVien[index].HoTen = txtHoTen.Text;
            dsNhanVien[index].NgaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            dsNhanVien[index].GioiTinh = rbNam.Checked ? "Nam" : "Nữ";
            dsNhanVien[index].Luong = txtLuong.Text;

            CapNhatDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentRow.Index;
                dsNhanVien.RemoveAt(index);
                CapNhatDataGridView();
                XoaTextBox();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;
                txtMaNV.Text = dsNhanVien[index].MaNV;
                txtHoTen.Text = dsNhanVien[index].HoTen;
                dtpNgaySinh.Value = DateTime.Parse(dsNhanVien[index].NgaySinh);
                if (dsNhanVien[index].GioiTinh == "Nam")
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;
                txtLuong.Text = dsNhanVien[index].Luong;
            }
        }

        private void CapNhatDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dsNhanVien;
        }

        private void XoaTextBox()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtLuong.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rbNam.Checked = true;
        }
    }

    // Lớp Nhân viên
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Luong { get; set; }
    }
}