using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kinoteka
{
    public partial class WhatHappensInVegas : Form
    {
        public WhatHappensInVegas()
        {
            InitializeComponent();
        }

        private void btnPlay7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филмот ќе започне во секој момент!");
            Application.Exit();
        }

        private void btnCancel7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
