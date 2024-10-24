using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_project.Class;
using Final_project.DAO;

namespace Final_project.UserControl
{
    public partial class UC_Employee : System.Windows.Forms.UserControl
    {
        private Owner owner;
        OwnerDAO ownerDAO = new OwnerDAO();


        public UC_Employee(Owner owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            FAddEmployee employee = new FAddEmployee(owner, dgvOverview);
            employee.ShowDialog();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            ownerDAO.loadListEmployee(dgvOverview);
        }

        // kiểm tra là số hay chữ
        public bool IsInteger(string input)
        {
            int number;
            return int.TryParse(input, out number);
        }


    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(IsInteger(txtSearchName.Text))
            {
                int id = int.Parse(txtSearchName.Text);
                dgvOverview.DataSource = owner.FindEmployeeByID(id);
            } 
            else
            {
                dgvOverview.DataSource = owner.FindEmployeeByName(txtSearchName.Text.Trim());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOverview.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in  dgvOverview.SelectedRows)
                {
                    if(!owner.DeleteEmployee(int.Parse(row.Cells["ID"].Value.ToString()), dgvOverview))
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchName.Text.Trim().Length == 0)
            {
                UC_Employee_Load(sender, e);
            }
        }
    }
}
