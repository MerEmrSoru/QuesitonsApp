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

        private void btnRegis_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(imagepath,FileMode.Open,FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)imagepath.Length);
            binaryReader.Close();
            fileStream.Close();

            connection.Open();
            if (cmbSubjectID.SelectedItem == null || cmbObjects.SelectedItem == null || cmbRansw.SelectedItem == null)
            {
                MessageBox.Show("The fields cannot be left blank ");
            }

            else if (txtQuestion.Text == " " && txtImage.Text == " ")
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




            

               

                SqlCommand cmd = new SqlCommand("insert into Tbl_Question(Question,SchoolObject,UnitID,SubjectID,CorrectAnswer,Image) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
                cmd.Parameters.AddWithValue("@p1", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@p2", txtSchoolObj.Text);
                cmd.Parameters.AddWithValue("@p3", cmbUnıtID.Text);
                cmd.Parameters.AddWithValue("@p4", cmbSubjectID.Text);
                cmd.Parameters.AddWithValue("@p5", cmbRansw.Text);
                cmd.Parameters.Add("@p6 ", SqlDbType.Image,resim.Length).Value = resim;



                cmd.ExecuteNonQuery();

                connection.Close();
               MessageBox.Show("REGISTRATION COMPLETED SUCCESSFULLY!!","Register",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Jpeg File(*.jpeg) |*.jpeg| Jpg File(*.jpg)|*.jpg| PngFile(*.png)|*.png| Gif File(*.gif)|*.gif| Tif File(*.tif)|*.tif";
            if(ofd.ShowDialog()== DialogResult.OK)
            {
            pctImage.Image=Image.FromFile(ofd.FileName);
                imagepath=ofd.FileName;
            }
        }

       
    }
}
