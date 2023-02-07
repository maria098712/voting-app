using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;

namespace mainhun
{
    public partial class Register : Form
    {
        
        SqlConnection con = new SqlConnection("Data source = sqlserver.dynamicdna .co.za; initial catalog= voting-thendo; password=zxchvf ");

        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form1 lf = new Form1();
            lf.Show();
            this.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                voting mainForm = new voting();
                mainForm.ShowDialog();
            
            try
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("Insert into voter values('"+textBox1.Text+"','"+textBox2.Text+"' ) ", con);
                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show(" sucess, you will be redirected to login page.");
                        sendEmail();
                        Form1 lf = new Form1();
                        lf.Show();
                        this.Hide();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(" failed to register");
                    }

                    con.Close();

                }
                catch(Exception) 
                {
                    MessageBox.Show("failed to connect to database.");
                }

            }
            else
            {
                MessageBox.Show("registration Failed !!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        /* private void sendEmail()
         {
             try
             {
                 MailMessage msg = new MailMessage();
                 msg.From = new MailAddress("mariakhan15ty@gmail.com");
                 msg.To.Add(email);
                 msg.Subject="Wellcome to voting";
                 msg.Body = "hello, " + fullname + "/nWelcome to voting /n thank you";

                 SmtpClient smt = new SmtpClient();
                 smt.Host = " smtp gmail.com";
                 System.Net.NetworkCredential ntcd = new System.Net.NetworkCredential();
                 ntcd.UserName = " mariakhan15ty@gmail.com";
                 smt.Credentials = ntcd;
                 smt.EnableSsl = true;
                 smt.Port = 587;
                 smt.Send(msg);
                 MessageBox.Show("check your email");

             }
             catch (Exception)
             {
                 MessageBox.Show("failed to send email");

             }
         }*/

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
       {
            
            Form1 rf = new Form1();
            this.Hide();
            rf.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
         private void sendEmail()
         {
             try
             {
                 MailMessage msg = new MailMessage();
                 msg.From = new MailAddress("mariakhan15ty@gmail.com");
                 msg.To.Add(textBox1.Text);
                 msg.Subject="Wellcome to voting";
                msg.Body = "hello, " + textBox1.Text + "/nWelcome to voting /n thank you";

                 SmtpClient smt = new SmtpClient();
                 smt.Host = " smtp gmail.com";
                 System.Net.NetworkCredential ntcd = new System.Net.NetworkCredential();
                 ntcd.UserName = " mariakhan15ty@gmail.com";
                 smt.Credentials = ntcd;
                 smt.EnableSsl = true;
                 smt.Port = 587;
                 smt.Send(msg);
                 MessageBox.Show("check your email");

             }
             catch (Exception)
             {
                 MessageBox.Show("failed to send email");

             }
         }

    }
}
