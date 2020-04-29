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
using System.Drawing.Printing;

namespace Database_check
{
    public partial class Teacher : Form
    {
        #region Form Movement Support
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public Teacher()
        {
            InitializeComponent();
        }
        #region SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = StudentDB; Integrated Security = True");
        #endregion

        #region Teacher DataBase Save Button

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking data from the GUI
                string fname = txtfname.Text;
                string email = txtemail.Text;
                int tel = int.Parse(txttp.Text);
                string gender;
                if (rbtmale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string grade = cmbgrade.Text;

                // SQL query
                string query_insert = "INSERT INTO Teacher VALUES('" + fname + "','" + email + "','" + tel + "','" + gender + "','" + grade + "')";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();
                // Successfull Message after the execution
                MessageBox.Show("Saved Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving" + ex);
            }

            finally
            {
                // Closing the connection
                con.Close();
            }
        }
        #endregion

        #region Teacher DataBase Update Button
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking data from the GUI
                string fname = txtfname.Text;
                string email = txtemail.Text;
                int tel = int.Parse(txttp.Text);
                string gender;
                if (rbtmale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string grade = cmbgrade.Text;

                // SQL query
                string updatesql = "UPDATE Student SET firstname='" + fname + "',email='" + email + "',tp='" + tel + "',gender='" + gender + "',grade='" + grade + "' where email='" + email + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(updatesql, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();
                // Successfull Message after the execution
                MessageBox.Show("Update Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Updating" + ex);
            }

            finally
            {
                // Closing the connection
                con.Close();
            }
        }
        #endregion

        #region Teacher DataBase Delete Button

        private void btndelete_Click(object sender, EventArgs e)
        {
            deleteTeacher obj = new deleteTeacher();
            obj.Show();
        }

        #endregion

        #region Show list of Teacher's Data

        private void listviewTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Search Someone

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string u_email = txtsearch.Text;
                string query_search = "SELECT * FROM Teacher WHERE email = '" + u_email + "'";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();
                while (r.Read())
                {
                    txtfname.Text = r[1].ToString();
                    txtemail.Text = r[2].ToString();
                    txttp.Text = r[3].ToString();
                    string gen = r[4].ToString();
                    if (gen == "Male")
                    {
                        rbtmale.Checked = true;
                    }
                    else
                    {
                        rbtmale.Checked = true;
                    }
                    cmbgrade.Text = r[5].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Searching " + ex);
            }
            finally
            {
                // Closing the connection
                con.Close();
            }
        }


        #endregion

        #region QR code
        private void btnQR_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txtfname.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            picQR.Image = code.GetGraphic(50);
        }
        #endregion

        #region Exit and Minimize button
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region form movement
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

        private void lblmainname_Click(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void lblmainname_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
        #endregion

        #region Aout Message box
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test Product Only");
        }
        #endregion

        #region Print QR code
        private void button2_Click(object sender, EventArgs e)
        {
            printQRcode();
        }

        private void printQRcode()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(picQR.Width, picQR.Height);
            picQR.DrawToBitmap(bm, new Rectangle(0, 0, picQR.Width, picQR.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        #endregion
    }
}
