using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kinoteka
{
    public partial class TheOtherWoman : Form
    {
        public TheOtherWoman()
        {
            InitializeComponent();
        }

        private void btnPlay8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филмот ќе започне во секој момент!");
            Application.Exit();
        }

        private void btnCancel8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
