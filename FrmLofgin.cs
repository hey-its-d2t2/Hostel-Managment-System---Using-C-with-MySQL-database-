using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hostel_Managment_System
{
    public partial class FrmLofgin : Form
    {
        DB_Function function = new DB_Function();
        string query;
        public FrmLofgin()
        {
            InitializeComponent();
        }
        private void FrmLofgin_Load(object sender, EventArgs e)
        {
            //query = "select UserID from UserDetails";
            //DataSet ds1 = function.GetData(query);
            //query = "select Password from UserDetails";
            //DataSet ds2 = function.GetData(query);
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            LblCreateAccount.ForeColor = Color.FromArgb(60, 215, 35);
        }

        private void LblCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            LblCreateAccount.ForeColor = Color.YellowGreen;
        }

        private void LblForPass_MouseMove(object sender, MouseEventArgs e)
        {
            LblForPass.ForeColor = Color.FromArgb(60, 215, 35);
        }

        private void LblForPass_MouseLeave(object sender, EventArgs e)
        {
            LblForPass.ForeColor = Color.YellowGreen;
        }

        private void LblForPass_MouseHover(object sender, EventArgs e)
        {
            LblForPass.ForeColor = Color.FromArgb(60, 215, 35);

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUID.Text != "")
            {
                Lbl_IDMsg.Visible = false;
                MySqlConnection con = new MySqlConnection("data source  = MySQL Community Server - GPL;integrated security = True;server=localhost;user=root;database=Hostel;port=3306;password=jinu0292");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from UserDetails where UserID  = '" + TxtUID.Text + "' and Password =  '" + TxtPass.Text + "'", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (dataTable.Rows[i]["UserID"].ToString() == TxtUID.Text && dataTable.Rows[i]["Password"].ToString() == TxtPass.Text)
                        {
                                FrnMain frnmain = new FrnMain();
                                Hide();
                                frnmain.Show();                                                 
                        }
                        else if(dataTable.Rows[i]["UserID"].ToString() != TxtUID.Text)
                        {
                            Lbl_IDMsg.Visible = true;
                        }
                        else
                        {
                            LblMsg_InvPass.Visible = true;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (dataTable.Rows[i]["UserID"].ToString() != TxtUID.Text)
                        {
                            Lbl_IDMsg.Visible = true;
                        }
                        else
                        {
                            LblMsg_InvPass.Visible = true;
                        }

                    }

                    MessageBox.Show("Invalid credentials...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Lbl_IDMsg.Visible = true;
                Lbl_IDMsg.Text = "Enter user ID.";
            }
          
        }

        private void LblCreateAccount_Click(object sender, EventArgs e)
        {
            Frm_CreateAccount ca = new Frm_CreateAccount();
            this.Hide();
            ca.Show();
        }

        private void LblForPass_Click(object sender, EventArgs e)
        {
            Frm_ForgotPassword fp = new Frm_ForgotPassword();
            this.Hide();
            fp.Show();
        }

        private void TxtUID_Click(object sender, EventArgs e)
        {
            if (Lbl_IDMsg.Visible == true)
                Lbl_IDMsg.Visible = false;
            else
                Lbl_IDMsg.Visible = false;
          
        }

        private void TxtPass_Click(object sender, EventArgs e)
        {
            if (LblMsg_InvPass.Visible == true)
                LblMsg_InvPass.Visible = false;
            else
                LblMsg_InvPass.Visible = false;
        }

       
    }
}
