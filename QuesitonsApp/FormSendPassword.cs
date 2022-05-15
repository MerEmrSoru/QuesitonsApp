using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace QuesitonsApp
{
    public partial class FormSendPassword : Form
    {
        public FormSendPassword()
        {
            InitializeComponent();
        }
       
       


        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlBaglanti bgln = new SqlBaglanti();
            SqlCommand cmd = new SqlCommand("Select *from Tbl_Users where Username='" + txtUsername.Text.ToString() + "'and Email='" + TxtMail.Text.ToString() + "'", bgln.baglanti());

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                try
                {
                    if (bgln.baglanti().State == ConnectionState.Closed)
                    {
                        bgln.baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String Date = DateTime.Now.ToLongTimeString();
                    string mailAd = ("soruuygulama@gmail.com");
                    string password = ("kurti2001");
                    string smtpsrvr = "smtp.gmail.com";
                    string toWho = (read["Email"].ToString());
                    string subject = ("Password Expiration Report");
                    string write = ("Mrs/Ms," + read["Name"].ToString() + "\nyou requested a password reminder from us on" + Date + "\n" + "Your Password :" + read["Password"].ToString() + "\n Have a nice day.");

                    smtpserver.Credentials = new NetworkCredential(mailAd, password);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailAd);
                    mail.To.Add(toWho);
                    mail.Subject = subject;
                    mail.Body = write;
                    smtpserver.Send(mail);
                    DialogResult info = new DialogResult();
                    info = MessageBox.Show("Your password has been sent to your e-mail address.");
                    this.Hide();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error", error.Message);
                }
            }




        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormUserSelect f1=new FormUserSelect();
            f1.Show();
            this.Hide();
        }
    }
}
