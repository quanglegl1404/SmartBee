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
    public partial class frmMansto : Form
    {
        public frmMansto()
        {
            InitializeComponent();
        }

        private void frmMansto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            frmAdmin newform = new frmAdmin();
            this.Hide();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin newform = new frmLogin();
            this.Hide();
            newform.Show();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            frmLogin.OpenSqlConnection();
            frmLogin.ds = new DataSet();
            SqlCommand cmd = new SqlCommand("Select *from SANPHAM", frmLogin.conn);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(frmLogin.ds, "SANPHAM");
            grdProductInfo.DataSource = frmLogin.ds;
            grdProductInfo.DataMember = "SANPHAM";
            for (int i = 0; i < grdProductInfo.Rows.Count - 1; i++)
            {
                if (grdProductInfo.Rows[i].Cells["SOLUONG"].Value.ToString() == "0")
                    grdProductInfo.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
            frmLogin.conn.Close();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            frmLogin.OpenSqlConnection();
            SqlCommand cmd = new SqlCommand($"Insert into SANPHAM values('{grdProductInfo.CurrentRow.Cells["IDSP"].Value.ToString()}','{grdProductInfo.CurrentRow.Cells["TENSP"].Value.ToString()}','{grdProductInfo.CurrentRow.Cells["DONGIA"].Value.ToString()}','{grdProductInfo.CurrentRow.Cells["SOLUONG"].Value.ToString()}','{grdProductInfo.CurrentRow.Cells["IDLOAISP"].Value.ToString()}')", frmLogin.conn);
            cmd.ExecuteNonQuery();
            frmLogin.conn.Close();
            MessageBox.Show("Insert");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            int result = 0;
            string s;
            result = Convert.ToInt16(MessageBox.Show("Are you want to delete this account?", "Deleting Staff Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (result == 1)
            {
                s = "delete from SANPHAM where IDSP='" + grdProductInfo.CurrentRow.Cells["IDSP"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(s, frmLogin.conn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(frmLogin.ds, "SANPHAM");
                grdProductInfo.DataSource = frmLogin.ds;
            }
            if (this.grdProductInfo.SelectedRows.Count > 0)
            {
                grdProductInfo.Rows.RemoveAt(this.grdProductInfo.SelectedRows[0].Index);
                MessageBox.Show("Deleted");
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            frmLogin.OpenSqlConnection();
            SqlCommand cmd = new SqlCommand($"Update SANPHAM set TENSP='{grdProductInfo.CurrentRow.Cells["TENSP"].Value.ToString()}',SOLUONG='{grdProductInfo.CurrentRow.Cells["SOLUONG"].Value.ToString()}',IDLOAISP='{grdProductInfo.CurrentRow.Cells["IDLOAISP"].Value.ToString()}' where IDSP='{grdProductInfo.CurrentRow.Cells["IDSP"].Value.ToString()}'", frmLogin.conn);
            cmd.ExecuteNonQuery();
            frmLogin.conn.Close();
            MessageBox.Show("Updated");
        }
    }
}
