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
		private int CN = WorkingContext.Instance.CurrentBranchID;
		public frmDuAn(string action)
		{
			this.action = action;
			InitializeComponent();
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
			var command = new SqlCommand(String.Format("select * from DuAn where ID = {0}", idNV), connection);
			command.Connection = connection;
			command.Connection.Open();
			using (SqlDataReader sqlReader = command.ExecuteReader())
			{
				while (sqlReader.Read())
				{
					txtTenDA.Text = sqlReader["TenDuAn"].ToString();
					mtbPhi.Text = sqlReader["KinhPhi"].ToString();
					dtpNgayBD.Text = DateTime.Parse(sqlReader["NgayBatDau"].ToString()).ToString("MM/dd/yyyy");
					mtpThoiHan.Text = sqlReader["ThoiHan"].ToString();
				}
				connection.Close();
			}
		}
		private void frmDuAn_Load(object sender, EventArgs e)
        {
			if(action != "Add")
				getData(action);
			cbbChiNhanh.SelectedIndex = CN - 1;
		}

        private void btnLuu_Click(object sender, EventArgs e)
        {
			if (action == "Add")
			{
				string SqlString = String.Format("exec themDA {0},N'{1}','{2}','{3}','{4}'", CN, txtTenDA.Text, dtpNgayBD.Text, mtbPhi.Text, mtpThoiHan.Text);
				connect(SqlString);
			}
			else
			{
				string SqlString = String.Format("exec suaDA {0},N'{1}','{2}','{3}','{4}'", action, txtTenDA.Text, dtpNgayBD.Text, mtbPhi.Text, mtpThoiHan.Text);
				connect(SqlString);

			}
			this.Dispose();
		}
    }
}
