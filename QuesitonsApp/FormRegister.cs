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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");


        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormStudentLogin f1=new FormStudentLogin();
            f1.Show();
            this.Hide();
        }

        private void btnRegis_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            if (rdbRStud.Checked == true)
            {
                TxtUserType.Text = "1";

            }
            else if (rdbRTeach.Checked == true)
            {
                TxtUserType.Text = "2";
            }

            if (TxtUsername.Text == " " || TxtMail.Text == " " || TxtPassword.Text == " " || TxtRname.Text == " " || TxtSurname.Text == " " || TxtUserType.Text == " " || TxtMail.Text == String.Empty || TxtPassword.Text == String.Empty || TxtRname.Text == String.Empty || TxtSurname.Text == String.Empty || TxtUsername.Text == String.Empty)
            {
                MessageBox.Show("Texts ​​must be entered in the boxes!! ");
            }
            else if (rdbRStud.Checked == false && rdbRTeach.Checked == false)
            {
                MessageBox.Show(" Choose one of the options ");
            }
            else
            {
                MessageBox.Show("REGISTRATION COMPLETED SUCCESSFULLY!!");

                SqlCommand cmd = new SqlCommand("insert into Tbl_User(Username,Name,Surname,Mail,Password,UserTypeID) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
                cmd.Parameters.AddWithValue("@p1", TxtUsername.Text);
                cmd.Parameters.AddWithValue("@p2", TxtRname.Text);
                cmd.Parameters.AddWithValue("@p3", TxtSurname.Text);
                cmd.Parameters.AddWithValue("@p4", TxtMail.Text);
                cmd.Parameters.AddWithValue("@p5", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@p6", TxtUserType.Text);
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
