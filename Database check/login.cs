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
    public partial class login : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public login()
        {
            InitializeComponent();
        }

        #region Login Button
        private void btnlogin_Click(object sender, EventArgs e)
        {

            // Data Base Setup
            string username = txtemail.Text;
            string pass = txtpassword.Text;


            // SELECT USERNAME
            SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = StudentDB; Integrated Security = True");
            SqlDataAdapter sqa = new SqlDataAdapter("SELECT COUNT(*) FROM FormLoginData WHERE user_name = '" + txtemail.Text + "' and password = '"+ txtpassword.Text + "' ", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (String.IsNullOrEmpty(txtemail.Text))
            {
                lbllogin.Text = "Please Provide Username";
                lbllogin.ForeColor = Color.Red;
                return;
            }

            if (String.IsNullOrEmpty(txtpassword.Text))
            {
                lbllogin.Text = "Please Provide Password";
                lbllogin.ForeColor = Color.Red;
                return;
            }

            // Check valied
            if (dt.Rows[0][0].ToString() == "1")
            {
                lbllogin.Text = "Login Success";
                lbllogin.ForeColor = Color.LawnGreen;                
                this.Hide();
                MainMenu obj = new MainMenu();
                obj.Show();
            }
            else
            {
                lbllogin.Text = "Check your username and password";
                lbllogin.ForeColor = Color.Red;               
            }
        }

        #endregion

        #region SingUp Process Button

        private void btnsingup_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup obj = new signup();
            obj.Show();
        }

        #endregion

        #region Admin Panel Temp
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpanel obj = new adminpanel();
            obj.Show();
        }
        #endregion

        #region Exit and Minimize Button
        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Form Movement

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void lblmain_Click(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void lblmain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
        #endregion
    }
}
