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
    public partial class Uc_StudentFee : UserControl
    {
        DB_Function function = new DB_Function();
        string query;
        public Uc_StudentFee()
        {
            InitializeComponent();
        }

        private void Uc_StudentFee_Load(object sender, EventArgs e)
        {
            ClearAll();
            TxtDueDate.Format = DateTimePickerFormat.Custom;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtMobile.Text != "")
            {
                try
                {
                    LblTypMobNo.Visible = false;

                    query = "select Name,MobileNo,Email,RoomNo from NewStudentDetails where MobileNo = " + TxtMobile.Text + " ";
                    DataSet ds = function.GetData(query);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        TxtStudentName.Text = ds.Tables[0].Rows[0][0].ToString();
                        TxtEmail.Text = ds.Tables[0].Rows[0][2].ToString();
                        TxtRoomNo.Text = ds.Tables[0].Rows[0][3].ToString();
                        SetDataGrid(Int64.Parse(TxtMobile.Text));
                    }
                    else
                    {
                        MessageBox.Show("No record exists...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Input mobile number in correct format.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                LblTypMobNo.Visible = true;
            }
        }

        public void SetDataGrid(Int64 mobile)
        {
            query = "select * from Fees where MobileNo = " + TxtMobile.Text + "";
            DataSet dataSet = function.GetData(query);
            DataGridView1.DataSource = dataSet.Tables[0];
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (TxtMobile.Text != "" && TxtDueAmount.Text != "")
            {
                query = "select * from Fees where MobileNo = " + Int64.Parse(TxtMobile.Text) + " and FeeMonth = '" + TxtDueDate.Text + "' ";
                DataSet dataSet = function.GetData(query);
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(TxtMobile.Text);
                    string month = TxtDueDate.Text;
                    Int64 amount = Int64.Parse(TxtDueAmount.Text);
                    query = "insert into Fees values(" + mobile + ",'" + month + "'," + amount + " )";
                    function.SetData(query, "Fee paid.");
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("No dues of " + TxtDueDate.Text + "  left.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter mobile number and" + Environment.NewLine + "Search then after pay.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();

        }
        private void ClearAll()
        {
            TxtMobile.Text = "";
            TxtStudentName.Text = "";
            TxtEmail.Text = "";
            TxtRoomNo.Text = "";
            TxtDueAmount.Text = "";
            TxtDueDate.Text = "";
            LblTypMobNo.Visible = false;
            DataGridView1.DataSource = "";
            DataGridView1.DataSource = 0;
        }

        private void LblHowToDel_Click(object sender, EventArgs e)
        {
            LblDelMsg.Visible = true;
        }

        private void LblDelMsg_Leave(object sender, EventArgs e)
        {
            LblDelMsg.Visible = false;
        }

        private void LblHowToDel_Leave(object sender, EventArgs e)
        {
            LblDelMsg.Visible = false;
        }

        private void LblHowToDel_MouseLeave(object sender, EventArgs e)
        {
            LblDelMsg.Visible = false;
        }

        private void LblHowToDel_MouseHover(object sender, EventArgs e)
        {
            LblDelMsg.Visible = true;
        }

        private void TxtMobile_Click(object sender, EventArgs e)
        {
            if (LblTypMobNo.Visible == true)
                LblTypMobNo.Visible = false;
            else
                LblTypMobNo.Visible = false;
        }

        private void Uc_StudentFee_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (MessageBox.Show("Delete item.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //DelWronFee();
            }
        }
        protected void DelWronFee()
        {
            query = "delete from Fees where FeeMonth = '" + TxtDueDate.Text + "'";
            function.SetData(query, "Data deleted.");
            Uc_StudentFee_Load(this, null);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DelWronFee();

        }
    }
}
