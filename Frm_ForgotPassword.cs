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
    public partial class Frm_ForgotPassword : Form
    {
        DB_Function function = new DB_Function();
        string query;
        public Frm_ForgotPassword()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmLofgin lf = new FrmLofgin();
            this.Close();
            lf.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //BtnContinue
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUID.Text != "")
            {
                MySqlConnection con = new MySqlConnection("data source  = MySQL Community Server - GPL;integrated security = True;server=localhost;user=root;database=Hostel;port=3306;password=jinu0292");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from UserDetails where UserID  = '" + TxtUID.Text + "'", con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (TxtUID.Text != "" && TxtPass.Text != "" && TxtConfPass.Text != "")
                        {
                            if (TxtUID.Text == dataTable.Rows[i]["UserID"].ToString())
                            {
                                if (TxtPass.Text == TxtConfPass.Text)
                                {
                                    try
                                    {


                                        query = "update UserDetails set Password = '" + TxtConfPass.Text + "' where UserID = '" + TxtUID.Text + "'";
                                        function.SetData(query, "Details updated.");
                                        FrmLofgin lf = new FrmLofgin();
                                        this.Close();
                                        lf.Show();
                                    }
                                    catch
                                    {
                                        LblMsg_UserNotExist.Visible = true;
                                        TxtUID.Text = "";
                                        TxtPass.Text = "";
                                        TxtConfPass.Text = "";
                                    }
                                }
                                else
                                {
                                    LblMsg_PasNotSame.Visible = true;
                                }
                            }
                            else
                            {
                                LblMsg_UserNotExist.Visible = true;
                                TxtUID.Text = "";
                                TxtPass.Text = "";
                                TxtConfPass.Text = "";
                            }
                        }
                        else
                        {
                            LblMsg_UserNotExist.Visible = true;
                            TxtUID.Text = "";
                            TxtPass.Text = "";
                            TxtConfPass.Text = "";
                        }
                    }
                }
            }
            else
            {
                LblMsg_UserNotExist.Visible = true;
                LblMsg_UserNotExist.Text = "Enter user ID.";
            }

        }

        private void TxtUID_Click(object sender, EventArgs e)
        {
            if (LblMsg_UserNotExist.Visible == true)
                 LblMsg_UserNotExist.Visible = false;
            else
                LblMsg_UserNotExist.Visible = false;
        }

        private void TxtPass_Click(object sender, EventArgs e)
        {
            if (LblMsg_PasNotSame.Visible == true)
                LblMsg_PasNotSame.Visible = false;
            else
                LblMsg_PasNotSame.Visible = false;
        }

        private void TxtConfPass_Click(object sender, EventArgs e)
        {
            if (LblMsg_PasNotSame.Visible == true)
                LblMsg_PasNotSame.Visible = false;
            else
                LblMsg_PasNotSame.Visible = false;
        }
    }
}
