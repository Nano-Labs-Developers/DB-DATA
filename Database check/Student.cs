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
    public partial class Student : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Student()
        {
            InitializeComponent();
        }
        #region SQL Connection Create
        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = StudentDB; Integrated Security = True");

        #endregion        

        #region Save DataBase
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking data from the GUI
                
                
                
                string gender;
                if (rbtmale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                

                if (String.IsNullOrEmpty(txtfname.Text))
                {
                    lblerror.Text = "Please Provide Name";
                    lblerror.ForeColor = Color.Red;
                    return;
                }

                if (String.IsNullOrEmpty(txtemail.Text))
                {
                    lblerror.Text = "Please Provide Email";
                    lblerror.ForeColor = Color.Red;
                    return;
                }

                if (String.IsNullOrEmpty(cmbgrade.Text))
                {
                    lblerror.Text = "Please Provide Grade";
                    lblerror.ForeColor = Color.Red;
                    return;
                }

                // SQL query

                if (String.IsNullOrEmpty(txttp.Text))
                {
                    string grade = cmbgrade.Text;
                    string email = txtemail.Text;
                    string tel = "null";
                    string fname = txtfname.Text;
                    string query_insert = "INSERT INTO Student VALUES('" + fname + "','" + email + "','" + tel + "','" + gender + "','" + grade + "')";
                    // SQL Command
                    SqlCommand cmnd = new SqlCommand(query_insert, con);
                    con.Open();
                    // Execution of the command
                    cmnd.ExecuteNonQuery();
                    // Successfull Message after the execution
                    lblerror.Text = "Saved Successfully";
                    lblerror.ForeColor = Color.LightGreen;
                }
                else
                {
                    string grade = cmbgrade.Text;
                    string email = txtemail.Text;
                    int tel = int.Parse(txttp.Text);
                    string fname = txtfname.Text;
                    string query_insert = "INSERT INTO Student VALUES('" + fname + "','" + email + "','" + tel + "','" + gender + "','" + grade + "')";
                    // SQL Command
                    SqlCommand cmnd = new SqlCommand(query_insert, con);
                    con.Open();
                    // Execution of the command
                    cmnd.ExecuteNonQuery();
                    // Successfull Message after the execution
                    lblerror.Text = "Saved Successfully";
                    lblerror.ForeColor = Color.LightGreen;
                }
                           

            }
            catch ( Exception ex )
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

        #region Update DataBase

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking data from the GUI
                
                string email = txtemail.Text;
                
                string gender;
                if (rbtmale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                

                //string updatesql = "UPDATE Student SET firstname='" + fname + "',email='" + email + "',tp='" + tel + "',gender='" + gender + "',grade='" + grade + "' where email='" + email + "'";

                if (String.IsNullOrEmpty(txtemail.Text))
                {
                    lblerror.Text = "Please Provide Email";
                    lblerror.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    // email- Check Name
                    if (String.IsNullOrEmpty(txtfname.Text))
                    {
                        // email- name- Check Tel no
                        if (String.IsNullOrEmpty(txttp.Text))
                        {
                            // email- telno- Check Grade
                            if (String.IsNullOrEmpty(cmbgrade.Text))
                            {
                                // email- name- tel no- grade- Check Gender
                                if (String.IsNullOrEmpty(gender))
                                {
                                    lblerror.Text = "I can't found anything to update";
                                    lblerror.ForeColor = Color.Red;
                                    return;
                                }
                                // email- name- tel no- grade- gender- else check gender
                                else
                                {
                                    string updatesql = "UPDATE student SET gender ='" + gender + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                            }
                            else
                            {
                                string grade = cmbgrade.Text;
                                // email- name- tel no- else.grade- Check Gender
                                if (String.IsNullOrEmpty(gender))
                                {
                                    string updatesql = "UPDATE student SET grade ='" + grade + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                                // email- name- tel no- else.grade- else Check Gender
                                else
                                {
                                    string updatesql = "UPDATE student SET grade ='" + grade + "',gender ='" + gender + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                            }
                        }
                        // email- name- Else Check Tel no
                        else
                        {
                            int tel = int.Parse(txttp.Text);
                            //string updatesql = "UPDATE Student SET firstname='" + fname + "',email='" + email + "',tp='" + tel + "',gender='" + gender + "',grade='" + grade + "' where email='" + email + "'";

                            // email- name- Else.Tel no- check grade
                            if (String.IsNullOrEmpty(cmbgrade.Text))
                            {
                                //email - name - Else Tel no- grade- gender
                                if (String.IsNullOrEmpty(gender))
                                {
                                    string updatesql = "UPDATE student SET tp ='" + tel + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                                //email - name - Else Tel no- grade- else gender
                                else
                                {
                                    string updatesql = "UPDATE student SET tp ='" + tel + "',gender ='" + gender + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }

                            }
                            // email- name- Else.Tel no- else grade
                            else
                            {
                                string grade = cmbgrade.Text;
                                // email- name- Else.Tel no- else.grade- check gender
                                if (String.IsNullOrEmpty(gender))
                                {
                                    string updatesql = "UPDATE student SET tp ='" + tel + "',grade ='" + grade + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                                // email- name- Else.Tel no- else.grade- else gender
                                else
                                {
                                    string updatesql = "UPDATE student SET tp ='" + tel + "',gender ='" + gender + "',grade = '" + grade + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                            }
                        }
                    }
                    // email- check else name
                    else
                    {
                        string fname = txtfname.Text;
                        // email- else.name- check telno
                        if (String.IsNullOrEmpty(txttp.Text))
                        {
                            // email- else.name telno- check grade
                            if (String.IsNullOrEmpty(cmbgrade.Text))
                            {
                                // email- else.name telno- grade- check gender
                                if (String.IsNullOrEmpty(gender))
                                {
                                    string updatesql = "UPDATE student SET firstname='" + fname + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                                // email- else.name telno- grade- else gender
                                else
                                {
                                    string updatesql = "UPDATE student SET firstname='" + fname + "',gender ='" + gender + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                            }
                            // email- else.name telno- else check grade
                            else
                            {
                                string grade = cmbgrade.Text;
                                // email - else.name telno - else.grade - check gender
                                if (String.IsNullOrEmpty(gender))
                                {
                                    string updatesql = "UPDATE student SET firstname='" + fname + "',grade ='" + grade + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                                // email - else.name telno - else.grade - else gender
                                else
                                {
                                    string updatesql = "UPDATE student SET firstname='" + fname + "',gender ='" + gender + "',grade ='" + grade + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                            }
                        }
                        else
                        {
                            int tel = int.Parse(txttp.Text);
                            // email - else.name else.telno - check grade
                            if (String.IsNullOrEmpty(cmbgrade.Text))
                            {
                                // email - else.name else.telno - grade- check gender
                                if (String.IsNullOrEmpty(gender))
                                {
                                    string updatesql = "UPDATE student SET firstname='" + fname + "',tp ='" + tel + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                                // email - else.name else.telno - grade- else check gender
                                else
                                {
                                    string updatesql = "UPDATE student SET firstname='" + fname + "',tp ='" + tel + "',gender ='" + gender + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }

                            }
                            // email - else.name else.telno - else check grade
                            else
                            {
                                string grade = cmbgrade.Text;
                                // email - else.name else.telno - else.grade- check gender
                                if (String.IsNullOrEmpty(gender))
                                {
                                    string updatesql = "UPDATE student SET firstname='" + fname + "',grade='" + grade + "',tp ='" + tel + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                                // email - else.name else.telno - else.grade- else check gender
                                else
                                {
                                    string updatesql = "UPDATE student SET firstname='" + fname + "',tp ='" + tel + "',gender ='" + gender + "',grade = '" + grade + "' where email='" + email + "'";
                                    // SQL Command
                                    SqlCommand cmnd = new SqlCommand(updatesql, con);
                                    con.Open();
                                    // Execution of the command
                                    cmnd.ExecuteNonQuery();
                                    // Successfull Message after the execution
                                    lblerror.Text = "Update Successfully";
                                    lblerror.ForeColor = Color.LightGreen;
                                }
                            }
                        }
                    }
                }
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

        #region Delete DataBase
        private void btndelete_Click(object sender, EventArgs e)
        {
            deleteStudent obj = new deleteStudent();
            obj.Show();
        }
        #endregion

        #region DataBase Search Button

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string u_email = txtsearch.Text;

                if (String.IsNullOrEmpty(txtsearch.Text))
                {
                    lblerror1.Text = "Please Provide Email";
                    lblerror1.ForeColor = Color.Red;
                    return;
                }

                string query_search = "SELECT * FROM Student WHERE email = '" + u_email + "'";
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
            catch ( Exception ex )
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

        #region Student DataBase Load to Text Area        

        private void DatalistStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentDBDataSet.Student);
        }
        #endregion

        #region Movement Form
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

        #region Exit and Minimize lable
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        #region Aout Message box
        private void button1_Click_1(object sender, EventArgs e)
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