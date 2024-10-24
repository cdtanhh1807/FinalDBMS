using Final_project.SqlConection;
using Final_project.UserControl;
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

namespace Final_project
{
    public partial class FAddPhone : Form
    {
        Connection conn = new Connection();
        private string consignmentCode;
        public FAddPhone(string consignmentCode)
        {
            InitializeComponent();
            this.consignmentCode = consignmentCode;
            LoadMetaData();
        }

        private void LoadMetaData()
        {
            using (SqlCommand cmd = new SqlCommand("select * from dbo.LoadShelf()", conn.Connect()))
            {

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string shelfID = reader.GetInt32(0).ToString();
                    cbbShelf.Items.Add(shelfID);
                }
               
            }
        }
        private void btnAddPhone_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.AddPhone", conn.Connect()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IMEI", SqlDbType.VarChar, 20)).Value = txtIMEI.Text;
                cmd.Parameters.Add(new SqlParameter("@Brand", SqlDbType.NVarChar, 50)).Value = txtBrand.Text;
                cmd.Parameters.Add(new SqlParameter("@ModelName", SqlDbType.NVarChar, 100)).Value = txtModelName.Text;
                cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 100)).Value = txtName.Text;
                cmd.Parameters.Add(new SqlParameter("@ROM", SqlDbType.NVarChar, 20)).Value = cbbROM.Text;
                cmd.Parameters.Add(new SqlParameter("@RAM", SqlDbType.NVarChar, 20)).Value = cbbRAM.Text;
                cmd.Parameters.Add(new SqlParameter("@Color", SqlDbType.NVarChar, 20)).Value = txtColor.Text;
                cmd.Parameters.Add(new SqlParameter("@State", SqlDbType.NVarChar, 50)).Value = cbbState.Text;
                cmd.Parameters.Add(new SqlParameter("@ConsignmentID", SqlDbType.VarChar, 50)).Value = consignmentCode;
                cmd.Parameters.Add(new SqlParameter("@CompartmentID", SqlDbType.VarChar, 20)).Value = cbbCompartment.Text;
                cmd.Parameters.Add(new SqlParameter("@ShelfID", SqlDbType.Int)).Value = cbbShelf.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string resultMessage = reader.GetString(0);
                    if (resultMessage == "Success")
                    {
                        MessageBox.Show("Them thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("Co loi xay ra");
                    }
                }
            }
            this.Close();
        }

        private void cbbShelf_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCompartment.Items.Clear();
            using (SqlCommand cmd = new SqlCommand("select * from dbo.LoadCompartment(@ShelfID)", conn.Connect()))
            {
                cmd.Parameters.AddWithValue("@ShelfID", Convert.ToInt32(cbbShelf.Text));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader.GetString(0);
                    cbbCompartment.Items.Add(ID);
                }

            }
        }
    }
}
