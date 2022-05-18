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
        int second = 60;
        public int minute = 10;
        int QuestionNumber = 0;
        public string Answer;

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
            BtnNextQuest.PerformClick();
        }
        private void ButtonAfterQuest_Click(object sender, EventArgs e)
        {
            if (QuestionNumber<10)
            {
                QuestionNumber++;
            }
            else
            {
                FormResult fres = new FormResult();
                fres.Show();
                this.Hide();
            }
                timer1.Start();

                int RandQ;
                RandQ = Convert.ToInt32(lblRandQu.Text);

                Random Random = new Random();

                int QuestionRandom = Random.Next(0, RandQ); //Rastgele sorular seçmek üzere "QuestionRandom" değişkeni oluşturuldu


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
                lblQuestId.Text = dataGridView1.Rows[QuestionRandom].Cells[0].Value.ToString();
                LblQuestion.Text = dataGridView1.Rows[QuestionRandom - 2].Cells[1].Value.ToString();
                lblSchoolObject.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[2].Value.ToString();
                lblUnitId.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[3].Value.ToString();
                lblSubjecIId.Text = dataGridView1.Rows[QuestionRandom - 2].Cells[4].Value.ToString();
                LblCorrect.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[5].Value.ToString();

                RdbA.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[7].Value.ToString();
                RdbB.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[8].Value.ToString();
                RdbC.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[9].Value.ToString();
                RdbD.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[10].Value.ToString();

            if (RdbA.Checked)
            {
                Answer = "A";
            }
            else if (RdbB.Checked)
            {
                Answer = "B";
            }
            else if (RdbC.Checked)
            {
                Answer = "C";
            }
            else if (RdbD.Checked)
            {
                Answer = "D";
            }
            if (LblCorrect.Text == Answer)
            {

                connection.Open();
                SqlCommand cau = new SqlCommand("insert into Tbl_RightQuestions(QuestionId,UnitId,SubjectId) values (@p1,@p2,@p3)", connection);               
                cau.Parameters.AddWithValue("@p1", QuestionRandom);
                cau.Parameters.AddWithValue("@p2", lblUnitId.Text);
                cau.Parameters.AddWithValue("@p3", lblSubjecIId.Text);      
                cau.ExecuteNonQuery();
                connection.Close();
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            second = second - 1;
            lblSec.Text = Convert.ToString(second);
            lblMin.Text = Convert.ToString(minute - 1);
            if (second == 0)
            {

                minute = minute - 1;
                lblMin.Text = Convert.ToString(minute);
                second = 60;
            }

            if (second == 0)
            {

                minute = minute - 1;
                lblMin.Text = Convert.ToString(minute);
                second = 60;
            }

            if (lblMin.Text == "00" &&lblSec.Text=="10")
            {
                this.lblMin.BackColor = Color.Red;
                this.lblSec.BackColor = Color.Red;
            }
            if (lblMin.Text == "-1")
            {
                timer1.Stop();
                lblMin.Text = "00";
                lblSec.Text = "00";
                

            }
             
        }       
    }
}
