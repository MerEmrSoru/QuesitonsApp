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
    public partial class FormTeacherProfile : Form
    {
        public FormTeacherProfile()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FormAddQuestion F1=new FormAddQuestion();
            F1.Show();
            this.Hide();
        }

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            FormTeacherUserProfile F1=new FormTeacherUserProfile();
            F1.Show();
            this.Hide();
        }
    }
}
