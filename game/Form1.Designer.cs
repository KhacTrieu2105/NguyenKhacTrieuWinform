using System.Drawing;
using System.Windows.Forms;

namespace SpaceShooterGame
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // GameForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(500, 600);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Space Shooter";
            Load += GameForm_Load;
            ResumeLayout(false);
        }
    }
}
