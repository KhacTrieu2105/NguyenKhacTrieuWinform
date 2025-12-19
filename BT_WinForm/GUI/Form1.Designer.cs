namespace BT_WinForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private TableLayoutPanel menuLayout;
        private Button btn1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button bt7;
        private Button btListBox;
        private Button btnArticle19;
        private Button btnQuanLyNhanSu;
        private Button btnArticle20;
        private Button btnArticle21;
        private Button btnArticle22;
        private Button btnArticle23;
        private Button btnArticle24;
        private Button btnArticle25;  // Nút mới cho Article 25

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            menuLayout = new TableLayoutPanel();
            btn1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            bt7 = new Button();
            btListBox = new Button();
            btnArticle19 = new Button();
            btnQuanLyNhanSu = new Button();
            btnArticle20 = new Button();
            btnArticle21 = new Button();
            btnArticle22 = new Button();
            btnArticle23 = new Button();
            btnArticle24 = new Button();
            btnArticle25 = new Button();  // Khai báo nút mới

            SuspendLayout();

            // TITLE
            lblTitle.Text = "MENU CHỨC NĂNG";
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Height = 70;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // TABLE LAYOUT
            menuLayout.Dock = DockStyle.Fill;
            menuLayout.ColumnCount = 2;
            menuLayout.RowCount = 11;  // Tăng lên 11 hàng
            menuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            menuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            for (int i = 0; i < 11; i++)
                menuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.09F)); // Chia đều

            // Thiết lập chung cho button
            Button[] buttons =
            {
                btn1, button2, button3, button4,
                button5, button6, bt7, btListBox,
                btnArticle19, btnQuanLyNhanSu, btnArticle20, btnArticle21,
                btnArticle22, btnArticle23, btnArticle24, btnArticle25
            };
            foreach (Button btn in buttons)
            {
                btn.Dock = DockStyle.Fill;
                btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                btn.Margin = new Padding(15);
            }

            // TEXT
            btn1.Text = "Profile";
            button2.Text = "Year & Phone";
            button3.Text = "Calculator";
            button4.Text = "Calculator 2";
            button5.Text = "Simple Calculator";
            button6.Text = "Chọn Khoa";
            bt7.Text = "sale";
            btListBox.Text = "ListBox Bài Hát";
            btnArticle19.Text = "Article 19 - QLNS Ảnh 3x4";
            btnQuanLyNhanSu.Text = "Article 19 - QLNS DataGridView";
            btnArticle20.Text = "Article 20 - DataGridView SV";
            btnArticle21.Text = "Article 21 - DataGridView NV";
            btnArticle22.Text = "Article 22 - BindingSource";
            btnArticle23.Text = "Article 23 - PictureBox";
            btnArticle24.Text = "Article 24 - Timer";
            btnArticle25.Text = "Article 25 - ProgressBar";

            // EVENTS
            btn1.Click += btn1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click_1;
            button6.Click += button6_Click_1;
            bt7.Click += bt7_Click;
            btListBox.Click += btListBox_Click;
            btnArticle19.Click += btnArticle19_Click;
            btnQuanLyNhanSu.Click += btnQuanLyNhanSu_Click;
            btnArticle20.Click += btnArticle20_Click;
            btnArticle21.Click += btnArticle21_Click;
            btnArticle22.Click += btnArticle22_Click;
            btnArticle23.Click += btnArticle23_Click;
            btnArticle24.Click += btnArticle24_Click;
            btnArticle25.Click += btnArticle25_Click;  // Sự kiện cho Article 25

            // ADD TO GRID
            menuLayout.Controls.Add(btn1, 0, 0);
            menuLayout.Controls.Add(button2, 1, 0);
            menuLayout.Controls.Add(button3, 0, 1);
            menuLayout.Controls.Add(button4, 1, 1);
            menuLayout.Controls.Add(button5, 0, 2);
            menuLayout.Controls.Add(button6, 1, 2);
            menuLayout.Controls.Add(bt7, 0, 3);
            menuLayout.Controls.Add(btListBox, 1, 3);
            menuLayout.Controls.Add(btnArticle19, 0, 4);
            menuLayout.Controls.Add(btnQuanLyNhanSu, 1, 4);
            menuLayout.Controls.Add(btnArticle20, 0, 5);
            menuLayout.Controls.Add(btnArticle21, 1, 5);
            menuLayout.Controls.Add(btnArticle22, 0, 6);
            menuLayout.Controls.Add(btnArticle23, 1, 6);
            menuLayout.Controls.Add(btnArticle24, 0, 7);
            menuLayout.Controls.Add(btnArticle25, 0, 8);  // Nút Article 25 ở hàng 8, cột trái (hàng dưới cùng)

            // FORM - Tăng chiều cao để hiển thị hết 11 hàng
            ClientSize = new Size(800, 1050);
            Controls.Add(menuLayout);
            Controls.Add(lblTitle);
            Text = "Main Menu";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }
    }
}