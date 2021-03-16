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
    public partial class WS1 : Form
    {
        public WS1()
        {
            InitializeComponent();
        }

        private void WS1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Stage Price: 25000 TK\nGate Price: 15000 TK\nPhotoshot Stage: 10000 TK\nStage + Gate + Photoshot Stage=45000TK");
            
        }
    }
}
