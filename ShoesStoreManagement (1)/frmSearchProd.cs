using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShoesStoreManagement
{
    public partial class frmSearchprd : Form
    {
        public frmSearchprd()
        {
            InitializeComponent();
        }

        private void frmSearchprd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (optBrand.Checked)
            {
                frmLogin.OpenSqlConnection();
                SqlCommand cmd = new SqlCommand("Select *from SANPHAM where TENSP like '%" + txtKeyword.Text.ToString() + "%'", frmLogin.conn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                frmLogin.ds.Clear();
                adt.Fill(frmLogin.ds, "SANPHAM");
                frmLogin.conn.Close();
                grdShoesInfo.DataSource = frmLogin.ds;
                grdShoesInfo.DataMember = "SANPHAM";
            }
            else if (optPrice.Checked)
            {
                frmLogin.OpenSqlConnection();
                SqlCommand cmd = new SqlCommand("Select *from SANPHAM where DONGIA = '" + txtKeyword.Text.ToString() + "'", frmLogin.conn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                frmLogin.ds.Clear();
                adt.Fill(frmLogin.ds, "SANPHAM");
                frmLogin.conn.Close();
                grdShoesInfo.DataSource = frmLogin.ds;
                grdShoesInfo.DataMember = "SANPHAM";
            }
            else if (optBrand.Checked)
            {
                frmLogin.OpenSqlConnection();
                SqlCommand cmd = new SqlCommand("Select *from SANPHAM where IDLOAISP = '" + txtKeyword.Text.ToString() + "'", frmLogin.conn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                frmLogin.ds.Clear();
                adt.Fill(frmLogin.ds, "SANPHAM");
                frmLogin.conn.Close();
                grdShoesInfo.DataSource = frmLogin.ds;
                grdShoesInfo.DataMember = "SANPHAM";
            }
            else
            {
                MessageBox.Show("You musst choose one");
            }
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
    }
}
