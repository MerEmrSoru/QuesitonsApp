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
    public partial class FormAddQuestion : Form
    {
        public FormAddQuestion()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");
        string imagepath;
        private void dataQuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seç";
            ofd.Filter = "Jpeg File(*.jpeg)|*.jpeg| Jpg File(*.jpg)|*.jpg| Png File(*.png)|*.png| Gif File(*.gif)|*.gif| Tif File(*.tif)|tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pctImage.Image = Image.FromFile(ofd.FileName);
                imagepath = ofd.FileName;
            }
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {



            if (cmbSubjectID.SelectedItem == null || cmbObjects.SelectedItem == null || cmbRansw.SelectedItem == null)
            {
                MessageBox.Show("The fields cannot be left blank ");
            }

            else if (txtQuestion.Text == " ")
            {
                MessageBox.Show("a picture or question is required");
            }

            else if (cmbRansw.SelectedItem.ToString() == "A")
            {
                txtWans.Text = "B";
                txtWans2.Text = "C";
                txtWans3.Text = "D";
            }
            else if (cmbRansw.SelectedItem.ToString() == "B")
            {
                txtWans.Text = "A";
                txtWans2.Text = "C";
                txtWans3.Text = "D";
            }
            else if (cmbRansw.SelectedItem.ToString() == "C")
            {
                txtWans.Text = "A";
                txtWans2.Text = "B";
                txtWans3.Text = "D";
            }
            else if (cmbRansw.SelectedItem.ToString() == "D")
            {
                txtWans.Text = "A";
                txtWans2.Text = "B";
                txtWans3.Text = "C";
            }
            else MessageBox.Show(" ");


            if (cmbObjects.Text == "FEN BILIMLERI")
            {
                txtSchoolObj.Text = cmbObjects.SelectedItem.ToString();

                if (cmbUnıtID.SelectedItem.ToString() == "1")
                {
                    txtUnitName.Text = "Mevsimler Ve Iklim";

                    if (cmbSubjectID.SelectedItem.ToString() == "1")
                    {
                        txtSubjectName.Text = "Mevsimlerin Olusumu";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "2")
                    {
                        txtSubjectName.Text = "Iklim ve Hava Hareketleri";
                    }

                    else { MessageBox.Show("The fields cannot be left blank"); }

                }


                else if (cmbUnıtID.SelectedItem.ToString() == "2")
                {
                    txtUnitName.Text = ("Dna ve Genetik Kod");
                    if (cmbSubjectID.SelectedItem.ToString() == "1")
                    {
                        txtSubjectName.Text = "Dna ve Genetik Kod";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "2")
                    {
                        txtSubjectName.Text = "Kalitim";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "3")
                    {
                        txtSubjectName.Text = "Mutasyon Ve Modifikasyon";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "4")
                    {
                        txtSubjectName.Text = "Adaptasyon";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "2")
                    {
                        txtSubjectName.Text = "Biyoteknoloji";
                    }
                }

                else if (cmbUnıtID.SelectedItem.ToString() == "3")
                {
                    txtUnitName.Text = ("Basinc");
                    if (cmbSubjectID.SelectedItem.ToString() == "1")
                    {
                        txtSubjectName.Text = "Basinc";
                    }
                }



                else if (cmbUnıtID.SelectedItem.ToString() == "4")
                {
                    txtUnitName.Text = ("Madde ve Endustri");

                    if (cmbSubjectID.SelectedItem.ToString() == "1")
                    {
                        txtSubjectName.Text = "Periyodik Sistem";
                    }

                    else if (cmbSubjectID.SelectedItem.ToString() == "2")
                    {
                        txtSubjectName.Text = "Fiziksel ve kimyasal değisimler";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "3")
                    {
                        txtSubjectName.Text = "Kimyasal Tepkimeler";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "4")
                    {
                        txtSubjectName.Text = "Asitler ve Bazlar";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "5")
                    {
                        txtSubjectName.Text = "Maddenin Isi ve Etkilesimi";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "6")
                    {
                        txtSubjectName.Text = "Turkiye'de Kimya Endustrisi ";
                    }
                }


                else if (cmbUnıtID.SelectedItem.ToString() == "5")
                {
                    txtUnitName.Text = ("Basit Makineler");
                    if (cmbSubjectID.SelectedItem.ToString() == "1")
                    {
                        txtSubjectName.Text = "Basit Makineler";
                    }
                }

                else if (cmbUnıtID.SelectedItem.ToString() == "6")
                {
                    txtUnitName.Text = ("Enerji Donusumleri ve Cevre Bilimi");

                    if (cmbSubjectID.SelectedItem.ToString() == "1")
                    {
                        txtSubjectName.Text = "Besin zinciri ve Enerji Akisi";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "2")
                    {
                        txtSubjectName.Text = "Enerji Donusumleri";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "3")
                    {
                        txtSubjectName.Text = "Madde Donguleri ve Cevre Sorunlari";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "4")
                    {
                        txtSubjectName.Text = "Surdurulebilir Kalkinma";
                    }
                }


                else if (cmbUnıtID.SelectedItem.ToString() == "7")
                {
                    txtUnitName.Text = ("Elektrik yukleri ve Elektrik Enerjisi");
                    if (cmbSubjectID.SelectedItem.ToString() == "1")
                    {
                        txtSubjectName.Text = "Elektrik Yukleri ve Elektriklenme";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "2")
                    {
                        txtSubjectName.Text = "Elektrik Yüklü Cisimler";
                    }
                    else if (cmbSubjectID.SelectedItem.ToString() == "3")
                    {
                        txtSubjectName.Text = "Elektrik Enerjisinin Dönüsümü";
                    }
                }
            }
            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] image = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();

            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Question(Question,SchoolObject,UnitID,SubjectID,CorrectAnswer,Image,Option1,Option2,Option3,Option4) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", connection);
            cmd.Parameters.AddWithValue("@p1", txtQuestion.Text);
            cmd.Parameters.AddWithValue("@p2", txtSchoolObj.Text);
            cmd.Parameters.AddWithValue("@p3", cmbUnıtID.Text);
            cmd.Parameters.AddWithValue("@p4", cmbSubjectID.Text);
            cmd.Parameters.AddWithValue("@p5", cmbRansw.Text);
            cmd.Parameters.Add("@p6", SqlDbType.Image, image.Length).Value = image;
            cmd.Parameters.AddWithValue("@p7", TxtOpt1.Text);
            cmd.Parameters.AddWithValue("@p8", TxtOpt2.Text);
            cmd.Parameters.AddWithValue("@p9", TxtOpt3.Text);
            cmd.Parameters.AddWithValue("@p10", TxtOpt4.Text);

            cmd.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("REGISTRATION COMPLETED SUCCESSFULLY!!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //BUTONA BASILDIĞINDA TABLOYU DOLDURUR.
            button1.PerformClick();

        }




        private void FormAddQuestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quesitonAppDataSet3.Tbl_Question' table. You can move, or remove it, as needed.
            this.tbl_QuestionTableAdapter.Fill(this.quesitonAppDataSet3.Tbl_Question);
            // TODO: This line of code loads data into the 'quesitonAppDataSet2.Tbl_Question' table. You can move, or remove it, as needed.
            this.tbl_QuestionTableAdapter.Fill(this.quesitonAppDataSet3.Tbl_Question);
            // TODO: This line of code loads data into the 'quesitonAppDataSet.Tbl_Question' table. You can move, or remove it, as needed.


            this.tbl_QuestionTableAdapter.Fill(this.quesitonAppDataSet3.Tbl_Question);
            // TODO: This line of code loads data into the 'quesitonAppDataSet3.Tbl_Question' table. You can move, or remove it, as needed 
            timer1.Start();
            //BU KOD İLE OTOMATİK OLARAK FORM AÇILDIĞINDA BİR KERE LİSTELE BUTONUNA BASACAK VE LİSTE AÇIK SEKİLDE FORM GELECEK

            DataTable tbl = new DataTable();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from tbl_Question", connection);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // "Timer" için gerekli ayarlarmalar

            lblNewDate.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.tbl_QuestionTableAdapter.Fill(this.quesitonAppDataSet3.Tbl_Question);
            DataTable tbl = new DataTable();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from tbl_Question", connection);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmdDelete = new SqlCommand("Delete from Tbl_Question where QuestionId=@k1", connection);
            cmdDelete.Parameters.AddWithValue("@k1", TxtQuesId.Text);
            cmdDelete.ExecuteNonQuery();
            MessageBox.Show("Deletion successful");
            connection.Close();
            button1.PerformClick();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select *from Tbl_Question where QuestionId='" + int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Image"] != null)
                {
                    byte[] image = new byte[0];
                    image = (byte[])dr["Image"];
                    MemoryStream memorystream = new MemoryStream(image);
                    pctImage.Image = Image.FromStream(memorystream);
                    dr.Close();
                    cmd.Dispose();
                    connection.Close();

                }
            }
            connection.Close();






            int select = dataGridView1.SelectedCells[0].RowIndex;

            TxtQuesId.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            txtQuestion.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            txtSchoolObj.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            cmbUnıtID.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            cmbSubjectID.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            cmbRansw.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();

            TxtOpt1.Text = dataGridView1.Rows[select].Cells[7].Value.ToString();
            TxtOpt2.Text = dataGridView1.Rows[select].Cells[8].Value.ToString();
            TxtOpt3.Text = dataGridView1.Rows[select].Cells[9].Value.ToString();
            TxtOpt4.Text = dataGridView1.Rows[select].Cells[10].Value.ToString();


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] image = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();

            connection.Open();
            SqlCommand cmdUpdate = new SqlCommand("Update Tbl_Question Set Question=@a1,UnitId=@a2,SubjectId=@a3,CorrectAnswer=@a4,Image=@a5,Option1=@a6,Option2=@a7,Option3=@a8,Option4=@a9 where QuestionId=@a10", connection);

            cmdUpdate.Parameters.AddWithValue("@a1", txtQuestion.Text);
            cmdUpdate.Parameters.AddWithValue("@a2", cmbUnıtID.Text);
            cmdUpdate.Parameters.AddWithValue("@a3", cmbSubjectID.Text);
            cmdUpdate.Parameters.AddWithValue("@a4", cmbRansw.Text);
            cmdUpdate.Parameters.Add("@a5", SqlDbType.Image, image.Length).Value = image;
            cmdUpdate.Parameters.AddWithValue("@a6", TxtOpt1.Text);
            cmdUpdate.Parameters.AddWithValue("@a7", TxtOpt2.Text);
            cmdUpdate.Parameters.AddWithValue("@a8", TxtOpt3.Text);
            cmdUpdate.Parameters.AddWithValue("@a9", TxtOpt4.Text);
            cmdUpdate.Parameters.AddWithValue("@a10", TxtQuesId.Text);
            cmdUpdate.ExecuteNonQuery();


            connection.Close();
            MessageBox.Show("Update Successful");
            button1.PerformClick();


        }
    }
}
