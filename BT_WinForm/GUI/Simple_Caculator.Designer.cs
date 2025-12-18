namespace BT_WinForm.GUI
{
    partial class Simple_Caculator
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
            tbDisplay = new TextBox();
            bt0 = new Button();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btnPlus = new Button();
            btMul = new Button();
            btDoc = new Button();
            btEquals = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(18, 36);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(606, 81);
            tbDisplay.TabIndex = 0;
            // 
            // bt0
            // 
            bt0.Location = new Point(18, 154);
            bt0.Name = "bt0";
            bt0.Size = new Size(94, 65);
            bt0.TabIndex = 1;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(174, 154);
            bt1.Name = "bt1";
            bt1.Size = new Size(94, 65);
            bt1.TabIndex = 1;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(355, 154);
            bt2.Name = "bt2";
            bt2.Size = new Size(94, 65);
            bt2.TabIndex = 3;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(520, 154);
            bt3.Name = "bt3";
            bt3.Size = new Size(94, 65);
            bt3.TabIndex = 4;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(18, 266);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 62);
            btnPlus.TabIndex = 5;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btMul
            // 
            btMul.Location = new Point(174, 266);
            btMul.Name = "btMul";
            btMul.Size = new Size(94, 62);
            btMul.TabIndex = 6;
            btMul.Text = "*";
            btMul.UseVisualStyleBackColor = true;
            btMul.Click += btMul_Click;
            // 
            // btDoc
            // 
            btDoc.Location = new Point(355, 266);
            btDoc.Name = "btDoc";
            btDoc.Size = new Size(94, 62);
            btDoc.TabIndex = 7;
            btDoc.Text = ".";
            btDoc.UseVisualStyleBackColor = true;
            btDoc.Click += btDoc_Click;
            // 
            // btEquals
            // 
            btEquals.Location = new Point(520, 266);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(94, 62);
            btEquals.TabIndex = 8;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = true;
            btEquals.Click += btEquals_Click;
            // 
            // Simple_Caculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 340);
            Controls.Add(btEquals);
            Controls.Add(btDoc);
            Controls.Add(btMul);
            Controls.Add(btnPlus);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(bt0);
            Controls.Add(tbDisplay);
            Name = "Simple_Caculator";
            Text = "Simple_Caculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisplay;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btnPlus;
        private Button btMul;
        private Button btDoc;
        private Button btEquals;
    }
}