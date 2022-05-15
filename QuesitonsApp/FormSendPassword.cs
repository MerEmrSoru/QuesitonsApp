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
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
          //  SqlCommand cmd = new SqlCommand("Select *from Tbl_Users where Username='" + txtUsername.Text.ToString() + "'and Email='" + TxtMail.Text.ToString() + "'", conn.
        }
    }
}
