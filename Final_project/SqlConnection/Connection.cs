using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Final_project.SqlConection
{
    internal class Connection
    {

       // string strCon = "Data Source=DELL\\MAITMY;Initial Catalog=Phone_1;Integrated Security=True;Encrypt=False";

        string strCon = @"Data Source=DESKTOP-O1GT1JO\SQLEXPRESS;Initial Catalog=DBMSFinal;Integrated Security=True";


        public SqlConnection Connect()
        {
            SqlConnection con = new SqlConnection(strCon);
            if (con.State != ConnectionState.Open) 
            {
                con.Open();
            }
            return con;

        }       

    }
}
