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

namespace Final_project
{
    public partial class FAddConsignment : Form
    {
        Connection conn = new Connection();

        private int maxOpenCount;
        private int openCount = 0;
        private string consignmentCode;
        public FAddConsignment()
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
                    }

                    this.Hide();
                    OpenAddPhoneForm();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenAddPhoneForm();
        }
    }
}
