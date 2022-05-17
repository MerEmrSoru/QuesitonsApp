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
using System.IO;

namespace QuesitonsApp
{
    public partial class FormQuestion : Form
    {
        public FormQuestion()
        {
            InitializeComponent();
        }
        


        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");
       
        
        private void FormQuestion_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'quesitonAppDataSet3.Tbl_Question' table. You can move, or remove it, as needed.
            this.tbl_QuestionTableAdapter.Fill(this.quesitonAppDataSet3.Tbl_Question);

            DataTable tbl = new DataTable();
            connection.Open();           
            SqlDataAdapter adtr = new SqlDataAdapter("select *from tbl_Question ", connection);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();

            //Soru Sayısını alır
            connection.Open();
            SqlCommand com=new SqlCommand("Select Count(*)From Tbl_Question",connection);
            lblRandQu.Text=com.ExecuteScalar().ToString();
            connection.Close();
        }       
        private void ButtonAfterQuest_Click(object sender, EventArgs e)
        {
            int RandQ;
            RandQ = Convert.ToInt32(lblRandQu.Text);

            Random Random = new Random();
            //   for (int QuestionNumber = 1; QuestionNumber <= 10; QuestionNumber++) //10 soruluk bir sınav hazırlanacağı için fonksiyonu 10 kere çalıştıracak olan kod yazıldı 
            // {
            int QuestionRandom = Random.Next(0, RandQ-4); //Rastgele sorular seçmek üzere "QuestionRandom" değişkeni oluşturuldu


            //  }

            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from Tbl_Question where QuestionId='" + QuestionRandom + "'", connection); ;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Image"] != null)
                {
                    byte[] image = new byte[0];
                    image = (byte[])dr["Image"];
                    MemoryStream memorystream = new MemoryStream(image);
                    pctimage.Image = Image.FromStream(memorystream);
                    dr.Close();
                    cmd.Dispose();
                    connection.Close();

                }
            }
            connection.Close();

            LblQuestion.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[1].Value.ToString();
            lblSchoolObject.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[2].Value.ToString();
            lblUnitId.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[3].Value.ToString();
            lblSubjecIId.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[4].Value.ToString();
            LblCorrect.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[5].Value.ToString();

            RdbA.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[7].Value.ToString();
            RdbB.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[8].Value.ToString();
            RdbC.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[9].Value.ToString();
            RdbD.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[10].Value.ToString();
        }

        
    }
}
