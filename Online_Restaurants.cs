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
    public partial class Online_Restaurants : Form
    {
        public Online_Restaurants()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OF_aabesh aab1 = new OF_aabesh();
            aab1.ShowDialog();
        }
    }
}
