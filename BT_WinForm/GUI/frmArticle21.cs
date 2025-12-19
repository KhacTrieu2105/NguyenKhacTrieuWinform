using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BT_WinForm.GUI
{
    public partial class frmArticle21 : Form
    {
        private List<Employee> list = new List<Employee>();

        public frmArticle21()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            // Cột Mã NV
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "Mã NV";
            colId.DataPropertyName = "Id";
            colId.Width = 100;
            dataGridView1.Columns.Add(colId);

            // Cột Tên NV
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.HeaderText = "Tên NV";
            colName.DataPropertyName = "Name";
            colName.Width = 200;
            dataGridView1.Columns.Add(colName);

            // Cột Tuổi
            DataGridViewTextBoxColumn colAge = new DataGridViewTextBoxColumn();
            colAge.HeaderText = "Tuổi";
            colAge.DataPropertyName = "Age";
            colAge.Width = 80;
            dataGridView1.Columns.Add(colAge);

            // Cột Giới tính (checkbox)
            DataGridViewCheckBoxColumn colGender = new DataGridViewCheckBoxColumn();
            colGender.HeaderText = "Giới tính (Nam)";
            colGender.DataPropertyName = "Gender";
            colGender.Width = 120;
            dataGridView1.Columns.Add(colGender);

          
           

            // SAU ĐÓ MỚI GÁN DATASOURCE
            dataGridView1.DataSource = list;

            // Tự động chọn dòng đầu tiên (nếu có)
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập mã NV và tên NV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee em = new Employee
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                Gender = cbGender.Checked
            };

            list.Add(em);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
            XoaTextBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridView1.CurrentRow.Index;
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                list.RemoveAt(index);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
                XoaTextBox();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                XoaTextBox();
                return;
            }

            int index = dataGridView1.CurrentRow.Index;
            txtId.Text = list[index].Id;
            txtName.Text = list[index].Name;
            txtAge.Text = list[index].Age.ToString();
            cbGender.Checked = list[index].Gender;
        }

        private void XoaTextBox()
        {
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            cbGender.Checked = false;
        }
    }

    // Lớp Employee
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; } // true = Nam, false = Nữ
    }
}