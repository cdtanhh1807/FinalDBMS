using Final_project.SqlConection;
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

namespace Final_project.UserControl
{
    public partial class UC_Import : System.Windows.Forms.UserControl
    {
        Connection conn = new Connection();
        public UC_Import()
        {
            InitializeComponent();
        }

        private void UC_Import_Load(object sender, EventArgs e)
        {
            lvConsignmentImport.Items.Clear();
            using (SqlCommand cmd = new SqlCommand("select * from dbo.LoadInforConsignment() order by ConsignmentID desc", conn.Connect()))
            {
               SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string consignmentID = reader.GetString(0);
                    string remittance = reader.GetString(1);
                    string phoneQuantity = reader.GetInt32(2).ToString();
                    string importDate = reader.GetDateTime(3).ToString("dd-MM-yyyy");
                    string importer = reader.GetString(4).ToString();

                    ListViewItem item = new ListViewItem(consignmentID);
                    item.SubItems.Add(remittance);
                    item.SubItems.Add(phoneQuantity);
                    item.SubItems.Add(importDate);
                    item.SubItems.Add(importer);

                    lvConsignmentImport.Items.Add(item);
                }

                reader.Close();
            }
        }

        private void lvConsignmentImport_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvConsignmentImportDetail.Items.Clear();
            
            if (lvConsignmentImport.SelectedItems.Count > 0 )
            {
                ListViewItem items = lvConsignmentImport.SelectedItems[0];

                string consigmentID = items.SubItems[0].Text;

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
        

        private void btnAddConsignment_Click(object sender, EventArgs e)
        {
            FAddConsignment frm = new FAddConsignment();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void UC_Import_Click(object sender, EventArgs e)
        {
            UC_Import_Load(sender, e);
        }
    }
}
