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
    public partial class FormTeacherLogin : Form
    {
        public FormTeacherLogin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormUserSelect f1=new FormUserSelect();
            f1.Show();
            this.Hide();

        }

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_User where UserTypeID='2'and Username=@p1 and Password=@p2", connection);
            cmd.Parameters.AddWithValue("@p1", TxtUsername.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FormAddQuestion frm = new FormAddQuestion();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
            connection.Close();
        }

        private void LnkRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister frm = new FormRegister();
            frm.Show();
            this.Hide();
        }
    }
}
