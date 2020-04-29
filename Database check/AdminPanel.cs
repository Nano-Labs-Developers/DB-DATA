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
using Bunifu;

namespace Database_check
{
    public partial class adminpanel : Form
    {
        // This can be buggy
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        //Fields
        private Button currentButton;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public adminpanel()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = string.Empty;
            this.ControlBox = false;
            adminformmain1.BringToFront();
        }

        #region App Exit, Maximize And Minimize

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        #endregion

        #region form movement
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            //this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void adminpanel2_Paint(object sender, PaintEventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void adminpanel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            login obj = new login();
            obj.Show();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {

                    currentButton = (Button)btnSender;
                }
            }
        }
        #endregion
             
        #region Button AdminForm

        private void dashboad_Click(object sender, EventArgs e)
        {
            mainlbl.Text = "Dash Boad";
            admindashboad1.BringToFront();
        }
        
        private void control_Click(object sender, EventArgs e)
        {
            mainlbl.Text = "Control Panel";
            admincontrolpanel1.BringToFront();
        }

        private void userdata_Click(object sender, EventArgs e)
        {
            mainlbl.Text = "User Data";
            adminuserdata1.BringToFront();
        }

        private void useradmin_Click(object sender, EventArgs e)
        {
            mainlbl.Text = "User Admin Data";
            admin_admin_user1.BringToFront();
        }

        private void usage_Click(object sender, EventArgs e)
        {
            mainlbl.Text = "Usage";
            adminusage1.BringToFront();
        }

        private void help_Click(object sender, EventArgs e)
        {
            mainlbl.Text = "About and Help";
            adminhelp1.BringToFront();
        }
        #endregion
        
        #region bar code
        private void button1_Click(object sender, EventArgs e)
        {
            AdminForms.Barcode obj = new AdminForms.Barcode();
            obj.Show();
        }
        #endregion

        #region Form movement

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mainlbl_Click(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void mainlbl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
