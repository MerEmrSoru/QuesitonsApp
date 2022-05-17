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
    public partial class FormSigmaSixExam : Form
    {
        public FormSigmaSixExam()
        {
            InitializeComponent();
        }

        private void FormSigma6Exam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quesitonAppDataSet3.Tbl_Question' table. You can move, or remove it, as needed.
            this.tbl_QuestionTableAdapter.Fill(this.quesitonAppDataSet3.Tbl_Question);

        }
    }
}
