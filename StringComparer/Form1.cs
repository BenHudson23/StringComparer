﻿using System;
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
            else if (txtStringX.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid string", "String X");
            }
        }
    }
}
