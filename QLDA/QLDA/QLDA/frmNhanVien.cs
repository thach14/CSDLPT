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
		private int CN = WorkingContext.Instance.CurrentBranchID;
		public frmNhanVien(string action)
		{
			InitializeComponent();
			this.action = action;
		}
		private void connect(string SqlString)
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
		private void getData(string idNV)
		{
			var connectionName = string.Format("CN{0}", CN);
			var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
			connectionString = string.Format(connectionString, "sa", "sa");
			var connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			var command = new SqlCommand(String.Format("select * from NhanVien where ID = {0}", idNV), connection);
			command.Connection = connection;
			command.Connection.Open();
			using (SqlDataReader sqlReader = command.ExecuteReader())
			{
				while (sqlReader.Read())
				{
					mtxtCMND.Text = sqlReader["CMND"].ToString();
					txtHoTen.Text = sqlReader["HoTen"].ToString();
					dtpNgaySinh.Text = DateTime.Parse(sqlReader["NgaySinh"].ToString()).ToString("MM/dd/yyyy");
					txtDiaChi.Text = sqlReader["DiaChi"].ToString();
					txtChucVu.Text = sqlReader["ChucVu"].ToString();
				}
				connection.Close();
			}
		}
		private void btnLuu_Click(object sender, EventArgs e)
        {
			if (action == "Add")
			{
				string SqlString = String.Format("exec themNV {0},'{1}',N'{2}','{3}',N'{4}',N'{5}'", CN, mtxtCMND.Text, txtHoTen.Text, dtpNgaySinh.Text, txtDiaChi.Text, txtChucVu.Text);
				connect(SqlString);
			}
			else
            {
				string SqlString = String.Format("exec suaNV {0},'{1}',N'{2}','{3}',N'{4}',N'{5}'", action, mtxtCMND.Text, txtHoTen.Text, dtpNgaySinh.Text, txtDiaChi.Text, txtChucVu.Text);
				connect(SqlString);
			}
			this.Dispose();
		}

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
			if (action != "Add")
				getData(action);
            cbbChiNhanh.SelectedIndex=CN-1;
        }
    }
}
