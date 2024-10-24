using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_project.Class;
using Final_project.SqlConection;

namespace Final_project.UserControl
{
    public partial class UC_Transaction : System.Windows.Forms.UserControl
    {
        Transaction Transaction = new Transaction();
        public UC_Transaction()
        {
            InitializeComponent();
        }

        private void UC_Transaction_Load(object sender, EventArgs e)
        {
            Transaction.DisplayTransaction("Kho", dgvIncom);
            Transaction.DisplayTransaction("Khac", dgvExport);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void dgvExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Connection conn = new Connection();
            if (e.RowIndex >= 0)
            {
                lvConsignmentImportDetail.Items.Clear();

                DataGridViewRow selectedRow = dgvExport.Rows[e.RowIndex];

                string consigmentID = selectedRow.Cells[0].Value.ToString();

                using (SqlCommand cmd = new SqlCommand("select * from dbo.ConsignmentDetail(@ConsigmentID)", conn.Connect()))
                {
                    cmd.Parameters.AddWithValue("@ConsigmentID", consigmentID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string imei = reader.GetString(0);
                        string brand = reader.GetString(1);
                        string modelName = reader.GetString(2);
                        string name = reader.GetString(3);
                        string rom = reader.GetString(4);
                        string ram = reader.GetString(5);
                        string color = reader.GetString(6);
                        string state = reader.GetString(7);

                        ListViewItem item = new ListViewItem(imei);
                        item.SubItems.Add(brand);
                        item.SubItems.Add(modelName);
                        item.SubItems.Add(name);
                        item.SubItems.Add(rom);
                        item.SubItems.Add(ram);
                        item.SubItems.Add(color);
                        item.SubItems.Add(state);

                        lvConsignmentImportDetail.Items.Add(item);
                    }

                    reader.Close();
                }
            }
        }

        private void dgvIncom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Connection conn = new Connection();
            if (e.RowIndex >= 0)
            {
                lvConsignmentImportDetail.Items.Clear();

                DataGridViewRow selectedRow = dgvExport.Rows[e.RowIndex];

                string consigmentID = selectedRow.Cells[0].Value.ToString();

                using (SqlCommand cmd = new SqlCommand("select * from dbo.ConsignmentDetail(@ConsigmentID)", conn.Connect()))
                {
                    cmd.Parameters.AddWithValue("@ConsigmentID", consigmentID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string imei = reader.GetString(0);
                        string brand = reader.GetString(1);
                        string modelName = reader.GetString(2);
                        string name = reader.GetString(3);
                        string rom = reader.GetString(4);
                        string ram = reader.GetString(5);
                        string color = reader.GetString(6);
                        string state = reader.GetString(7);

                        ListViewItem item = new ListViewItem(imei);
                        item.SubItems.Add(brand);
                        item.SubItems.Add(modelName);
                        item.SubItems.Add(name);
                        item.SubItems.Add(rom);
                        item.SubItems.Add(ram);
                        item.SubItems.Add(color);
                        item.SubItems.Add(state);

                        lvConsignmentImportDetail.Items.Add(item);
                    }

                    reader.Close();
                }
            }
        }
    }
}
