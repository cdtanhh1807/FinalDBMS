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
    public partial class UC_Merchandise : System.Windows.Forms.UserControl
    {
        Connection conn = new Connection();
        public UC_Merchandise()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UC_Merchandise_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void lvMerch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDetailMerch.Items.Clear();

            if (lvMerch.SelectedItems.Count > 0)
            {
                ListViewItem lvItems = lvMerch.SelectedItems[0];

                string modelSelec = lvItems.SubItems[1].Text;

                using (SqlCommand cmd = new SqlCommand("EXEC GetPhoneDetailsByModel @ModelName=@modelSelec, @Location='Tong'", conn.Connect()))
                {
                    cmd.Parameters.AddWithValue("@modelSelec", modelSelec);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string brand = reader.GetString(0);
                        string model = reader.GetString(1);
                        string name = reader.GetString(2);
                        string imei = reader.GetString(3);
                        string rom = reader.GetString(4);
                        string ram = reader.GetString(5);
                        string color = reader.GetString(6);
                        string state = reader.GetString(7);
                        string shelfID = reader.GetString(8);
                        string compartmentID = reader.GetString(9);

                        ListViewItem item = new ListViewItem(imei);
                        item.SubItems.Add(rom);
                        item.SubItems.Add(ram);
                        item.SubItems.Add(color);
                        item.SubItems.Add(state);
                        item.SubItems.Add(shelfID);
                        item.SubItems.Add(compartmentID);

                        lvDetailMerch.Items.Add(item);
                    }
                    reader.Close();
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lvMerch.Items.Clear();
            lvDetailMerch.Items.Clear();

            string brandSearch = txbSearchBrand.Text;
            string modelSearch = txbSearchModel.Text;
            string nameSearch = txbSearchName.Text;

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetPhoneModelList(@brandSearch, @modelSearch, @nameSearch, 'Tong')", conn.Connect()))
            {
                cmd.Parameters.AddWithValue("@brandSearch", brandSearch);
                cmd.Parameters.AddWithValue("@modelSearch", modelSearch);
                cmd.Parameters.AddWithValue("@nameSearch", nameSearch);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string brand = reader.GetString(0);
                    string model = reader.GetString(1);
                    string name = reader.GetString(2);
                    string count = reader.GetInt32(3).ToString();

                    ListViewItem item = new ListViewItem(brand);
                    item.SubItems.Add(model);
                    item.SubItems.Add(name);
                    item.SubItems.Add(count);

                    lvMerch.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            lvMerch.Items.Clear();
            lvDetailMerch.Items.Clear();
            LoadAll();
        }

        public void LoadAll()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetPhoneModelList(NULL, NULL, NULL, 'Tong')", conn.Connect()))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string brand = reader.GetString(0);
                    string model = reader.GetString(1);
                    string name = reader.GetString(2);
                    string count = reader.GetInt32(3).ToString();

                    ListViewItem item = new ListViewItem(brand);
                    item.SubItems.Add(model);
                    item.SubItems.Add(name);
                    item.SubItems.Add(count);

                    lvMerch.Items.Add(item);
                }
                reader.Close();
            }
        }
    }
}
