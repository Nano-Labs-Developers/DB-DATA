namespace Database_check.AdminForms
{
    partial class Barcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcode));
            this.btngen = new System.Windows.Forms.Button();
            this.txtbar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngen
            // 
            this.btngen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btngen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngen.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btngen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btngen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngen.Location = new System.Drawing.Point(199, 257);
            this.btngen.Name = "btngen";
            this.btngen.Size = new System.Drawing.Size(120, 40);
            this.btngen.TabIndex = 0;
            this.btngen.Text = "Generate";
            this.btngen.UseVisualStyleBackColor = true;
            this.btngen.Click += new System.EventHandler(this.btngen_Click);
            // 
            // txtbar
            // 
            this.txtbar.BackColor = System.Drawing.Color.LightGray;
            this.txtbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbar.Location = new System.Drawing.Point(46, 220);
            this.txtbar.Name = "txtbar";
            this.txtbar.Size = new System.Drawing.Size(441, 24);
            this.txtbar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 32);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Location = new System.Drawing.Point(506, 7);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 25);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(481, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bar Code Generator";
            // 
            // picBox1
            // 
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Image = global::Database_check.Properties.Resources.unnamed;
            this.picBox1.InitialImage = global::Database_check.Properties.Resources.unnamed;
            this.picBox1.Location = new System.Drawing.Point(46, 79);
            this.picBox1.Margin = new System.Windows.Forms.Padding(0);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(441, 124);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox1.TabIndex = 2;
            this.picBox1.TabStop = false;
            // 
            // Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(535, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.txtbar);
            this.Controls.Add(this.btngen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barcode";
            this.Text = "Barcode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngen;
        private System.Windows.Forms.TextBox txtbar;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label2;
    }
}