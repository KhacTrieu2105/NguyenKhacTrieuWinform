using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BT_WinForm.GUI
{
    public partial class article19 : Form
    {
        public article19()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Chọn ảnh 3x4";
            dlg.Filter = "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG files (*.png)|*.png|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbImage.ImageLocation = dlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở file!\nLỗi: " + ex.Message,
                                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void article19_Load(object sender, EventArgs e)
        {

        }
    }
}