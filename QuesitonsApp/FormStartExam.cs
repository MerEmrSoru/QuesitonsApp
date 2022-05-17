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
    public partial class FormStartExam : Form
    {
        public FormStartExam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult opt= MessageBox.Show("You are about to start the test.Your timer will start and you will be given your first page of questions when you confirm."," You are about to start the test", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (opt == DialogResult.OK)
            {
              FormQuestion f1=new FormQuestion();
                f1.Show();
                this.Hide();
            }
            else if (opt == DialogResult.Cancel)
            {
               FormStartExam frm = new FormStartExam();
                frm.Show();
                this.Hide();
            }

        }

      
    }
}
