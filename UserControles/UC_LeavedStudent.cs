using DGVPrinterHelper;
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
    public partial class UC_LeavedStudent : UserControl
    {
        DB_Function function = new DB_Function();
        string query;
        public UC_LeavedStudent()
        {
            InitializeComponent();
        }

        private void UC_LeavedStudent_Load(object sender, EventArgs e)
        {

            query = "select * from NewStudentDetails where Living = 'No' ";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];

        }

        private void TxtNameSearch_OnValueChanged(object sender, EventArgs e)
        {
            //Search Students by name
            query = "select * from NewStudentDetails where Living = 'No'and Name like '" + TxtNameSearch.Text + "%'";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            DGVPrinter printer = new DGVPrinter();
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.Title = "Genesis Hostel "+Environment.NewLine+"S.M Colege Road Bhagalpur"+Environment.NewLine+"Ph : 999999"+Environment.NewLine+
                "-----------------------------------------"+Environment.NewLine+ " All Leaved Student  Data\n ------------------------------------------ ";
            printer.SubTitle = String.Format("Date : {0}                                Time : {1}", DateTime.Now.ToString("dd MMMM yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.Footer = "Developed by : developers.02.92 contact: developers.02.92@gmail.com";
            printer.PrintDataGridView(DataGridView1);

            //Reset 
            DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView1.CurrentRow.Selected = true;
            string Id, Name, MobileNo, FathersName, MothersName, ParrentsMobileNo, Email, Gender, CollegeName, CollegeRoll, IDProof, StudyField, RoomNo, Living, Address;
            Id = DataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            Name = DataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            MobileNo = DataGridView1.Rows[e.RowIndex].Cells["MobileNo"].Value.ToString();
            FathersName = DataGridView1.Rows[e.RowIndex].Cells["FathersName"].Value.ToString();
            MothersName = DataGridView1.Rows[e.RowIndex].Cells["MothersName"].Value.ToString();
            ParrentsMobileNo = DataGridView1.Rows[e.RowIndex].Cells["ParrentsMobileNo"].Value.ToString();
            Email = DataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            Gender = DataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            CollegeName = DataGridView1.Rows[e.RowIndex].Cells["CollegeName"].Value.ToString();
            CollegeRoll = DataGridView1.Rows[e.RowIndex].Cells["CollegeRoll"].Value.ToString();
            IDProof = DataGridView1.Rows[e.RowIndex].Cells["IDProof"].Value.ToString();
            StudyField = DataGridView1.Rows[e.RowIndex].Cells["StudyField"].Value.ToString();
            RoomNo = DataGridView1.Rows[e.RowIndex].Cells["RoomNo"].Value.ToString();
            Living = DataGridView1.Rows[e.RowIndex].Cells["Living"].Value.ToString();
            Address = DataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();


            DGVPrinter printer = new DGVPrinter();
            printer.printDocument.DefaultPageSettings.Landscape = true;

            printer.Title = "Genesis Hostel " + Environment.NewLine + "S.M Colege Road Bhagalpur" + Environment.NewLine + "Ph : 99999";
            printer.SubTitle = String.Format("\n                                                " +
                "----------------------------------------- \n" +
                "                                                             Leaved Student  Data\n" +
                "                                                ----------------------------------------- \n" +
                " Date : {0}                                                   Time : {1}" +
                "\n----------------------------------------------------------------------------------------" +
                "\n  Name  : {2}" +
                "\n  Mobile No. : {3}" +
                "\n  Father's Name : {4}" +
                "\n  Mother's Name : {5}" +
                "\n  Parrent's Mobile No. : {6}" +
                "\n  Email : {7}" +
                "\n  Gender : {8}" +
                "\n  College Name : {9}" +
                "\n  College Roll :{10}" +
                "\n  Id Proof {11}" +
                "\n  Study Field : {12}" +
                "\n  Room No : {13}" +
                "\n  Living : {14}" +
                "\n  Address : {15}" +
                "\n\n" +
                "----------------------------------------------------------------------------------------",
                DateTime.Now.ToString("dd MMMM yyyy"), DateTime.Now.ToString("hh:mm:ss tt"),
                Name, MobileNo, FathersName, MothersName, ParrentsMobileNo, Email, Gender, CollegeName, CollegeRoll, IDProof, StudyField, RoomNo, Living, Address);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PrintMargins = new System.Drawing.Printing.Margins(60, 60, 30, 15);
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.SubTitleAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.Footer = "Developed by : developers.02.92 contact: developers.02.92@gmail.com";
            printer.PrintDataGridView(dtv2);
        }
    }
}
