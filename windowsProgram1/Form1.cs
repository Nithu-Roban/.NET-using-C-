using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsProgram1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp;
            temp = label1.Text;
            label1.Text = label2.Text;
            label2.Text = temp;
            button1.BackColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tb1.Text == "nithu")
            {
                button2.BackColor = Color.Purple;
                label4.Text = "Hiii \t" + tb1.Text;
            }
        }
    }
}
