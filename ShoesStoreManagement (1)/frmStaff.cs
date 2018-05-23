using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNeword_Click(object sender, EventArgs e)
        {
            frmNeword newform = new frmNeword();
            newform.Show();
            this.Hide();
        }

        private void btnSearchprod_Click(object sender, EventArgs e)
        {
            frmSearchprd newform = new frmSearchprd();
            this.Hide();
            newform.Show();
        }

        private void btnMancusacc_Click(object sender, EventArgs e)
        {
            frmMancusacc newform = new frmMancusacc();
            this.Hide();
            newform.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin newform = new frmLogin();
            newform.Show();
            this.Hide();
        }
    }
}
