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
    public partial class PI : Form
    {
        public PI()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=project_parbon");
            string InsertQuery = "INSERT INTO project_parbon.bookingdetails(Name,MobileNumber,Location,DateofBooking,Time) Values(' " + textBox1.Text + "',' " + textBox2.Text + "','" + textBox3.Text + "',' " + textBox4.Text + "',' " + textBox5.Text + "')";
            MySqlCommand command = new MySqlCommand(InsertQuery, DBconnect);
            MySqlDataReader mySqlData;
            DBconnect.Open();
            mySqlData = command.ExecuteReader();
            MessageBox.Show("Order Placed, Thank you for using our service");
            DBconnect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
