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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormAdminLogin f1=new FormAdminLogin();
            f1.Show();
            this.Hide();
        }

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            FormUserList formUserList = new FormUserList();
            formUserList.Show();
            this.Hide();
        }
    }
}
