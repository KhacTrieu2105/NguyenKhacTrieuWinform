namespace BT_WinForm.GUI
{
    partial class Form2
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
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            lb1 = new Label();
            txtBox1 = new TextBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(142, 154);
            checkBox1.Margin = new Padding(4, 4, 4, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(499, 152);
            radioButton1.Margin = new Padding(4, 4, 4, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(751, 76);
            numericUpDown1.Margin = new Padding(4, 4, 4, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(188, 31);
            numericUpDown1.TabIndex = 3;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(74, 85);
            lb1.Margin = new Padding(4, 0, 4, 0);
            lb1.Name = "lb1";
            lb1.Size = new Size(59, 25);
            lb1.TabIndex = 4;
            lb1.Text = "Name";
            lb1.Click += label1_Click;
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(142, 75);
            txtBox1.Margin = new Padding(4, 4, 4, 4);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(502, 31);
            txtBox1.TabIndex = 5;
            txtBox1.TextChanged += txtBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(142, 236);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(502, 33);
            comboBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H" });
            listBox1.Location = new Point(142, 378);
            listBox1.Margin = new Padding(4, 4, 4, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(320, 129);
            listBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(646, 509);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(821, 509);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(118, 36);
            button2.TabIndex = 9;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(txtBox1);
            Controls.Add(lb1);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private Label lb1;
        private TextBox txtBox1;
        private ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}