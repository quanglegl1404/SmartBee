namespace ShoesStoreManagement
{
    partial class frmManstaf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManstaf));
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.splButton = new System.Windows.Forms.Splitter();
            this.grbManstaf = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.grdStaffInfo = new System.Windows.Forms.DataGridView();
            this.pnlBanner.SuspendLayout();
            this.grbManstaf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStaffInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBanner.BackgroundImage")));
            this.pnlBanner.Controls.Add(this.btnLogout);
            this.pnlBanner.Controls.Add(this.btnGoback);
            this.pnlBanner.Controls.Add(this.splButton);
            this.pnlBanner.Location = new System.Drawing.Point(-1, 2);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(920, 103);
            this.pnlBanner.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(22, 58);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 29);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoback.Location = new System.Drawing.Point(22, 10);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(82, 29);
            this.btnGoback.TabIndex = 1;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = true;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // splButton
            // 
            this.splButton.Location = new System.Drawing.Point(0, 0);
            this.splButton.Name = "splButton";
            this.splButton.Size = new System.Drawing.Size(128, 103);
            this.splButton.TabIndex = 0;
            this.splButton.TabStop = false;
            // 
            // grbManstaf
            // 
            this.grbManstaf.Controls.Add(this.btnUpdate);
            this.grbManstaf.Controls.Add(this.btnDel);
            this.grbManstaf.Controls.Add(this.btnIns);
            this.grbManstaf.Controls.Add(this.btnPreview);
            this.grbManstaf.Location = new System.Drawing.Point(21, 129);
            this.grbManstaf.Name = "grbManstaf";
            this.grbManstaf.Size = new System.Drawing.Size(167, 269);
            this.grbManstaf.TabIndex = 1;
            this.grbManstaf.TabStop = false;
            this.grbManstaf.Text = "Manage Staff";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(33, 211);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(33, 154);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(95, 32);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnIns
            // 
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.Location = new System.Drawing.Point(33, 93);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(95, 32);
            this.btnIns.TabIndex = 1;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(33, 37);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(95, 32);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // grdStaffInfo
            // 
            this.grdStaffInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStaffInfo.Location = new System.Drawing.Point(206, 129);
            this.grdStaffInfo.Name = "grdStaffInfo";
            this.grdStaffInfo.RowTemplate.Height = 24;
            this.grdStaffInfo.Size = new System.Drawing.Size(701, 269);
            this.grdStaffInfo.TabIndex = 2;
            // 
            // frmManstaf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(919, 472);
            this.Controls.Add(this.grdStaffInfo);
            this.Controls.Add(this.grbManstaf);
            this.Controls.Add(this.pnlBanner);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "frmManstaf";
            this.Text = "Manage Staff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManstaf_FormClosing);
            this.pnlBanner.ResumeLayout(false);
            this.grbManstaf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStaffInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Splitter splButton;
        private System.Windows.Forms.GroupBox grbManstaf;
        private System.Windows.Forms.DataGridView grdStaffInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnPreview;
    }
}