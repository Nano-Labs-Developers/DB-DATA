namespace Database_check
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtmale = new System.Windows.Forms.RadioButton();
            this.rbtfemale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblerror1 = new System.Windows.Forms.Label();
            this.DatalistStudent = new System.Windows.Forms.ListView();
            this.studentDBDataSet = new Database_check.StudentDBDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Database_check.StudentDBDataSetTableAdapters.StudentTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmainname = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btnQR = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name *";
            // 
            // btnsave
            // 
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnsave.Location = new System.Drawing.Point(12, 233);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(128, 46);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfname
            // 
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtfname.Location = new System.Drawing.Point(153, 44);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(255, 24);
            this.txtfname.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtemail.Location = new System.Drawing.Point(153, 78);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(255, 24);
            this.txtemail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email *";
            // 
            // txttp
            // 
            this.txttp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txttp.Location = new System.Drawing.Point(153, 112);
            this.txttp.Name = "txttp";
            this.txttp.Size = new System.Drawing.Size(255, 24);
            this.txttp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telephone no";
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtsearch.Location = new System.Drawing.Point(19, 71);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(283, 24);
            this.txtsearch.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(15, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type the email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender *";
            // 
            // rbtmale
            // 
            this.rbtmale.AutoSize = true;
            this.rbtmale.Checked = true;
            this.rbtmale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbtmale.Location = new System.Drawing.Point(167, 154);
            this.rbtmale.Name = "rbtmale";
            this.rbtmale.Size = new System.Drawing.Size(53, 19);
            this.rbtmale.TabIndex = 10;
            this.rbtmale.TabStop = true;
            this.rbtmale.Text = "Male";
            this.rbtmale.UseVisualStyleBackColor = true;
            // 
            // rbtfemale
            // 
            this.rbtfemale.AutoSize = true;
            this.rbtfemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbtfemale.Location = new System.Drawing.Point(255, 154);
            this.rbtfemale.Name = "rbtfemale";
            this.rbtfemale.Size = new System.Drawing.Size(67, 19);
            this.rbtfemale.TabIndex = 11;
            this.rbtfemale.Text = "Female";
            this.rbtfemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(14, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Grade *";
            // 
            // cmbgrade
            // 
            this.cmbgrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cmbgrade.Location = new System.Drawing.Point(153, 191);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(121, 26);
            this.cmbgrade.TabIndex = 14;
            // 
            // btnupdate
            // 
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnupdate.Location = new System.Drawing.Point(146, 233);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(128, 46);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btndelete.Location = new System.Drawing.Point(280, 233);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(128, 46);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnsearch.Location = new System.Drawing.Point(105, 118);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(128, 46);
            this.btnsearch.TabIndex = 17;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblerror1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(734, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 184);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Student";
            // 
            // lblerror1
            // 
            this.lblerror1.AutoSize = true;
            this.lblerror1.Location = new System.Drawing.Point(148, 44);
            this.lblerror1.Name = "lblerror1";
            this.lblerror1.Size = new System.Drawing.Size(0, 15);
            this.lblerror1.TabIndex = 18;
            // 
            // DatalistStudent
            // 
            this.DatalistStudent.HideSelection = false;
            this.DatalistStudent.Location = new System.Drawing.Point(8, 316);
            this.DatalistStudent.Name = "DatalistStudent";
            this.DatalistStudent.Size = new System.Drawing.Size(1059, 250);
            this.DatalistStudent.TabIndex = 20;
            this.DatalistStudent.UseCompatibleStateImageBehavior = false;
            this.DatalistStudent.SelectedIndexChanged += new System.EventHandler(this.DatalistStudent_SelectedIndexChanged);
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentDBDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblmainname);
            this.panel1.Controls.Add(this.lblMinimize);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 28);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblmainname
            // 
            this.lblmainname.AutoSize = true;
            this.lblmainname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblmainname.Location = new System.Drawing.Point(3, 3);
            this.lblmainname.Name = "lblmainname";
            this.lblmainname.Size = new System.Drawing.Size(80, 25);
            this.lblmainname.TabIndex = 2;
            this.lblmainname.Text = "Student";
            this.lblmainname.Click += new System.EventHandler(this.lblmainname_Click);
            this.lblmainname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblmainname_MouseDown);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMinimize.Location = new System.Drawing.Point(1025, 1);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(19, 25);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblExit.Location = new System.Drawing.Point(1050, 1);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(26, 25);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // picQR
            // 
            this.picQR.Image = global::Database_check.Properties.Resources.unnamed;
            this.picQR.Location = new System.Drawing.Point(414, 44);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(308, 266);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQR.TabIndex = 26;
            this.picQR.TabStop = false;
            // 
            // btnQR
            // 
            this.btnQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnQR.Location = new System.Drawing.Point(734, 233);
            this.btnQR.Margin = new System.Windows.Forms.Padding(2);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(128, 54);
            this.btnQR.TabIndex = 27;
            this.btnQR.Text = "Generate QR Code";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "* = Required field ";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(1007, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 26);
            this.button1.TabIndex = 31;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(866, 233);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 54);
            this.button2.TabIndex = 32;
            this.button2.Text = "Print QR Code";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(167, 286);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 33;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 578);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DatalistStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cmbgrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbtfemale);
            this.Controls.Add(this.rbtmale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Data | Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnsave;
        protected System.Windows.Forms.TextBox txtfname;
        protected System.Windows.Forms.TextBox txtemail;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox txttp;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtsearch;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.RadioButton rbtmale;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Button btnupdate;
        protected System.Windows.Forms.Button btndelete;
        protected System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView DatalistStudent;
        protected System.Windows.Forms.RadioButton rbtfemale;
        protected System.Windows.Forms.ComboBox cmbgrade;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentDBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmainname;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox picQR;
        protected System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblerror1;
    }
}