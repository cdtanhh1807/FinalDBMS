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

        private int maxOpenCount;
        private int openCount = 0;
        private string consignmentCode;

        bool check = false;

        public UC_Import()
        {
            InitializeComponent();
        }

        private void OpenAddPhoneForm()
        {
            if (openCount < maxOpenCount)
            {
                FAddPhone fAddPhone = new FAddPhone(consignmentCode);
                fAddPhone.StartPosition = FormStartPosition.CenterScreen;
                fAddPhone.FormClosed += NewForm_FormClosed;

                fAddPhone.Show();
                openCount++;
                
            }
        }

        private void UC_Import_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtQuantity.Text, out maxOpenCount) && maxOpenCount > 0)
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.AddConsignment", conn.Connect()))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            consignmentCode = reader.GetString(0);
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("dbo.SaveTransaction", conn.Connect()))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Reception", SqlDbType.NVarChar, 255)).Value = "Kho";
                        cmd.Parameters.Add(new SqlParameter("@Remittance", SqlDbType.NVarChar, 255)).Value = txtRemittance.Text;
                        cmd.Parameters.Add(new SqlParameter("@ConsignmentID", SqlDbType.VarChar, 50)).Value = consignmentCode;
                        cmd.Parameters.Add(new SqlParameter("@AccountID", SqlDbType.Int)).Value = 1;

                        cmd.ExecuteNonQuery();
                    };
                    OpenAddPhoneForm();

                    btnConfirm.Enabled = false;
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAll()
        {
            if (check == true)
            {
                using (SqlCommand cmd = new SqlCommand("select * from dbo.ConsignmentDetail(@ConsigmentID)", conn.Connect()))
                {
                    cmd.Parameters.AddWithValue("@ConsigmentID", consignmentCode);

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

        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (openCount == maxOpenCount)
            {
                check = true;
                LoadAll();
            }

            OpenAddPhoneForm();   
        }
    }
}
