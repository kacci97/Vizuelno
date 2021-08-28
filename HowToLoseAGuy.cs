using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kinoteka
{
    public partial class HowToLoseAGuy : Form
    {
        public HowToLoseAGuy()
        {
            InitializeComponent();
        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Филмот ќе започне во секој момент!");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
