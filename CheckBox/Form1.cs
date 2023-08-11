using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tb1.Text;
            string pass = tb2.Text;

            if(name =="nithu" && pass == "123")
            {
                Form2  form = new Form2(tb1.Text);
                form.Show();
                this.Hide();
               
            }
        }
    }
}
