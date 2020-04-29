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
    public partial class signup : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public signup()
        {
            InitializeComponent();
        }

        #region SQL Connection Create
        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = StudentDB; Integrated Security = True");
        #endregion

        #region Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Back to login

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login obj = new login();
            obj.Show();
        }

        #endregion

        #region SingUP Button

        private void btnsingup_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking data from the GUI
                string user_name = txtusername.Text;
                string password = txtpass.Text;
                string role = txtrole.Text;
                string usertype;
                
                if (rbtteacher.Checked)
                {
                    usertype = "Teacher";
                }
                else
                {
                    usertype = "Student";
                }

                if (String.IsNullOrEmpty(txtusername.Text))
                {
                    lblerror.Text = "Please Provide Username";
                    lblerror.ForeColor = Color.Red;
                    return;
                }

                if (String.IsNullOrEmpty(txtpass.Text))
                {
                    lblerror.Text = "Please Provide Password";
                    lblerror.ForeColor = Color.Red;
                    return;
                }

                if (String.IsNullOrEmpty(txtrole.Text))
                {
                    lblerror.Text = "Please Provide Role";
                    lblerror.ForeColor = Color.Red;
                    return;
                }

                if (String.IsNullOrEmpty(txtauthpassword.Text))
                {
                    lblerror.Text = "Please Provide Authontication Password";
                    lblerror.ForeColor = Color.Red;
                    return;
                }

                // SQL query
                string query_insert = "INSERT INTO FormLoginData VALUES('" + user_name+ "','" +password+ "','" +role+ "','"+ usertype  + "')";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();
                // Successfull Message after the execution
                lblerror.Text = "Sing Up Sucssefully";
                lblerror.ForeColor = Color.Red;
                this.Dispose();
                login obj = new login();
                obj.Show();
            }
            catch (Exception ex)
            {
                // Error send
                MessageBox.Show("Error While Singup" + ex);
            }

            finally
            {
                // Closing the connection
                con.Close();
            }
        }

        #endregion

        #region Form Movement
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
        #endregion

        #region Minimize and Exit
        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
