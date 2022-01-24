using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtStringX_TextChanged(object sender, EventArgs e)
        {
            if (txtStringX.Text == "")
            {
                MessageBox.Show("Please enter a valid string", "String X");
            }
            else if (txtStringX.TextLength > 1024)
            {
                MessageBox.Show("Please enter a shorter string", "String X");
                txtStringX.Text = "";
            }
        }

        private void txtStringY_TextChanged(object sender, EventArgs e)
        {
            if (txtStringY.Text == "")
            {
                MessageBox.Show("Please enter a valid string", "String Y");
            }
            else if (txtStringY.TextLength > 1024)
            {
                MessageBox.Show("Please enter a shorter string", "String Y");
                txtStringY.Text = "";
            }
        }
    }
}
