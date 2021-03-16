using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parbon
{
    
    public partial class Form1 : Form
    {
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            Community c1 = new Community();
            c1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Online_Restaurants OR1 = new Online_Restaurants();
            OR1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Catering cat1 = new Catering();
            cat1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decorator D1 = new Decorator();
            D1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LorS ls = new LorS();
            ls.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BookPack bp = new BookPack();
            bp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin add = new Admin();
            add.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserLogin us = new UserLogin();
            us.ShowDialog();
        }
    }
}
