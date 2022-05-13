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
    public partial class FormStudentListTeac : Form
    {
        public FormStudentListTeac()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");
        private void FormTeacherUserProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quesitonAppDataSet2.Tbl_User' table. You can move, or remove it, as needed.
            this.tbl_UserTableAdapter.Fill(this.quesitonAppDataSet2.Tbl_User);
           

            fill4button.PerformClick();

        }
        
        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UserTableAdapter.FillBy4(this.quesitonAppDataSet2.Tbl_User);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FormTeacher f1=new FormTeacher();
            f1.Show();
            this.Hide();
        }
    }
}
