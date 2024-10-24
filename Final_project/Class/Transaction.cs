using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_project.DAO;
using Guna.UI2.WinForms;

namespace Final_project.Class
{
    internal class Transaction
    {
        TransactionDAO TransactionDAO = new TransactionDAO();
        public Transaction()
        {
            
        }

        public void DisplayTransaction(string type, Guna2DataGridView dataGridView)
        {
            TransactionDAO.excutiveDisplayTransaction(type, dataGridView);
        }
    }
}
