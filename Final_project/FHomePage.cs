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
using Final_project.UserControl;

namespace Final_project
{
    public partial class frmHomePage : Form
    {

     private Owner owner = new Owner(1);
        
//         public frmHomePage()

        Account account;
        public frmHomePage(Account account)
        {
            InitializeComponent();

            this.account = account;


            if (account.Role == "admin")
            {
                btnEmployee.Visible = true;
            }
            else btnEmployee.Visible = false;
 
            this.Load += new EventHandler(btnMerchandise_Click);

        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ResetButton()
        {
            btnMerchandise.FillColor = Color.FromArgb(0, 106, 250);
            btnImport.FillColor = Color.FromArgb(0, 106, 250);
            btnExport.FillColor = Color.FromArgb(0, 106, 250);
            btnTransaction.FillColor = Color.FromArgb(0, 106, 250);
            btnEmployee.FillColor = Color.FromArgb(0, 106, 250);
        }
        private void btnMerchandise_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnMerchandise.FillColor = Color.FromArgb(0, 106, 219);

            UC_Merchandise merchandise = new UC_Merchandise();
            pnShowUC.Controls.Clear();
            merchandise.Location = new Point(0, 0);
            merchandise.Size = new Size(1340, 900);
            pnShowUC.Controls.Add(merchandise);

        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnExport.FillColor = Color.FromArgb(0, 106, 219);

            UC_Export export = new UC_Export(account);
            pnShowUC.Controls.Clear();
            export.Location = new Point(0, 0);
            export.Size = new Size(1340, 900);
            pnShowUC.Controls.Add(export);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnImport.FillColor = Color.FromArgb(0, 106, 219);

            UC_Import import = new UC_Import();
            pnShowUC.Controls.Clear();
            import.Location = new Point(0, 0);
            import.Size = new Size(1340, 900);
            pnShowUC.Controls.Add(import);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnTransaction.FillColor = Color.FromArgb(0, 106, 219);

            UC_Transaction transaction = new UC_Transaction();
            pnShowUC.Controls.Clear();
            transaction.Location = new Point(0, 0);
            transaction.Size = new Size(1340, 900);
            pnShowUC.Controls.Add(transaction);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnEmployee.FillColor = Color.FromArgb(0, 106, 219);
            UC_Employee uc_employee = new UC_Employee(owner);
            pnShowUC.Controls.Clear();
            uc_employee.Location = new Point(0, 0);
            uc_employee.Size = new Size(1340, 900);
            pnShowUC.Controls.Add(uc_employee);
        }
    }
}
