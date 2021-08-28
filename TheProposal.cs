using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kinoteka
{
    public partial class TheProposal : Form
    {
        public TheProposal()
        {
            InitializeComponent();
        }

        private void btnPlay5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филмот ќе започне во секој момент!");
            Application.Exit();
        }

        private void btnCancel5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
