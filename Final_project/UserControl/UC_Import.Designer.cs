namespace Final_project.UserControl
{
    partial class UC_Import
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddConsignment = new Guna.UI2.WinForms.Guna2Button();
            this.lvConsignmentImportDetail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvConsignmentImport = new System.Windows.Forms.ListView();
            this.ConsignmentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remittance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImportDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvOverview = new System.Windows.Forms.DataGridView();
            this.Importer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel2.Controls.Add(this.txtSearchName);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(212, 717);
            this.guna2Panel2.TabIndex = 8;
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchName.BorderColor = System.Drawing.Color.LightGray;
            this.txtSearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchName.DefaultText = "";
            this.txtSearchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchName.Location = new System.Drawing.Point(22, 81);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.PasswordChar = '\0';
            this.txtSearchName.PlaceholderText = "Theo tên đơn hàng";
            this.txtSearchName.SelectedText = "";
            this.txtSearchName.Size = new System.Drawing.Size(173, 40);
            this.txtSearchName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(219)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(194, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 136);
            this.label1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(223, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(260, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Danh sách phiếu nhập kho";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddConsignment
            // 
            this.btnAddConsignment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddConsignment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddConsignment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddConsignment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddConsignment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(172)))), ((int)(((byte)(77)))));
            this.btnAddConsignment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConsignment.ForeColor = System.Drawing.Color.White;
            this.btnAddConsignment.Location = new System.Drawing.Point(942, 28);
            this.btnAddConsignment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddConsignment.Name = "btnAddConsignment";
            this.btnAddConsignment.Size = new System.Drawing.Size(84, 41);
            this.btnAddConsignment.TabIndex = 18;
            this.btnAddConsignment.Text = "Thêm";
            this.btnAddConsignment.Click += new System.EventHandler(this.btnAddConsignment_Click);
            // 
            // lvConsignmentImportDetail
            // 
            this.lvConsignmentImportDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvConsignmentImportDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConsignmentImportDetail.FullRowSelect = true;
            this.lvConsignmentImportDetail.GridLines = true;
            this.lvConsignmentImportDetail.HideSelection = false;
            this.lvConsignmentImportDetail.Location = new System.Drawing.Point(225, 427);
            this.lvConsignmentImportDetail.Name = "lvConsignmentImportDetail";
            this.lvConsignmentImportDetail.Size = new System.Drawing.Size(821, 287);
            this.lvConsignmentImportDetail.TabIndex = 23;
            this.lvConsignmentImportDetail.UseCompatibleStateImageBehavior = false;
            this.lvConsignmentImportDetail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IMEI";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "HÃNG";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DÒNG";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TÊN";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ROM";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "RAM";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "MÀU";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TÌNH TRẠNG";
            this.columnHeader8.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Chi tiết lô hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lô hàng đã nhập";
            // 
            // lvConsignmentImport
            // 
            this.lvConsignmentImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConsignmentID,
            this.Remittance,
            this.PhoneQuantity,
            this.ImportDate,
            this.Importer});
            this.lvConsignmentImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConsignmentImport.FullRowSelect = true;
            this.lvConsignmentImport.GridLines = true;
            this.lvConsignmentImport.HideSelection = false;
            this.lvConsignmentImport.Location = new System.Drawing.Point(225, 119);
            this.lvConsignmentImport.Name = "lvConsignmentImport";
            this.lvConsignmentImport.Size = new System.Drawing.Size(821, 271);
            this.lvConsignmentImport.TabIndex = 20;
            this.lvConsignmentImport.UseCompatibleStateImageBehavior = false;
            this.lvConsignmentImport.View = System.Windows.Forms.View.Details;
            this.lvConsignmentImport.SelectedIndexChanged += new System.EventHandler(this.lvConsignmentImport_SelectedIndexChanged);
            // 
            // ConsignmentID
            // 
            this.ConsignmentID.Text = "MÃ LÔ HÀNG";
            this.ConsignmentID.Width = 200;
            // 
            // Remittance
            // 
            this.Remittance.Text = "NGUỒN NHẬP";
            this.Remittance.Width = 220;
            // 
            // PhoneQuantity
            // 
            this.PhoneQuantity.Text = "SỐ LƯỢNG ĐIỆN THOẠI";
            this.PhoneQuantity.Width = 100;
            // 
            // ImportDate
            // 
            this.ImportDate.Text = "NGẢY NHẬP";
            this.ImportDate.Width = 150;
            // 
            // dgvOverview
            // 
            this.dgvOverview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverview.Location = new System.Drawing.Point(225, 81);
            this.dgvOverview.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.RowHeadersWidth = 51;
            this.dgvOverview.RowTemplate.Height = 24;
            this.dgvOverview.Size = new System.Drawing.Size(821, 617);
            this.dgvOverview.TabIndex = 19;
            // 
            // Importer
            // 
            this.Importer.Text = "NGƯỜI NHẬP";
            this.Importer.Width = 140;
            // 
            // UC_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lvConsignmentImportDetail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvConsignmentImport);
            this.Controls.Add(this.dgvOverview);
            this.Controls.Add(this.btnAddConsignment);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Import";
            this.Size = new System.Drawing.Size(1048, 717);
            this.Load += new System.EventHandler(this.UC_Import_Load);
            this.Click += new System.EventHandler(this.UC_Import_Click);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAddConsignment;
        private System.Windows.Forms.ListView lvConsignmentImportDetail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvConsignmentImport;
        private System.Windows.Forms.ColumnHeader ConsignmentID;
        private System.Windows.Forms.ColumnHeader Remittance;
        private System.Windows.Forms.ColumnHeader PhoneQuantity;
        private System.Windows.Forms.ColumnHeader ImportDate;
        private System.Windows.Forms.DataGridView dgvOverview;
        private System.Windows.Forms.ColumnHeader Importer;
    }
}
