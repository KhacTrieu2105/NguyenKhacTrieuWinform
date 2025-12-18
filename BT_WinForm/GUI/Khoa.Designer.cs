namespace BT_WinForm.GUI
{
    partial class Khoa
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
            cb_Faculty = new ComboBox();
            tbDisplay = new TextBox();
            button1 = new Button();
            btOK = new Button();
            SuspendLayout();
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Items.AddRange(new object[] {});
            cb_Faculty.Location = new Point(90, 96);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(602, 28);
            cb_Faculty.TabIndex = 0;
            cb_Faculty.SelectedValueChanged += cb_Faculty_SelectedValueChanged;
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(90, 164);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(602, 145);
            tbDisplay.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(401, 393);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            btOK.Location = new Point(625, 397);
            btOK.Name = "btOK";
            btOK.Size = new Size(94, 29);
            btOK.TabIndex = 3;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // Khoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btOK);
            Controls.Add(button1);
            Controls.Add(tbDisplay);
            Controls.Add(cb_Faculty);
            Name = "Khoa";
            Text = "Khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Faculty;
        private TextBox tbDisplay;
        private Button button1;
        private Button btOK;
    }
}