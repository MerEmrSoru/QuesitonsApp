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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FormAddQuestion f1=new FormAddQuestion();
            f1.Show();
            this.Hide();

        }

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            FormUserList f2=new FormUserList();
            f2.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormAdminLogin f3=new FormAdminLogin();
            f3.Show();
            this.Hide();
        }       
    }
}
