namespace ShoesStoreManagement
{
    partial class frmMancusacc
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMancusacc));
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.grbFilters = new System.Windows.Forms.GroupBox();
            this.optCusphonenum = new System.Windows.Forms.RadioButton();
            this.optCustype = new System.Windows.Forms.RadioButton();
            this.optCusadd = new System.Windows.Forms.RadioButton();
            this.optCusname = new System.Windows.Forms.RadioButton();
            this.optCusid = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusPhonenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.splButton = new System.Windows.Forms.Splitter();
            this.grbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(141, 131);
            this.txtKeyword.Multiline = true;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(254, 30);
            this.txtKeyword.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(427, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(340, 478);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 43);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Info";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAddCus
            // 
            this.btnAddCus.BackColor = System.Drawing.Color.White;
            this.btnAddCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCus.Location = new System.Drawing.Point(175, 478);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(108, 43);
            this.btnAddCus.TabIndex = 4;
            this.btnAddCus.Text = "Add New Customer";
            this.btnAddCus.UseVisualStyleBackColor = false;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // grbFilters
            // 
            this.grbFilters.Controls.Add(this.optCusphonenum);
            this.grbFilters.Controls.Add(this.optCustype);
            this.grbFilters.Controls.Add(this.optCusadd);
            this.grbFilters.Controls.Add(this.optCusname);
            this.grbFilters.Controls.Add(this.optCusid);
            this.grbFilters.Location = new System.Drawing.Point(42, 179);
            this.grbFilters.Name = "grbFilters";
            this.grbFilters.Size = new System.Drawing.Size(537, 87);
            this.grbFilters.TabIndex = 5;
            this.grbFilters.TabStop = false;
            this.grbFilters.Text = "Fiters";
            // 
            // optCusphonenum
            // 
            this.optCusphonenum.AutoSize = true;
            this.optCusphonenum.Location = new System.Drawing.Point(385, 37);
            this.optCusphonenum.Name = "optCusphonenum";
            this.optCusphonenum.Size = new System.Drawing.Size(151, 21);
            this.optCusphonenum.TabIndex = 9;
            this.optCusphonenum.TabStop = true;
            this.optCusphonenum.Text = "Telephone Number";
            this.optCusphonenum.UseVisualStyleBackColor = true;
            // 
            // optCustype
            // 
            this.optCustype.AutoSize = true;
            this.optCustype.Location = new System.Drawing.Point(218, 37);
            this.optCustype.Name = "optCustype";
            this.optCustype.Size = new System.Drawing.Size(61, 21);
            this.optCustype.TabIndex = 2;
            this.optCustype.TabStop = true;
            this.optCustype.Text = "Type";
            this.optCustype.UseVisualStyleBackColor = true;
            // 
            // optCusadd
            // 
            this.optCusadd.AutoSize = true;
            this.optCusadd.Location = new System.Drawing.Point(298, 37);
            this.optCusadd.Name = "optCusadd";
            this.optCusadd.Size = new System.Drawing.Size(81, 21);
            this.optCusadd.TabIndex = 3;
            this.optCusadd.TabStop = true;
            this.optCusadd.Text = "Address";
            this.optCusadd.UseVisualStyleBackColor = true;
            // 
            // optCusname
            // 
            this.optCusname.AutoSize = true;
            this.optCusname.Location = new System.Drawing.Point(133, 37);
            this.optCusname.Name = "optCusname";
            this.optCusname.Size = new System.Drawing.Size(66, 21);
            this.optCusname.TabIndex = 1;
            this.optCusname.TabStop = true;
            this.optCusname.Text = "Name";
            this.optCusname.UseVisualStyleBackColor = true;
            // 
            // optCusid
            // 
            this.optCusid.AutoSize = true;
            this.optCusid.Location = new System.Drawing.Point(9, 37);
            this.optCusid.Name = "optCusid";
            this.optCusid.Size = new System.Drawing.Size(106, 21);
            this.optCusid.TabIndex = 0;
            this.optCusid.TabStop = true;
            this.optCusid.Text = "Customer ID";
            this.optCusid.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusID,
            this.CusName,
            this.CusType,
            this.CusAdd,
            this.CusPhonenum});
            this.dataGridView1.Location = new System.Drawing.Point(42, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 170);
            this.dataGridView1.TabIndex = 6;
            // 
            // CusID
            // 
            this.CusID.HeaderText = "ID";
            this.CusID.Name = "CusID";
            this.CusID.Width = 50;
            // 
            // CusName
            // 
            this.CusName.HeaderText = "Name";
            this.CusName.Name = "CusName";
            this.CusName.Width = 150;
            // 
            // CusType
            // 
            this.CusType.HeaderText = "Type";
            this.CusType.Name = "CusType";
            this.CusType.Width = 50;
            // 
            // CusAdd
            // 
            this.CusAdd.HeaderText = "Address";
            this.CusAdd.Name = "CusAdd";
            this.CusAdd.Width = 120;
            // 
            // CusPhonenum
            // 
            this.CusPhonenum.HeaderText = "Telephone Number";
            this.CusPhonenum.Name = "CusPhonenum";
            this.CusPhonenum.Width = 124;
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBanner.BackgroundImage")));
            this.pnlBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBanner.Controls.Add(this.btnLogout);
            this.pnlBanner.Controls.Add(this.btnGoback);
            this.pnlBanner.Controls.Add(this.splButton);
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(619, 100);
            this.pnlBanner.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(23, 58);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 29);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.Color.White;
            this.btnGoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnGoback.Location = new System.Drawing.Point(23, 10);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(82, 29);
            this.btnGoback.TabIndex = 1;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // splButton
            // 
            this.splButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splButton.Location = new System.Drawing.Point(0, 0);
            this.splButton.Name = "splButton";
            this.splButton.Size = new System.Drawing.Size(131, 96);
            this.splButton.TabIndex = 0;
            this.splButton.TabStop = false;
            // 
            // frmMancusacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(619, 533);
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbFilters);
            this.Controls.Add(this.btnAddCus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtKeyword);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "frmMancusacc";
            this.Text = "Manage Customer Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMancusacc_FormClosing);
            this.grbFilters.ResumeLayout(false);
            this.grbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlBanner.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.GroupBox grbFilters;
        private System.Windows.Forms.RadioButton optCustype;
        private System.Windows.Forms.RadioButton optCusname;
        private System.Windows.Forms.RadioButton optCusid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Splitter splButton;
        private System.Windows.Forms.RadioButton optCusadd;
        private System.Windows.Forms.RadioButton optCusphonenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusPhonenum;
    }
}