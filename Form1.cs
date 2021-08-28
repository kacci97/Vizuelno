using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbHowToLoseAGuy_Click(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            HowToLoseAGuy howToLoseAGuy = new HowToLoseAGuy();
            howToLoseAGuy.Show();
            

            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TheProposal proposal = new TheProposal();
            proposal.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FriendsWithBenefits friend = new FriendsWithBenefits();
            friend.Show();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            WhatHappensInVegas vegas = new WhatHappensInVegas();
            vegas.Show();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CrazyStuipidLove stuipidLove = new CrazyStuipidLove();
            stuipidLove.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CrazyRichAsians asians = new CrazyRichAsians();
            asians.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NoStringsAttached noStrings = new NoStringsAttached();
            noStrings.Show();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TheOtherWoman woman = new TheOtherWoman();
            woman.Show();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string movie = tbSearch.Text.ToLower();
            if (movie.Equals("crazy rich asians"))
            {
                CrazyRichAsians crazyRichAsians = new CrazyRichAsians();
                crazyRichAsians.Show();
            }
            else if (movie.Equals("how to lose a guy in 10 days"))
            {
                HowToLoseAGuy howToLoseAGuy = new HowToLoseAGuy();
                howToLoseAGuy.Show();
            }
            else if (movie.Equals("friends with benefits"))
            {
                FriendsWithBenefits friends = new FriendsWithBenefits();
                friends.Show();
            }
            else if (movie.Equals("the proposal"))
            {
                TheProposal proposal = new TheProposal();
                proposal.Show();
            }
            else if (movie.Equals("crazy, stupid, love"))
            {
                CrazyStuipidLove love = new CrazyStuipidLove();
                love.Show();
            }
            else if (movie.Equals("no strings attached"))
            {
                NoStringsAttached strings = new NoStringsAttached();
                strings.Show();
            }
            else if (movie.Equals("what happens in vegas"))
            {
                WhatHappensInVegas vegas = new WhatHappensInVegas();
                vegas.Show();
            }
            else if (movie.Equals("the other woman"))
            {
                TheOtherWoman woman = new TheOtherWoman();
                woman.Show();
            }
            else
            {
                MessageBox.Show("The movie you are looking for doesn't exist");
            }




        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            lbDurration m = new lbDurration();
            m.Show();
        }
    }
}
