using Final_project.Class;
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
    public partial class UC_Export : System.Windows.Forms.UserControl
    {
        Account account;

        Connection conn = new Connection();
        public UC_Export(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void lvDetailMerch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDetailMerch.SelectedItems.Count > 0)
            {
                int index = lvDetailMerch.SelectedItems[0].Index;

                ListViewItem lvItems = lvDetailMerch.SelectedItems[0];

                string imeiSelec = lvItems.SubItems[0].Text;

                using (SqlCommand cmd = new SqlCommand("EXEC GetPhoneDetailsByIMEI @IMEI=@IMEISelec", conn.Connect()))
                {
                    cmd.Parameters.AddWithValue("@IMEISelec", imeiSelec);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string imei = reader.GetString(0);
                        string name = reader.GetString(1);
                        string model = reader.GetString(2);

                        ListViewItem item = new ListViewItem(imei);
                        item.SubItems.Add(name);
                        item.SubItems.Add(model);

                        lv.Items.Add(item);
                    }
                    reader.Close();

                    lvDetailMerch.Items.RemoveAt(index);
                }
            }
        }

        private void UC_Export_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lvMerch.Items.Clear();
            lvDetailMerch.Items.Clear();

            string brandSearch = txbSearchBrand.Text;
            string modelSearch = txbSearchModel.Text;
            string nameSearch = txbSearchName.Text;

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetPhoneModelList(@brandSearch, @modelSearch, @nameSearch, 'Kho')", conn.Connect()))
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

        private void lvMerch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDetailMerch.Items.Clear();

            if (lvMerch.SelectedItems.Count > 0)
            {
                ListViewItem lvItems = lvMerch.SelectedItems[0];

                string modelSelec = lvItems.SubItems[1].Text;

                using (SqlCommand cmd = new SqlCommand("EXEC GetPhoneDetailsByModel @ModelName=@modelSelec, @Location='Kho'", conn.Connect()))
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

        private string GetImeiList()
        {
            string imeis = "";
            foreach (ListViewItem item in lv.Items)
            {
                string imei = item.SubItems[0].Text;
                imeis += imei + ",";
            }
            string imeisResult = imeis.TrimEnd(',');
            return imeisResult;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string transacID = txbTransactionId.Text;
            string consignmentID = txbConsignmentId.Text;
            string recep = txbRecep.Text;
            //string accountIDStr = account.AccountId;
            //int accountID = Convert.ToInt32(accountIDStr);
            string imeis = GetImeiList();

            using (SqlCommand cmd = new SqlCommand("EXEC CreateTransaction @TransactionID=@TransactionID, @Reception=@Reception, @ConsignmentID=@ConsignmentID, @AccountID=@AccountID, @IMEIs=@IMEIs", conn.Connect()))
            {
                cmd.Parameters.AddWithValue("@TransactionID", transacID);
                cmd.Parameters.AddWithValue("@Reception", recep);
                cmd.Parameters.AddWithValue("@ConsignmentID", consignmentID);
                cmd.Parameters.AddWithValue("@AccountID", 1);
                cmd.Parameters.AddWithValue("@IMEIs", imeis);

                try
                {
                    int check = cmd.ExecuteNonQuery();

                    if (check > 0) MessageBox.Show("Thành công");
                }
                catch( Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }
    }
}
