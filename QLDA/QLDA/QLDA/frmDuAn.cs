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
	public partial class frmDuAn : Form
	{
		private string action;
		public frmDuAn(string action)
		{
			this.action = action;
			InitializeComponent();
		}
		private void connect(int CN, string SqlString)
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
		private void frmDuAn_Load(object sender, EventArgs e)
        {
			if (WorkingContext.Instance.CurrentLoginInfo.RoleName == "ChuTich" && action == "Add")
				cbbChiNhanh.Enabled = true;
			cbbChiNhanh.Text = WorkingContext.Instance.CurrentBranch;
		}

        private void btnLuu_Click(object sender, EventArgs e)
        {
			if (action == "Add")
			{
				string SqlString = String.Format("exec themDA {0},N'{1}','{2}','{3}','{4}'", cbbChiNhanh.SelectedIndex + 1, txtTenDA.Text, dtpNgayBD.Text, mtbPhi.Text, mtpThoiHan.Text);
				connect(cbbChiNhanh.SelectedIndex + 1, SqlString);
			}
			else
			{
				string SqlString = String.Format("exec suaDA {0},N'{1}','{2}','{3}','{4}'", action, txtTenDA.Text, dtpNgayBD.Text, mtbPhi.Text, mtpThoiHan.Text);
				connect(cbbChiNhanh.SelectedIndex + 1, SqlString);

			}
			this.Dispose();
		}
    }
}
