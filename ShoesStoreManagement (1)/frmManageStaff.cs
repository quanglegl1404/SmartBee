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
    public partial class frmManstaf : Form
    {
        public frmManstaf()
        {
            InitializeComponent();
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            frmAdmin newform = new frmAdmin();
            this.Hide();
            newform.Show();
        }

        private void frmManstaf_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin newform = new frmLogin();
            this.Hide();
            newform.Show();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            frmLogin.OpenSqlConnection();
            frmLogin.ds = new DataSet();
            SqlCommand cmd = new SqlCommand("Select IDNV,HOTEN,NGAYSINH,DIACHI,LUONG,IDCHUCVU,SDT from NHANVIEN", frmLogin.conn);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(frmLogin.ds, "NHANVIEN");
            grdStaffInfo.DataSource = frmLogin.ds;
            grdStaffInfo.DataMember = "NHANVIEN";
            frmLogin.conn.Close();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            frmInsStaffInfo newform = new frmInsStaffInfo();
            this.Hide();
            newform.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmLogin.OpenSqlConnection();
            SqlCommand cmd = new SqlCommand($"Update NHANVIEN set TENDANGNHAP='{grdStaffInfo.CurrentRow.Cells["TENDANGNHAP"].Value.ToString()}',HOTEN='{grdStaffInfo.CurrentRow.Cells["HOTEN"].Value.ToString()}',MATKHAU='{grdStaffInfo.CurrentRow.Cells["MATKHAU"].Value.ToString()}',NGAYSINH='{grdStaffInfo.CurrentRow.Cells["NGAYSINH"].Value.ToString()}',DIACHI='{grdStaffInfo.CurrentRow.Cells["DIACHI"].Value.ToString()}',LUONG ='{grdStaffInfo.CurrentRow.Cells["LUONG"].Value.ToString()}',IDCHUCVU='{grdStaffInfo.CurrentRow.Cells["IDCHUCVU"].Value.ToString()}',SDT='{grdStaffInfo.CurrentRow.Cells["SDT"].Value.ToString()}' where IDNV='{grdStaffInfo.CurrentRow.Cells["IDNV"].Value.ToString()}'", frmLogin.conn);
            cmd.ExecuteNonQuery();
            frmLogin.conn.Close();
            MessageBox.Show("Updated");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int result = 0;
            string s;
            result = Convert.ToInt16(MessageBox.Show("Are you want to delete this account?", "Deleting Staff Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (result == 1)
            {
                s = "delete from NHANVIEN where IDNV='" + grdStaffInfo.CurrentRow.Cells["IDNV"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(s, frmLogin.conn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(frmLogin.ds, "NHANVIEN");
                grdStaffInfo.DataSource = frmLogin.ds;
                grdStaffInfo.DataMember = "NHANVIEN";
            }
            if (this.grdStaffInfo.SelectedRows.Count > 0)
            {
                grdStaffInfo.Rows.RemoveAt(this.grdStaffInfo.SelectedRows[0].Index);
                MessageBox.Show("Deleted");
            }
        }
    }
}
