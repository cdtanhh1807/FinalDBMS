using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;
using Final_project.Class;
using Guna.UI2.WinForms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace Final_project
{
    public partial class FAddEmployee : Form
    {
        private Account account;
        private Employee employee;
        private Owner owner;
        private Guna2DataGridView gridView;
        public FAddEmployee(Owner owner, Guna2DataGridView dataGridView)
        {
            InitializeComponent();
            this.owner = owner;
            this.gridView = dataGridView;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime dateOfBirth = dtkDOB.Value.Date;
            account = new Account(txtAccount.Text.Trim(), txtPassWorld.Text.Trim());
            employee = new Employee(txtName.Text, dateOfBirth, txtAddress.Text, txtPhone.Text);

            owner.AddEmployee(employee, account ,owner.Id, gridView);

        }
    }
}
