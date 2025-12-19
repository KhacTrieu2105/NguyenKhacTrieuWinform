using System;
using System.Windows.Forms;

namespace BT_WinForm
{
    public partial class ListBoxForm : Form
    {
        public ListBoxForm()
        {
            InitializeComponent();
        }

        // > chọn 1 bài
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem == null) return;

            var song = lbSong.SelectedItem;
            lbFavorite.Items.Add(song);
            lbSong.Items.Remove(song);
        }

        // < bỏ chọn 1 bài
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem == null) return;

            var song = lbFavorite.SelectedItem;
            lbSong.Items.Add(song);
            lbFavorite.Items.Remove(song);
        }

        // >> chọn tất cả
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lbSong.Items)
            {
                lbFavorite.Items.Add(item);
            }
            lbSong.Items.Clear();
        }

        // << bỏ chọn tất cả
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lbFavorite.Items)
            {
                lbSong.Items.Add(item);
            }
            lbFavorite.Items.Clear();
        }

        // Double click chọn bài
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbSong.SelectedItem == null) return;

            var song = lbSong.SelectedItem;
            lbFavorite.Items.Add(song);
            lbSong.Items.Remove(song);
        }

        // Double click bỏ chọn bài
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbFavorite.SelectedItem == null) return;

            var song = lbFavorite.SelectedItem;
            lbSong.Items.Add(song);
            lbFavorite.Items.Remove(song);
        }
    }
}
