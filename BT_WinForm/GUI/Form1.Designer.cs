namespace BT_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            bt7 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(22, 86);
            btn1.Name = "btn1";
            btn1.Size = new Size(151, 56);
            btn1.TabIndex = 0;
            btn1.Text = "Profile";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(273, 86);
            button2.Name = "button2";
            button2.Size = new Size(151, 56);
            button2.TabIndex = 1;
            button2.Text = "Year and Phone Number";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(509, 86);
            button3.Name = "button3";
            button3.Size = new Size(151, 56);
            button3.TabIndex = 2;
            button3.Text = "Caculator";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(22, 250);
            button4.Name = "button4";
            button4.Size = new Size(151, 56);
            button4.TabIndex = 3;
            button4.Text = "Caculator_2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(273, 250);
            button5.Name = "button5";
            button5.Size = new Size(151, 56);
            button5.TabIndex = 4;
            button5.Text = "Simple Caculator";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(509, 250);
            button6.Name = "button6";
            button6.Size = new Size(151, 56);
            button6.TabIndex = 5;
            button6.Text = "Khoa";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // bt7
            // 
            bt7.Location = new Point(22, 357);
            bt7.Name = "bt7";
            bt7.Size = new Size(151, 65);
            bt7.TabIndex = 6;
            bt7.Text = "Giảm giá";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += bt7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button bt7;
    }
}
