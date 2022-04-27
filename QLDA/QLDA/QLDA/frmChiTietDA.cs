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
	public partial class frmChiTietDA : Form
	{
		private string SqlString, Role = WorkingContext.Instance.CurrentLoginInfo.RoleName;
		private DataTable dt;
		private string idDA;
		private int CN= WorkingContext.Instance.CurrentBranchID, idCN;
		public frmChiTietDA(string idDA, int idCN)
		{
			this.idDA = idDA;
			this.idCN = idCN;
			InitializeComponent();
		}
		private void connect(string SqlString, DataGridView dgv)
		{
			dt = new DataTable();
			var connectionName = string.Format("CN{0}", CN);
			var connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
			connectionString = string.Format(connectionString, "sa", "sa");
			var connection = new SqlConnection();
			connection.ConnectionString = connectionString;
			var command = new SqlCommand();
			command.Connection = connection;
			command.CommandType = CommandType.Text;
			SqlDataAdapter sda = new SqlDataAdapter(SqlString, connection);
			sda.Fill(dt);
			dgv.DataSource = dt;
			connection.Close();
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
			using (SqlDataReader sqlReader = command.ExecuteReader())
			{
				while (sqlReader.Read())
				{
					lblChiNhanh.Text = sqlReader["TenCN"].ToString();
					lblTenDuAn.Text = sqlReader["TenDuAn"].ToString();
					lblNgayBatDau.Text = sqlReader["NgayBatDau"].ToString();
					lblKinhPhi.Text = sqlReader["KinhPhi"].ToString();
					lblThoiHan.Text = sqlReader["ThoiHan"].ToString();
				}
				connection.Close();
			}
		}
		private void tsmiPhanCong_Click(object sender, EventArgs e)
		{
			frmPhanCong frmPhanCong = new frmPhanCong(idDA);
			frmPhanCong.ShowDialog();
			getPC();
		}
		private void getPC()
        {
			if (CN == idCN)
			{
				SqlString = String.Format("exec pcda {0}", idDA);
				connect(SqlString, dgvPhanCong);
			}
			else
            {
				SqlString = String.Format("exec LINK.QLDA.[dbo].pcda {0}", idDA);
				connect(SqlString, dgvPhanCong);
			}
		}

        private void tsmiKetToan_Click(object sender, EventArgs e)
        {
			DataRow row = (dgvPhanCong.SelectedRows[0].DataBoundItem as DataRowView).Row;
			frmKetToan ketToan = new frmKetToan(row["ID"].ToString());
			ketToan.ShowDialog();
        }

        private void getDA()
        {
			if (CN == idCN)
            {
				SqlString = String.Format("select da.*, cn.TenCN from DuAn da, ChiNhanh cn where da.ID = {0} and da.IDCN = cn.ID", idDA);
				connect(SqlString);
			}
			else
            {
				SqlString = String.Format("select da.*, cn.TenCN from LINK.QLDA.[dbo].DuAn da, LINK.QLDA.[dbo].ChiNhanh cn where da.ID = {0} and da.IDCN = cn.ID", idDA);
				connect(SqlString);
			}
		}
        private void frmChiTietDA_Load(object sender, EventArgs e)
        {
			getDA();
			getPC();
			if(Role == "ChuTich" || Role == "NhanVien")
				tmsMenu.Items.Clear();
        }
    }
}
