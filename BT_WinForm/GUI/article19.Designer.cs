namespace BT_WinForm.GUI
{
    partial class article19
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pbImage = new PictureBox();
            btFile = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Location = new Point(500, 96);
            pbImage.Margin = new Padding(5, 6, 5, 6);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(250, 385);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // btFile
            // 
            btFile.Location = new Point(760, 201);
            btFile.Margin = new Padding(5, 6, 5, 6);
            btFile.Name = "btFile";
            btFile.Size = new Size(250, 58);
            btFile.TabIndex = 1;
            btFile.Text = "Chọn ảnh...";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 31);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 99);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 3;
            label1.Text = "MNV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 147);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 4;
            label2.Text = "Họ Tên";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(222, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 31);
            textBox2.TabIndex = 5;
            // 
            // article19
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 865);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btFile);
            Controls.Add(pbImage);
            Margin = new Padding(5, 6, 5, 6);
            Name = "article19";
            Text = "Quản lý nhân sự";
            Load += article19_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btFile;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
    }
}