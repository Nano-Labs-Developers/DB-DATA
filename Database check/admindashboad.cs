using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_check
{
    public partial class admindashboad : UserControl
    {
        public admindashboad()
        {
            InitializeComponent();
        }

        #region CPU RAM HDD Check timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            pcbCPU.Value = (int)cpu.NextValue();
            pcbRAM.Value = (int)ram.NextValue();
            pcbHDD.Value = (int)hard.NextValue();
            //pcbCPU.Text = (string)cpu.NextValue();


        }
        #endregion
    }
}
