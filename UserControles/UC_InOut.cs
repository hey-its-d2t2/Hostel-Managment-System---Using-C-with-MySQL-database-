using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Managment_System.UserControles
{
   
    public partial class UC_InOut : UserControl
    {
        DB_Function function = new DB_Function();
        string query;
        public UC_InOut()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string status = "Out";
            if (TxtRoomNo.Text != "")
            {
                LblMsgRoomNotFound.Visible = false;
                query = "select RoomNo from Rooms where Booked = 'Yes'";
                DataSet ds = function.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    query = "insert into InOutStatus (RoomNo,Name,Status,Purpose,Time,Date) values(" + TxtRoomNo.Text + ",'" + TxtName.Text + "','" + status + "','" + TxtPurpose.Text + "','" + TxtTime.Text + "','" + TxtDate.Text + "')";
                    function.SetData(query, "Status saved");
                    FetchData();
                }
            }
            else
            {
                LblMsgRoomNotFound.Visible = true;
            }
        }
        protected void FetchData()
        {
            query = "select * from InOutStatus";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_InOut_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        //BtnOut
        private void BtnSave_In_Click(object sender, EventArgs e)
        {
            string statusOut = "Yes";
        
            if (status == 1)
            {
                query = "insert into InOutStatus(RoomNo,Name,StatusOut,Purpose,OutTime,OutDate) values(" + TxtRoomNo.Text + ",'" + TxtName.Text + "','" + statusOut + "'," +
                    "'" + TxtPurpose.Text + "','" + TxtTime.Text + "','" + TxtDate.Text + "')";
                function.SetData(query);
                DataGridView1.DataSource = "";
                FetchData();
            }
            else
            {
                MessageBox.Show("Either room not booke or not exists...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDate.Text = "";
                TxtName.Text = "";
                TxtPurpose.Text = "";
                TxtTime.Text = "";
                TxtRoomNo.Text = "";
            }
        }   

        private void TxtSerchRoomNo_OnValueChanged(object sender, EventArgs e)
        {
            //Search Students by room no
            query = "select * from  InOutStatus where RoomNo like '" + TxtSerchRoomNo.Text + "%'";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }
        int status;
        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {


                if (TxtRoomNo.Text != "")
                {
                    LblMsgRoomNotFound.Visible = false;
                    query = "select * from Rooms where RoomNo = " + TxtRoomNo.Text + " and Booked = 'Yes'";
                    DataSet d = function.GetData(query);
                    if (d.Tables[0].Rows.Count == 0)
                    {
                        LblMsgRoomNotFound.Visible = true;
                        LblMsgRoomNotFound.Text = "Room not found...";
                        status = 0;
                      //  MessageBox.Show(status.ToString(),"");
                    }
                    else
                    {
                        status = 1;
                       // MessageBox.Show(status.ToString(), "");
                        LblMsgRoomNotFound.Visible = true;
                        LblMsgRoomNotFound.Text = "Room found...";

                    }
                }
                else
                {
                    LblMsgRoomNotFound.Visible = true;
                
                }
            }
            catch { 
                MessageBox.Show("Enter room number in correct format.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                TxtRoomNo.Text = "";
            }

        }

        private void TxtRoomNo_Click(object sender, EventArgs e)
        {
            if (LblMsgRoomNotFound.Visible == true)
                LblMsgRoomNotFound.Visible = false;
            else
                LblMsgRoomNotFound.Visible = false;
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            string statusOut = "No";
            string statusIn = "Yes";

            if (status == 1)
            {
                query = "insert into InOutStatus(RoomNo,Name,StatusOut,Purpose,StatusIN,InTime,InDate) values(" + TxtRoomNo.Text + ",'" + TxtName.Text + "','" + statusOut + "'," +
                    "'" + TxtPurpose.Text + "','"+statusIn+"','" + TxtTime.Text + "','" + TxtDate.Text + "')";
                function.SetData(query);
                DataGridView1.DataSource = "";
                FetchData();
            }
            else
            {
                MessageBox.Show("Either room not booke or not exists...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtDate.Text = "";
                TxtName.Text = "";
                TxtPurpose.Text = "";
                TxtTime.Text = "";
                TxtRoomNo.Text = "";
            }

        }
    }
}
