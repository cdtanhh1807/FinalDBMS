using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_project.SqlConection;
using Guna.UI2.WinForms;

namespace Final_project.DAO
{
    internal class TransactionDAO
    {
        Connection con = new Connection();
        public TransactionDAO()
        {
            
        }

        public void excutiveDisplayTransaction(string type, Guna2DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            try 
            {
                using (SqlCommand cmd = new SqlCommand("select * from GetIn(@Place)", con.Connect()))
                {
                    cmd.Parameters.AddWithValue("@Place", type);
                    using (SqlDataAdapter ap = new SqlDataAdapter(cmd))
                    {
                        ap.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            } 
            catch (Exception ex) { }
        }

        
    }
}
