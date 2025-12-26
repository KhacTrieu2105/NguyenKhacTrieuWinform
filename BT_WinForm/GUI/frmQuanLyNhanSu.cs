using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq; // Cần thiết để sử dụng chức năng tìm kiếm (Where)
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class frmQuanLyNhanSu : Form
    {
        // Danh sách gốc lưu trữ toàn bộ nhân viên
        private List<NhanVien> dsNhanVien = new List<NhanVien>();

        public frmQuanLyNhanSu()
        {
            InitializeComponent();
            CaiDatDataGridView();
            ThemDuLieuMau();
            CapNhatDataGridView();
            TinhTongLuong(); // Tính toán lần đầu khi mở app
        }

        private void ThemDuLieuMau()
        {
            dsNhanVien.Add(new NhanVien { MaNV = "NV001", HoTen = "Nguyễn Văn A", NgaySinh = "01/01/1995", GioiTinh = "Nam", Luong = "15000000", SDT = "0912345678" });
            dsNhanVien.Add(new NhanVien { MaNV = "NV002", HoTen = "Trần Thị B", NgaySinh = "15/05/1998", GioiTinh = "Nữ", Luong = "12000000", SDT = "0987654321" });
        }

        private void CaiDatDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã NV", DataPropertyName = "MaNV", Width = 80 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ tên", DataPropertyName = "HoTen", Width = 150 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày sinh", DataPropertyName = "NgaySinh", Width = 100 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giới tính", DataPropertyName = "GioiTinh", Width = 80 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lương", DataPropertyName = "Luong", Width = 100 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "SĐT", DataPropertyName = "SDT", Width = 100 });
        }

        // --- CHỨC NĂNG 1: TÍNH TỔNG LƯƠNG ---
        private void TinhTongLuong()
        {
            double tong = 0;
            foreach (var nv in dsNhanVien)
            {
                if (double.TryParse(nv.Luong, out double l))
                    tong += l;
            }
            lblTongLuong.Text = $"Tổng quỹ lương: {tong.ToString("N0")} VNĐ";
        }

        // --- CHỨC NĂNG 2: TÌM KIẾM (LIVE SEARCH) ---
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.ToLower();
            var ketQua = dsNhanVien.Where(nv =>
                nv.HoTen.ToLower().Contains(keyword) ||
                nv.MaNV.ToLower().Contains(keyword)
            ).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ketQua;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (SĐT đủ 10 số)!");
                return;
            }

            dsNhanVien.Add(new NhanVien
            {
                MaNV = txtMaNV.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy"),
                GioiTinh = rbNam.Checked ? "Nam" : "Nữ",
                Luong = txtLuong.Text,
                SDT = txtSDT.Text
            });

            CapNhatDataGridView();
            TinhTongLuong(); // Cập nhật tổng lương
            XoaTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int index = dataGridView1.CurrentRow.Index;

            dsNhanVien[index].MaNV = txtMaNV.Text;
            dsNhanVien[index].HoTen = txtHoTen.Text;
            dsNhanVien[index].NgaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            dsNhanVien[index].GioiTinh = rbNam.Checked ? "Nam" : "Nữ";
            dsNhanVien[index].Luong = txtLuong.Text;
            dsNhanVien[index].SDT = txtSDT.Text;

            CapNhatDataGridView();
            TinhTongLuong(); // Cập nhật tổng lương
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int index = dataGridView1.CurrentRow.Index;
            dsNhanVien.RemoveAt(index);
            CapNhatDataGridView();
            TinhTongLuong(); // Cập nhật tổng lương
            XoaTextBox();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int index = dataGridView1.CurrentRow.Index;
            if (index >= dsNhanVien.Count) return;

            txtMaNV.Text = dsNhanVien[index].MaNV;
            txtHoTen.Text = dsNhanVien[index].HoTen;
            txtLuong.Text = dsNhanVien[index].Luong;
            txtSDT.Text = dsNhanVien[index].SDT;
            dtpNgaySinh.Value = DateTime.ParseExact(dsNhanVien[index].NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            rbNam.Checked = dsNhanVien[index].GioiTinh == "Nam";
            rbNu.Checked = dsNhanVien[index].GioiTinh == "Nữ";
        }

        private void CapNhatDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dsNhanVien;
        }

        private void XoaTextBox()
        {
            txtMaNV.Clear(); txtHoTen.Clear(); txtLuong.Clear(); txtSDT.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rbNam.Checked = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }
    }

    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Luong { get; set; }
        public string SDT { get; set; }
    }
}