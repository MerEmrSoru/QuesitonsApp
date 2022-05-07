using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuesitonsApp
{
    public partial class FormUserSelect : Form
    {
        public FormUserSelect()
        {
            InitializeComponent();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            FormStudentLogin f1=new FormStudentLogin();
            f1.Show();
            this.Hide();

        }

        private void BtnTeacher_Click(object sender, EventArgs e)
        {
            FormTeacherLogin f1=new FormTeacherLogin();
            f1.Show();
            this.Hide();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FormAdminLogin f1=new FormAdminLogin();
            f1.Show();
            this.Hide();
        }
    }
}
