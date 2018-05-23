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
    public partial class frmInsStaffInfo : Form
    {
        public frmInsStaffInfo()
        {
            InitializeComponent();
        }

        private void frmInsStaffInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmManstaf newform = new frmManstaf();
            this.Hide();
            newform.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin newform = new frmLogin();
            this.Hide();
            newform.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmLogin.OpenSqlConnection();
            SqlCommand cmd = new SqlCommand($"Insert into NHANVIEN(TENDANGNHAP,HOTEN,MATKHAU,NGAYSINH ,DIACHI,LUONG,IDCHUCVU,SDT) values('{txtUserName.Text.ToString()}','{txtName.Text.ToString()}','{txtPassword.Text.ToString()}','{txtDOB.Text.ToString()}','{txtAddress.Text.ToString()}','{txtSalary.Text.ToString()}','NV','{txtPhoneNum.Text.ToString()}')", frmLogin.conn);
            cmd.ExecuteNonQuery();
            frmLogin.conn.Close();
            MessageBox.Show("Inserted ");
        }
    }
}
