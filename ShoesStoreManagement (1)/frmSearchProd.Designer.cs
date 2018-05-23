namespace ShoesStoreManagement
{
    partial class frmSearchprd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchprd));
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdShoesInfo = new System.Windows.Forms.DataGridView();
            this.picShoes = new System.Windows.Forms.PictureBox();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.splButton = new System.Windows.Forms.Splitter();
            this.grbFilters = new System.Windows.Forms.GroupBox();
            this.optBrand = new System.Windows.Forms.RadioButton();
            this.optName = new System.Windows.Forms.RadioButton();
            this.optPrice = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdShoesInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShoes)).BeginInit();
            this.pnlBanner.SuspendLayout();
            this.grbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(145, 102);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(254, 27);
            this.txtKeyword.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(438, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdShoesInfo
            // 
            this.grdShoesInfo.AllowUserToAddRows = false;
            this.grdShoesInfo.AllowUserToDeleteRows = false;
            this.grdShoesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShoesInfo.Location = new System.Drawing.Point(127, 199);
            this.grdShoesInfo.Name = "grdShoesInfo";
            this.grdShoesInfo.ReadOnly = true;
            this.grdShoesInfo.RowTemplate.Height = 24;
            this.grdShoesInfo.Size = new System.Drawing.Size(484, 202);
            this.grdShoesInfo.TabIndex = 3;
            // 
            // picShoes
            // 
            this.picShoes.Location = new System.Drawing.Point(9, 199);
            this.picShoes.Name = "picShoes";
            this.picShoes.Size = new System.Drawing.Size(112, 102);
            this.picShoes.TabIndex = 4;
            this.picShoes.TabStop = false;
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBanner.BackgroundImage")));
            this.pnlBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBanner.Controls.Add(this.btnLogout);
            this.pnlBanner.Controls.Add(this.btnGoback);
            this.pnlBanner.Controls.Add(this.splButton);
            this.pnlBanner.Location = new System.Drawing.Point(-3, -3);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(627, 87);
            this.pnlBanner.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(24, 47);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 29);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.Color.White;
            this.btnGoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoback.Location = new System.Drawing.Point(24, 10);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(82, 29);
            this.btnGoback.TabIndex = 2;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // splButton
            // 
            this.splButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splButton.Location = new System.Drawing.Point(0, 0);
            this.splButton.Name = "splButton";
            this.splButton.Size = new System.Drawing.Size(134, 83);
            this.splButton.TabIndex = 0;
            this.splButton.TabStop = false;
            // 
            // grbFilters
            // 
            this.grbFilters.Controls.Add(this.optPrice);
            this.grbFilters.Controls.Add(this.optName);
            this.grbFilters.Controls.Add(this.optBrand);
            this.grbFilters.Location = new System.Drawing.Point(91, 137);
            this.grbFilters.Name = "grbFilters";
            this.grbFilters.Size = new System.Drawing.Size(393, 44);
            this.grbFilters.TabIndex = 6;
            this.grbFilters.TabStop = false;
            this.grbFilters.Text = "Filters";
            // 
            // optBrand
            // 
            this.optBrand.AutoSize = true;
            this.optBrand.Location = new System.Drawing.Point(54, 17);
            this.optBrand.Name = "optBrand";
            this.optBrand.Size = new System.Drawing.Size(67, 21);
            this.optBrand.TabIndex = 0;
            this.optBrand.TabStop = true;
            this.optBrand.Text = "Brand";
            this.optBrand.UseVisualStyleBackColor = true;
            // 
            // optName
            // 
            this.optName.AutoSize = true;
            this.optName.Location = new System.Drawing.Point(166, 17);
            this.optName.Name = "optName";
            this.optName.Size = new System.Drawing.Size(66, 21);
            this.optName.TabIndex = 1;
            this.optName.TabStop = true;
            this.optName.Text = "Name";
            this.optName.UseVisualStyleBackColor = true;
            // 
            // optPrice
            // 
            this.optPrice.AutoSize = true;
            this.optPrice.Location = new System.Drawing.Point(286, 17);
            this.optPrice.Name = "optPrice";
            this.optPrice.Size = new System.Drawing.Size(61, 21);
            this.optPrice.TabIndex = 2;
            this.optPrice.TabStop = true;
            this.optPrice.Text = "Price";
            this.optPrice.UseVisualStyleBackColor = true;
            // 
            // frmSearchprd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(623, 413);
            this.Controls.Add(this.grbFilters);
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.picShoes);
            this.Controls.Add(this.grdShoesInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "frmSearchprd";
            this.Text = "Search Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchprd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdShoesInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShoes)).EndInit();
            this.pnlBanner.ResumeLayout(false);
            this.grbFilters.ResumeLayout(false);
            this.grbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdShoesInfo;
        private System.Windows.Forms.PictureBox picShoes;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Splitter splButton;
        private System.Windows.Forms.GroupBox grbFilters;
        private System.Windows.Forms.RadioButton optPrice;
        private System.Windows.Forms.RadioButton optName;
        private System.Windows.Forms.RadioButton optBrand;
    }
}