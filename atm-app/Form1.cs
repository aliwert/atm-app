﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
