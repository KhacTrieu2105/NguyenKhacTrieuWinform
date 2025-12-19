using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BT_WinForm.GUI
{
    public partial class frmArticle22 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private List<Employee> list = new List<Employee>();

        public frmArticle22()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Thêm dữ liệu mẫu
           
            // Gán BindingSource
            bindingSource.DataSource = list;

            // Bind DataGridView với BindingSource
            dataGridView1.DataSource = bindingSource;

            // Bind các control với BindingSource
            txtId.DataBindings.Add("Text", bindingSource, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", bindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", bindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cbGender.DataBindings.Add("Checked", bindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);

            // Cấu hình cột DataGridView
            dataGridView1.Columns["Id"].HeaderText = "Mã NV";
            dataGridView1.Columns["Name"].HeaderText = "Tên NV";
            dataGridView1.Columns["Age"].HeaderText = "Tuổi";
            dataGridView1.Columns["Gender"].HeaderText = "Giới tính (Nam)";
            dataGridView1.Columns["Gender"].ReadOnly = true; // Checkbox chỉ đọc

            // Tự động chọn dòng đầu tiên
            if (bindingSource.Count > 0)
            {
                bindingSource.Position = 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo nhân viên mới
            Employee newEmp = new Employee();

            // Thêm vào list
            list.Add(newEmp);

            // Di chuyển BindingSource đến dòng mới
            bindingSource.Position = bindingSource.Count - 1;

            // Focus vào TextBox Mã NV để người dùng nhập
            txtId.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Lớp Employee
    public class Employee1
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; } // true = Nam, false = Nữ
    }
}