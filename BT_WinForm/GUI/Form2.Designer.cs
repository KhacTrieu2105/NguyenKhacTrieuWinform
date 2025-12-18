namespace BT_WinForm.GUI
{
    partial class Form2
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
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
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
            checkBox1.Location = new Point(114, 123);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(114, 242);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(399, 122);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(601, 61);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(59, 68);
            lb1.Name = "lb1";
            lb1.Size = new Size(49, 20);
            lb1.TabIndex = 4;
            lb1.Text = "Name";
            lb1.Click += label1_Click;
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(114, 60);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(402, 27);
            txtBox1.TabIndex = 5;
            txtBox1.TextChanged += txtBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(402, 28);
            comboBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H" });
            listBox1.Location = new Point(114, 302);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(257, 104);
            listBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(517, 407);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(657, 407);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(txtBox1);
            Controls.Add(lb1);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private Label lb1;
        private TextBox txtBox1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}