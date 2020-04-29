namespace Database_check
{
    partial class admindashboad
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpu = new System.Diagnostics.PerformanceCounter();
            this.ram = new System.Diagnostics.PerformanceCounter();
            this.hard = new System.Diagnostics.PerformanceCounter();
            this.pcbHDD = new CircularProgressBar.CircularProgressBar();
            this.pcbRAM = new CircularProgressBar.CircularProgressBar();
            this.pcbCPU = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "HDD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "RAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPU";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cpu
            // 
            this.cpu.CategoryName = "Processor";
            this.cpu.CounterName = "% Processor Time";
            this.cpu.InstanceName = "_Total";
            // 
            // ram
            // 
            this.ram.CategoryName = "Memory";
            this.ram.CounterName = "Available MBytes";
            // 
            // hard
            // 
            this.hard.CategoryName = "LogicalDisk";
            this.hard.CounterName = "% Free Space";
            this.hard.InstanceName = "_Total";
            // 
            // pcbHDD
            // 
            this.pcbHDD.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pcbHDD.AnimationSpeed = 500;
            this.pcbHDD.BackColor = System.Drawing.Color.Transparent;
            this.pcbHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.pcbHDD.ForeColor = System.Drawing.Color.SeaGreen;
            this.pcbHDD.InnerColor = System.Drawing.Color.LightGray;
            this.pcbHDD.InnerMargin = 2;
            this.pcbHDD.InnerWidth = -1;
            this.pcbHDD.Location = new System.Drawing.Point(566, 33);
            this.pcbHDD.MarqueeAnimationSpeed = 1000;
            this.pcbHDD.Maximum = 930;
            this.pcbHDD.Name = "pcbHDD";
            this.pcbHDD.OuterColor = System.Drawing.Color.Lavender;
            this.pcbHDD.OuterMargin = -25;
            this.pcbHDD.OuterWidth = 26;
            this.pcbHDD.ProgressColor = System.Drawing.Color.SeaGreen;
            this.pcbHDD.ProgressWidth = 4;
            this.pcbHDD.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pcbHDD.Size = new System.Drawing.Size(201, 201);
            this.pcbHDD.StartAngle = 270;
            this.pcbHDD.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pcbHDD.SubscriptColor = System.Drawing.Color.Empty;
            this.pcbHDD.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pcbHDD.SubscriptText = "";
            this.pcbHDD.SuperscriptColor = System.Drawing.Color.Empty;
            this.pcbHDD.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pcbHDD.SuperscriptText = "";
            this.pcbHDD.TabIndex = 12;
            this.pcbHDD.Text = "0%";
            this.pcbHDD.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // pcbRAM
            // 
            this.pcbRAM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pcbRAM.AnimationSpeed = 500;
            this.pcbRAM.BackColor = System.Drawing.Color.Transparent;
            this.pcbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.pcbRAM.ForeColor = System.Drawing.Color.SeaGreen;
            this.pcbRAM.InnerColor = System.Drawing.Color.LightGray;
            this.pcbRAM.InnerMargin = 2;
            this.pcbRAM.InnerWidth = -1;
            this.pcbRAM.Location = new System.Drawing.Point(349, 33);
            this.pcbRAM.MarqueeAnimationSpeed = 1000;
            this.pcbRAM.Maximum = 8192;
            this.pcbRAM.Name = "pcbRAM";
            this.pcbRAM.OuterColor = System.Drawing.Color.Lavender;
            this.pcbRAM.OuterMargin = -25;
            this.pcbRAM.OuterWidth = 26;
            this.pcbRAM.ProgressColor = System.Drawing.Color.SeaGreen;
            this.pcbRAM.ProgressWidth = 4;
            this.pcbRAM.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pcbRAM.Size = new System.Drawing.Size(201, 201);
            this.pcbRAM.StartAngle = 270;
            this.pcbRAM.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pcbRAM.SubscriptColor = System.Drawing.Color.Empty;
            this.pcbRAM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pcbRAM.SubscriptText = "";
            this.pcbRAM.SuperscriptColor = System.Drawing.Color.Empty;
            this.pcbRAM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pcbRAM.SuperscriptText = "";
            this.pcbRAM.TabIndex = 13;
            this.pcbRAM.Text = "0%";
            this.pcbRAM.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // pcbCPU
            // 
            this.pcbCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pcbCPU.AnimationSpeed = 500;
            this.pcbCPU.BackColor = System.Drawing.Color.Transparent;
            this.pcbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.pcbCPU.ForeColor = System.Drawing.Color.SeaGreen;
            this.pcbCPU.InnerColor = System.Drawing.Color.LightGray;
            this.pcbCPU.InnerMargin = 2;
            this.pcbCPU.InnerWidth = -1;
            this.pcbCPU.Location = new System.Drawing.Point(129, 30);
            this.pcbCPU.MarqueeAnimationSpeed = 1000;
            this.pcbCPU.Name = "pcbCPU";
            this.pcbCPU.OuterColor = System.Drawing.Color.Lavender;
            this.pcbCPU.OuterMargin = -25;
            this.pcbCPU.OuterWidth = 26;
            this.pcbCPU.ProgressColor = System.Drawing.Color.SeaGreen;
            this.pcbCPU.ProgressWidth = 4;
            this.pcbCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pcbCPU.Size = new System.Drawing.Size(201, 201);
            this.pcbCPU.StartAngle = 270;
            this.pcbCPU.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pcbCPU.SubscriptColor = System.Drawing.Color.Empty;
            this.pcbCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pcbCPU.SubscriptText = "";
            this.pcbCPU.SuperscriptColor = System.Drawing.Color.Empty;
            this.pcbCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pcbCPU.SuperscriptText = "";
            this.pcbCPU.TabIndex = 14;
            this.pcbCPU.Text = "0%";
            this.pcbCPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // admindashboad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.pcbCPU);
            this.Controls.Add(this.pcbRAM);
            this.Controls.Add(this.pcbHDD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "admindashboad";
            this.Size = new System.Drawing.Size(935, 599);
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter cpu;
        private System.Diagnostics.PerformanceCounter ram;
        private System.Diagnostics.PerformanceCounter hard;
        private CircularProgressBar.CircularProgressBar pcbHDD;
        private CircularProgressBar.CircularProgressBar pcbRAM;
        private CircularProgressBar.CircularProgressBar pcbCPU;
    }
}
