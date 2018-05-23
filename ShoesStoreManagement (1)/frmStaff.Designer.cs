namespace ShoesStoreManagement
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.btnNeword = new System.Windows.Forms.Button();
            this.btnSearchprod = new System.Windows.Forms.Button();
            this.btnMancusacc = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNeword
            // 
            this.btnNeword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNeword.Location = new System.Drawing.Point(53, 168);
            this.btnNeword.Name = "btnNeword";
            this.btnNeword.Size = new System.Drawing.Size(195, 70);
            this.btnNeword.TabIndex = 0;
            this.btnNeword.Text = "New Order";
            this.btnNeword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNeword.UseVisualStyleBackColor = true;
            this.btnNeword.Click += new System.EventHandler(this.btnNeword_Click);
            // 
            // btnSearchprod
            // 
            this.btnSearchprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchprod.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchprod.Location = new System.Drawing.Point(302, 168);
            this.btnSearchprod.Name = "btnSearchprod";
            this.btnSearchprod.Size = new System.Drawing.Size(195, 70);
            this.btnSearchprod.TabIndex = 1;
            this.btnSearchprod.Text = "Search Product";
            this.btnSearchprod.UseVisualStyleBackColor = true;
            this.btnSearchprod.Click += new System.EventHandler(this.btnSearchprod_Click);
            // 
            // btnMancusacc
            // 
            this.btnMancusacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMancusacc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMancusacc.Location = new System.Drawing.Point(53, 295);
            this.btnMancusacc.Name = "btnMancusacc";
            this.btnMancusacc.Size = new System.Drawing.Size(195, 70);
            this.btnMancusacc.TabIndex = 2;
            this.btnMancusacc.Text = "Manage Customer Account";
            this.btnMancusacc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMancusacc.UseVisualStyleBackColor = true;
            this.btnMancusacc.Click += new System.EventHandler(this.btnMancusacc_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.Location = new System.Drawing.Point(302, 295);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(195, 70);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBanner.BackgroundImage")));
            this.pnlBanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBanner.Location = new System.Drawing.Point(1, 1);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(561, 115);
            this.pnlBanner.TabIndex = 4;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(564, 406);
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMancusacc);
            this.Controls.Add(this.btnSearchprod);
            this.Controls.Add(this.btnNeword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Name = "frmStaff";
            this.Text = "Staff ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStaff_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNeword;
        private System.Windows.Forms.Button btnMancusacc;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Button btnSearchprod;
    }
}