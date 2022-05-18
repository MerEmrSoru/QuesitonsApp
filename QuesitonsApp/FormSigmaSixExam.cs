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
    public partial class FormSigmaSixExam : Form
    {
        public string Answer;
        public FormSigmaSixExam()
        {
            InitializeComponent();
        }
        int x;
        int second = 60;
        public int minute = 10;
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");
        public void FormSigma6Exam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quesitonAppDataSet4.Tbl_Exam1' table. You can move, or remove it, as needed.
            this.tbl_Exam1TableAdapter.Fill(this.quesitonAppDataSet4.Tbl_Exam1);

            // TODO: This line of code loads data into the 'quesitonAppDataSet3.Tbl_Question' table. You can move, or remove it, as needed.
            this.tbl_QuestionTableAdapter.Fill(this.quesitonAppDataSet3.Tbl_Question);

            DataTable tbl = new DataTable();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from tbl_Question ", connection);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();

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



            StepOne();

        }
        public void StepOne()
        {
            bool FirstTimeTrue = false; //Bir sorunun ilk defa doğru yapılıp yapılmadığını denetler
            int FirstTimeDayInterval = 1; //İlk zaman aralığını bir gün olmak üzere ayarlar

            //Soru Sayısını alır
            connection.Open();
            SqlCommand com = new SqlCommand("Select Count(*)From Tbl_Question", connection);
            lblRandQu.Text = com.ExecuteScalar().ToString();
            connection.Close();
            BtnNextQuest.PerformClick();

            int RandQ;
            RandQ = Convert.ToInt32(lblRandQu.Text);
            Random Random = new Random();

            for (int QuestionNumber = 1; QuestionNumber <= 10; QuestionNumber++) //10 soruluk bir sınav hazırlanacağı için fonksiyonu 10 kere çalıştıracak olan kod yazıldı 
            {
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

                LblQuestion.Text = dataGridView1.Rows[QuestionRandom - 2].Cells[1].Value.ToString();
                lblSchoolObject.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[2].Value.ToString();
                lblUnitId.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[3].Value.ToString();
                lblSubjecIId.Text = dataGridView1.Rows[QuestionRandom - 2].Cells[4].Value.ToString();
                LblCorrect.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[5].Value.ToString();

                RdbA.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[7].Value.ToString();
                RdbB.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[8].Value.ToString();
                RdbC.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[9].Value.ToString();
                RdbD.Text = dataGridView1.Rows[QuestionRandom - 1].Cells[10].Value.ToString();

                if (LblCorrect.Text == Answer)
                {
                    x++;
                    DateTime InitialTime = DateTime.Now.Date; //Başlangıç zamanını veritabanına kaydetmek üzere "InitialTime" değişkenine eşitler
                    FirstTimeTrue = true;

                    //Üst üste bir defa doğru işaretlenen soruların tutulduğu veritabanı kodu buraya yazılacak
                    connection.Open();
                    SqlCommand cmdd = new SqlCommand("insert into Tbl_Exam1(QuestionID,ExamDate) values (@p1,@p2)", connection);
                    cmdd.Parameters.AddWithValue("@p1", QuestionRandom);
                    cmdd.Parameters.AddWithValue("@p2", InitialTime);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

            }

        }

        public void StepTwo()
        {

            if (x > 0) // && InitialTime + FirstTimeDayInterval == DateTime.Now) 
            {
                bool SecondTimeTrue = false; //Bir sorunun ikinci defa üst üste doğru yapılıp yapılmadığını denetler
                int SecondTimeWeekInterval = 1; //İkinci zaman aralığını 1 hafta olmak üzere ayarlar

                listBox1.Items.Clear();
                connection.Open();
                SqlCommand kmt = new SqlCommand("Select *from Tbl_Exam1", connection);
                SqlDataReader read = kmt.ExecuteReader();
                while (read.Read())
                {
                    listBox1.Items.Add(read[1]);
                }
                connection.Close();

                int numb = listBox1.Items.Count;
                Random rndm = new Random();
                int randnum = rndm.Next(0, 5);
                listBox1.SelectedIndex = randnum;
                lblRandNumb.Text = listBox1.SelectedItem.ToString();
                int QuestRandSt2 = Convert.ToInt32(lblRandNumb.Text);

                //Veritabanından soruyu forma yazdıracak kod buraya yazılacak
                connection.Open();
                SqlCommand cmd = new SqlCommand("select *from Tbl_Exam1 where QuestionId='" + QuestRandSt2 + "'", connection); ;
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

                LblQuestion.Text = dataGridView1.Rows[QuestRandSt2 - 2].Cells[1].Value.ToString();
                lblSchoolObject.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[2].Value.ToString();
                lblUnitId.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[3].Value.ToString();
                lblSubjecIId.Text = dataGridView1.Rows[QuestRandSt2 - 2].Cells[4].Value.ToString();
                LblCorrect.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[5].Value.ToString();

                RdbA.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[7].Value.ToString();
                RdbB.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[8].Value.ToString();
                RdbC.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[9].Value.ToString();
                RdbD.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[10].Value.ToString();

                if (LblCorrect.Text == Answer)
                {
                    SecondTimeTrue = true;
                    //Üst üste iki defa doğru işaretlenen soruların tutulduğu veritabanı kodu buraya yazılacak
                    connection.Open();
                    SqlCommand cmdd = new SqlCommand("insert into Tbl_Exam2(QuestionID,ExamDate) values (@p1,@p2)", connection);
                    cmdd.Parameters.AddWithValue("@p1", QuestRandSt2);
                    cmdd.Parameters.AddWithValue("@p2", DateTime.Now.Date);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    //Sorunun başa geri döndürüldüğü (algoritma veritabanından çıkartıldığı) kod buraya yazılmalı
                    connection.Open();
                    SqlCommand cmdDelete = new SqlCommand("Delete from Tbl_Exam1 And Tbl_Exam1 where QuestionId=@k1", connection);
                    cmdDelete.Parameters.AddWithValue("@k1", QuestRandSt2);
                    cmdDelete.ExecuteNonQuery();
                    MessageBox.Show("Deletion successful");
                    connection.Close();
                }


            }
        }

        public void StepThree(bool SecondTimeTrue)
        {
            if (SecondTimeTrue == true /* && InitialTime + SecondTimeWeekInterval == DateTime.Now) */)
            {
                bool ThirdTimeTrue = false; //Bir sorunun ikinci defa üst üste doğru yapılıp yapılmadığını denetler
                int ThirdTimeMonthInterval = 3; //İkinci zaman aralığını 3 ay olmak üzere ayarlar

                listBox1.Items.Clear();
                connection.Open();
                SqlCommand cmdStep3 = new SqlCommand("Select*from Tbl_Exam2", connection);
                SqlDataReader read = cmdStep3.ExecuteReader();
                while (read.Read())
                {
                    listBox1.Items.Add(read[1]);
                }
                connection.Close();
                int numb = listBox1.Items.Count;
                Random rndm = new Random();
                int sayi = rndm.Next(0, 5);
                listBox1.SelectedIndex = sayi;
                lblRandNumb.Text = listBox1.SelectedItem.ToString();
                int QuestRandSt2 = Convert.ToInt32(lblRandNumb.Text);
                //Veritabanından soruyu forma yazdıracak kod buraya yazılacak
                connection.Open();
                SqlCommand cmd = new SqlCommand("select *from Tbl_Exam3 where QuestionId='" + QuestRandSt2 + "'", connection); ;
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

                LblQuestion.Text = dataGridView1.Rows[QuestRandSt2 - 2].Cells[1].Value.ToString();
                lblSchoolObject.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[2].Value.ToString();
                lblUnitId.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[3].Value.ToString();
                lblSubjecIId.Text = dataGridView1.Rows[QuestRandSt2 - 2].Cells[4].Value.ToString();
                LblCorrect.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[5].Value.ToString();

                RdbA.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[7].Value.ToString();
                RdbB.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[8].Value.ToString();
                RdbC.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[9].Value.ToString();
                RdbD.Text = dataGridView1.Rows[QuestRandSt2 - 1].Cells[10].Value.ToString();
                //if(CorrectAnswer == Answer)
                //{
                ThirdTimeTrue = true;
                //Üst üste üç defa doğru işaretlenen soruların tutulduğu veritabanı kodu buraya yazılacak
                //}
                //else 
                //{
                //Sorunun başa geri döndürüldüğü (algoritma veritabanından çıkartıldığı) kod buraya yazılmalı
                //}

                SecondTimeTrue = false; //Bool tipindeki değişken bir daha kullanılabilmek üzere sıfırlandı
            }
        }

        public void StepFour(bool ThirdTimeTrue)
        {
            if (ThirdTimeTrue == true /* && InitialTime + ThirdTimeMonthInterval == DateTime.Now) */)
            {
                bool FourthTimeTrue = false; //Bir sorunun ikinci defa üst üste doğru yapılıp yapılmadığını denetler
                int FourthTimeMonthInterval = 6; //İkinci zaman aralığını 6 ay olmak üzere ayarlar

                //Veritabanından soruyu forma yazdıracak kod buraya yazılacak

                //if(CorrectAnswer == Answer)
                //{
                FourthTimeTrue = true;
                //Üst üste dört defa doğru işaretlenen soruların tutulduğu veritabanı kodu buraya yazılacak
                //}
                //else 
                //{
                //Sorunun başa geri döndürüldüğü (algoritma veritabanından çıkartıldığı) kod buraya yazılmalı
                //}

                ThirdTimeTrue = false; //Bool tipindeki değişken bir daha kullanılabilmek üzere sıfırlandı
            }
        }

        public void StepFive(bool FourthTimeTrue)
        {
            if (FourthTimeTrue == true /* && InitialTime + FourthTimeMonthInterval == DateTime.Now) */)
            {
                bool FifthTimeTrue = false; //Bir sorunun ikinci defa üst üste doğru yapılıp yapılmadığını denetler
                int FifthTimeYearInterval = 1; //İkinci zaman aralığını 1 yıl olmak üzere ayarlar

                //Veritabanından soruyu forma yazdıracak kod buraya yazılacak

                //if(CorrectAnswer == Answer)
                //{
                FifthTimeTrue = true;
                //Üst üste beş defa doğru işaretlenen soruların tutulduğu veritabanı kodu buraya yazılacak
                //}
                //else 
                //{
                //Sorunun başa geri döndürüldüğü (algoritma veritabanından çıkartıldığı) kod buraya yazılmalı
                //}

                FourthTimeTrue = false; //Bool tipindeki değişken bir daha kullanılabilmek üzere sıfırlandı
            }
        }

        public void StepSix(bool FifthTimeTrue)
        {
            if (FifthTimeTrue == true /* && InitialTime + FifthTimeYearInterval == DateTime.Now) */)
            {
                //Bir sorunun altıncı defa üst üste doğru yapılıp yapılmadığını denetler
                //Altı kere üst üste doğru cevaplanan sorunun sistemden çıkartılmasını sağlar

                //Veritabanından soruyu forma yazdıracak kod buraya yazılacak

                //if(CorrectAnswer == Answer)
                //{
                //Buraya gelmiş soruları bir daha sorulmamak üzere veritabanından çıkartacak kod buraya yazılacak
                //}
                //else 
                //{
                //Sorunun başa geri döndürüldüğü (algoritma veritabanından çıkartıldığı) kod buraya yazılmalı
                FifthTimeTrue = false; //Bool tipindeki değişken bir daha kullanılabilmek üzere sıfırlanacak
                //}
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

            if (lblMin.Text == "00" && lblSec.Text == "10")
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

        private void BtnNextQuest_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
