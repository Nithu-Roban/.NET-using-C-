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
    public partial class Form2 : Form
    {
        public Form2( string newText)
        {
            InitializeComponent();
            fLabel.Text = "hiii \t"+newText;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void fLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
