using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;
using Final_project.Class;
using Final_project.SqlConection;
using Guna.UI2.WinForms;

namespace Final_project.DAO
{
    internal class OwnerDAO
    {
        public OwnerDAO() { }

        Connection conn = new Connection();

        // thực thi thêm nhân viên
        public void ExcutiveAddEmployee(Employee employee, Account account, int idOwner, Guna2DataGridView gridView)
        {
                                                                                    
            try
            {
                using (SqlCommand command = new SqlCommand("AddEmployee", conn.Connect()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", employee.Adress);
                    command.Parameters.AddWithValue("@DateOfBirth", employee.DataOfBirth);
                    command.Parameters.AddWithValue("@StoreOwnerID", idOwner);
                    command.Parameters.AddWithValue("@Username", account.UserName);
                    command.Parameters.AddWithValue("@Password", account.Password);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    loadListEmployee(gridView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        // Xóa nhân viên

        public bool excutiveDeleteEmployee(int idEmployee, Guna2DataGridView dataGridView)
        {
            bool result = true;
            try
            {
                using (SqlCommand command = new SqlCommand("DeleteEmployee", conn.Connect()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", idEmployee);
                    command.ExecuteNonQuery ();
                    loadListEmployee(dataGridView);

                }
            } catch (Exception ex) 
            {
                result = false;

            }
            return result;
        }

        // tìm nhân viên theo tên

        public DataTable FindEmployeeByName(string employeeName) 
        {
            DataTable dataTable = new DataTable();
            try
            {
                using(SqlCommand cmd = new SqlCommand("SELECT * FROM GetEmployee(@ID, @Name)", conn.Connect()))
                {
              
                    cmd.Parameters.AddWithValue("@ID", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Name", employeeName);
                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            } 
            catch
            {
            }
            return dataTable;
        }
        public DataTable FindEmployeeByID(int id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetEmployee(@ID, @Name)", conn.Connect()))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", DBNull.Value);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            catch
            {
            }
            return dataTable;
        }

        // load lại danh sách nhân viên
        public void loadListEmployee(Guna2DataGridView dgvEmployees)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM GetEmployee(NULL, NULL)", conn.Connect()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

     
                dgvEmployees.DataSource = dataTable;
                if (dgvEmployees.Columns["visible"].Visible != null)
                {
                    dgvEmployees.Columns["visible"].Visible = false;

                }

            }

        }

    }
}
