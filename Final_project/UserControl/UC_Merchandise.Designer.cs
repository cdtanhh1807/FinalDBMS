namespace Final_project.UserControl
{
    partial class UC_Merchandise
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
            this.txbSearchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbSearchModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbSearchBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOverview = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lvMerch = new System.Windows.Forms.ListView();
            this.MerchBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MerchModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MerchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvDetailMerch = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchAll = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel2.Controls.Add(this.btnFind);
            this.guna2Panel2.Controls.Add(this.txbSearchName);
            this.guna2Panel2.Controls.Add(this.txbSearchModel);
            this.guna2Panel2.Controls.Add(this.txbSearchBrand);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(212, 717);
            this.guna2Panel2.TabIndex = 2;
            // 
            // txbSearchName
            // 
            this.txbSearchName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbSearchName.BorderColor = System.Drawing.Color.LightGray;
            this.txbSearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchName.DefaultText = "";
            this.txbSearchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchName.ForeColor = System.Drawing.Color.Black;
            this.txbSearchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchName.Location = new System.Drawing.Point(22, 180);
            this.txbSearchName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbSearchName.Name = "txbSearchName";
            this.txbSearchName.PasswordChar = '\0';
            this.txbSearchName.PlaceholderText = "tên điện thoại";
            this.txbSearchName.SelectedText = "";
            this.txbSearchName.Size = new System.Drawing.Size(173, 40);
            this.txbSearchName.TabIndex = 6;
            // 
            // txbSearchModel
            // 
            this.txbSearchModel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbSearchModel.BorderColor = System.Drawing.Color.LightGray;
            this.txbSearchModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchModel.DefaultText = "";
            this.txbSearchModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearchModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearchModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchModel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchModel.ForeColor = System.Drawing.Color.Black;
            this.txbSearchModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchModel.Location = new System.Drawing.Point(22, 131);
            this.txbSearchModel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbSearchModel.Name = "txbSearchModel";
            this.txbSearchModel.PasswordChar = '\0';
            this.txbSearchModel.PlaceholderText = "dòng điện thoại";
            this.txbSearchModel.SelectedText = "";
            this.txbSearchModel.Size = new System.Drawing.Size(173, 40);
            this.txbSearchModel.TabIndex = 5;
            // 
            // txbSearchBrand
            // 
            this.txbSearchBrand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbSearchBrand.BorderColor = System.Drawing.Color.LightGray;
            this.txbSearchBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchBrand.DefaultText = "";
            this.txbSearchBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearchBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearchBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchBrand.ForeColor = System.Drawing.Color.Black;
            this.txbSearchBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchBrand.Location = new System.Drawing.Point(22, 81);
            this.txbSearchBrand.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbSearchBrand.Name = "txbSearchBrand";
            this.txbSearchBrand.PasswordChar = '\0';
            this.txbSearchBrand.PlaceholderText = "hãng điện thoại";
            this.txbSearchBrand.SelectedText = "";
            this.txbSearchBrand.Size = new System.Drawing.Size(173, 40);
            this.txbSearchBrand.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(219)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(183, 41);
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
            this.label1.Size = new System.Drawing.Size(190, 288);
            this.label1.TabIndex = 2;
            // 
            // dgvOverview
            // 
            this.dgvOverview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverview.Location = new System.Drawing.Point(223, 81);
            this.dgvOverview.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.RowHeadersWidth = 51;
            this.dgvOverview.RowTemplate.Height = 24;
            this.dgvOverview.Size = new System.Drawing.Size(821, 617);
            this.dgvOverview.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(219, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(194, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kiểm kho";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lvMerch
            // 
            this.lvMerch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MerchBrand,
            this.MerchModel,
            this.MerchName,
            this.columnHeader11});
            this.lvMerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMerch.FullRowSelect = true;
            this.lvMerch.GridLines = true;
            this.lvMerch.HideSelection = false;
            this.lvMerch.Location = new System.Drawing.Point(223, 119);
            this.lvMerch.Name = "lvMerch";
            this.lvMerch.Size = new System.Drawing.Size(821, 271);
            this.lvMerch.TabIndex = 9;
            this.lvMerch.UseCompatibleStateImageBehavior = false;
            this.lvMerch.View = System.Windows.Forms.View.Details;
            this.lvMerch.SelectedIndexChanged += new System.EventHandler(this.lvMerch_SelectedIndexChanged);
            // 
            // MerchBrand
            // 
            this.MerchBrand.Text = "HÃNG";
            this.MerchBrand.Width = 250;
            // 
            // MerchModel
            // 
            this.MerchModel.Text = "DÒNG";
            this.MerchModel.Width = 220;
            // 
            // MerchName
            // 
            this.MerchName.Text = "TÊN";
            this.MerchName.Width = 250;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "SỐ LƯỢNG";
            this.columnHeader11.Width = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chi tiết điện thoại";
            // 
            // lvDetailMerch
            // 
            this.lvDetailMerch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvDetailMerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDetailMerch.FullRowSelect = true;
            this.lvDetailMerch.GridLines = true;
            this.lvDetailMerch.HideSelection = false;
            this.lvDetailMerch.Location = new System.Drawing.Point(223, 427);
            this.lvDetailMerch.Name = "lvDetailMerch";
            this.lvDetailMerch.Size = new System.Drawing.Size(821, 271);
            this.lvDetailMerch.TabIndex = 12;
            this.lvDetailMerch.UseCompatibleStateImageBehavior = false;
            this.lvDetailMerch.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "IMEI";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ROM";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "RAM";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "MÀU";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TÌNH TRẠNG";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "VỊ TRÍ";
            this.columnHeader9.Width = 110;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "";
            this.columnHeader10.Width = 144;
            // 
            // btnFind
            // 
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(172)))), ((int)(((byte)(77)))));
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(22, 227);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(173, 40);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "Tìm";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(172)))), ((int)(((byte)(77)))));
            this.btnSearchAll.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAll.ForeColor = System.Drawing.Color.White;
            this.btnSearchAll.Location = new System.Drawing.Point(844, 28);
            this.btnSearchAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(191, 40);
            this.btnSearchAll.TabIndex = 19;
            this.btnSearchAll.Text = "Tất cả điện thoại";
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // UC_Merchandise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.lvDetailMerch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvMerch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOverview);
            this.Controls.Add(this.guna2Panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Merchandise";
            this.Size = new System.Drawing.Size(1048, 717);
            this.Load += new System.EventHandler(this.UC_Merchandise_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txbSearchName;
        private Guna.UI2.WinForms.Guna2TextBox txbSearchModel;
        private Guna.UI2.WinForms.Guna2TextBox txbSearchBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOverview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvMerch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader MerchBrand;
        private System.Windows.Forms.ColumnHeader MerchModel;
        //private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ListView lvDetailMerch;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader MerchName;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2Button btnSearchAll;
    }
}
