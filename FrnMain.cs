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
    public partial class FrnMain : Form
    {
        public FrnMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (PnlButtonsControle.Width == 186)
            {
                PnlButtonsControle.Width = 60;
                BtnColl.Rotate(180);
            }
            else if(PnlButtonsControle.Width == 60)
            {
                PnlButtonsControle.Width = 186;
                BtnColl.Rotate(0);
            }
            else
            {
                PnlButtonsControle.Width = 60;
                BtnColl.Rotate(180);
            }
          
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            PnlBtnSlider.Top = BtnMonthFee.Top;
            uc_StudentFee1.BringToFront();
        }

        private void BtnManageRoom_Click(object sender, EventArgs e)
        {
           
            PnlBtnSlider.Top = BtnManageRoom.Top;
            uC_ManageRoom1.BringToFront();
        }

        private void BtnNewStudent_Click(object sender, EventArgs e)
        {
            PnlBtnSlider.Top = BtnNewStudent.Top;
            uC_NewStudent1.BringToFront();
        }

        private void BtnLeavingStudent_Click(object sender, EventArgs e)
        {
            PnlBtnSlider.Top = BtnLeavingStudent.Top;
            WindowState = FormWindowState.Maximized;
            uC_LivingStudent1.BringToFront();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            PnlBtnSlider.Top = BtnUpdate.Top;
           
            uC_UpdateDelete1.BringToFront();
            
        }

        private void BtnLeavedStudent_Click(object sender, EventArgs e)
        {
            PnlBtnSlider.Top = BtnLeavedStudent.Top;
            WindowState = FormWindowState.Maximized;
            uC_LeavedStudent1.BringToFront();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PnlTop_DoubleClick(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void BtnRerstore_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FrmLofgin lf = new FrmLofgin();
            this.Close();
            lf.Show();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            PnlBtnSlider.Top = BtnAdmin.Top;
            uC_Admin1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            PnlBtnSlider.Top = BtnHome.Top;
            uC_Home1.BringToFront();

        }

        private void BtnAboutDev_Click(object sender, EventArgs e)
        {
            Frm_AboutDev ad = new Frm_AboutDev();
            this.Hide();
            ad.Show();
        }

        private void BtnInOut_Click(object sender, EventArgs e)
        {
            PnlBtnSlider.Top = BtnInOut.Top;
            uC_InOut1.BringToFront();
        }
    }
}
