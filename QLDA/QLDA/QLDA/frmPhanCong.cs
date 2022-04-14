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
	public partial class frmPhanCong : Form
	{
		private string idDA;
		public frmPhanCong(string idDA)
		{
			this.idDA = idDA;
			InitializeComponent();
		}
		private void nhanVien(int CN)
		{
			var connectionName = string.Format("CN{0}", CN);
			var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
			connectionString = string.Format(connectionString, "sa", "sa");
			var connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			var command = new SqlCommand("exec dsNVCT", connection);
			command.Connection = connection;
			command.Connection.Open();
			using (SqlDataReader sqlReader = command.ExecuteReader())
			{
				while (sqlReader.Read())
				{
					cbbNhanVien.Items.Add(String.Format("{0} - {1}",sqlReader["ID"].ToString(), sqlReader["HoTen"].ToString()));
				}
				connection.Close();
			}
		}
		private void vaiTro(int CN)
		{
			var connectionName = string.Format("CN{0}", CN);
			var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
			connectionString = string.Format(connectionString, "sa", "sa");
			var connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			var command = new SqlCommand("select * from VaiTro", connection);
			command.Connection = connection;
			command.Connection.Open();
			using (SqlDataReader sqlReader = command.ExecuteReader())
			{
				while (sqlReader.Read())
				{
					cbbVaiTro.Items.Add(sqlReader["VaiTro"].ToString());
				}
				connection.Close();
			}
		}
		private void frmPhanCong_Load(object sender, EventArgs e)
        {
			nhanVien(WorkingContext.Instance.CurrentBranchID);
			cbbNhanVien.Text = cbbNhanVien.Items[0].ToString();
			vaiTro(WorkingContext.Instance.CurrentBranchID);
			cbbVaiTro.Text = cbbVaiTro.Items[0].ToString();
		}
    }
}
