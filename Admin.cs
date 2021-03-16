using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Parbon
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            textBox10.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            MySqlCommand command = new MySqlCommand("select * from project_parbon.admin where AdminID='" + this.textBox9.Text + "' and Password= '" + this.textBox10.Text + "';", DBconnect);
            MySqlDataReader myreader;
            DBconnect.Open();
            myreader = command.ExecuteReader();
            int count = 0;
            while (myreader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Correct");
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate");
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }
    }
}
