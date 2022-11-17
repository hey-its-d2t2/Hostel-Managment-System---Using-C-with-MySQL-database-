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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CircleProgress.Value += 2;
            if(CircleProgress.Value == 100)
            {
               
                timer1.Enabled = false;
                FrmLofgin frmLofgin = new FrmLofgin();
                Hide();
                ShowInTaskbar = false;
                frmLofgin.ShowDialog();
          
            
            }
        }
    }
}
