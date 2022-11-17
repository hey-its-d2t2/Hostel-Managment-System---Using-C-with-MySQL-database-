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
    public partial class Frm_AddNewUSer : Form
    {
        DB_Function function = new DB_Function();
        string query;
        public Frm_AddNewUSer()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (TxtsecretKey.Text != "" && TxtUID.Text != "" && TxtUserName.Text != "" && TxtPass.Text != "")
            {
                if (TxtsecretKey.Text == "0292")
                {
                    try
                    {


                        query = "insert into UserDetails(Name,UserID,Password) values ('" + TxtUserName.Text + "','" + TxtUID.Text + "','" + TxtPass.Text + "')";
                        function.SetData(query, "User added.");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("User already exists... or" + Environment.NewLine + " Try diffrent User Id and Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    LBLMsg_InvKey.Visible = true;
                }
            }
            else
            {

                MessageBox.Show("Fill all details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TxtsecretKey_Click(object sender, EventArgs e)
        {
            if (LBLMsg_InvKey.Visible == true)
                LBLMsg_InvKey.Visible = false;
            else
                LBLMsg_InvKey.Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
