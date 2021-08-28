using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kinoteka
{
    public partial class CrazyRichAsians : Form
    {
        public CrazyRichAsians()
        {
            InitializeComponent();
        }

        private void btnPlay3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филмот ќе започне во секој момент!");
            Application.Exit();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
