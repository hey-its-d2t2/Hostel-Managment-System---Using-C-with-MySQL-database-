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
    public partial class Frm_SoftUserDet : Form
    {
        DB_Function function = new DB_Function();
        string query;
        public Frm_SoftUserDet()
        {
            InitializeComponent();
        }

        private void Frm_SoftUserDet_Load(object sender, EventArgs e)
        {
            query = "select * from UserDetails";
            DataSet ds = function.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete User.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from UserDetails where Id = " + id + "";
                function.SetData(query, "Data deleted.");
                this.Close();
            }
        }
    }
}
