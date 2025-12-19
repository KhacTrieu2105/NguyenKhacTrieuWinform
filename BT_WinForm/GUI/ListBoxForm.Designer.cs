namespace BT_WinForm
{
    partial class ListBoxForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btDeselectAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btDeselect = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSong
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.ItemHeight = 20;
            this.lbSong.Items.AddRange(new object[] {
            "Giấc mơ Chapi",
            "Đôi mắt Pleiku",
            "Em muốn sống bên anh trọn đời",
            "H'Zen lên rẫy",
            "Còn thương nhau thì về Buôn Mê Thuột",
            "Ly cà phê Ban Mê",
            "Đi tìm lời ru mặt trời"});
            this.lbSong.Location = new System.Drawing.Point(30, 50);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(300, 304);
            this.lbSong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSong_MouseDoubleClick);
            // 
            // lbFavorite
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.ItemHeight = 20;
            this.lbFavorite.Location = new System.Drawing.Point(470, 50);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(300, 304);
            this.lbFavorite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFavorite_MouseDoubleClick);
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(360, 100);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(80, 40);
            this.btSelect.Text = ">";
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btDeselect
            // 
            this.btDeselect.Location = new System.Drawing.Point(360, 150);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(80, 40);
            this.btDeselect.Text = "<";
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);
            // 
            // btSelectAll
            // 
            this.btSelectAll.Location = new System.Drawing.Point(360, 200);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(80, 40);
            this.btSelectAll.Text = ">>";
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // btDeselectAll
            // 
            this.btDeselectAll.Location = new System.Drawing.Point(360, 250);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(80, 40);
            this.btDeselectAll.Text = "<<";
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);
            // 
            // ListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 420);
            this.Controls.Add(this.lbSong);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btDeselectAll);
            this.Name = "ListBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Favorite";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
