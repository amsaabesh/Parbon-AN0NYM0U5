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
    public partial class BookPack : Form
    {
        int total = 0;
        public BookPack()
        {
            InitializeComponent();
        }

        private void BookPack_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PI pi = new PI();
            pi.ShowDialog();
            {
                MySqlConnection DBconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=project_parbon");
                MySqlDataReader mySqlData;
                DBconnect.Open();
                string InsertQuery1 = "INSERT INTO packagedetails(Catering,Wedding_Stage,Community_Center,Holud_Stage,Food,Total) Values(' " + comboBox1.SelectedItem + "',' " + comboBox2.SelectedItem + "','" + comboBox3.SelectedItem + "',' " + comboBox4.SelectedItem + "',' " + comboBox7.SelectedItem + "',' " + total + "')";
                MySqlCommand command2 = new MySqlCommand(InsertQuery1, DBconnect);
                mySqlData = command2.ExecuteReader();
                DBconnect.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.ToString() == "0")
            {
                total = total + 5000;
            }
            if (comboBox2.SelectedIndex.ToString() == "0")
            {
                total = total + 5000;
            }
            if (comboBox3.SelectedIndex.ToString() == "0")
            {
                total = total + 5000;
            }
            if (comboBox4.SelectedIndex.ToString() == "0")
            {
                total = total + 5000;
            }
            if (comboBox7.SelectedIndex.ToString() == "0")
            {
                total = total + 10000;
            }
            //MessageBox.Show(total.ToString());
            MessageBox.Show(string.Format("Total : {0}", total));
        }
    }
}
