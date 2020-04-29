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

namespace Database_check
{
    public partial class deleteStudent : Form
    {
        public deleteStudent()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = StudentDB; Integrated Security = True");

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking data from the GUI
                string email = txtemail.Text;

                if (String.IsNullOrEmpty(txtemail.Text))
                {
                    lblerror.Text = "Please Provide Username";
                    lblerror.ForeColor = Color.Red;
                    return;
                }

                // SQL query
                string deletesql = "DELETE FROM Student WHERE email='" + email + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(deletesql, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();
                // Successfull Message after the execution
                lblerror.Text = "Delete Successfully";
                lblerror.ForeColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Deleting" + ex);
            }

            finally
            {
                // Closing the connection
                con.Close();
            }
        }
    }
}

namespace DeleteFormData
{
    class deleteStudent
    {
    }
}

namespace DeleteFormData1
{
    class deleteStudent
    {
    }
}