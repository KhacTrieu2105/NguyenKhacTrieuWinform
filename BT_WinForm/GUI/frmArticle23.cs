using System;
using System.Drawing;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class frmArticle23 : Form
    {
        private PictureBox pbImage;
        private Button btnLoad;
        private Button btnLeft;
        private Button btnRight;

        public frmArticle23()
        {
            InitializeComponent();
            SetupControls();
        }

        private void SetupControls()
        {
            // PictureBox
            pbImage = new PictureBox();
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.Size = new Size(300, 400);
            pbImage.Location = new Point(250, 50);
            //pbImage.Image = Image.FromFile("default.jpg"); // Đổi đường dẫn ảnh mặc định nếu có
            this.Controls.Add(pbImage);

            // Nút Load
            btnLoad = new Button();
            btnLoad.Text = "Load";
            btnLoad.Size = new Size(100, 40);
            btnLoad.Location = new Point(200, 480);
            btnLoad.Click += BtnLoad_Click;
            this.Controls.Add(btnLoad);

            // Nút Left
            btnLeft = new Button();
            btnLeft.Text = "Left";
            btnLeft.Size = new Size(100, 40);
            btnLeft.Location = new Point(320, 480);
            btnLeft.Click += BtnLeft_Click;
            this.Controls.Add(btnLeft);

            // Nút Right
            btnRight = new Button();
            btnRight.Text = "Right";
            btnRight.Size = new Size(100, 40);
            btnRight.Location = new Point(440, 480);
            btnRight.Click += BtnRight_Click;
            this.Controls.Add(btnRight);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Chọn ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbImage.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở ảnh!\nLỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (pbImage.Location.X > 0)
            {
                pbImage.Location = new Point(pbImage.Location.X - 20, pbImage.Location.Y);
            }
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (pbImage.Location.X < this.ClientSize.Width - pbImage.Width)
            {
                pbImage.Location = new Point(pbImage.Location.X + 20, pbImage.Location.Y);
            }
        }
    }
}