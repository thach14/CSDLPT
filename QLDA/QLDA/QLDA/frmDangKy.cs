using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
	public partial class frmDangKy : Form
	{
		private string Role = WorkingContext.Instance.CurrentLoginInfo.RoleName;
		private int CN = WorkingContext.Instance.CurrentBranchID;
		public frmDangKy()
		{
			InitializeComponent();
		}
		private void create(string SqlString)
		{
			var connectionName = string.Format("CN{0}", CN);
			var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
			connectionString = string.Format(connectionString, "sa", "sa");
			var connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			var command = new SqlCommand(SqlString, connection);
			command.Connection = connection;
			command.Connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}

        private void btnOK_Click(object sender, EventArgs e)
        {
			if (txtPassword.Text == txtrePass.Text && txtUser.Text != "")
			{
				string SqlString = String.Format("exec sp_TaoTaiKhoan '{0}', '{1}', '{2}', '{3}'", txtUser.Text, txtPassword.Text, cbbCMND.Text, cbbRole.Text);
				create(SqlString);
				MessageBox.Show("Tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Dispose();
			}
			else

				MessageBox.Show("Kiểm tra lại thông tin đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
		private void cmnd()
		{
			var connectionName = string.Format("CN{0}", CN);
			var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
			connectionString = string.Format(connectionString, "sa", "sa");
			var connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			var command = new SqlCommand("exec dsNVCN", connection);
			command.Connection = connection;
			command.Connection.Open();
			using (SqlDataReader sqlReader = command.ExecuteReader())
			{
				while (sqlReader.Read())
				{
					cbbCMND.Items.Add(sqlReader["CMND"].ToString());
				}
				connection.Close();
			}
		}
		private void frmDangKy_Load(object sender, EventArgs e)
        {
			if(Role == "ChuTich")
            {
				cbbRole.Items.Add("QuanLyCN");
            }
			cmnd();
			cbbRole.SelectedIndex = 0;
			cbbCMND.SelectedIndex = 0;
        }
    }
}
