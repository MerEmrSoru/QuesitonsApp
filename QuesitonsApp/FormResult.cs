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
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");
        private void FormResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quesitonAppDataSet5.Tbl_RightQuestions' table. You can move, or remove it, as needed.
            this.tbl_RightQuestionsTableAdapter.Fill(this.quesitonAppDataSet5.Tbl_RightQuestions);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            SqlCommand cmd2 = new SqlCommand("TRUNCATE TABLE Tbl_RightQuestions ", connection); //silinen tablo id sıfırlamak için
            connection.Open();
            cmd2.ExecuteNonQuery();
            connection.Close();
            this.Hide();
        }
    }
}
