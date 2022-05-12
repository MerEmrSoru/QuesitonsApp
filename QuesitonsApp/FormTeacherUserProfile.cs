using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuesitonsApp
{
    public partial class FormTeacherUserProfile : Form
    {
        public FormTeacherUserProfile()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QuesitonApp;Integrated Security=True");
        private void FormTeacherUserProfile_Load(object sender, EventArgs e)
        {
            
      
        }
    }
}
