namespace ShoesStoreManagement
{
    partial class frmMansto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMansto));
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.splButton = new System.Windows.Forms.Splitter();
            this.grbMansto = new System.Windows.Forms.GroupBox();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.grdProductInfo = new System.Windows.Forms.DataGridView();
            this.pnlBanner.SuspendLayout();
            this.grbMansto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBanner.BackgroundImage")));
            this.pnlBanner.Controls.Add(this.button2);
            this.pnlBanner.Controls.Add(this.btnGoback);
            this.pnlBanner.Controls.Add(this.splButton);
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(787, 91);
            this.pnlBanner.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(23, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Log out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoback.Location = new System.Drawing.Point(25, 12);
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
            this.splButton.Size = new System.Drawing.Size(129, 91);
            this.splButton.TabIndex = 0;
            this.splButton.TabStop = false;
            // 
            // grbMansto
            // 
            this.grbMansto.Controls.Add(this.btnUpd);
            this.grbMansto.Controls.Add(this.btnDel);
            this.grbMansto.Controls.Add(this.btnIns);
            this.grbMansto.Controls.Add(this.btnPreview);
            this.grbMansto.Location = new System.Drawing.Point(18, 127);
            this.grbMansto.Name = "grbMansto";
            this.grbMansto.Size = new System.Drawing.Size(167, 269);
            this.grbMansto.TabIndex = 1;
            this.grbMansto.TabStop = false;
            this.grbMansto.Text = "Manage Storage";
            // 
            // btnUpd
            // 
            this.btnUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.Location = new System.Drawing.Point(27, 213);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(95, 32);
            this.btnUpd.TabIndex = 5;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(27, 157);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(95, 32);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnIns
            // 
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.Location = new System.Drawing.Point(27, 99);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(95, 32);
            this.btnIns.TabIndex = 3;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(27, 42);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(95, 32);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // grdProductInfo
            // 
            this.grdProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductInfo.Location = new System.Drawing.Point(210, 127);
            this.grdProductInfo.Name = "grdProductInfo";
            this.grdProductInfo.RowTemplate.Height = 24;
            this.grdProductInfo.Size = new System.Drawing.Size(567, 269);
            this.grdProductInfo.TabIndex = 2;
            // 
            // frmMansto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(789, 446);
            this.Controls.Add(this.grdProductInfo);
            this.Controls.Add(this.grbMansto);
            this.Controls.Add(this.pnlBanner);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "frmMansto";
            this.Text = "Manage Storage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMansto_FormClosing);
            this.pnlBanner.ResumeLayout(false);
            this.grbMansto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.GroupBox grbMansto;
        private System.Windows.Forms.DataGridView grdProductInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Splitter splButton;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnPreview;
    }
}