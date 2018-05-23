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
    public partial class frmNeword : Form
    {
        public frmNeword()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmNeword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            frmStaff newform = new frmStaff();
            this.Hide();
            newform.Show();
        }
    }
}
