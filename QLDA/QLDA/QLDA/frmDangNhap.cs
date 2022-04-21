using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
	public partial class frmDangNhap : Form
	{
		public frmDangNhap()
		{
			InitializeComponent();
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			if (txtPassword.PasswordChar == '*')
				txtPassword.PasswordChar = '\0';
			else
				txtPassword.PasswordChar = '*';
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			var kq = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (kq == DialogResult.Yes)
				Application.Exit();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string CN, login, password;
			if(txtUser.Text == ""|| txtPassword.Text=="")
            {
				label3.Text = "Nhập thông tin đăng nhập!";
				return;
            }
			if (cbbChiNhanh.Text == cbbChiNhanh.Items[0].ToString())
			{
				label3.Text = "Chọn chi nhánh!";
				return;
			}
			else
			{
				CN = cbbChiNhanh.Text;
				int IDCN = cbbChiNhanh.SelectedIndex;
				login = txtUser.Text;
				password = txtPassword.Text;
				WorkingContext.Instance.CurrentBranch = CN;
				WorkingContext.Instance.CurrentBranchID = IDCN;
				WorkingContext.Instance.CurrentLoginName = login;

				var connectionName = string.Format("CN{0}", IDCN);
				var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

				
				connectionString = string.Format(connectionString, login, password);
				WorkingContext.Instance.Inititalize(connectionString);
				try
				{
					var dbcontext = WorkingContext.Instance._dbContext;
					var loginInfo = dbcontext.Database.SqlQuery<LoginInfo>("exec sp_GetLoginInfo @p0", login).FirstOrDefault();				
					WorkingContext.Instance.CurrentLoginInfo = loginInfo;
					frmMain main = new frmMain();
					main.ShowDialog();
					this.Dispose();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Sai thông tin đăng nhập \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
				}
			}
		}

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
			cbbChiNhanh.Text = cbbChiNhanh.Items[0].ToString();
		}
    }
}
