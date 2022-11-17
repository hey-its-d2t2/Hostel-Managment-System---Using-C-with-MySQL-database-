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
    public partial class UC_Admin : UserControl
    {
            DB_Function function = new DB_Function();
        string query1;
        public UC_Admin()
        {
            InitializeComponent();
        }

        private void UC_Admin_Load(object sender, EventArgs e)
        {
           
            MySqlConnection conn1 = new MySqlConnection("data source = MySQL Community Server - GPL; integrated security = True; server = localhost; user = root; database = Hostel; port = 3306; password = jinu0292");
            conn1.Open();
            //Avilabel Rooms
            MySqlCommand query = new MySqlCommand("select count(*) from Rooms where RoomStatus = 'Yes'", conn1);
            var Av = query.ExecuteScalar();
            LblAvilableRooms_Val.Text = Av.ToString();

            //Room under service
            query = new MySqlCommand("select count(*) from Rooms where RoomStatus = 'No'", conn1);
            var Lb = query.ExecuteScalar();
            LblRoomUndMain_Val.Text = Lb.ToString();

            //Booked Rooms
            query = new MySqlCommand("select count(*) from Rooms where Booked = 'Yes'", conn1);
            var br = query.ExecuteScalar();
            LblBookedRooms_Val.Text = br.ToString();

            //Total Rooms
            query = new MySqlCommand("select count(*) from Rooms", conn1);
            var tr = query.ExecuteScalar();
            LblTotalRooms_Vla.Text = tr.ToString();


            //Boys in hostel
            query = new MySqlCommand("select count(*) from NewStudentDetails where Gender = 'Boy' and Living = 'Yes'", conn1);
            var boyIn = query.ExecuteScalar();
            LblBoyInHos_Val.Text = boyIn.ToString();

            //Girls in hostel
            query = new MySqlCommand("select count(*) from NewStudentDetails where Gender = 'Girl' and Living = 'Yes'", conn1);
            var girlIn = query.ExecuteScalar();
            LblGirlInHos_Val.Text = girlIn.ToString();

            //Present student in Hostel
            LblPresentStudetn_Val.Text = (Int64.Parse(boyIn.ToString()) + Int64.Parse(girlIn.ToString())).ToString();
            //Leaved Boys From Hostel
            query = new MySqlCommand("select count(*) from NewStudentDetails where Gender = 'Boy' and Living='No'", conn1);
            var bouOut = query.ExecuteScalar();
            LblLevBoyFromHos_Val.Text = bouOut.ToString();

            //Leaved Girls From Hostel
            query = new MySqlCommand("select count(*) from NewStudentDetails where Gender = 'Girl' and Living='No'", conn1);
            var girlOut = query.ExecuteScalar();
            LblLevGirlFromHos_Val.Text = girlOut.ToString();

            //Software User
            query = new MySqlCommand("select count(*) from UserDetails", conn1);
            var softUser = query.ExecuteScalar();
            LblSoftUser_Val.Text = softUser.ToString();

            conn1.Close();
        }

        private void BtnDeleteLivingAllData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete all data of Leaving student "+Environment.NewLine+"Are you sure? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query1 = "delete  from NewStudentDetails  where Living = 'Yes'";
                function.SetData(query1, "Details deleted.");
                UC_Admin_Load(this, null);
            }
        }

        private void BtnDeleteLeavedAllData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete all data of Leaved student " + Environment.NewLine + "Are you sure? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query1 = "delete  from NewStudentDetails  where Living = 'No'";
                function.SetData(query1, "Details deleted.");
                UC_Admin_Load(this, null);
            }

        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            Frm_SoftUserDet df = new Frm_SoftUserDet();
            df.Show();
            
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            Frm_CahgePass fc = new Frm_CahgePass();
            fc.Show();
            
            
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            Frm_AddNewUSer ad = new Frm_AddNewUSer();
            ad.Show();
          
        }
    }
}
