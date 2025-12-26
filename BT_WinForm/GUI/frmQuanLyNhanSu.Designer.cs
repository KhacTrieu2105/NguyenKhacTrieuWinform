namespace BT_WinForm.GUI
{
    partial class frmQuanLyNhanSu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTongLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // --- DataGridView ---
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 15);
            this.dataGridView1.Size = new System.Drawing.Size(770, 250);
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            // --- Tổng quỹ lương (Hiện rõ màu đỏ, Font đậm) ---
            this.lblTongLuong.AutoSize = true;
            this.lblTongLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongLuong.ForeColor = System.Drawing.Color.Red;
            this.lblTongLuong.Location = new System.Drawing.Point(15, 280);
            this.lblTongLuong.Text = "Tổng quỹ lương: 0 VNĐ";

            // --- Ô Tìm kiếm (Căn lề phải rõ ràng) ---
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 285);
            this.label7.Text = "Tìm kiếm nhanh:";
            this.txtTimKiem.Location = new System.Drawing.Point(560, 282);
            this.txtTimKiem.Size = new System.Drawing.Size(225, 23);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // --- Khu vực nhập liệu (Tăng khoảng cách để không bị đè chữ) ---
            int startX = 30; int inputX = 120; // Căn lề trái và vị trí ô nhập

            this.label1.Text = "Mã NV:"; this.label1.Location = new System.Drawing.Point(startX, 330); this.label1.AutoSize = true;
            this.txtMaNV.Location = new System.Drawing.Point(inputX, 327); this.txtMaNV.Size = new System.Drawing.Size(200, 23);

            this.label2.Text = "Họ tên:"; this.label2.Location = new System.Drawing.Point(startX, 370); this.label2.AutoSize = true;
            this.txtHoTen.Location = new System.Drawing.Point(inputX, 367); this.txtHoTen.Size = new System.Drawing.Size(300, 23);

            this.label3.Text = "Ngày sinh:"; this.label3.Location = new System.Drawing.Point(startX, 410); this.label3.AutoSize = true;
            this.dtpNgaySinh.Location = new System.Drawing.Point(inputX, 407); this.dtpNgaySinh.Size = new System.Drawing.Size(200, 23);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.label4.Text = "Giới tính:"; this.label4.Location = new System.Drawing.Point(startX, 450); this.label4.AutoSize = true;
            this.rbNam.Text = "Nam"; this.rbNam.Location = new System.Drawing.Point(inputX, 448); this.rbNam.AutoSize = true;
            this.rbNu.Text = "Nữ"; this.rbNu.Location = new System.Drawing.Point(200, 448); this.rbNu.AutoSize = true;

            this.label5.Text = "Lương:"; this.label5.Location = new System.Drawing.Point(startX, 490); this.label5.AutoSize = true;
            this.txtLuong.Location = new System.Drawing.Point(inputX, 487); this.txtLuong.Size = new System.Drawing.Size(200, 23);

            this.label6.Text = "Số điện thoại:"; this.label6.Location = new System.Drawing.Point(30, 530); this.label6.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(120, 527); this.txtSDT.Size = new System.Drawing.Size(200, 23);
            this.txtSDT.MaxLength = 10;

            // --- Các nút bấm (Gọn gàng, thẳng hàng) ---
            int btnX = 500;
            this.btnThem.Text = "Thêm mới"; this.btnThem.Location = new System.Drawing.Point(btnX, 330); this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.BackColor = System.Drawing.Color.LightBlue;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Cập nhật"; this.btnSua.Location = new System.Drawing.Point(btnX, 385); this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa bỏ"; this.btnXoa.Location = new System.Drawing.Point(btnX, 440); this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // --- Form Setup ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 580);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
        this.dataGridView1, this.lblTongLuong, this.label7, this.txtTimKiem,
        this.label1, this.txtMaNV, this.label2, this.txtHoTen,
        this.label3, this.dtpNgaySinh, this.label4, this.rbNam, this.rbNu,
        this.label5, this.txtLuong, this.label6, this.txtSDT,
        this.btnThem, this.btnSua, this.btnXoa
    });
            this.Text = "Hệ thống quản lý nhân sự chuyên nghiệp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaNV, txtHoTen, txtLuong, txtSDT, txtTimKiem;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rbNam, rbNu;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7, lblTongLuong;
    }
}