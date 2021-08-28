using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kinoteka
{
    public partial class FriendsWithBenefits : Form
    {
        public FriendsWithBenefits()
        {
            InitializeComponent();
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филмот ќе започне во секој момент!");
            Application.Exit();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FriendsWithBenefits_Load(object sender, EventArgs e)
        {

        }
    }
}
