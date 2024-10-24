using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_project.DAO;
using Guna.UI2.WinForms;

namespace Final_project.Class
{
    public class Owner
    {
        private int id;
        OwnerDAO ownerDAO = new OwnerDAO();
        public Owner(int id)
        {
            this.Id = id;
        }

        public int Id { get => id; set => id = value; }

        public void AddEmployee(Employee emp, Account account, int idOwner, Guna2DataGridView gridView)
        {
            ownerDAO.ExcutiveAddEmployee(emp, account, idOwner, gridView);
        }

        public bool DeleteEmployee(int idEpmloyee, Guna2DataGridView dataGridView) 
        {
            return ownerDAO.excutiveDeleteEmployee(idEpmloyee, dataGridView);
        }

        public DataTable FindEmployeeByName(string empName) 
        {
            return ownerDAO.FindEmployeeByName(empName);
        }

        public DataTable FindEmployeeByID(int id)
        {
            return ownerDAO.FindEmployeeByID(id);
        }
    }
}
