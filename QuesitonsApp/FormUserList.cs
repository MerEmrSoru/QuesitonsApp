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
    public partial class FormUserList : Form
    {
        public FormUserList()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");
        private void FormUserList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quesitonAppDataSet2.Tbl_User' table. You can move, or remove it, as needed.
            this.tbl_UserTableAdapter.Fill(this.quesitonAppDataSet2.Tbl_User);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;

            txtUserID.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            txtUsername.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
            cmbUserTypeId.Text = dataGridView1.Rows[select].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmdUpdate = new SqlCommand("Update Tbl_User Set Username=@a1,Name=@a2,Surname=@a3,Mail=@a4,Password=@a5,UserTypeID=@a6 Where UserID=@a7", connection);


            
            cmdUpdate.Parameters.AddWithValue("@a1", txtUsername.Text);
            cmdUpdate.Parameters.AddWithValue("@a2", txtName.Text);
            cmdUpdate.Parameters.AddWithValue("@a3", txtSurname.Text);
            cmdUpdate.Parameters.AddWithValue("@a4", txtMail.Text);
            cmdUpdate.Parameters.AddWithValue("@a5", txtPassword.Text);
            cmdUpdate.Parameters.AddWithValue("@a6", cmbUserTypeId.Text);
            cmdUpdate.Parameters.AddWithValue("@a7", txtUserID.Text);

            cmdUpdate.ExecuteNonQuery();


            connection.Close();
            MessageBox.Show("Update Successful");
            btnRefresh.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_User(Username,Name,Surname,Mail,Password,UserTypeId) values (@a1,@a2,@a3,@a4,@a5,@a6)", connection);



            cmd.Parameters.AddWithValue("@a1", txtUsername.Text);
            cmd.Parameters.AddWithValue("@a2", txtName.Text);
            cmd.Parameters.AddWithValue("@a3", txtSurname.Text);
            cmd.Parameters.AddWithValue("@a4", txtMail.Text);
            cmd.Parameters.AddWithValue("@a5", txtPassword.Text);
            cmd.Parameters.AddWithValue("@a6", cmbUserTypeId.Text);
            

            cmd.ExecuteNonQuery();


            connection.Close();

            MessageBox.Show("User has been added successfully!");
            btnRefresh.PerformClick();

        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmdDelete = new SqlCommand("Delete from Tbl_Question where QuestionId=@k1", connection);
            cmdDelete.Parameters.AddWithValue("@k1", txtUserID.Text);
            cmdDelete.ExecuteNonQuery();
            MessageBox.Show("Deletion successful");
            connection.Close();
            btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from tbl_User", connection);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            connection.Close();
        }

        private void fillStudentToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UserTableAdapter.FillStudent(this.quesitonAppDataSet2.Tbl_User);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillTeacherToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UserTableAdapter.FillTeacher(this.quesitonAppDataSet2.Tbl_User);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillAllUserToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UserTableAdapter.FillAllUser(this.quesitonAppDataSet2.Tbl_User);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillTeacher1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UserTableAdapter.FillTeacher1(this.quesitonAppDataSet2.Tbl_User);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
