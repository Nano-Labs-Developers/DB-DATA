using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Database_check
{
    public partial class admin_admin_user : UserControl
    {
        public admin_admin_user()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = StudentDB; Integrated Security = True");

        private void txtuasename_OnTextChange(object sender, EventArgs e)
        {
            txtuasename.text = "";
        }

        private void searchadmin_OnTextChange(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

    }
}
