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
	public partial class frmMain : Form
	{
		private DataTable dt;
		private int CN = WorkingContext.Instance.CurrentBranchID;

		public frmMain()
		{
			InitializeComponent();
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			var kq = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (kq == DialogResult.Yes)
				Application.Exit();
		}

		private void btnThemNV_Click(object sender, EventArgs e)
		{
			frmNhanVien frmNhanVien = new frmNhanVien("Add");
			frmNhanVien.ShowDialog();
			getNV();
		}

		private void btnThemDA_Click(object sender, EventArgs e)
		{
			frmDuAn frmDuAn = new frmDuAn();
			frmDuAn.ShowDialog();
		}

		private void tsmiChiTietDA_Click(object sender, EventArgs e)
		{
			frmChiTietDA frmChiTietDA = new frmChiTietDA();
			frmChiTietDA.ShowDialog();
		}

		private void tsmiCreateAcc_Click(object sender, EventArgs e)
		{
			frmDangKy frmDK = new frmDangKy();
			frmDK.ShowDialog();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			cbbChiNhanh.Text = cbbChiNhanh.Items[WorkingContext.Instance.CurrentBranchID].ToString();
			if (WorkingContext.Instance.CurrentLoginInfo.RoleName != "ChuTich")
				cbbChiNhanh.Enabled = false;
			tsslChiNhanh.Text += WorkingContext.Instance.CurrentBranch;
			tsslUser.Text += WorkingContext.Instance.CurrentLoginName;
			tsslRole.Text += WorkingContext.Instance.CurrentLoginInfo.RoleName;
			getNV();
			getDA();
			getLuong();
		}
		private void connect(int CN, string SqlString, DataGridView dgv)
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
		public void getNV()
		{
			string SqlString;
			if (cbbChiNhanh.SelectedIndex == 0)
			{
				SqlString = "exec dsNVCT";
				connect(CN, SqlString, dgvNhanVien);
			}
			else if (cbbChiNhanh.SelectedIndex == CN)
			{
				SqlString = "exec dsNVCN";
				connect(CN, SqlString, dgvNhanVien);
			}
			else
			{
				SqlString = "exec dsNVCN";
				connect(cbbChiNhanh.SelectedIndex, SqlString, dgvNhanVien);
			}
		}
		private void getDA()
		{
			string SqlString;
			if (cbbChiNhanh.SelectedIndex == 0)
			{
				SqlString = "exec dsDACT";
				connect(CN, SqlString, dgvDuAn);
			}
			else if (cbbChiNhanh.SelectedIndex == CN)
			{
				SqlString = "exec dsDACN";
				connect(CN, SqlString, dgvDuAn);
			}
			else
			{
				SqlString = "exec dsDACN";
				connect(cbbChiNhanh.SelectedIndex, SqlString, dgvDuAn);
			}
		}
		private void getLuong()
		{
			string SqlString;
			if (cbbChiNhanh.SelectedIndex == 0)
			{
				SqlString = "exec luongCT";
				connect(CN, SqlString, dgvLuong);
			}
			else if (cbbChiNhanh.SelectedIndex == CN)
			{
				SqlString = "exec luongCN";
				connect(CN, SqlString, dgvLuong);
			}
			else
			{
				SqlString = "exec luongCN";
				connect(cbbChiNhanh.SelectedIndex, SqlString, dgvLuong);
			}
		}

		private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
		{
			getNV();
			getDA();
			getLuong();
		}

		private void tsmiSuaNV_Click(object sender, EventArgs e)
		{
			DataRow row = (dgvNhanVien.SelectedRows[0].DataBoundItem as DataRowView).Row;
			frmNhanVien frmNhanVien = new frmNhanVien(row["ID"].ToString());
			frmNhanVien.ShowDialog();
			getNV();
		}

        private void tsmiXoaNV_Click(object sender, EventArgs e)
        {
			DataRow row = (dgvNhanVien.SelectedRows[0].DataBoundItem as DataRowView).Row;
			string sql = String.Format("exec statusNV {0}, 0",row["ID"].ToString());
			connect(cbbChiNhanh.SelectedIndex, sql);
			getNV();
		}
    }
}
