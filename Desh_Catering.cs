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
    public partial class Desh_Catering : Form
    {
        public Desh_Catering()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wedding w1 = new Wedding();
            w1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Holud h1 = new Holud();
            h1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Beddec b1 = new Beddec();
            b1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Khatna k1 = new Khatna();
            k1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
                Birthday b1 = new Birthday();
                b1.ShowDialog();
        }
    }
}
