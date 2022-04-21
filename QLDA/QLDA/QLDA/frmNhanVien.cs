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
	public partial class frmNhanVien : Form
	{
		private string action;
		public frmNhanVien(string action)
		{
			InitializeComponent();
			this.action = action;
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
		private void btnLuu_Click(object sender, EventArgs e)
        {
			if (action == "Add")
			{
				string SqlString = String.Format("exec themNV {0},'{1}',N'{2}','{3}',N'{4}',N'{5}'", cbbChiNhanh.SelectedIndex + 1, mtxtCMND.Text, txtHoTen.Text, dtpNgaySinh.Text, txtDiaChi.Text, txtChucVu.Text);
				connect(cbbChiNhanh.SelectedIndex + 1, SqlString);
			}
			else
            {
				string SqlString = String.Format("exec suaNV {0},'{1}',N'{2}','{3}',N'{4}',N'{5}'", action, mtxtCMND.Text, txtHoTen.Text, dtpNgaySinh.Text, txtDiaChi.Text, txtChucVu.Text);
				connect(cbbChiNhanh.SelectedIndex + 1, SqlString);

			}
			this.Dispose();
		}

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            if(WorkingContext.Instance.CurrentLoginInfo.RoleName == "ChuTich" && action =="Add")
                cbbChiNhanh.Enabled = true;
            cbbChiNhanh.Text = WorkingContext.Instance.CurrentBranch;
        }
    }
}
