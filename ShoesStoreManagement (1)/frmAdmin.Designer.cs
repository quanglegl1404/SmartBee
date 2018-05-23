namespace ShoesStoreManagement
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManstaf = new System.Windows.Forms.Button();
            this.btnMansto = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 95);
            this.panel1.TabIndex = 0;
            // 
            // btnManstaf
            // 
            this.btnManstaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManstaf.Location = new System.Drawing.Point(28, 129);
            this.btnManstaf.Name = "btnManstaf";
            this.btnManstaf.Size = new System.Drawing.Size(84, 49);
            this.btnManstaf.TabIndex = 1;
            this.btnManstaf.Text = "Manage Staff";
            this.btnManstaf.UseVisualStyleBackColor = true;
            this.btnManstaf.Click += new System.EventHandler(this.btnManstaf_Click);
            // 
            // btnMansto
            // 
            this.btnMansto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMansto.Location = new System.Drawing.Point(168, 129);
            this.btnMansto.Name = "btnMansto";
            this.btnMansto.Size = new System.Drawing.Size(84, 49);
            this.btnMansto.TabIndex = 2;
            this.btnMansto.Text = "Manage Storage";
            this.btnMansto.UseVisualStyleBackColor = true;
            this.btnMansto.Click += new System.EventHandler(this.btnMansto_Click);
            // 
            // btnReport
            // 
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(318, 129);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(84, 49);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(466, 129);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 49);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(584, 227);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnMansto);
            this.Controls.Add(this.btnManstaf);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManstaf;
        private System.Windows.Forms.Button btnMansto;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnLogout;
    }
}