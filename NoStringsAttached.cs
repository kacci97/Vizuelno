using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kinoteka
{
    public partial class NoStringsAttached : Form
    {
        public NoStringsAttached()
        {
            InitializeComponent();
        }

        private void btnPlay6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филмот ќе започне во секој момент!");
            Application.Exit();
        }

        private void btnCancel6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
