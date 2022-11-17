using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Managment_System
{
    public partial class Frm_AboutDev : Form
    {
        public Frm_AboutDev()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrnMain fm = new FrnMain();
      
            this.Close();
            fm.Show();
        }
    }
}
