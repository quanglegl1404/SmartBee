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
    public partial class frmMancusacc : Form
    {
        public frmMancusacc()
        {
            InitializeComponent();
        }

        private void frmMancusacc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            frmStaff newform = new frmStaff();
            this.Hide();
            newform.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin newform = new frmLogin();
            this.Hide();
            newform.Show();
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            frmAddnewcus newform = new frmAddnewcus();
            this.Hide();
            newform.Show();
        }
    }
}
