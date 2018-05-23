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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin newform = new frmLogin();
            this.Hide();
            newform.Show();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnManstaf_Click(object sender, EventArgs e)
        {
            frmManstaf newform = new frmManstaf();
            this.Hide();
            newform.Show();
        }

        private void btnMansto_Click(object sender, EventArgs e)
        {
            frmMansto newform = new frmMansto();
            this.Hide();
            newform.Show();
        }
    }
}
