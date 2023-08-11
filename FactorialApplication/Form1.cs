using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int fact=1, count=0;
            
            int num = Convert.ToInt32(tb1.Text);
         //  label2.Text = num.ToString();
            for(int i = num; i >=1;i--)
            {
                fact =fact* i;
                count++;
            }
            label2.Text = fact.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }
    }
}
