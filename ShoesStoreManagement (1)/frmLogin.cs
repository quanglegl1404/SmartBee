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
    public partial class frmLogin : Form
    {
        public static SqlConnection conn = new SqlConnection();
        static private frmLogin a = new frmLogin();
        public static DataSet ds;
        public static string k;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenSqlConnection();
            string query = "Select TENDANGNHAP from NHANVIEN where TENDANGNHAP='" + txtUsername.Text + "'and MATKHAU='" + txtPassword.Text + "'and IDCHUCVU='QL'";
            string query1 = "Select TENDANGNHAP from NHANVIEN where TENDANGNHAP='" + txtUsername.Text + "' and MATKHAU='" + txtPassword.Text  +"'and IDCHUCVU='NV'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            var verify = cmd.ExecuteScalar();
            var verify1 = cmd1.ExecuteScalar();
            conn.Close();
            if (verify != null)
            {
                frmAdmin newform = new frmAdmin();
                this.Hide();
                newform.Show();
            }
            else if (verify1 != null)
            {
                frmStaff newfrm = new frmStaff();
                this.Hide();
                newfrm.Show();
            }
            else
            {
                MessageBox.Show("Log in failed!", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();

        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }
        public static void OpenSqlConnection()
        {
            conn.ConnectionString = "Data Source=DESKTOP-K5UACHN;Initial Catalog=ShoeStore;" + "Integrated Security=true;";
            conn.Open();
        }
    }
}
