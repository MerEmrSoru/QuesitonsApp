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

        private void btnLogin_Click(object sender, EventArgs e)
        {
           FormAdmin f1=new FormAdmin();
            f1.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormUserSelect f2 = new FormUserSelect();
            f2.Show();
            this.Hide();
        }

        private void FormAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void LnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LnkRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister f1 = new FormRegister();
            f1.Show();
            this.Hide();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSendPassword f1 = new FormSendPassword();
            f1.Show();
            this.Hide();
        }
    }
}
