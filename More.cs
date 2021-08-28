using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kinoteka
{
    public partial class lbDurration : Form
    {
        public lbDurration()
        {
            InitializeComponent();
        }

        private void btnAddName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Movie m = new Movie();
            m.name = btnNewMovieName.Text;
            m.rating = nudRating.Value;
            m.durration = nudDurration.Value;

            if (m.rating == 0 || m.durration == 0||m.name==null)
            {
                MessageBox.Show("Enter valid information");
            }
            
            else
            {
                lbNewMovies.Items.Add(m.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbNewMovies.SelectedIndex == -1)
            {
                MessageBox.Show("You must select movie");
            }
            else
            { 

                
                 lbNewMovies.Items.RemoveAt(lbNewMovies.SelectedIndex);
               

            }
        }

        private void tbRating_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNewMovies_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void btnCancelMore_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudDurration_Validating(object sender, CancelEventArgs e)
        {
            if (nudDurration.Value < 60)
            {
                errorProvider1.SetError(nudDurration, "Durration can't be lower then 60 minutes");
                e.Cancel = true;
            }      
        }

        private void nudRating_Validating(object sender, CancelEventArgs e)
        {
            if (nudRating.Value > 10)
            {
                errorProvider1.SetError(nudRating, "Rating can't be higher then 10");
                e.Cancel = true;
            }
        }
    }
}
