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
    public partial class FormStudentPanel : Form
    {
        public FormStudentPanel()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FormUserSelect f1=new FormUserSelect();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStartExam fst=new FormStartExam();
            fst.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSigmaSixExam fst=new FormSigmaSixExam();
            fst.Show();
            this.Hide();
        }
    }
}
