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
    public partial class UC_UpdateDelete : UserControl
    {
        DB_Function function = new DB_Function();
        string query;
        public UC_UpdateDelete()
        {
            InitializeComponent();
            ClearAll();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            TxtAddress.Text = "";
            TxtCollegeName.Text = "";
            TxtCollegeRoll.Text = "";
            TxtEmail.Text = "";
            TxtFathersName.Text = "";
            TxtMothersName.Text = "";
            TxtParrentMNo.Text = "";
            TxtStudyField.Text = "";
            TxtStudentName.Text = "";
            TxtIDProof.Text = "";
            TxtMobile.Text = "";
            TxtRoomNo.Text = "";
            RadBtnBoy.Checked = false;
            RadBtnGirl.Checked = false;
            LblTypMobNo.Visible = false;
            ComboLiving.SelectedIndex = -1;
        

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (TxtMobile.Text != "")
                {
                    query = "select * from NewStudentDetails where MobileNo = " + TxtMobile.Text + "";
                    DataSet ds = function.GetData(query);

                    LblTypMobNo.Visible = false;
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        TxtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
                        TxtMobile.Text = ds.Tables[0].Rows[0][2].ToString();
                        TxtFathersName.Text = ds.Tables[0].Rows[0][3].ToString();
                        TxtMothersName.Text = ds.Tables[0].Rows[0][4].ToString();
                        TxtParrentMNo.Text = ds.Tables[0].Rows[0][5].ToString();
                        TxtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                        string gender = ds.Tables[0].Rows[0][7].ToString();
                        if (gender == "Boy")
                        {
                            RadBtnBoy.Checked = true;
                        }
                        else
                        {
                            RadBtnGirl.Checked = true;
                        }
                        TxtCollegeName.Text = ds.Tables[0].Rows[0][8].ToString();
                        TxtCollegeRoll.Text = ds.Tables[0].Rows[0][9].ToString();
                        TxtIDProof.Text = ds.Tables[0].Rows[0][10].ToString();
                        TxtStudyField.Text = ds.Tables[0].Rows[0][11].ToString();
                        TxtRoomNo.Text = ds.Tables[0].Rows[0][12].ToString();
                        ComboLiving.Text = ds.Tables[0].Rows[0][13].ToString();
                        TxtAddress.Text = ds.Tables[0].Rows[0][14].ToString();
                    }
                    else
                    {
                        ClearAll();
                        MessageBox.Show("No record exists with this mobile number" + Environment.NewLine + " Try again...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    LblTypMobNo.Visible = true;
                }
            }
            catch
            {
                LblTypMobNo.Visible = true;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtMobile.Text != "")
            {
                LblTypMobNo.Visible = false;
                string gender;
                if (RadBtnBoy.Checked == true)
                {
                    gender = "Boy";
                }
                else
                {
                    gender = "Girl";
                }

                Int64 mobile = Int64.Parse(TxtMobile.Text);
                Int64 pmobile = Int64.Parse(TxtParrentMNo.Text);
                Int64 roomno = Int64.Parse(TxtRoomNo.Text);
                Int64 croll = Int64.Parse(TxtCollegeRoll.Text);
                string sname = TxtStudentName.Text;
                string fname = TxtFathersName.Text;
                string mname = TxtMothersName.Text;
                string add = TxtAddress.Text;
                string email = TxtEmail.Text;
                string college = TxtCollegeName.Text;
                string stdfield = TxtStudyField.Text;
                string idproof = TxtIDProof.Text;
                string livingstatus = ComboLiving.Text;
                query = "update NewStudentDetails set Name = '" + sname + "',MobileNo = " + mobile + ",FathersName = '" + fname + "',MothersName = '" + mname + "',ParrentsMobileNo = " + pmobile + ",Email = '" + email + "',Gender = '" + gender + "',CollegeName = '" + college + "'," +
                    "CollegeRoll = " + croll + ",IDProof = '" + idproof + "',StudyField = '" + stdfield + "',RoomNo = " + roomno + ",Living = '" + livingstatus + "',Address = '" +
                    add + "' where MobileNo = " + mobile + "" ;
           
                function.SetData(query);
                query = "update Rooms set Booked = '" + livingstatus + "' where RoomNo = " + roomno + "  ";
                function.SetData(query, "Details updated.");
                ClearAll();
            }
            else
            {
                LblTypMobNo.Visible = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtMobile.Text != "")
            {
                LblTypMobNo.Visible = false;
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete  from NewStudentDetails  where MobileNo = " + TxtMobile.Text + "";
                    function.SetData(query, "Details deleted.");
                    ClearAll();
                }
            }
            else
            {
                LblTypMobNo.Visible = true;
            }
        }

        private void UC_UpdateDelete_Load(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void TxtMobile_Click(object sender, EventArgs e)
        {
            if (LblTypMobNo.Visible == true)
             LblTypMobNo.Visible = false;
            else
                LblTypMobNo.Visible = false;
        }

        private void UC_UpdateDelete_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void panel2_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
