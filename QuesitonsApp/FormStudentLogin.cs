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
    public partial class FormStudentLogin : Form
    {
        public FormStudentLogin()
        {
            InitializeComponent();
        }

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           FormRegister f1=new FormRegister();
            f1.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormUserSelect f1 = new FormUserSelect();
            f1.Show();
            this.Hide();
        }
    }
}
