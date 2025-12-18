using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_WinForm.GUI
{
    public partial class Simple_Caculator : Form
    {
        decimal wokingMemory = 0;
        string opr = "";
        public Simple_Caculator()
         
        {
            InitializeComponent();
            bt0.Click += new EventHandler(bt0_Click);
            bt1.Click += new EventHandler(bt1_Click);
            bt2.Click += new EventHandler(bt2_Click);
            bt3.Click += new EventHandler(bt3_Click);
            btMul.Click += new EventHandler(btMul_Click);
            btEquals.Click += new EventHandler(btEquals_Click);
            btnPlus.Click += new EventHandler(btnPlus_Click);
            btDoc.Click += new EventHandler(btDoc_Click);
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;

        }
        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text;

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt3.Text;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
         opr = btnPlus.Text;
            wokingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();

        }

        private void btMul_Click(object sender, EventArgs e)
        {

        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text);
            if( opr == "+")
                tbDisplay.Text = (wokingMemory +  secondValue).ToString ();
            if (opr == "*")
                tbDisplay.Text = (wokingMemory * secondValue).ToString();

        }

        private void btDoc_Click(object sender, EventArgs e)
        {

        }
    }
}
