﻿using System;
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
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
           FormUserSelect f1=new FormUserSelect();
            f1.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormAdmin f1 = new FormAdmin();
            f1.Show();
            this.Hide();
        }
    }
}
