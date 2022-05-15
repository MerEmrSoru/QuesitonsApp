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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormTeacherLogin f1=new FormTeacherLogin();
            f1.Show();
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FormAddQuestion f2=new FormAddQuestion();
            f2.Show();
            this.Hide();
        }

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            
        }
    }
}
