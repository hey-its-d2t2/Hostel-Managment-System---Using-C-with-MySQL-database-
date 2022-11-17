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

namespace Hostel_Managment_System.UserControles
{
    public partial class UC_NewStudent : UserControl
    {
        DB_Function function = new DB_Function();
        string query;
        public UC_NewStudent()
        {
            InitializeComponent();
        }

 
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtStudentName.Text != "" && TxtMobile.Text != "" && TxtFathersName.Text != "" && TxtMothersName.Text != "" && TxtAddress.Text != "" && TxtParrentMNo.Text != "" && TxtEmail.Text != "" && TxtCollegeName.Text != "" && TxtCollegeRoll.Text != "" && TxtIDProof.Text != "" && TxtStudyField.Text != "" && ComboRoomNo.SelectedIndex != -1)
                {


                    string gender;
                    if (chkboy.Checked)
                    {
                        gender = "Boy";
                    }
                    else
                    {
                        gender = "Girl";
                    }

                    Int64 mobile = Int64.Parse(TxtMobile.Text);
                    Int64 pmobile = Int64.Parse(TxtParrentMNo.Text);
                    Int64 roomno = Int64.Parse(ComboRoomNo.Text);
                    Int64 croll = Int64.Parse(TxtCollegeRoll.Text);
                    string sname = TxtStudentName.Text;
                    string fname = TxtFathersName.Text;
                    string mname = TxtMothersName.Text;
                    string add = TxtAddress.Text;
                    string email = TxtEmail.Text;
                    string college = TxtCollegeName.Text;
                    string stdfield = TxtStudyField.Text;
                    string idproof = TxtIDProof.Text;

                    query = "insert into NewStudentDetails (Name,MobileNo,FathersName,MothersName,ParrentsMobileNo,Email,Gender,CollegeName,CollegeRoll,IDProof,StudyField,RoomNo,Address)  " +
                        "values('" + sname + "'," + mobile + ",'" + fname + "','" + mname + "'," + pmobile + ",'" + email + "','" + gender + "','" + college + "'," + croll + ",'" + idproof + "','" + stdfield + "'," + roomno + ",'" + add + "')  ";

                    function.SetData(query, "Student registration sucessfull...");
                    UC_NewStudent_Load(this, null);
                    query = "update Rooms set Booked = 'Yes'  where RoomNo = " + roomno + " ";
                    function.SetData(query);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Please fill all the details...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {

            }





            // -----------------------------
            //string ConnectionString = "server=localhost;user=root;database=Hostel;port=3306;password=jinu0292";
            //MySqlConnection con = new MySqlConnection(ConnectionString);
            //con.Open();
            //string query = "Insert into StudentDetails (name,mobile,gender,email,collegeName,stydyField,collegeRoll,idProof,fName,mName,fMob,address) Values('" + TxtStudentName.Text + "','" + TxtMobile.Text + "', '" + gender + "','" + TxtEmail.Text + "','" + TxtCollegeName.Text + "','" + TxtStudyField.Text + "','" + TxtCollegeRoll.Text + "','" + TxtIDProof.Text + "','" + TxtFathersName.Text + "','" + TxtMothersName.Text + "','" + TxtMobile.Text + "','" + TxtAddress.Text + "')";

            //MySqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = query;
            //if (cmd.ExecuteNonQuery() > 0)
            //{
            //    MessageBox.Show(" Inserted Successfully ");
            //}
            //else
            //{
            //    MessageBox.Show(" Failed to insert ");
            //}
            //con.Close();

            //////if(con!=null)
            //////{
            //////    MessageBox.Show("Connection Success");
            //////}



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
            ComboRoomNo.SelectedIndex = -1;
        }
        private void UC_NewStudent_Load(object sender, EventArgs e)
        {
            ClearAll();
            query = "select RoomNo from Rooms where RoomStatus ='Yes' And Booked = 'No'";
            DataSet ds = function.GetData(query);
            for(int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                ComboRoomNo.Items.Add(room);
            }
        }

        private void UC_NewStudent_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
