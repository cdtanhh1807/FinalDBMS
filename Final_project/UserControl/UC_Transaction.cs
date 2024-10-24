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

namespace Final_project.UserControl
{
    public partial class UC_Transaction : System.Windows.Forms.UserControl
    {
        Transaction Transaction = new Transaction();
        public UC_Transaction()
        {
            InitializeComponent();
        }

        private void UC_Transaction_Load(object sender, EventArgs e)
        {
            Transaction.DisplayTransaction("Kho", dgvIncom);
            Transaction.DisplayTransaction("Khac", dgvExport);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
