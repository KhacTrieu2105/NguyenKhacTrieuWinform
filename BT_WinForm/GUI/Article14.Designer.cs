namespace BT_WinForm.GUI
{
    partial class Article14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbName = new TextBox();
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            ckDiscount = new CheckBox();
            tbDiscount = new TextBox();
            tbResult = new TextBox();
            btRun_Click = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(48, 45);
            tbName.Name = "tbName";
            tbName.Size = new Size(397, 27);
            tbName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Location = new Point(48, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(153, 57);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 3;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(34, 57);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 2;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // ckDiscount
            // 
            ckDiscount.AutoSize = true;
            ckDiscount.Location = new Point(53, 221);
            ckDiscount.Name = "ckDiscount";
            ckDiscount.Size = new Size(91, 24);
            ckDiscount.TabIndex = 2;
            ckDiscount.Text = "Giảm giá";
            ckDiscount.UseVisualStyleBackColor = true;
            ckDiscount.CheckedChanged += ckDiscount_CheckedChanged;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(172, 221);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(176, 27);
            tbDiscount.TabIndex = 4;
            tbDiscount.TextChanged += tbDiscount_TextChanged;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(53, 254);
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(381, 117);
            tbResult.TabIndex = 5;
            // 
            // btRun_Click
            // 
            btRun_Click.Location = new Point(64, 409);
            btRun_Click.Name = "btRun_Click";
            btRun_Click.Size = new Size(94, 29);
            btRun_Click.TabIndex = 6;
            btRun_Click.Text = "Tính tiền";
            btRun_Click.UseVisualStyleBackColor = true;
            btRun_Click.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(282, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Article14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btRun_Click);
            Controls.Add(tbResult);
            Controls.Add(tbDiscount);
            Controls.Add(ckDiscount);
            Controls.Add(groupBox1);
            Controls.Add(tbName);
            Name = "Article14";
            Text = "Article14";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private CheckBox ckDiscount;
        private TextBox tbDiscount;
        private TextBox tbResult;
        private Button btRun_Click;
        private Button button2;
    }
}