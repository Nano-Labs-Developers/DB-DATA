namespace Database_check
{
    partial class admin_admin_user
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_admin_user));
            this.panelleft = new System.Windows.Forms.Panel();
            this.panelhead2 = new System.Windows.Forms.Panel();
            this.panelhead1 = new System.Windows.Forms.Panel();
            this.panelbody = new System.Windows.Forms.Panel();
            this.searchadmin = new Bunifu.Framework.UI.BunifuTextbox();
            this.addadmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kickadmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picmain = new System.Windows.Forms.PictureBox();
            this.lblmain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtuasename = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblsure = new System.Windows.Forms.Label();
            this.panelleft.SuspendLayout();
            this.panelhead2.SuspendLayout();
            this.panelhead1.SuspendLayout();
            this.panelbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.DimGray;
            this.panelleft.Controls.Add(this.kickadmin);
            this.panelleft.Controls.Add(this.addadmin);
            this.panelleft.Controls.Add(this.panelhead1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(166, 599);
            this.panelleft.TabIndex = 2;
            // 
            // panelhead2
            // 
            this.panelhead2.BackColor = System.Drawing.Color.Black;
            this.panelhead2.Controls.Add(this.label1);
            this.panelhead2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelhead2.Location = new System.Drawing.Point(166, 0);
            this.panelhead2.Name = "panelhead2";
            this.panelhead2.Size = new System.Drawing.Size(769, 69);
            this.panelhead2.TabIndex = 3;
            // 
            // panelhead1
            // 
            this.panelhead1.BackColor = System.Drawing.Color.DarkOrange;
            this.panelhead1.Controls.Add(this.lblmain);
            this.panelhead1.Controls.Add(this.picmain);
            this.panelhead1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelhead1.Location = new System.Drawing.Point(0, 0);
            this.panelhead1.Name = "panelhead1";
            this.panelhead1.Size = new System.Drawing.Size(166, 69);
            this.panelhead1.TabIndex = 0;
            // 
            // panelbody
            // 
            this.panelbody.Controls.Add(this.lblsure);
            this.panelbody.Controls.Add(this.bunifuCheckbox1);
            this.panelbody.Controls.Add(this.txtuasename);
            this.panelbody.Controls.Add(this.bunifuFlatButton1);
            this.panelbody.Controls.Add(this.searchadmin);
            this.panelbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbody.Location = new System.Drawing.Point(166, 69);
            this.panelbody.Name = "panelbody";
            this.panelbody.Size = new System.Drawing.Size(769, 530);
            this.panelbody.TabIndex = 4;
            // 
            // searchadmin
            // 
            this.searchadmin.BackColor = System.Drawing.SystemColors.Control;
            this.searchadmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchadmin.BackgroundImage")));
            this.searchadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchadmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.searchadmin.Icon = ((System.Drawing.Image)(resources.GetObject("searchadmin.Icon")));
            this.searchadmin.Location = new System.Drawing.Point(497, 15);
            this.searchadmin.Name = "searchadmin";
            this.searchadmin.Size = new System.Drawing.Size(256, 42);
            this.searchadmin.TabIndex = 0;
            this.searchadmin.text = "Search";
            this.searchadmin.OnTextChange += new System.EventHandler(this.searchadmin_OnTextChange);
            // 
            // addadmin
            // 
            this.addadmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addadmin.BorderRadius = 0;
            this.addadmin.ButtonText = "Add New Admin";
            this.addadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addadmin.DisabledColor = System.Drawing.Color.Gray;
            this.addadmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.addadmin.Iconcolor = System.Drawing.Color.Transparent;
            this.addadmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("addadmin.Iconimage")));
            this.addadmin.Iconimage_right = null;
            this.addadmin.Iconimage_right_Selected = null;
            this.addadmin.Iconimage_Selected = null;
            this.addadmin.IconMarginLeft = 0;
            this.addadmin.IconMarginRight = 0;
            this.addadmin.IconRightVisible = true;
            this.addadmin.IconRightZoom = 0D;
            this.addadmin.IconVisible = true;
            this.addadmin.IconZoom = 90D;
            this.addadmin.IsTab = false;
            this.addadmin.Location = new System.Drawing.Point(0, 69);
            this.addadmin.Name = "addadmin";
            this.addadmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addadmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addadmin.OnHoverTextColor = System.Drawing.Color.White;
            this.addadmin.selected = false;
            this.addadmin.Size = new System.Drawing.Size(166, 48);
            this.addadmin.TabIndex = 1;
            this.addadmin.Text = "Add New Admin";
            this.addadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addadmin.Textcolor = System.Drawing.Color.White;
            this.addadmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // kickadmin
            // 
            this.kickadmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.kickadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.kickadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kickadmin.BorderRadius = 0;
            this.kickadmin.ButtonText = "Delete Admin";
            this.kickadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kickadmin.DisabledColor = System.Drawing.Color.Gray;
            this.kickadmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.kickadmin.Iconcolor = System.Drawing.Color.Transparent;
            this.kickadmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("kickadmin.Iconimage")));
            this.kickadmin.Iconimage_right = null;
            this.kickadmin.Iconimage_right_Selected = null;
            this.kickadmin.Iconimage_Selected = null;
            this.kickadmin.IconMarginLeft = 0;
            this.kickadmin.IconMarginRight = 0;
            this.kickadmin.IconRightVisible = true;
            this.kickadmin.IconRightZoom = 0D;
            this.kickadmin.IconVisible = true;
            this.kickadmin.IconZoom = 90D;
            this.kickadmin.IsTab = false;
            this.kickadmin.Location = new System.Drawing.Point(0, 117);
            this.kickadmin.Name = "kickadmin";
            this.kickadmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.kickadmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.kickadmin.OnHoverTextColor = System.Drawing.Color.White;
            this.kickadmin.selected = false;
            this.kickadmin.Size = new System.Drawing.Size(166, 48);
            this.kickadmin.TabIndex = 2;
            this.kickadmin.Text = "Delete Admin";
            this.kickadmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kickadmin.Textcolor = System.Drawing.Color.White;
            this.kickadmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // picmain
            // 
            this.picmain.Image = global::Database_check.Properties.Resources.unnamed;
            this.picmain.Location = new System.Drawing.Point(3, 3);
            this.picmain.Name = "picmain";
            this.picmain.Size = new System.Drawing.Size(49, 60);
            this.picmain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picmain.TabIndex = 0;
            this.picmain.TabStop = false;
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.Location = new System.Drawing.Point(58, 19);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(90, 31);
            this.lblmain.TabIndex = 1;
            this.lblmain.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Admin";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Kick Admin";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(311, 227);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(141, 49);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Kick Admin";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtuasename
            // 
            this.txtuasename.BackColor = System.Drawing.SystemColors.Control;
            this.txtuasename.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtuasename.BackgroundImage")));
            this.txtuasename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtuasename.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtuasename.Icon = ((System.Drawing.Image)(resources.GetObject("txtuasename.Icon")));
            this.txtuasename.Location = new System.Drawing.Point(211, 132);
            this.txtuasename.MinimumSize = new System.Drawing.Size(354, 42);
            this.txtuasename.Name = "txtuasename";
            this.txtuasename.Size = new System.Drawing.Size(354, 42);
            this.txtuasename.TabIndex = 3;
            this.txtuasename.TabStop = false;
            this.txtuasename.text = "Username";
            this.txtuasename.OnTextChange += new System.EventHandler(this.txtuasename_OnTextChange);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCheckbox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(311, 194);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 4;
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsure.Location = new System.Drawing.Point(347, 194);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(105, 20);
            this.lblsure.TabIndex = 5;
            this.lblsure.Text = "Are You Sure";
            // 
            // admin_admin_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelbody);
            this.Controls.Add(this.panelhead2);
            this.Controls.Add(this.panelleft);
            this.Name = "admin_admin_user";
            this.Size = new System.Drawing.Size(935, 599);
            this.panelleft.ResumeLayout(false);
            this.panelhead2.ResumeLayout(false);
            this.panelhead2.PerformLayout();
            this.panelhead1.ResumeLayout(false);
            this.panelhead1.PerformLayout();
            this.panelbody.ResumeLayout(false);
            this.panelbody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private Bunifu.Framework.UI.BunifuFlatButton kickadmin;
        private Bunifu.Framework.UI.BunifuFlatButton addadmin;
        private System.Windows.Forms.Panel panelhead1;
        private System.Windows.Forms.Label lblmain;
        private System.Windows.Forms.PictureBox picmain;
        private System.Windows.Forms.Panel panelhead2;
        private System.Windows.Forms.Panel panelbody;
        private Bunifu.Framework.UI.BunifuTextbox searchadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsure;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuTextbox txtuasename;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
