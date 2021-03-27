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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconnect1 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            DBconnect1.Open();
            MySqlCommand command1 = new MySqlCommand("select * from project_parbon.user where NIDnumber='" + this.textBox1.Text + "' and Password= '" + this.textBox2.Text + "';", DBconnect1);
            MySqlDataReader myreader1;
            myreader1 = command1.ExecuteReader();
            int counter = 0;
            while (myreader1.Read())
            {
                counter = counter + 1;
            }

            if (counter == 1)
            {
                MessageBox.Show("Correct");
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else if (counter > 1)
            {
                MessageBox.Show("Duplicate");
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
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
                Form1 f1 = new Form1();
                f1.ShowDialog();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LorS ls = new LorS();
            ls.ShowDialog();
        }
    }
}
