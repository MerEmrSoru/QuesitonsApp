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

namespace QuesitonsApp
{
    public partial class FormStudentLogin : Form
    {
        public FormStudentLogin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");
        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           FormRegister f1=new FormRegister();
            f1.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormUserSelect f2 = new FormUserSelect();
            f2.Show();
            this.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_User where UserTypeID='1'and Username=@p1 and Password=@p2", connection);
            cmd.Parameters.AddWithValue("@p1", TxtMail.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FormStudentPanel f3=new FormStudentPanel();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
            connection.Close();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSendPassword f4=new FormSendPassword();
            f4.Show();
            this.Hide();
        }
    }
}
