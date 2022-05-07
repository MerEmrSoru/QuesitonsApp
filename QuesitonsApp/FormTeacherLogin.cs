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
    public partial class FormTeacherLogin : Form
    {
        public FormTeacherLogin()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormUserSelect f1=new FormUserSelect();
            f1.Show();
            this.Hide();

        }
    }
}
