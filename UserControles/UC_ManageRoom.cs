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
    public partial class UC_ManageRoom : UserControl
    {
        
        DB_Function function = new DB_Function();
        string query;
        public UC_ManageRoom()
        {
            InitializeComponent();
        }

        private void UC_ManageRoom_Load(object sender, EventArgs e)
        {
            ClearAll();
            LblMsgRoomExists.Visible = false;
            LblMsgRoomFound.Visible = false;
            query = "select * from Rooms";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }  
    

        private void UC_ManageRoom_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            LblSelRSt.Visible = false;
            TxtRoomNo.Text = "";
            TxtRoomNoSer.Text = "";
            LblMsgRoomExists.Visible = false;
            LblMsgRoomFound.Visible = false;
            RadBtnRoomActive.Checked = false;
            RadBtnRoomDeactive.Checked = false;
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            if (TxtRoomNoSer.Text != "")
            {
                query = "select * from Rooms where RoomNo = " + TxtRoomNoSer.Text + "";
                DataSet d = function.GetData(query);
                if (d.Tables[0].Rows.Count == 0)
                {
                    LblMsgRoomFound.Visible = true;
                    RadBtnRoomActiveSer.Checked = false;
                }
                else
                {
                    LblMsgRoomFound.Visible = true;
                    LblMsgRoomFound.Text = "Room found...";

                    if (d.Tables[0].Rows[0][1].ToString() == "Yes")
                    {
                        RadBtnRoomDeactiveSer.Checked = false;
                        RadBtnRoomActiveSer.Checked = true;
                    }
                    else
                    {
                        RadBtnRoomActiveSer.Checked = false;
                        RadBtnRoomDeactiveSer.Checked = true;
                    }
                }
            }
            else
            {
                LblMsgRoomFound.Visible = true;
                LblMsgRoomFound.Text = "Enter room number.";
            }
        }
       
        private void BtnAddNewRooms_Click_1(object sender, EventArgs e)
        {
            if (TxtRoomNo.Text != "")
            {
                if (RadBtnRoomActive.Checked == true || RadBtnRoomDeactive.Checked == true)
                {
                    LblSelRSt.Visible = false;
                    query = "select * from Rooms where RoomNo = " + TxtRoomNo.Text + "";
                    DataSet ds = function.GetData(query);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        string status;
                        LblMsgRoomExists.Visible = false;
                        if (RadBtnRoomActive.Checked)
                        {
                            status = "Yes";
                        }
                        else
                        {
                            status = "No";
                        }
                        query = "insert into Rooms (RoomNo,RoomStatus) values (" + TxtRoomNo.Text + ",'" + status + "')";
                        function.SetData(query, "Room Added.");
                        UC_ManageRoom_Load(this, null);
                    }
                    else
                    {
                        LblMsgRoomExists.Visible = true;
                    }
                }
                else
                {
                    LblSelRSt.Visible = true;
                }
            }
            else
            {
                LblMsgRoomExists.Visible = true;
                LblMsgRoomExists.Text = "Enter room number.";
            }
        }

        private void BtnUpdateRoom_Click_1(object sender, EventArgs e)
        {
            if (TxtRoomNoSer.Text != "")
            {
                query = "select * from Rooms where RoomNo = " + TxtRoomNoSer.Text + "";
                DataSet d = function.GetData(query);
                LblMsgRoomFound.Visible = false;
                if (d.Tables[0].Rows.Count != 0)
                {
                    string status;
                    if (RadBtnRoomActiveSer.Checked)
                    {
                        status = "Yes";
                    }
                    else
                    {
                        status = "No";
                    }
                    query = "update rooms set RoomStatus = '" + status + "' where RoomNo = " + TxtRoomNoSer.Text + "";
                    function.SetData(query, "Details updated...");
                    UC_ManageRoom_Load(this, null);
                }
            }
            else
            {
                LblMsgRoomFound.Visible = true;
                LblMsgRoomFound.Text = "Enter room number.";
            }
        }

        private void BtnDeleteRoom_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TxtRoomNoSer.Text != "")
                {
                    LblMsgRoomFound.Visible = true;
                    if (LblMsgRoomFound.Text == "Room found...")
                    {
                        query = "delete from Rooms where RoomNo = " + TxtRoomNoSer.Text + "";
                        function.SetData(query, "Room Deleated");
                        UC_ManageRoom_Load(this, null);
                    }
                    else
                    {
                        MessageBox.Show("Trying to delete which dosn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    LblMsgRoomFound.Visible = true;
                    LblMsgRoomFound.Text = "Enter room number.";
                }
            }
            catch
            {
                MessageBox.Show("Unable to delete because all rooms are not deleted or " + Environment.NewLine + "Either room is parrent room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtRoomNo_Click_1(object sender, EventArgs e)
        {
            TxtRoomNo.Select();
            RadBtnRoomActive.Checked = false;
            RadBtnRoomDeactive.Checked = false;
            LblMsgRoomExists.Visible = false;
        }

        private void TxtRoomNoSer_Click_2(object sender, EventArgs e)
        {
            if (LblMsgRoomExists.Visible == true)
                LblMsgRoomFound.Visible = false;

        }
    }
}
