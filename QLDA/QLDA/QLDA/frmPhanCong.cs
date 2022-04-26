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
		private int CN = WorkingContext.Instance.CurrentBranchID;
		public frmPhanCong(string idDA)
		{
			this.idDA = idDA;
			InitializeComponent();
		}
		private void nhanVien()
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
					cbbNhanVien.Items.Add(String.Format("CN{0} - {1} - {2}", sqlReader["IDCN"].ToString(),sqlReader["ID"].ToString(), sqlReader["HoTen"].ToString()));
				}
				connection.Close();
			}
		}
		private void vaiTro()
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
			nhanVien();
			cbbNhanVien.Text = cbbNhanVien.Items[0].ToString();
			vaiTro();
			cbbVaiTro.Text = cbbVaiTro.Items[0].ToString();
		}
		private void phanCong(int CN)
		{
			string[] nv = cbbNhanVien.Text.Split(' ');
			var connectionName = string.Format("CN{0}", CN);
			var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
			connectionString = string.Format(connectionString, "sa", "sa");
			var connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			var command = new SqlCommand(String.Format("exec themPC {0},{1},{2},'{3}'", idDA, nv[2], cbbVaiTro.SelectedIndex + 1, DateTime.Now.ToString("MM/dd/yyyy")), connection);
			command.Connection = connection;
			command.Connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		private void btnPhanCong_Click(object sender, EventArgs e)
        {
			phanCong(CN);
			this.Dispose();
        }
    }
}
