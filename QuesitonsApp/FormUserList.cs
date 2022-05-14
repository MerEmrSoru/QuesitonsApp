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
    public partial class FormUserList : Form
    {
        public FormUserList()
        {
            InitializeComponent();
        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quesitonAppDataSet3.Tbl_User' table. You can move, or remove it, as needed.
            this.tbl_UserTableAdapter.Fill(this.quesitonAppDataSet3.Tbl_User);
            // TODO: This line of code loads data into the 'quesitonAppDataSet3.Tbl_Question' table. You can move, or remove it, as needed.
            this.tbl_QuestionTableAdapter.Fill(this.quesitonAppDataSet3.Tbl_Question);

        }
    }
}
