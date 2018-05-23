namespace ShoesStoreManagement
{
    partial class frmAddnewcus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddnewcus));
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPhonenum = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.splButton = new System.Windows.Forms.Splitter();
            this.grbCusinfo = new System.Windows.Forms.GroupBox();
            this.btnAddnewcus = new System.Windows.Forms.Button();
            this.pnlBanner.SuspendLayout();
            this.grbCusinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 68);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(254, 33);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 17);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type: ";
            // 
            // lblPhonenum
            // 
            this.lblPhonenum.AutoSize = true;
            this.lblPhonenum.Location = new System.Drawing.Point(254, 71);
            this.lblPhonenum.Name = "lblPhonenum";
            this.lblPhonenum.Size = new System.Drawing.Size(107, 17);
            this.lblPhonenum.TabIndex = 3;
            this.lblPhonenum.Text = "Phone Number:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(364, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(364, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 22);
            this.textBox4.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 22);
            this.txtName.TabIndex = 9;
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBanner.BackgroundImage")));
            this.pnlBanner.Controls.Add(this.btnLogout);
            this.pnlBanner.Controls.Add(this.btnGoback);
            this.pnlBanner.Controls.Add(this.splButton);
            this.pnlBanner.Location = new System.Drawing.Point(2, 1);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(608, 89);
            this.pnlBanner.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(23, 49);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 29);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGoback.Location = new System.Drawing.Point(21, 10);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(82, 29);
            this.btnGoback.TabIndex = 1;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // splButton
            // 
            this.splButton.Location = new System.Drawing.Point(0, 0);
            this.splButton.Name = "splButton";
            this.splButton.Size = new System.Drawing.Size(121, 89);
            this.splButton.TabIndex = 0;
            this.splButton.TabStop = false;
            // 
            // grbCusinfo
            // 
            this.grbCusinfo.Controls.Add(this.lblName);
            this.grbCusinfo.Controls.Add(this.lblAddress);
            this.grbCusinfo.Controls.Add(this.textBox3);
            this.grbCusinfo.Controls.Add(this.textBox4);
            this.grbCusinfo.Controls.Add(this.textBox2);
            this.grbCusinfo.Controls.Add(this.txtName);
            this.grbCusinfo.Controls.Add(this.lblPhonenum);
            this.grbCusinfo.Controls.Add(this.lblType);
            this.grbCusinfo.Location = new System.Drawing.Point(25, 120);
            this.grbCusinfo.Name = "grbCusinfo";
            this.grbCusinfo.Size = new System.Drawing.Size(534, 107);
            this.grbCusinfo.TabIndex = 11;
            this.grbCusinfo.TabStop = false;
            this.grbCusinfo.Text = "Customer Info";
            // 
            // btnAddnewcus
            // 
            this.btnAddnewcus.BackColor = System.Drawing.Color.White;
            this.btnAddnewcus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewcus.Location = new System.Drawing.Point(233, 246);
            this.btnAddnewcus.Name = "btnAddnewcus";
            this.btnAddnewcus.Size = new System.Drawing.Size(108, 50);
            this.btnAddnewcus.TabIndex = 3;
            this.btnAddnewcus.Text = "Add New Customer";
            this.btnAddnewcus.UseVisualStyleBackColor = false;
            // 
            // frmAddnewcus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 322);
            this.Controls.Add(this.btnAddnewcus);
            this.Controls.Add(this.grbCusinfo);
            this.Controls.Add(this.pnlBanner);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "frmAddnewcus";
            this.Text = "Add New Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddnewcus_FormClosing);
            this.pnlBanner.ResumeLayout(false);
            this.grbCusinfo.ResumeLayout(false);
            this.grbCusinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPhonenum;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.GroupBox grbCusinfo;
        private System.Windows.Forms.Splitter splButton;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Button btnAddnewcus;
    }
}