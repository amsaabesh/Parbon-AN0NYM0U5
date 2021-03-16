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
using System.Net;
using System.Net.Mail;

namespace Parbon
{
    public partial class LorS : Form
    {
        public LorS()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
        }

        private void LorS_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            string InsertQuery = "INSERT INTO project_parbon.user(NIDnumber,Name,Email,MobileNumber,Password,DateofBirth) Values(' " + textBox4.Text + "',' " + textBox5.Text + "','" + textBox6.Text + "',' " + textBox7.Text + "',' " + textBox3.Text + "',' " + textBox8.Text + "')";
            MySqlCommand command = new MySqlCommand(InsertQuery, DBconnect);
            MySqlDataReader mySqlData;
            DBconnect.Open();
            mySqlData = command.ExecuteReader();
            MessageBox.Show("Account Created. A Confermation message will send to your mail");
            String fromAddress = "shoaibaabesh@gmail.com";
            String toAddress = textBox6.Text;
            String password = "A@besh.1";
            MailMessage mail = new MailMessage();
            mail.Subject = "Parbon";
            mail.From = new MailAddress(fromAddress);
            mail.Body = "Thanks for using parbon. Have a Nice Day. Your Account has been Created.";
            mail.To.Add(new MailAddress(toAddress));

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            NetworkCredential nec = new NetworkCredential(fromAddress, password);
            smtp.Credentials = nec;
            smtp.Send(mail);
            MessageBox.Show("Account created. A confirmation mail is send on your email.");

        }
    }
}
